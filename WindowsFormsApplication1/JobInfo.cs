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
    public partial class JobInfo : Form
    {
        public JobInfo()
        {
            InitializeComponent();
        }

        private void JobInfo_Load(object sender, EventArgs e)
        {
            this.jobInfoViewTableAdapter.Fill(this.jobDataSet.jobInfoView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = this.职位编号Label1.Text;
            if (uid != "")
            {
                ResumeForm rsumeForm = new ResumeForm();
                rsumeForm.JobID = Convert.ToInt32(uid);
                rsumeForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 职位名称ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection dbConnection;
            //dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Job;Integrated Security=True");
            //dbConnection.Open();
            
        }
    }
}
