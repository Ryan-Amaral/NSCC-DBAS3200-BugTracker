namespace RyanAmaral_DBAS3200_BugTracker
{
    partial class FormBugTracker
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
            this.tabsBugTracker = new System.Windows.Forms.TabControl();
            this.tabPageIdentify = new System.Windows.Forms.TabPage();
            this.button0Go = new System.Windows.Forms.Button();
            this.textBox0UserName = new System.Windows.Forms.TextBox();
            this.label0UserName = new System.Windows.Forms.Label();
            this.label0PleaseIdentifyYourself = new System.Windows.Forms.Label();
            this.tabPageApplications = new System.Windows.Forms.TabPage();
            this.button1Delete = new System.Windows.Forms.Button();
            this.listBox1Applications = new System.Windows.Forms.ListBox();
            this.vBar1 = new System.Windows.Forms.Label();
            this.button1Save = new System.Windows.Forms.Button();
            this.textBox1Description = new System.Windows.Forms.TextBox();
            this.textBox1CurrentVersion = new System.Windows.Forms.TextBox();
            this.textBox1ApplicationName = new System.Windows.Forms.TextBox();
            this.labelVal1ApplicationId = new System.Windows.Forms.Label();
            this.label1Description = new System.Windows.Forms.Label();
            this.label1CurrentVersion = new System.Windows.Forms.Label();
            this.label1ApplicationName = new System.Windows.Forms.Label();
            this.label1ApplicationId = new System.Windows.Forms.Label();
            this.label1ApplicationManager = new System.Windows.Forms.Label();
            this.tabPageBugs = new System.Windows.Forms.TabPage();
            this.button2Save = new System.Windows.Forms.Button();
            this.textBox2UpdateComments = new System.Windows.Forms.TextBox();
            this.label2UpdateComments = new System.Windows.Forms.Label();
            this.dataGridViewBugActivityLog = new System.Windows.Forms.DataGridView();
            this.DataGridView2ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView2ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView2ColumnUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView2ColumnComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2BugActivityLog = new System.Windows.Forms.Label();
            this.labelVal2FixDate = new System.Windows.Forms.Label();
            this.label2FixDate = new System.Windows.Forms.Label();
            this.comboBox2Status = new System.Windows.Forms.ComboBox();
            this.label2Status = new System.Windows.Forms.Label();
            this.textBox2RepSteps = new System.Windows.Forms.TextBox();
            this.label2RepSteps = new System.Windows.Forms.Label();
            this.textBox2Details = new System.Windows.Forms.TextBox();
            this.label2Details = new System.Windows.Forms.Label();
            this.textBox2Description = new System.Windows.Forms.TextBox();
            this.labelVal2BugId = new System.Windows.Forms.Label();
            this.labelVal2SubmitDate = new System.Windows.Forms.Label();
            this.label2Description = new System.Windows.Forms.Label();
            this.label2BugId = new System.Windows.Forms.Label();
            this.label2SubmitDate = new System.Windows.Forms.Label();
            this.vBar2 = new System.Windows.Forms.Label();
            this.button2DeleteBug = new System.Windows.Forms.Button();
            this.listBox2BugList = new System.Windows.Forms.ListBox();
            this.label2BugList = new System.Windows.Forms.Label();
            this.comboBox2SelectApplication = new System.Windows.Forms.ComboBox();
            this.comboBox2StatusFilter = new System.Windows.Forms.ComboBox();
            this.label2StatusFilter = new System.Windows.Forms.Label();
            this.label2Application = new System.Windows.Forms.Label();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.button3Delete = new System.Windows.Forms.Button();
            this.listBox3Users = new System.Windows.Forms.ListBox();
            this.button3Save = new System.Windows.Forms.Button();
            this.vBar3 = new System.Windows.Forms.Label();
            this.labelVal3UserId = new System.Windows.Forms.Label();
            this.textBox3UserName = new System.Windows.Forms.TextBox();
            this.textBox3Email = new System.Windows.Forms.TextBox();
            this.textBox3PhoneNum = new System.Windows.Forms.TextBox();
            this.label3PhoneNum = new System.Windows.Forms.Label();
            this.label3Email = new System.Windows.Forms.Label();
            this.label3UserName = new System.Windows.Forms.Label();
            this.label3UserId = new System.Windows.Forms.Label();
            this.label3UserManager = new System.Windows.Forms.Label();
            this.tabsBugTracker.SuspendLayout();
            this.tabPageIdentify.SuspendLayout();
            this.tabPageApplications.SuspendLayout();
            this.tabPageBugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugActivityLog)).BeginInit();
            this.tabPageUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsBugTracker
            // 
            this.tabsBugTracker.Controls.Add(this.tabPageIdentify);
            this.tabsBugTracker.Controls.Add(this.tabPageApplications);
            this.tabsBugTracker.Controls.Add(this.tabPageBugs);
            this.tabsBugTracker.Controls.Add(this.tabPageUsers);
            this.tabsBugTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsBugTracker.Location = new System.Drawing.Point(0, 0);
            this.tabsBugTracker.Name = "tabsBugTracker";
            this.tabsBugTracker.SelectedIndex = 0;
            this.tabsBugTracker.Size = new System.Drawing.Size(846, 453);
            this.tabsBugTracker.TabIndex = 0;
            // 
            // tabPageIdentify
            // 
            this.tabPageIdentify.Controls.Add(this.button0Go);
            this.tabPageIdentify.Controls.Add(this.textBox0UserName);
            this.tabPageIdentify.Controls.Add(this.label0UserName);
            this.tabPageIdentify.Controls.Add(this.label0PleaseIdentifyYourself);
            this.tabPageIdentify.Location = new System.Drawing.Point(4, 22);
            this.tabPageIdentify.Name = "tabPageIdentify";
            this.tabPageIdentify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIdentify.Size = new System.Drawing.Size(838, 427);
            this.tabPageIdentify.TabIndex = 0;
            this.tabPageIdentify.Text = "Identify";
            this.tabPageIdentify.UseVisualStyleBackColor = true;
            // 
            // button0Go
            // 
            this.button0Go.Location = new System.Drawing.Point(522, 198);
            this.button0Go.Name = "button0Go";
            this.button0Go.Size = new System.Drawing.Size(75, 23);
            this.button0Go.TabIndex = 3;
            this.button0Go.Text = "Go";
            this.button0Go.UseVisualStyleBackColor = true;
            this.button0Go.Click += new System.EventHandler(this.button0Go_Click);
            // 
            // textBox0UserName
            // 
            this.textBox0UserName.Location = new System.Drawing.Point(310, 200);
            this.textBox0UserName.Name = "textBox0UserName";
            this.textBox0UserName.Size = new System.Drawing.Size(206, 20);
            this.textBox0UserName.TabIndex = 2;
            // 
            // label0UserName
            // 
            this.label0UserName.AutoSize = true;
            this.label0UserName.Location = new System.Drawing.Point(241, 203);
            this.label0UserName.Name = "label0UserName";
            this.label0UserName.Size = new System.Drawing.Size(63, 13);
            this.label0UserName.TabIndex = 1;
            this.label0UserName.Text = "User Name:";
            // 
            // label0PleaseIdentifyYourself
            // 
            this.label0PleaseIdentifyYourself.AutoSize = true;
            this.label0PleaseIdentifyYourself.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0PleaseIdentifyYourself.Location = new System.Drawing.Point(8, 14);
            this.label0PleaseIdentifyYourself.Name = "label0PleaseIdentifyYourself";
            this.label0PleaseIdentifyYourself.Size = new System.Drawing.Size(263, 25);
            this.label0PleaseIdentifyYourself.TabIndex = 0;
            this.label0PleaseIdentifyYourself.Text = "Please Identify Yourself";
            // 
            // tabPageApplications
            // 
            this.tabPageApplications.Controls.Add(this.button1Delete);
            this.tabPageApplications.Controls.Add(this.listBox1Applications);
            this.tabPageApplications.Controls.Add(this.vBar1);
            this.tabPageApplications.Controls.Add(this.button1Save);
            this.tabPageApplications.Controls.Add(this.textBox1Description);
            this.tabPageApplications.Controls.Add(this.textBox1CurrentVersion);
            this.tabPageApplications.Controls.Add(this.textBox1ApplicationName);
            this.tabPageApplications.Controls.Add(this.labelVal1ApplicationId);
            this.tabPageApplications.Controls.Add(this.label1Description);
            this.tabPageApplications.Controls.Add(this.label1CurrentVersion);
            this.tabPageApplications.Controls.Add(this.label1ApplicationName);
            this.tabPageApplications.Controls.Add(this.label1ApplicationId);
            this.tabPageApplications.Controls.Add(this.label1ApplicationManager);
            this.tabPageApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageApplications.Name = "tabPageApplications";
            this.tabPageApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplications.Size = new System.Drawing.Size(838, 427);
            this.tabPageApplications.TabIndex = 1;
            this.tabPageApplications.Text = "Applications";
            this.tabPageApplications.UseVisualStyleBackColor = true;
            // 
            // button1Delete
            // 
            this.button1Delete.Location = new System.Drawing.Point(622, 372);
            this.button1Delete.Name = "button1Delete";
            this.button1Delete.Size = new System.Drawing.Size(75, 23);
            this.button1Delete.TabIndex = 12;
            this.button1Delete.Text = "Delete";
            this.button1Delete.UseVisualStyleBackColor = true;
            this.button1Delete.Click += new System.EventHandler(this.button1Delete_Click);
            // 
            // listBox1Applications
            // 
            this.listBox1Applications.FormattingEnabled = true;
            this.listBox1Applications.Location = new System.Drawing.Point(482, 72);
            this.listBox1Applications.Name = "listBox1Applications";
            this.listBox1Applications.Size = new System.Drawing.Size(215, 290);
            this.listBox1Applications.TabIndex = 11;
            this.listBox1Applications.SelectedIndexChanged += new System.EventHandler(this.listBox1Applications_SelectedIndexChanged);
            // 
            // vBar1
            // 
            this.vBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vBar1.Location = new System.Drawing.Point(418, 63);
            this.vBar1.Name = "vBar1";
            this.vBar1.Size = new System.Drawing.Size(2, 300);
            this.vBar1.TabIndex = 10;
            // 
            // button1Save
            // 
            this.button1Save.Location = new System.Drawing.Point(303, 372);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(75, 23);
            this.button1Save.TabIndex = 9;
            this.button1Save.Text = "Save";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // textBox1Description
            // 
            this.textBox1Description.Location = new System.Drawing.Point(166, 177);
            this.textBox1Description.Multiline = true;
            this.textBox1Description.Name = "textBox1Description";
            this.textBox1Description.Size = new System.Drawing.Size(212, 180);
            this.textBox1Description.TabIndex = 8;
            // 
            // textBox1CurrentVersion
            // 
            this.textBox1CurrentVersion.Location = new System.Drawing.Point(166, 141);
            this.textBox1CurrentVersion.Name = "textBox1CurrentVersion";
            this.textBox1CurrentVersion.Size = new System.Drawing.Size(78, 20);
            this.textBox1CurrentVersion.TabIndex = 7;
            // 
            // textBox1ApplicationName
            // 
            this.textBox1ApplicationName.Location = new System.Drawing.Point(166, 105);
            this.textBox1ApplicationName.Name = "textBox1ApplicationName";
            this.textBox1ApplicationName.Size = new System.Drawing.Size(212, 20);
            this.textBox1ApplicationName.TabIndex = 6;
            // 
            // labelVal1ApplicationId
            // 
            this.labelVal1ApplicationId.AutoSize = true;
            this.labelVal1ApplicationId.Location = new System.Drawing.Point(163, 72);
            this.labelVal1ApplicationId.Name = "labelVal1ApplicationId";
            this.labelVal1ApplicationId.Size = new System.Drawing.Size(0, 13);
            this.labelVal1ApplicationId.TabIndex = 5;
            // 
            // label1Description
            // 
            this.label1Description.AutoSize = true;
            this.label1Description.Location = new System.Drawing.Point(67, 180);
            this.label1Description.Name = "label1Description";
            this.label1Description.Size = new System.Drawing.Size(63, 13);
            this.label1Description.TabIndex = 4;
            this.label1Description.Text = "Description:";
            // 
            // label1CurrentVersion
            // 
            this.label1CurrentVersion.AutoSize = true;
            this.label1CurrentVersion.Location = new System.Drawing.Point(67, 144);
            this.label1CurrentVersion.Name = "label1CurrentVersion";
            this.label1CurrentVersion.Size = new System.Drawing.Size(82, 13);
            this.label1CurrentVersion.TabIndex = 3;
            this.label1CurrentVersion.Text = "Current Version:";
            // 
            // label1ApplicationName
            // 
            this.label1ApplicationName.AutoSize = true;
            this.label1ApplicationName.Location = new System.Drawing.Point(67, 108);
            this.label1ApplicationName.Name = "label1ApplicationName";
            this.label1ApplicationName.Size = new System.Drawing.Size(93, 13);
            this.label1ApplicationName.TabIndex = 2;
            this.label1ApplicationName.Text = "Application Name:";
            // 
            // label1ApplicationId
            // 
            this.label1ApplicationId.AutoSize = true;
            this.label1ApplicationId.Location = new System.Drawing.Point(67, 72);
            this.label1ApplicationId.Name = "label1ApplicationId";
            this.label1ApplicationId.Size = new System.Drawing.Size(76, 13);
            this.label1ApplicationId.TabIndex = 1;
            this.label1ApplicationId.Text = "Application ID:";
            // 
            // label1ApplicationManager
            // 
            this.label1ApplicationManager.AutoSize = true;
            this.label1ApplicationManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1ApplicationManager.Location = new System.Drawing.Point(8, 12);
            this.label1ApplicationManager.Name = "label1ApplicationManager";
            this.label1ApplicationManager.Size = new System.Drawing.Size(228, 25);
            this.label1ApplicationManager.TabIndex = 0;
            this.label1ApplicationManager.Text = "Application Manager";
            // 
            // tabPageBugs
            // 
            this.tabPageBugs.Controls.Add(this.button2Save);
            this.tabPageBugs.Controls.Add(this.textBox2UpdateComments);
            this.tabPageBugs.Controls.Add(this.label2UpdateComments);
            this.tabPageBugs.Controls.Add(this.dataGridViewBugActivityLog);
            this.tabPageBugs.Controls.Add(this.label2BugActivityLog);
            this.tabPageBugs.Controls.Add(this.labelVal2FixDate);
            this.tabPageBugs.Controls.Add(this.label2FixDate);
            this.tabPageBugs.Controls.Add(this.comboBox2Status);
            this.tabPageBugs.Controls.Add(this.label2Status);
            this.tabPageBugs.Controls.Add(this.textBox2RepSteps);
            this.tabPageBugs.Controls.Add(this.label2RepSteps);
            this.tabPageBugs.Controls.Add(this.textBox2Details);
            this.tabPageBugs.Controls.Add(this.label2Details);
            this.tabPageBugs.Controls.Add(this.textBox2Description);
            this.tabPageBugs.Controls.Add(this.labelVal2BugId);
            this.tabPageBugs.Controls.Add(this.labelVal2SubmitDate);
            this.tabPageBugs.Controls.Add(this.label2Description);
            this.tabPageBugs.Controls.Add(this.label2BugId);
            this.tabPageBugs.Controls.Add(this.label2SubmitDate);
            this.tabPageBugs.Controls.Add(this.vBar2);
            this.tabPageBugs.Controls.Add(this.button2DeleteBug);
            this.tabPageBugs.Controls.Add(this.listBox2BugList);
            this.tabPageBugs.Controls.Add(this.label2BugList);
            this.tabPageBugs.Controls.Add(this.comboBox2SelectApplication);
            this.tabPageBugs.Controls.Add(this.comboBox2StatusFilter);
            this.tabPageBugs.Controls.Add(this.label2StatusFilter);
            this.tabPageBugs.Controls.Add(this.label2Application);
            this.tabPageBugs.Location = new System.Drawing.Point(4, 22);
            this.tabPageBugs.Name = "tabPageBugs";
            this.tabPageBugs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBugs.Size = new System.Drawing.Size(838, 427);
            this.tabPageBugs.TabIndex = 2;
            this.tabPageBugs.Text = "Bugs";
            this.tabPageBugs.UseVisualStyleBackColor = true;
            // 
            // button2Save
            // 
            this.button2Save.Location = new System.Drawing.Point(757, 393);
            this.button2Save.Name = "button2Save";
            this.button2Save.Size = new System.Drawing.Size(75, 23);
            this.button2Save.TabIndex = 30;
            this.button2Save.Text = "Save";
            this.button2Save.UseVisualStyleBackColor = true;
            this.button2Save.Click += new System.EventHandler(this.button2Save_Click);
            // 
            // textBox2UpdateComments
            // 
            this.textBox2UpdateComments.Location = new System.Drawing.Point(552, 293);
            this.textBox2UpdateComments.Multiline = true;
            this.textBox2UpdateComments.Name = "textBox2UpdateComments";
            this.textBox2UpdateComments.Size = new System.Drawing.Size(280, 94);
            this.textBox2UpdateComments.TabIndex = 29;
            // 
            // label2UpdateComments
            // 
            this.label2UpdateComments.AutoSize = true;
            this.label2UpdateComments.Location = new System.Drawing.Point(549, 277);
            this.label2UpdateComments.Name = "label2UpdateComments";
            this.label2UpdateComments.Size = new System.Drawing.Size(97, 13);
            this.label2UpdateComments.TabIndex = 28;
            this.label2UpdateComments.Text = "Update Comments:";
            // 
            // dataGridViewBugActivityLog
            // 
            this.dataGridViewBugActivityLog.AllowUserToAddRows = false;
            this.dataGridViewBugActivityLog.AllowUserToDeleteRows = false;
            this.dataGridViewBugActivityLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBugActivityLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBugActivityLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridView2ColumnDate,
            this.DataGridView2ColumnStatus,
            this.DataGridView2ColumnUpdatedBy,
            this.DataGridView2ColumnComments});
            this.dataGridViewBugActivityLog.Location = new System.Drawing.Point(549, 35);
            this.dataGridViewBugActivityLog.Name = "dataGridViewBugActivityLog";
            this.dataGridViewBugActivityLog.ReadOnly = true;
            this.dataGridViewBugActivityLog.Size = new System.Drawing.Size(283, 223);
            this.dataGridViewBugActivityLog.TabIndex = 27;
            // 
            // DataGridView2ColumnDate
            // 
            this.DataGridView2ColumnDate.HeaderText = "Date";
            this.DataGridView2ColumnDate.Name = "DataGridView2ColumnDate";
            this.DataGridView2ColumnDate.ReadOnly = true;
            // 
            // DataGridView2ColumnStatus
            // 
            this.DataGridView2ColumnStatus.HeaderText = "Status";
            this.DataGridView2ColumnStatus.Name = "DataGridView2ColumnStatus";
            this.DataGridView2ColumnStatus.ReadOnly = true;
            // 
            // DataGridView2ColumnUpdatedBy
            // 
            this.DataGridView2ColumnUpdatedBy.HeaderText = "Updated By";
            this.DataGridView2ColumnUpdatedBy.Name = "DataGridView2ColumnUpdatedBy";
            this.DataGridView2ColumnUpdatedBy.ReadOnly = true;
            // 
            // DataGridView2ColumnComments
            // 
            this.DataGridView2ColumnComments.HeaderText = "Comments";
            this.DataGridView2ColumnComments.Name = "DataGridView2ColumnComments";
            this.DataGridView2ColumnComments.ReadOnly = true;
            // 
            // label2BugActivityLog
            // 
            this.label2BugActivityLog.AutoSize = true;
            this.label2BugActivityLog.Location = new System.Drawing.Point(546, 19);
            this.label2BugActivityLog.Name = "label2BugActivityLog";
            this.label2BugActivityLog.Size = new System.Drawing.Size(87, 13);
            this.label2BugActivityLog.TabIndex = 26;
            this.label2BugActivityLog.Text = "Bug Activity Log:";
            // 
            // labelVal2FixDate
            // 
            this.labelVal2FixDate.AutoSize = true;
            this.labelVal2FixDate.Location = new System.Drawing.Point(351, 345);
            this.labelVal2FixDate.Name = "labelVal2FixDate";
            this.labelVal2FixDate.Size = new System.Drawing.Size(0, 13);
            this.labelVal2FixDate.TabIndex = 25;
            // 
            // label2FixDate
            // 
            this.label2FixDate.AutoSize = true;
            this.label2FixDate.Location = new System.Drawing.Point(274, 345);
            this.label2FixDate.Name = "label2FixDate";
            this.label2FixDate.Size = new System.Drawing.Size(49, 13);
            this.label2FixDate.TabIndex = 24;
            this.label2FixDate.Text = "Fix Date:";
            // 
            // comboBox2Status
            // 
            this.comboBox2Status.FormattingEnabled = true;
            this.comboBox2Status.Location = new System.Drawing.Point(351, 310);
            this.comboBox2Status.Name = "comboBox2Status";
            this.comboBox2Status.Size = new System.Drawing.Size(192, 21);
            this.comboBox2Status.TabIndex = 23;
            // 
            // label2Status
            // 
            this.label2Status.AutoSize = true;
            this.label2Status.Location = new System.Drawing.Point(274, 313);
            this.label2Status.Name = "label2Status";
            this.label2Status.Size = new System.Drawing.Size(40, 13);
            this.label2Status.TabIndex = 22;
            this.label2Status.Text = "Status:";
            // 
            // textBox2RepSteps
            // 
            this.textBox2RepSteps.Location = new System.Drawing.Point(351, 202);
            this.textBox2RepSteps.Multiline = true;
            this.textBox2RepSteps.Name = "textBox2RepSteps";
            this.textBox2RepSteps.Size = new System.Drawing.Size(192, 97);
            this.textBox2RepSteps.TabIndex = 21;
            // 
            // label2RepSteps
            // 
            this.label2RepSteps.AutoSize = true;
            this.label2RepSteps.Location = new System.Drawing.Point(274, 205);
            this.label2RepSteps.Name = "label2RepSteps";
            this.label2RepSteps.Size = new System.Drawing.Size(60, 13);
            this.label2RepSteps.TabIndex = 20;
            this.label2RepSteps.Text = "Rep Steps:";
            // 
            // textBox2Details
            // 
            this.textBox2Details.Location = new System.Drawing.Point(351, 99);
            this.textBox2Details.Multiline = true;
            this.textBox2Details.Name = "textBox2Details";
            this.textBox2Details.Size = new System.Drawing.Size(192, 92);
            this.textBox2Details.TabIndex = 19;
            // 
            // label2Details
            // 
            this.label2Details.AutoSize = true;
            this.label2Details.Location = new System.Drawing.Point(274, 102);
            this.label2Details.Name = "label2Details";
            this.label2Details.Size = new System.Drawing.Size(42, 13);
            this.label2Details.TabIndex = 18;
            this.label2Details.Text = "Details:";
            // 
            // textBox2Description
            // 
            this.textBox2Description.Location = new System.Drawing.Point(351, 71);
            this.textBox2Description.Name = "textBox2Description";
            this.textBox2Description.Size = new System.Drawing.Size(192, 20);
            this.textBox2Description.TabIndex = 17;
            // 
            // labelVal2BugId
            // 
            this.labelVal2BugId.AutoSize = true;
            this.labelVal2BugId.Location = new System.Drawing.Point(348, 19);
            this.labelVal2BugId.Name = "labelVal2BugId";
            this.labelVal2BugId.Size = new System.Drawing.Size(63, 13);
            this.labelVal2BugId.TabIndex = 16;
            this.labelVal2BugId.Text = "<Add New>";
            // 
            // labelVal2SubmitDate
            // 
            this.labelVal2SubmitDate.AutoSize = true;
            this.labelVal2SubmitDate.Location = new System.Drawing.Point(348, 47);
            this.labelVal2SubmitDate.Name = "labelVal2SubmitDate";
            this.labelVal2SubmitDate.Size = new System.Drawing.Size(0, 13);
            this.labelVal2SubmitDate.TabIndex = 15;
            // 
            // label2Description
            // 
            this.label2Description.AutoSize = true;
            this.label2Description.Location = new System.Drawing.Point(274, 74);
            this.label2Description.Name = "label2Description";
            this.label2Description.Size = new System.Drawing.Size(63, 13);
            this.label2Description.TabIndex = 14;
            this.label2Description.Text = "Description:";
            // 
            // label2BugId
            // 
            this.label2BugId.AutoSize = true;
            this.label2BugId.Location = new System.Drawing.Point(274, 19);
            this.label2BugId.Name = "label2BugId";
            this.label2BugId.Size = new System.Drawing.Size(43, 13);
            this.label2BugId.TabIndex = 13;
            this.label2BugId.Text = "Bug ID:";
            // 
            // label2SubmitDate
            // 
            this.label2SubmitDate.AutoSize = true;
            this.label2SubmitDate.Location = new System.Drawing.Point(274, 47);
            this.label2SubmitDate.Name = "label2SubmitDate";
            this.label2SubmitDate.Size = new System.Drawing.Size(68, 13);
            this.label2SubmitDate.TabIndex = 12;
            this.label2SubmitDate.Text = "Submit Date:";
            // 
            // vBar2
            // 
            this.vBar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vBar2.Location = new System.Drawing.Point(265, 16);
            this.vBar2.Name = "vBar2";
            this.vBar2.Size = new System.Drawing.Size(1, 371);
            this.vBar2.TabIndex = 11;
            // 
            // button2DeleteBug
            // 
            this.button2DeleteBug.Location = new System.Drawing.Point(176, 386);
            this.button2DeleteBug.Name = "button2DeleteBug";
            this.button2DeleteBug.Size = new System.Drawing.Size(75, 23);
            this.button2DeleteBug.TabIndex = 6;
            this.button2DeleteBug.Text = "Delete Bug";
            this.button2DeleteBug.UseVisualStyleBackColor = true;
            this.button2DeleteBug.Click += new System.EventHandler(this.button2DeleteBug_Click);
            // 
            // listBox2BugList
            // 
            this.listBox2BugList.FormattingEnabled = true;
            this.listBox2BugList.Location = new System.Drawing.Point(20, 90);
            this.listBox2BugList.Name = "listBox2BugList";
            this.listBox2BugList.Size = new System.Drawing.Size(231, 290);
            this.listBox2BugList.TabIndex = 5;
            this.listBox2BugList.SelectedIndexChanged += new System.EventHandler(this.listBox2BugList_SelectedIndexChanged);
            // 
            // label2BugList
            // 
            this.label2BugList.AutoSize = true;
            this.label2BugList.Location = new System.Drawing.Point(17, 74);
            this.label2BugList.Name = "label2BugList";
            this.label2BugList.Size = new System.Drawing.Size(48, 13);
            this.label2BugList.TabIndex = 4;
            this.label2BugList.Text = "Bug List:";
            // 
            // comboBox2SelectApplication
            // 
            this.comboBox2SelectApplication.FormattingEnabled = true;
            this.comboBox2SelectApplication.Location = new System.Drawing.Point(88, 16);
            this.comboBox2SelectApplication.Name = "comboBox2SelectApplication";
            this.comboBox2SelectApplication.Size = new System.Drawing.Size(163, 21);
            this.comboBox2SelectApplication.TabIndex = 3;
            this.comboBox2SelectApplication.Text = "<Select Application>";
            this.comboBox2SelectApplication.SelectedIndexChanged += new System.EventHandler(this.comboBox2SelectApplication_SelectedIndexChanged);
            // 
            // comboBox2StatusFilter
            // 
            this.comboBox2StatusFilter.FormattingEnabled = true;
            this.comboBox2StatusFilter.Location = new System.Drawing.Point(88, 44);
            this.comboBox2StatusFilter.Name = "comboBox2StatusFilter";
            this.comboBox2StatusFilter.Size = new System.Drawing.Size(163, 21);
            this.comboBox2StatusFilter.TabIndex = 2;
            this.comboBox2StatusFilter.Text = "<Select Status>";
            this.comboBox2StatusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox2StatusFilter_SelectedIndexChanged);
            // 
            // label2StatusFilter
            // 
            this.label2StatusFilter.AutoSize = true;
            this.label2StatusFilter.Location = new System.Drawing.Point(17, 47);
            this.label2StatusFilter.Name = "label2StatusFilter";
            this.label2StatusFilter.Size = new System.Drawing.Size(65, 13);
            this.label2StatusFilter.TabIndex = 1;
            this.label2StatusFilter.Text = "Status Filter:";
            // 
            // label2Application
            // 
            this.label2Application.AutoSize = true;
            this.label2Application.Location = new System.Drawing.Point(17, 19);
            this.label2Application.Name = "label2Application";
            this.label2Application.Size = new System.Drawing.Size(62, 13);
            this.label2Application.TabIndex = 0;
            this.label2Application.Text = "Application:";
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.button3Delete);
            this.tabPageUsers.Controls.Add(this.listBox3Users);
            this.tabPageUsers.Controls.Add(this.button3Save);
            this.tabPageUsers.Controls.Add(this.vBar3);
            this.tabPageUsers.Controls.Add(this.labelVal3UserId);
            this.tabPageUsers.Controls.Add(this.textBox3UserName);
            this.tabPageUsers.Controls.Add(this.textBox3Email);
            this.tabPageUsers.Controls.Add(this.textBox3PhoneNum);
            this.tabPageUsers.Controls.Add(this.label3PhoneNum);
            this.tabPageUsers.Controls.Add(this.label3Email);
            this.tabPageUsers.Controls.Add(this.label3UserName);
            this.tabPageUsers.Controls.Add(this.label3UserId);
            this.tabPageUsers.Controls.Add(this.label3UserManager);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(838, 427);
            this.tabPageUsers.TabIndex = 3;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // button3Delete
            // 
            this.button3Delete.Location = new System.Drawing.Point(569, 340);
            this.button3Delete.Name = "button3Delete";
            this.button3Delete.Size = new System.Drawing.Size(75, 23);
            this.button3Delete.TabIndex = 14;
            this.button3Delete.Text = "Delete";
            this.button3Delete.UseVisualStyleBackColor = true;
            this.button3Delete.Click += new System.EventHandler(this.button3Delete_Click);
            // 
            // listBox3Users
            // 
            this.listBox3Users.FormattingEnabled = true;
            this.listBox3Users.Location = new System.Drawing.Point(444, 63);
            this.listBox3Users.Name = "listBox3Users";
            this.listBox3Users.Size = new System.Drawing.Size(200, 251);
            this.listBox3Users.TabIndex = 13;
            this.listBox3Users.SelectedIndexChanged += new System.EventHandler(this.listBox3Users_SelectedIndexChanged);
            // 
            // button3Save
            // 
            this.button3Save.Location = new System.Drawing.Point(262, 340);
            this.button3Save.Name = "button3Save";
            this.button3Save.Size = new System.Drawing.Size(75, 23);
            this.button3Save.TabIndex = 12;
            this.button3Save.Text = "Save";
            this.button3Save.UseVisualStyleBackColor = true;
            this.button3Save.Click += new System.EventHandler(this.button3Save_Click);
            // 
            // vBar3
            // 
            this.vBar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vBar3.Location = new System.Drawing.Point(392, 63);
            this.vBar3.Name = "vBar3";
            this.vBar3.Size = new System.Drawing.Size(2, 300);
            this.vBar3.TabIndex = 11;
            // 
            // labelVal3UserId
            // 
            this.labelVal3UserId.AutoSize = true;
            this.labelVal3UserId.Location = new System.Drawing.Point(146, 74);
            this.labelVal3UserId.Name = "labelVal3UserId";
            this.labelVal3UserId.Size = new System.Drawing.Size(0, 13);
            this.labelVal3UserId.TabIndex = 9;
            // 
            // textBox3UserName
            // 
            this.textBox3UserName.Location = new System.Drawing.Point(149, 102);
            this.textBox3UserName.Name = "textBox3UserName";
            this.textBox3UserName.Size = new System.Drawing.Size(188, 20);
            this.textBox3UserName.TabIndex = 8;
            // 
            // textBox3Email
            // 
            this.textBox3Email.Location = new System.Drawing.Point(149, 133);
            this.textBox3Email.Name = "textBox3Email";
            this.textBox3Email.Size = new System.Drawing.Size(188, 20);
            this.textBox3Email.TabIndex = 7;
            // 
            // textBox3PhoneNum
            // 
            this.textBox3PhoneNum.Location = new System.Drawing.Point(149, 163);
            this.textBox3PhoneNum.Name = "textBox3PhoneNum";
            this.textBox3PhoneNum.Size = new System.Drawing.Size(188, 20);
            this.textBox3PhoneNum.TabIndex = 6;
            // 
            // label3PhoneNum
            // 
            this.label3PhoneNum.AutoSize = true;
            this.label3PhoneNum.Location = new System.Drawing.Point(77, 166);
            this.label3PhoneNum.Name = "label3PhoneNum";
            this.label3PhoneNum.Size = new System.Drawing.Size(66, 13);
            this.label3PhoneNum.TabIndex = 5;
            this.label3PhoneNum.Text = "Phone Num:";
            // 
            // label3Email
            // 
            this.label3Email.AutoSize = true;
            this.label3Email.Location = new System.Drawing.Point(77, 136);
            this.label3Email.Name = "label3Email";
            this.label3Email.Size = new System.Drawing.Size(35, 13);
            this.label3Email.TabIndex = 4;
            this.label3Email.Text = "Email:";
            // 
            // label3UserName
            // 
            this.label3UserName.AutoSize = true;
            this.label3UserName.Location = new System.Drawing.Point(77, 105);
            this.label3UserName.Name = "label3UserName";
            this.label3UserName.Size = new System.Drawing.Size(60, 13);
            this.label3UserName.TabIndex = 3;
            this.label3UserName.Text = "UserName:";
            // 
            // label3UserId
            // 
            this.label3UserId.AutoSize = true;
            this.label3UserId.Location = new System.Drawing.Point(77, 74);
            this.label3UserId.Name = "label3UserId";
            this.label3UserId.Size = new System.Drawing.Size(46, 13);
            this.label3UserId.TabIndex = 2;
            this.label3UserId.Text = "User ID:";
            // 
            // label3UserManager
            // 
            this.label3UserManager.AutoSize = true;
            this.label3UserManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3UserManager.Location = new System.Drawing.Point(8, 13);
            this.label3UserManager.Name = "label3UserManager";
            this.label3UserManager.Size = new System.Drawing.Size(160, 25);
            this.label3UserManager.TabIndex = 1;
            this.label3UserManager.Text = "User Manager";
            // 
            // FormBugTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 453);
            this.Controls.Add(this.tabsBugTracker);
            this.Name = "FormBugTracker";
            this.Text = "Bug Tracker";
            this.Load += new System.EventHandler(this.FormBugTracker_Load);
            this.tabsBugTracker.ResumeLayout(false);
            this.tabPageIdentify.ResumeLayout(false);
            this.tabPageIdentify.PerformLayout();
            this.tabPageApplications.ResumeLayout(false);
            this.tabPageApplications.PerformLayout();
            this.tabPageBugs.ResumeLayout(false);
            this.tabPageBugs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugActivityLog)).EndInit();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsBugTracker;
        private System.Windows.Forms.TabPage tabPageIdentify;
        private System.Windows.Forms.Button button0Go;
        private System.Windows.Forms.TextBox textBox0UserName;
        private System.Windows.Forms.Label label0UserName;
        private System.Windows.Forms.Label label0PleaseIdentifyYourself;
        private System.Windows.Forms.TabPage tabPageApplications;
        private System.Windows.Forms.Label vBar1;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.TextBox textBox1Description;
        private System.Windows.Forms.TextBox textBox1CurrentVersion;
        private System.Windows.Forms.TextBox textBox1ApplicationName;
        private System.Windows.Forms.Label labelVal1ApplicationId;
        private System.Windows.Forms.Label label1Description;
        private System.Windows.Forms.Label label1CurrentVersion;
        private System.Windows.Forms.Label label1ApplicationName;
        private System.Windows.Forms.Label label1ApplicationId;
        private System.Windows.Forms.Label label1ApplicationManager;
        private System.Windows.Forms.TabPage tabPageBugs;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Label label3UserManager;
        private System.Windows.Forms.ListBox listBox1Applications;
        private System.Windows.Forms.Button button1Delete;
        private System.Windows.Forms.Label label2StatusFilter;
        private System.Windows.Forms.Label label2Application;
        private System.Windows.Forms.Button button2DeleteBug;
        private System.Windows.Forms.ListBox listBox2BugList;
        private System.Windows.Forms.Label label2BugList;
        private System.Windows.Forms.ComboBox comboBox2SelectApplication;
        private System.Windows.Forms.ComboBox comboBox2StatusFilter;
        private System.Windows.Forms.Label vBar2;
        private System.Windows.Forms.Label label2BugId;
        private System.Windows.Forms.Label label2SubmitDate;
        private System.Windows.Forms.DataGridView dataGridViewBugActivityLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridView2ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridView2ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridView2ColumnUpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridView2ColumnComments;
        private System.Windows.Forms.Label label2BugActivityLog;
        private System.Windows.Forms.Label labelVal2FixDate;
        private System.Windows.Forms.Label label2FixDate;
        private System.Windows.Forms.ComboBox comboBox2Status;
        private System.Windows.Forms.Label label2Status;
        private System.Windows.Forms.TextBox textBox2RepSteps;
        private System.Windows.Forms.Label label2RepSteps;
        private System.Windows.Forms.TextBox textBox2Details;
        private System.Windows.Forms.Label label2Details;
        private System.Windows.Forms.TextBox textBox2Description;
        private System.Windows.Forms.Label labelVal2BugId;
        private System.Windows.Forms.Label labelVal2SubmitDate;
        private System.Windows.Forms.Label label2Description;
        private System.Windows.Forms.Button button2Save;
        private System.Windows.Forms.TextBox textBox2UpdateComments;
        private System.Windows.Forms.Label label2UpdateComments;
        private System.Windows.Forms.Label label3PhoneNum;
        private System.Windows.Forms.Label label3Email;
        private System.Windows.Forms.Label label3UserName;
        private System.Windows.Forms.Label label3UserId;
        private System.Windows.Forms.TextBox textBox3PhoneNum;
        private System.Windows.Forms.Button button3Delete;
        private System.Windows.Forms.ListBox listBox3Users;
        private System.Windows.Forms.Button button3Save;
        private System.Windows.Forms.Label vBar3;
        private System.Windows.Forms.Label labelVal3UserId;
        private System.Windows.Forms.TextBox textBox3UserName;
        private System.Windows.Forms.TextBox textBox3Email;
    }
}

