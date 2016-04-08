using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class ResumeForm : Form
    {
        private int userID = -1;//标识用户，-1表示无效
        private int jobID;      //标识工作
        private SqlConnection sqlConnection;//设置公共连接sqlConnection
        public ResumeForm()
        {
            InitializeComponent();
        }
        public int JobID//与外界数据交换接口
        {
            get { return jobID; }
            set { jobID = value; }
        }
        private void ResumeForm_Load(object sender, EventArgs e)
        {//如果没有选择工作则退出窗体
            if (JobID < 0) this.Close();
            sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");//创建连接
            loadcomboZzmm();//初始化政治面貌组合框
            loadcomboNation();//初始化民族组合框
            loadcomboaddress();//初始化地址列表框
            loadTreeView();//初始化树结构视图
            //设置出生日期为20年前的1月1日
            dateTimeCsrq.Value = new DateTime(dateTimeCsrq.Value.Year - 20, 1, 1);
        }
        public void loadcomboZzmm()//加载政治面貌
        {
            comboZzmm.Items.Add("中共党员");
            comboZzmm.Items.Add("共青团员");
            comboZzmm.Items.Add("民主党派");
            comboZzmm.Items.Add("无党派");
        }
        public void loadcomboNation()//加载民族
        {
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = sqlConnection;
            dbCommand.Connection.Open();
            dbCommand.CommandType = System.Data.CommandType.Text;
            dbCommand.CommandText = "select * from nation";
            SqlDataReader sdr = dbCommand.ExecuteReader();
            while (sdr.Read())
            {
                this.comboMz.Items.Add(sdr["nation"].ToString());   
            }
            sqlConnection.Close();
        }
        public void loadcomboaddress()//加载城市地址
        {
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = sqlConnection;
            dbCommand.Connection.Open();
            dbCommand.CommandType = System.Data.CommandType.Text;
            dbCommand.CommandText = "select * from workAddress";
            SqlDataReader sdr = dbCommand.ExecuteReader();
            while (sdr.Read())
            {
                this.comboMz.Items.Add(sdr["Address"].ToString());
            }
            sqlConnection.Close();
        }
        public void loadTreeView()//加载职位信息
        {
            TreeNode rootNode = new TreeNode();
            TreeNode newNode;
            string node1 = "";
            string sqlString = "select * from positionClass;";
            SqlCommand dbCommand = new SqlCommand(sqlString, sqlConnection);
            dbCommand.Connection.Open();
            SqlDataReader dataReader = dbCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    newNode = new TreeNode();
                    newNode.Text = dataReader[2].ToString();
                    newNode.Tag = dataReader[0];
                    if (node1 != dataReader[1].ToString())//如果数据库中的职位类别1没有在节点中出现过
                    {
                        if (rootNode.Nodes.Count > 0)
                            rootNode = new TreeNode();
                        node1 = dataReader[1].ToString();
                        rootNode.Text = node1;
                        treeGw.Nodes.Add(rootNode);
                    }
                    rootNode.Nodes.Add(newNode);//添加职位类别2的节点
                }
            }
            dataReader.Close();
            dbCommand.Connection.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (userID < 0)
                MessageBox.Show("你还没有创建简历或保存简历", "错误");
            else 
            {
                TextForm txtForm = new TextForm();
                txtForm.UserID = userID;
                txtForm.Show();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveResume();//保存简历
            if (userID >= 0)
            {
                savePosition();//保存职位信息
                UpdateJobinfo();//修改注册人数
                buttonEdit.Enabled = true;
            }
        }
        //姓名检查
        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (textName.TextLength < 2)
            {
                MessageBox.Show("姓名不能太短或为空");
                textName.Focus();
            }
        }
        //更改相关显示信息
        private void textName_Validated(object sender, EventArgs e)
        {
            lblTitle.Text = textName.Text + "的简历";
            lblPic.Text = textName.Text + "的照片";
            labelXm.Text = textName.Text;
        }
        //身份证信息检查（核对是否存在）
        private void maskedTextSfzh_Validated(object sender, EventArgs e)
        {
            if (checkName(textName.Text, maskedTextSfzh.Text))
            {
                MessageBox.Show(textName.Text + "\n" + maskedTextSfzh.Text + "\n注册信息已存在，不能再注册！", "提示");
                buttonSave.Enabled = false;
                if (userID > 0) buttonEdit.Enabled = true;
            }
        }
        //检查用户是否已注册，若已注册，更改userID为用户ID
        private bool checkName(string username, string idcard)
        {
            bool bl = false;
            string sqlString = "select userID from resume where name='" + username + "' and idCard='" + idcard + "';";
            SqlCommand dbCommand = new SqlCommand(sqlString, sqlConnection);
            dbCommand.Connection.Open();
            int n = (int)dbCommand.ExecuteNonQuery();
            if (n > 0)
            {
                userID = n;
                bl = true;
            }
            dbCommand.Connection.Close();
            return bl;
        }
        //双击图片框加载照片
        private void pictureZp_DoubleClick(object sender, EventArgs e)
        {
            string fileToDisplay;
            openPhotoFile.Filter = "All File|*.*|Jpg File|*.jpg|Bmp File|*.bmp|Gif File|*.gif";
            openPhotoFile.FileName = "";
            if (openPhotoFile.ShowDialog() == DialogResult.OK)
            {
                fileToDisplay = openPhotoFile.FileName;
                pictureZp.ImageLocation = fileToDisplay;
                pictureZp.Load();
                lblPic.Text = textName.Text + "的照片";
            }
            else
            {
                pictureZp.Image = Properties.Resources.embed;
                
            }
        }
        //单击链接，打开浏览器
        private void linkWlkj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = textWeb.Text;
            if (target == "") return;
            if (target.StartsWith("www."))
                System.Diagnostics.Process.Start(target);
            else
                MessageBox.Show("不是有效的URL链接格式");
        }
        //Email输入格式检查
        private void textEmail_Validated(object sender, EventArgs e)
        {
            if (textEmail.Text == "") return;
            if (textEmail.Text != "" && textEmail.Text.IndexOf("@") == 0)
                MessageBox.Show("不是有效的Email格式");
        }
        //Web输入格式检查
        private void textWeb_Validated(object sender, EventArgs e)
        {
            string target = textWeb.Text;
            if (target == "") return;
            if (target != "" && !target.StartsWith("www."))
                MessageBox.Show("不是有效的Web链接格式");
        }
        //学位选择检查
        private void comboXw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboXl.Text != "本科" && comboXl.Text != "研究生")
                if (this.comboXw.Text == "博士" || comboXw.Text == "硕士")
                    MessageBox.Show("学历与学位很不匹配");
        }
        //单击职位项是选择该项
        private void treeGw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.Checked = !e.Node.Checked;
        }
        //保存简历信息
        private void saveResume()
        {
            //检查必填项目，如没有填写完整立即返回
            if (!checkInput()) return;
            //配置插入命令参数
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = sqlConnection;
            dbCommand.CommandType = System.Data.CommandType.Text;
            dbCommand.CommandText = @"insert into [resume]([name],[sex],[birth],[nation],[politics],
[marry],[idCard],[address],[learn],[degree],[workYear],[major],[title],[school],[eduExperience],[jobExperience],
[introduce],[mobiPhone],[telephone],[qqmsn],[email],[persWeb],[photoFile],[registerDate]) values (@name,@sex,
@birth,@nation,@politics,@marry,@idCard,@address,@learn,@degree,@workYear,@major,@title,@school,@eduExperience,
@jobExperience,@introduce,@mobiPhone,@telephone,@qqmsn,@email,@persWeb,@photoFile,@registerDate)";
            dbCommand.Parameters.AddRange(new SqlParameter[]{
                new SqlParameter("@name", SqlDbType.NVarChar, 10),
                new SqlParameter("@sex", SqlDbType.NChar, 1),
                new SqlParameter("@birth", SqlDbType.SmallDateTime),
                new SqlParameter("@nation", SqlDbType.NChar, 10),
                new SqlParameter("@politics", SqlDbType.NChar, 4),
                new SqlParameter("@marry", SqlDbType.Bit),
                new SqlParameter("@idCard", SqlDbType.NChar, 18),
                new SqlParameter("@address", SqlDbType.NVarChar, 30),
                new SqlParameter("@learn", SqlDbType.NChar, 6),
                new SqlParameter("@degree", SqlDbType.NChar, 4),
                new SqlParameter("@workYear", SqlDbType.Int),
                new SqlParameter("@major", SqlDbType.NVarChar, 12),
                new SqlParameter("@title", SqlDbType.NVarChar, 6),
                new SqlParameter("@school", SqlDbType.NVarChar, 12),
                new SqlParameter("@eduExperience", SqlDbType.NVarChar,50),
                new SqlParameter("@jobExperience", SqlDbType.NVarChar,50),
                new SqlParameter("@introduce", SqlDbType.NVarChar,50),
                new SqlParameter("@mobiPhone", SqlDbType.NChar, 11),
                new SqlParameter("@telephone", SqlDbType.NChar, 11),
                new SqlParameter("@qqmsn", SqlDbType.NVarChar, 12),
                new SqlParameter("@email", SqlDbType.NVarChar, 30),
                new SqlParameter("@persWeb", SqlDbType.NVarChar, 50),
                new SqlParameter("@photoFile", SqlDbType.NVarChar, 50),
                new SqlParameter("@registerDate", SqlDbType.SmallDateTime)}
                );
            //读出数据为参数赋值
            dbCommand.Parameters["@name"].Value = textName.Text;
            dbCommand.Parameters["@sex"].Value = radioNan.Checked ? "男" : "女";
            dbCommand.Parameters["@birth"].Value = dateTimeCsrq.Value;
            dbCommand.Parameters["@nation"].Value = comboMz.Text;
            dbCommand.Parameters["@politics"].Value = comboZzmm.Text;
            dbCommand.Parameters["@marry"].Value = checkHf.Checked;
            dbCommand.Parameters["@idCard"].Value = maskedTextSfzh.Text;
            dbCommand.Parameters["@address"].Value = textJtzz.Text;
            dbCommand.Parameters["@learn"].Value = comboXl.Text;
            dbCommand.Parameters["@degree"].Value = comboXw.Text;
            dbCommand.Parameters["@workYear"].Value = (int)numerciGznx.Value;
            dbCommand.Parameters["@major"].Value = textSxzy.Text;
            dbCommand.Parameters["@title"].Value = textJszc.Text;
            dbCommand.Parameters["@school"].Value = textByyx.Text;
            dbCommand.Parameters["@eduExperience"].Value = textJyjl.Text;
            dbCommand.Parameters["@jobExperience"].Value = textGzjl.Text;
            dbCommand.Parameters["@introduce"].Value = textZwjd.Text;
            dbCommand.Parameters["@mobiPhone"].Value = maskedTextDh1.Text;
            dbCommand.Parameters["@telephone"].Value = maskedTextDh2.Text;
            dbCommand.Parameters["@qqmsn"].Value = maskedTextQq.Text;
            dbCommand.Parameters["@email"].Value = textEmail.Text;
            dbCommand.Parameters["@persWeb"].Value = textWeb.Text;
            dbCommand.Parameters["@photoFile"].Value = "";
            dbCommand.Parameters["@registerDate"].Value = System.DateTime.Now.Date;
            try
            {//打开连接，执行命令
                dbCommand.Connection.Open();
                dbCommand.ExecuteNonQuery();
                dbCommand.CommandText = "select userID from resume where name='" + textName.Text + "';";
                SqlDataReader dataReader = dbCommand.ExecuteReader();
                dataReader.Read();
                string str = dataReader["userID"].ToString();
                if (str != "") userID = Convert.ToInt32(str);
                dataReader.Close();
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message, "简历数据保存出错！");
            }
            dbCommand.Connection.Close();
            return;
        }
        //检查必须输入项是否都已输入
        private bool checkInput()
        {
            bool inputOK = true;
            string msg = "";
            textName.Text = textName.Text.Trim();
            if (textName.Text == "")
                msg += "输入姓名是必须的！\n";
            if (maskedTextSfzh.Text.Trim().Length < 15)
                msg += "身份证号是必须的，至少15位！\n";
            if (textJtzz.Text == "")
                msg += "家庭住址是必须的！\n";
            if (textSxzy.Text == "")
                msg += "专业是必须的！\n";
            if (textByyx.Text == "")
                msg += "毕业院校是必须的！\n";
            if (textJszc.Text == "")
                msg += "技术职称是必须的！\n";
            if (textJyjl.Text+textGzjl.Text == "")
                msg += "教育经历或工作经历至少填一项！\n";
            if (maskedTextDh1.Text+maskedTextDh2.Text == "")
                msg += "联系电话是必须的，至少要一个！\n";
            if (msg != "")
            {
                MessageBox.Show(msg, "输入数据不完整");
                inputOK = false;
            }
            return inputOK;
        }
        //保存职位期望信息
        private void savePosition()
        {
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = sqlConnection;
            dbCommand.CommandType = System.Data.CommandType.Text;
            dbCommand.CommandText = @"insert into [jobExpectation] ([userID],[jobID],[salary],
[housing],[insurance],[interview],[other],[registerDate],[status],[professionHope],[workAddressHope]) values
(@userID,@jobID,@salary,@housing,@insurance,@interview,@other,@registerDate,@status,@professionHope,@workAddressHope)";
            dbCommand.Parameters.AddRange(new SqlParameter[]{
                new SqlParameter("@userID", SqlDbType.Int),
                new SqlParameter("@jobID", SqlDbType.Int),
                new SqlParameter("@salary", SqlDbType.Int),
                new SqlParameter("@housing", SqlDbType.Bit),
                new SqlParameter("@insurance", SqlDbType.Bit),
                new SqlParameter("@interview", SqlDbType.Bit),
                new SqlParameter("@other", SqlDbType.Text),
                new SqlParameter("@registerDate", SqlDbType.SmallDateTime),
                new SqlParameter("@status", SqlDbType.Text),
                new SqlParameter("@professionHope", SqlDbType.Text),
                new SqlParameter("@workAddressHope", SqlDbType.Text)}
                );
            dbCommand.Parameters["@userID"].Value = userID;
            dbCommand.Parameters["@jobID"].Value = jobID;
            dbCommand.Parameters["@salary"].Value = trackBarGz.Value;
            dbCommand.Parameters["@housing"].Value = checkZf.Checked;
            dbCommand.Parameters["@insurance"].Value = checkBx.Checked;
            dbCommand.Parameters["@interview"].Value = checkMt.Checked;
            dbCommand.Parameters["@other"].Value = textNeed.Text.Trim();
            string str = CallRecursive(treeGw);
            if (str == "" && treeGw.SelectedNode != null)
                str = treeGw.SelectedNode.Tag.ToString();
            if (str.Length > 50) str = str.Substring(0, 50);
            dbCommand.Parameters["@professionHope"].Value = str;
            str = "";
            if (listGzdd.SelectedItem != null)
                str = listGzdd.SelectedItem.ToString();
            dbCommand.Parameters["@workAddressHope"].Value = str;
            dbCommand.Parameters["@status"].Value = "注册登记";
            dbCommand.Parameters["@registerDate"].Value = System.DateTime.Now.Date;
            try
            {
                dbCommand.Connection.Open();
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("数据保存成功", "提示！");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message, "数据保存出错！");
            }
            dbCommand.Connection.Close();
        }
        //调用递归方法，取出选中树节点文本
        private string CallRecursive(TreeView treeView)
        {
            string treeText = "";
            TreeNodeCollection nodes = treeView.Nodes;  //节点集合数据类型
            foreach (TreeNode n in nodes)               // 找到每个根节点
            {
                treeText += PrintRecursive(n);            // 调用递归方法
            }
            return treeText;
        }
        // 创建测试每个节点的递归方法
        private string PrintRecursive(TreeNode treeNode)
        {
            string treetxt = "";
            if (treeNode.Checked)
                treetxt = treeNode.Text + ",";
            // 输出每个子节点.
            foreach (TreeNode tn in treeNode.Nodes)
            {
                treetxt += PrintRecursive(tn);           // 递归调用
            }
            return treetxt;
        }
        //修改注册人数（增加一个）
        private void UpdateJobinfo()
        {
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.Connection = sqlConnection;
            dbCommand.CommandType = System.Data.CommandType.Text;
            dbCommand.CommandText = "update jobInfo set register=register+1 where jobID=" + JobID;
            dbCommand.Connection.Open();
            dbCommand.ExecuteNonQuery();
            dbCommand.Connection.Close();
        }
    }
}
