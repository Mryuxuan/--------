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
    public partial class TextForm : Form
    {
        //private static int printLine = 0;
        //private bool textChange = false;
        private int userID;
        public TextForm()
        {
            InitializeComponent();
        }
        public TextForm(int id)
        {
            InitializeComponent();
            UserID = id;
        }
        public int UserID
        {
            get { return userID;}
            set { userID = value; }
        }
        private void TextForm_Load(object sender, EventArgs e)
        {
            if (UserID >= 0)
                richTextBox1.Text = createNewResume(UserID);
            timer1.Interval = 1000;
            //this.ShowInTaskbar = false;
        }
        //建立简历字符串
        public string createNewResume(int userId)
        {
            string infoText = "";
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");
            try
            {
                sqlConnection.Open();
                SqlCommand dbInsertCommand = new SqlCommand();
                dbInsertCommand.Connection = sqlConnection;
                dbInsertCommand.CommandType = System.Data.CommandType.Text;
                dbInsertCommand.CommandText = "select * from resume where userID=" + userId.ToString() + ";";
                SqlDataReader sdr = dbInsertCommand.ExecuteReader();
                sdr.Read();
                infoText = "\n\t\t\t" + sdr["name"].ToString() + "的简历";
                infoText += "\n\n" + sdr["name"].ToString();
                infoText += "," + sdr["sex"].ToString();
                infoText += "," + sdr["politics"].ToString();
                infoText += "," + sdr["nation"].ToString().Trim() + ",";
                infoText += ((DateTime)sdr["birth"]).ToString("yyyy-MM-dd") + "出生";
                infoText += "," + (sdr["marry"].ToString() == "true" ? "已婚" : "未婚");
                infoText += "\n毕业于" + sdr["school"].ToString();
                infoText += "," + sdr["major"].ToString() + "专业";
                infoText += "," + sdr["learn"].ToString();
                infoText += "," + sdr["degree"].ToString();
                infoText += "," + sdr["title"].ToString();
                infoText += "\n 工作年限：" + sdr["workYear"].ToString();
                infoText += "\n 身份证号：" + sdr["idCard"].ToString();
                infoText += "\n 家庭住址：" + sdr["address"].ToString();
                infoText += "\n\n 【教育经历】\n" + sdr["eduExperience"].ToString();
                infoText += "\n\n 【工作简历】\n" + sdr["jobExperience"].ToString();
                infoText += "\n\n 【自我鉴定】\n" + sdr["introduce"].ToString();
                infoText += "\n\n 【联系方式】\n";
                infoText += "\n 移动电话：" + sdr["mobiPhone"].ToString();
                infoText += "\n 固定电话：" + sdr["telephone"].ToString();
                infoText += "\n QQ/MSN：" + sdr["qqmsn"].ToString();
                infoText += "\n 电子邮箱：" + sdr["email"].ToString();
                infoText += "\n 个人主页：" + sdr["persWeb"].ToString();
                infoText += "\n 照片文件：" + sdr["photoFile"].ToString();
                infoText += "\n";
                sdr.Close();
            }
            catch (Exception eMsg)
            {
                MessageBox.Show("简历信息读取出错！\n" + eMsg.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close(); 
            }
            return infoText;
        }
    }
}
