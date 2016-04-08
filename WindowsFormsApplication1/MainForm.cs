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
    public partial class MainForm : Form
    {
        public string companyNameStr = "";
        public string companySummary = "";
        public MainForm()
        {
            InitializeComponent();
        }
        private void ReadCompany()
        {
            string sqlString = "select * from company;";
            SqlConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");
            dbConnection.Open();
            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);
            SqlDataReader dataReader = dbCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                companyNameStr = dataReader[0].ToString();
                companySummary = companyNameStr;
                companySummary += "\n联系人：" + dataReader.GetString(1);
                companySummary += "\n电  话：" + dataReader.GetString(2);
                companySummary += "\nEmail：" + dataReader.GetString(3);
                companySummary += "\n网  址：" + dataReader.GetString(4);
                companySummary += "\n地  址：" + dataReader.GetString(5);
                companySummary += "\n\n单位简介：" + dataReader.GetString(6);
                companySummary += "\n\n招聘说明：" + dataReader.GetString(7);
            }
            else
            {
                companySummary = "暂无单位简介";
            }
            dataReader.Close();
            dbConnection.Close();
            this.Text = companyNameStr + "招聘信息管理";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            JobInfo jobInfo = new JobInfo();
            jobInfo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCompany();
            
        }

        private void pictureAbout_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureAbout_MouseEnter(object sender, EventArgs e)
        {
            ReadCompany();
            labelMsg.Text = companySummary;
        }

        private void pictureAbout_MouseLeave(object sender, EventArgs e)
        {
            ReadCompany();
            labelMsg.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDialog loginDialog = new LoginDialog();
            loginDialog.ShowDialog();
            if (LoginDialog.LoginName != null)
            {
                Employ employ = new Employ();
                employ.ShowDialog();
            }
            this.Show();
        }
    }
}
