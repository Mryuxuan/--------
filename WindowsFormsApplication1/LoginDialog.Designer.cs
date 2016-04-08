namespace WindowsFormsApplication1
{
    partial class LoginDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLoginName = new System.Windows.Forms.TextBox();
            this.textLoginPassWord = new System.Windows.Forms.TextBox();
            this.btnLoginOk = new System.Windows.Forms.Button();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLoginName
            // 
            this.textLoginName.Location = new System.Drawing.Point(136, 48);
            this.textLoginName.Name = "textLoginName";
            this.textLoginName.Size = new System.Drawing.Size(100, 21);
            this.textLoginName.TabIndex = 0;
            // 
            // textLoginPassWord
            // 
            this.textLoginPassWord.Location = new System.Drawing.Point(136, 104);
            this.textLoginPassWord.Name = "textLoginPassWord";
            this.textLoginPassWord.Size = new System.Drawing.Size(100, 21);
            this.textLoginPassWord.TabIndex = 1;
            // 
            // btnLoginOk
            // 
            this.btnLoginOk.Location = new System.Drawing.Point(45, 182);
            this.btnLoginOk.Name = "btnLoginOk";
            this.btnLoginOk.Size = new System.Drawing.Size(75, 23);
            this.btnLoginOk.TabIndex = 2;
            this.btnLoginOk.Text = "确定";
            this.btnLoginOk.UseVisualStyleBackColor = true;
            this.btnLoginOk.Click += new System.EventHandler(this.btnLoginOk_Click);
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.Location = new System.Drawing.Point(161, 182);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLoginCancel.TabIndex = 3;
            this.btnLoginCancel.Text = "取消";
            this.btnLoginCancel.UseVisualStyleBackColor = true;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnLoginCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密  码：";
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginCancel);
            this.Controls.Add(this.btnLoginOk);
            this.Controls.Add(this.textLoginPassWord);
            this.Controls.Add(this.textLoginName);
            this.Name = "LoginDialog";
            this.Text = "管理员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLoginName;
        private System.Windows.Forms.TextBox textLoginPassWord;
        private System.Windows.Forms.Button btnLoginOk;
        private System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}