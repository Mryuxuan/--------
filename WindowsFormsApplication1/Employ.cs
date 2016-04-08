using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Employ : Form
    {
        private SqlConnection dbConnection;
        public Employ()
        {
            dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");
            InitializeComponent();
        }

        private void Employ_Load(object sender, EventArgs e)
        {
            this.jobinfoTableAdapter.Fill(this.jobDataSet.jobinfo);
            this.jobInfoViewTableAdapter.Fill(this.jobDataSet.jobInfoView);
            this.jobAnswerviewTableAdapter.Fill(this.jobDataSet.jobAnswerview);
            LoadAddress();
            LoadPosition();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            labelTitle.Text = tabControl1.SelectedTab.Text;
            if (tabControl1.SelectedTab == tabPage4)
                LoadCompany();
        }
        private void jobInfoViewDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //获取绑定数据源中的当前记录的位置
            int n = jobInfoViewBindingSource.Position;
            //将当前记录的数据显示在可编辑区
            requirementNumericUpDown.Value = (int)jobDataSet.jobInfoView[n]["需求人数"];
            validDateDateTimePicker.Value = (DateTime)jobDataSet.jobInfoView[n]["有效日期"];
            detailedTextBox.Text = jobDataSet.jobInfoView[n]["职位描述"].ToString();
            prerequisiteTextBox.Text = jobDataSet.jobInfoView[n]["入职条件"].ToString();
        }

        private void jobInfoViewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //将当前记录的ID号
            int n = jobInfoViewBindingSource.Position;
            int id = (int)jobDataSet.jobInfoView[n]["职位编号"];
            //根据ID号找到表中相应的记录并修改
            UpdatajobInfo(id);
        }
        private void UpdatajobInfo(int id)
        {
            //根据ID号获取表中要修改的记录
            DataRow dr = jobDataSet.jobinfo.FindByjobID(id);
            if (dr != null)
            {
                //修改记录
                dr["requirement"] = requirementNumericUpDown.Value;
                dr["validDate"] = validDateDateTimePicker.Value;
                dr["detailed"] = detailedTextBox.Text;
                dr["prerequisite"] = prerequisiteTextBox.Text;
                //更新数据库中的表
                jobinfoTableAdapter.Update(jobDataSet.jobinfo);
                //更新内存中的数据表
                jobDataSet.jobinfo.AcceptChanges();
                MessageBox.Show("更新完毕");
                //更新视图对应的内存中的数据集
                dr = jobDataSet.jobInfoView.FindBy职位编号(id);
                dr["需求人数"] = requirementNumericUpDown.Value;
                dr["有效日期"] = validDateDateTimePicker.Value;
                dr["职位描述"] = detailedTextBox.Text;
                dr["入职条件"] = prerequisiteTextBox.Text;
            }
            else
                MessageBox.Show("错误！");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //撤消通过视图对数据所作的修改
            jobInfoViewBindingSource.CancelEdit();
        }
        private void LoadAddress()
        {
            dbConnection.Open();
            string sqlstr = "select * from workaddress";
            SqlCommand com = new SqlCommand(sqlstr, dbConnection);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[1]).ToString();
            }
            dbConnection.Close();
        }
        private void LoadPosition()
        {
            TreeNode rootNode = new TreeNode();//新建一个根结点
            TreeNode newNode;//定义当前结点
            string node1 = "";//初始化当前结点的父结点名称
            dbConnection.Open();
            string sqlstr = "select * from positionClass";
            SqlCommand com = new SqlCommand(sqlstr, dbConnection);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                newNode = new TreeNode();//新建当前结点
                newNode.Text = dr[2].ToString();//存当前结点的名称
                newNode.Tag = dr[0];//存当前结点的编号

                if (node1 != dr[1].ToString())//当前根结点的名称不等于当前结点的父结点名称
                {
                    rootNode = new TreeNode();//生成一个新的根结点
                    node1 = dr[1].ToString();//保存当前根结点的名称
                    rootNode.Text = node1;//保存当前根结点的名称
                    rootNode.Tag = dr[0];//保存当前根结点的编号
                    treeView1.Nodes.Add(rootNode);//加根结点
                }
                rootNode.Nodes.Add(newNode);//加子结点
            }
            dbConnection.Close();
        }

        private void btnfbzw_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlstr = "select *  from jobinfo";
                SqlCommand com = new SqlCommand(sqlstr, dbConnection);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds, "jobinfo");
                DataRow dr = ds.Tables["jobinfo"].NewRow();
                int n = 0;
                if (treeView1.SelectedNode != null)
                    n = (int)treeView1.SelectedNode.Tag;
                dr["classification"] = n;
                dr["position"] = textBox1.Text;
                string str = "";
                if (listBox1.SelectedItem != null)
                    str = listBox1.Text;
                dr["workAddress"] = str;
                dr["detailed"] = textBox2.Text;
                dr["requirement"] = (int)numericUpDown1.Value;
                dr["validDate"] = dateTimePicker1.Value;
                dr["postDate"] = System.DateTime.Now.Date;
                dr["register"] = 0;
                dr["throuht"] = 0;
                ds.Tables["jobinfo"].Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["jobinfo"]);
                ds.Tables["jobinfo"].AcceptChanges();
                MessageBox.Show("职位发布成功！");

            }
            catch (Exception emsg)
            {
                MessageBox.Show(emsg.Message, "数据写入错误!");
            }
        }

        private void btnUpCompany_Click(object sender, EventArgs e)
        {
            if (btnUpCompany.Text == "添加")
                InstCompany();
            else
                UpdataCompany();
        }

        private void LoadCompany()
        {
            dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");
            dbConnection.Open();
            //设置数据查询字符串
            string sqlstr = "select * from company";
            //创建一个SqlCommand对象，用于指定要完成的SQL命令及使用的连接通道
            SqlCommand com = new SqlCommand(sqlstr, dbConnection);
            //创建一个SqlDataReader对象，用于存储SQL命令执行后返回的查询结果（一个只读的记录集）
            SqlDataReader dr = com.ExecuteReader();
            //通过访问SqlDataReader对象的HasRows属性，判断记录集是否为空
            if (dr.HasRows)
            {
                //记录集不为空时，读取下一行记录
                dr.Read();
                //将读到的当前行的各行数据显示在窗口中
                //获取列数据，可通过下标访问
                txtCompany.Text = dr[0].ToString();
                //获取列数据，也可通过记录集中的列名
                txtContact.Text = dr["contact"].ToString();
                //可通过qlDataReader对象的类型化访问器将获取的数据转换成相应的类型
                txtCall.Text = dr.GetString(2);
            }
            else
            {
                //记录集为空时，在命令按钮上显示添加
                btnUpCompany.Text = "添加";
                MessageBox.Show("还没有单位简介，请添加！");
            }
            //关闭对象
            dr.Close();
            dbConnection.Close();
            //释放资源
            dbConnection.Dispose();
        }
       
        private void InstCompany()
        {
            if (txtCompany.Text == "" || txtContact.Text == "" || txtCall.Text == "")
            {
                MessageBox.Show("单位名称不能为空");
            }
            string comname = txtCompany.Text;
            string contact = txtContact.Text;
            string call = txtCall.Text;
            string sqlstr;
            sqlstr = "insert into company(name,contact,phoneCall) values('{0}','{1}','{2}')";
            sqlstr = string.Format(sqlstr, comname, contact, call);
            SqlConnection con = new SqlConnection(Program.GetConnectionString());
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            if (com.ExecuteNonQuery() > 0)
                MessageBox.Show("记录已添加！");
            con.Close();
        }
        private void UpdataCompany()
        {
            string comname = txtCompany.Text;
            string contact = txtContact.Text;
            string call = txtCall.Text;
            string sqlstr;
            sqlstr = "update company set contact='{0}',phonecall='{1}' where name='{2}'";
            sqlstr = string.Format(sqlstr, contact, call, txtCompany.Text);
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand(sqlstr, con);
            if (com.ExecuteNonQuery() > 0)
                MessageBox.Show("记录已修改！");
            con.Close();
            con.Dispose();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            UpdataJobStatus("审核通过");
        }

        private void btnNoPass_Click(object sender, EventArgs e)
        {
            string str = jobDataSet.jobAnswerview[jobAnswerviewBindingSource.Position]["审核状态"].ToString();
            if (str.Trim() != "审核通过")
                UpdataJobStatus("审核未过");
        }

        private void UpdataJobStatus(string status)
        {
            int row_n = jobAnswerviewBindingSource.Position;
            int id;
            jobDataSet.jobAnswerview[row_n].审核状态 = status;
            try
            {
                id = jobDataSet.jobAnswerview[row_n].ID;
                string sqlString = "update jobExpectation set status='" + status + "'where ID=" + id;
                dataCommandExecute(sqlString);
                if (status == "审核通过")
                {   //修改表jobInfo中简历通过人数
                    id = jobDataSet.jobAnswerview[row_n].jobID;
                    jobDataSet.jobinfo.FindByjobID(id).throuht++;
                    jobinfoTableAdapter.Update(jobDataSet.jobinfo);
                    jobDataSet.jobinfo.AcceptChanges();
                }
            }
            catch (Exception eMsg)
            {
                MessageBox.Show("写入数据源失败！\n" + eMsg.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row_n = jobAnswerviewBindingSource.Position;
            string answerName = jobDataSet.jobAnswerview[row_n].姓名;
            if (jobDataSet.jobAnswerview[row_n].审核状态 == "审核通过")
            {
                MessageBox.Show(answerName + "的简历已经审核通过，不能删除");
                return;
            }
            string msgString = "确定要删除" + answerName + "的简历？";
            if (MessageBox.Show(msgString, "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int rowIndex = jobAnswerviewBindingSource.Position;
                int id = jobDataSet.jobAnswerview[rowIndex].ID;
                string sqlString = "delete from jobExpectation where id=" + id;
                dataCommandExecute(sqlString);
                id = jobDataSet.jobAnswerview[rowIndex].userID;
                sqlString = "delete from resume where userID=" + id;
                dataCommandExecute(sqlString);
                jobAnswerviewBindingSource.RemoveCurrent();
            }
        }

        private void btnViewResume_Click(object sender, EventArgs e)
        {
            int rowIndex = jobAnswerviewBindingSource.Position;
            int userId = jobDataSet.jobAnswerview[rowIndex].userID;
            TextForm txtForm = new TextForm();
            txtForm.UserID = userId;
            txtForm.Show();
        }

        private bool dataCommandExecute(string sqlString)
        {
            bool commandResult = false;
            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);
            try
            {
                dbCommand.Connection.Open();
                dbCommand.ExecuteNonQuery();
                commandResult = true;
            }
            catch (Exception eMsg)
            {
                MessageBox.Show("写入数据源失败！\n" + eMsg.Message);
            }
            finally
            {
                dbCommand.Connection.Close();
            }
            return commandResult;
        }
    }
}
