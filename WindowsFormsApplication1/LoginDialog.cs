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
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
            LoginName = null;
        }
        private static string loginName;
        public static string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }
        private void btnLoginOk_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");
            SqlDataReader dataReader;
            string sqlString = "select name,password from admin;";
            string loginPassWord = "";
            dbConnection.Open();
            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);
            dataReader = dbCommand.ExecuteReader();
            try
            {
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    LoginName = dataReader["name"].ToString();
                    loginPassWord = dataReader["password"].ToString();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "登录出错");
            }
            dataReader.Close();
            if (LoginName.Trim() == textLoginName.Text.Trim() && loginPassWord.Trim() == textLoginPassWord.Text.Trim())
                this.Close();
            else
            {
                MessageBox.Show("请输入正确的用户名或密码！", "登录出错");
                LoginName = null;
            }
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
