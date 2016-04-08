namespace WindowsFormsApplication1
{
    partial class JobInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label 职位名称Label;
            System.Windows.Forms.Label 职位编号Label;
            System.Windows.Forms.Label 职位名称Label1;
            System.Windows.Forms.Label 职位类别1Label;
            System.Windows.Forms.Label 工作地点Label;
            System.Windows.Forms.Label 有效日期Label;
            System.Windows.Forms.Label 需求人数Label;
            System.Windows.Forms.Label 职位描述Label;
            System.Windows.Forms.Label 入职条件Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobInfo));
            this.jobDataSet = new WindowsFormsApplication1.JobDataSet();
            this.jobInfoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobInfoViewTableAdapter = new WindowsFormsApplication1.JobDataSetTableAdapters.jobInfoViewTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.JobDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.职位编号Label1 = new System.Windows.Forms.Label();
            this.职位名称Label2 = new System.Windows.Forms.Label();
            this.职位类别2Label1 = new System.Windows.Forms.Label();
            this.工作地点Label1 = new System.Windows.Forms.Label();
            this.有效日期Label1 = new System.Windows.Forms.Label();
            this.需求人数Label1 = new System.Windows.Forms.Label();
            this.职位描述Label1 = new System.Windows.Forms.Label();
            this.入职条件Label1 = new System.Windows.Forms.Label();
            this.职位名称ListBox = new System.Windows.Forms.ListBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.职位类别1Label3 = new System.Windows.Forms.Label();
            职位名称Label = new System.Windows.Forms.Label();
            职位编号Label = new System.Windows.Forms.Label();
            职位名称Label1 = new System.Windows.Forms.Label();
            职位类别1Label = new System.Windows.Forms.Label();
            工作地点Label = new System.Windows.Forms.Label();
            有效日期Label = new System.Windows.Forms.Label();
            需求人数Label = new System.Windows.Forms.Label();
            职位描述Label = new System.Windows.Forms.Label();
            入职条件Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobInfoViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 职位名称Label
            // 
            职位名称Label.AutoSize = true;
            职位名称Label.Font = new System.Drawing.Font("楷体_GB2312", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            职位名称Label.Location = new System.Drawing.Point(12, 19);
            职位名称Label.Name = "职位名称Label";
            职位名称Label.Size = new System.Drawing.Size(142, 21);
            职位名称Label.TabIndex = 1;
            职位名称Label.Text = "最新职位信息";
            // 
            // 职位编号Label
            // 
            职位编号Label.AutoSize = true;
            职位编号Label.Location = new System.Drawing.Point(244, 77);
            职位编号Label.Name = "职位编号Label";
            职位编号Label.Size = new System.Drawing.Size(59, 12);
            职位编号Label.TabIndex = 5;
            职位编号Label.Text = "职位编号:";
            // 
            // 职位名称Label1
            // 
            职位名称Label1.AutoSize = true;
            职位名称Label1.Location = new System.Drawing.Point(244, 108);
            职位名称Label1.Name = "职位名称Label1";
            职位名称Label1.Size = new System.Drawing.Size(59, 12);
            职位名称Label1.TabIndex = 7;
            职位名称Label1.Text = "职位名称:";
            // 
            // 职位类别1Label
            // 
            职位类别1Label.AutoSize = true;
            职位类别1Label.Location = new System.Drawing.Point(244, 141);
            职位类别1Label.Name = "职位类别1Label";
            职位类别1Label.Size = new System.Drawing.Size(59, 12);
            职位类别1Label.TabIndex = 9;
            职位类别1Label.Text = "职位类别:";
            // 
            // 工作地点Label
            // 
            工作地点Label.AutoSize = true;
            工作地点Label.Location = new System.Drawing.Point(244, 174);
            工作地点Label.Name = "工作地点Label";
            工作地点Label.Size = new System.Drawing.Size(59, 12);
            工作地点Label.TabIndex = 12;
            工作地点Label.Text = "工作地点:";
            // 
            // 有效日期Label
            // 
            有效日期Label.AutoSize = true;
            有效日期Label.Location = new System.Drawing.Point(244, 204);
            有效日期Label.Name = "有效日期Label";
            有效日期Label.Size = new System.Drawing.Size(59, 12);
            有效日期Label.TabIndex = 14;
            有效日期Label.Text = "有效日期:";
            // 
            // 需求人数Label
            // 
            需求人数Label.AutoSize = true;
            需求人数Label.Location = new System.Drawing.Point(244, 234);
            需求人数Label.Name = "需求人数Label";
            需求人数Label.Size = new System.Drawing.Size(59, 12);
            需求人数Label.TabIndex = 16;
            需求人数Label.Text = "需求人数:";
            // 
            // 职位描述Label
            // 
            职位描述Label.AutoSize = true;
            职位描述Label.Location = new System.Drawing.Point(244, 263);
            职位描述Label.Name = "职位描述Label";
            职位描述Label.Size = new System.Drawing.Size(59, 12);
            职位描述Label.TabIndex = 18;
            职位描述Label.Text = "职位描述:";
            // 
            // 入职条件Label
            // 
            入职条件Label.AutoSize = true;
            入职条件Label.Location = new System.Drawing.Point(244, 310);
            入职条件Label.Name = "入职条件Label";
            入职条件Label.Size = new System.Drawing.Size(59, 12);
            入职条件Label.TabIndex = 20;
            入职条件Label.Text = "入职条件:";
            // 
            // jobDataSet
            // 
            this.jobDataSet.DataSetName = "JobDataSet";
            this.jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobInfoViewBindingSource
            // 
            this.jobInfoViewBindingSource.DataMember = "jobInfoView";
            this.jobInfoViewBindingSource.DataSource = this.jobDataSet;
            // 
            // jobInfoViewTableAdapter
            // 
            this.jobInfoViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.jobinfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.JobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "投简历";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 职位编号Label1
            // 
            this.职位编号Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "职位编号", true));
            this.职位编号Label1.Location = new System.Drawing.Point(309, 77);
            this.职位编号Label1.Name = "职位编号Label1";
            this.职位编号Label1.Size = new System.Drawing.Size(100, 23);
            this.职位编号Label1.TabIndex = 6;
            this.职位编号Label1.Text = "label1";
            // 
            // 职位名称Label2
            // 
            this.职位名称Label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "职位名称", true));
            this.职位名称Label2.Location = new System.Drawing.Point(309, 108);
            this.职位名称Label2.Name = "职位名称Label2";
            this.职位名称Label2.Size = new System.Drawing.Size(100, 23);
            this.职位名称Label2.TabIndex = 8;
            this.职位名称Label2.Text = "label1";
            // 
            // 职位类别2Label1
            // 
            this.职位类别2Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "职位类别2", true));
            this.职位类别2Label1.Location = new System.Drawing.Point(415, 141);
            this.职位类别2Label1.Name = "职位类别2Label1";
            this.职位类别2Label1.Size = new System.Drawing.Size(100, 23);
            this.职位类别2Label1.TabIndex = 12;
            this.职位类别2Label1.Text = "label1";
            // 
            // 工作地点Label1
            // 
            this.工作地点Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "工作地点", true));
            this.工作地点Label1.Location = new System.Drawing.Point(309, 174);
            this.工作地点Label1.Name = "工作地点Label1";
            this.工作地点Label1.Size = new System.Drawing.Size(100, 23);
            this.工作地点Label1.TabIndex = 13;
            this.工作地点Label1.Text = "label1";
            // 
            // 有效日期Label1
            // 
            this.有效日期Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "有效日期", true));
            this.有效日期Label1.Location = new System.Drawing.Point(309, 204);
            this.有效日期Label1.Name = "有效日期Label1";
            this.有效日期Label1.Size = new System.Drawing.Size(100, 23);
            this.有效日期Label1.TabIndex = 15;
            this.有效日期Label1.Text = "label1";
            // 
            // 需求人数Label1
            // 
            this.需求人数Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "需求人数", true));
            this.需求人数Label1.Location = new System.Drawing.Point(309, 234);
            this.需求人数Label1.Name = "需求人数Label1";
            this.需求人数Label1.Size = new System.Drawing.Size(100, 23);
            this.需求人数Label1.TabIndex = 17;
            this.需求人数Label1.Text = "label1";
            // 
            // 职位描述Label1
            // 
            this.职位描述Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "职位描述", true));
            this.职位描述Label1.Location = new System.Drawing.Point(309, 263);
            this.职位描述Label1.Name = "职位描述Label1";
            this.职位描述Label1.Size = new System.Drawing.Size(100, 23);
            this.职位描述Label1.TabIndex = 19;
            this.职位描述Label1.Text = "label1";
            // 
            // 入职条件Label1
            // 
            this.入职条件Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "入职条件", true));
            this.入职条件Label1.Location = new System.Drawing.Point(309, 310);
            this.入职条件Label1.Name = "入职条件Label1";
            this.入职条件Label1.Size = new System.Drawing.Size(100, 23);
            this.入职条件Label1.TabIndex = 21;
            this.入职条件Label1.Text = "label1";
            // 
            // 职位名称ListBox
            // 
            //this.职位名称ListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobInfoViewBindingSource, "职位名称", true));
            this.职位名称ListBox.DataSource = this.jobInfoViewBindingSource;
            this.职位名称ListBox.DisplayMember = "职位名称";
            this.职位名称ListBox.FormattingEnabled = true;
            this.职位名称ListBox.ItemHeight = 12;
            this.职位名称ListBox.Location = new System.Drawing.Point(16, 101);
            this.职位名称ListBox.Name = "职位名称ListBox";
            this.职位名称ListBox.Size = new System.Drawing.Size(205, 232);
            this.职位名称ListBox.TabIndex = 22;
            this.职位名称ListBox.SelectedIndexChanged += new System.EventHandler(this.职位名称ListBox_SelectedIndexChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.jobInfoViewBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(9, 64);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 23;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 职位类别1Label3
            // 
            this.职位类别1Label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobInfoViewBindingSource, "职位类别1", true));
            this.职位类别1Label3.Location = new System.Drawing.Point(309, 141);
            this.职位类别1Label3.Name = "职位类别1Label3";
            this.职位类别1Label3.Size = new System.Drawing.Size(100, 23);
            this.职位类别1Label3.TabIndex = 24;
            this.职位类别1Label3.Text = "label1";
            // 
            // JobInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 350);
            this.Controls.Add(this.职位类别1Label3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.职位名称ListBox);
            this.Controls.Add(入职条件Label);
            this.Controls.Add(this.入职条件Label1);
            this.Controls.Add(职位描述Label);
            this.Controls.Add(this.职位描述Label1);
            this.Controls.Add(需求人数Label);
            this.Controls.Add(this.需求人数Label1);
            this.Controls.Add(有效日期Label);
            this.Controls.Add(this.有效日期Label1);
            this.Controls.Add(工作地点Label);
            this.Controls.Add(this.工作地点Label1);
            this.Controls.Add(this.职位类别2Label1);
            this.Controls.Add(职位类别1Label);
            this.Controls.Add(职位名称Label1);
            this.Controls.Add(this.职位名称Label2);
            this.Controls.Add(职位编号Label);
            this.Controls.Add(this.职位编号Label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(职位名称Label);
            this.Name = "JobInfo";
            this.Text = "职位信息";
            this.Load += new System.EventHandler(this.JobInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobInfoViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JobDataSet jobDataSet;
        private System.Windows.Forms.BindingSource jobInfoViewBindingSource;
        private JobDataSetTableAdapters.jobInfoViewTableAdapter jobInfoViewTableAdapter;
        private JobDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label 职位编号Label1;
        private System.Windows.Forms.Label 职位名称Label2;
        private System.Windows.Forms.Label 职位类别2Label1;
        private System.Windows.Forms.Label 工作地点Label1;
        private System.Windows.Forms.Label 有效日期Label1;
        private System.Windows.Forms.Label 需求人数Label1;
        private System.Windows.Forms.Label 职位描述Label1;
        private System.Windows.Forms.Label 入职条件Label1;
        private System.Windows.Forms.ListBox 职位名称ListBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label 职位类别1Label3;

    }
}