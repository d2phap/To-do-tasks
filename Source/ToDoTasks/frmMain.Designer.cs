﻿namespace ToDoTasks
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panMenu = new System.Windows.Forms.Panel();
            this.radTabLogin = new System.Windows.Forms.RadioButton();
            this.radTabSettings = new System.Windows.Forms.RadioButton();
            this.radTabSchedule = new System.Windows.Forms.RadioButton();
            this.rabTabStatus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panControl = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timSys = new System.Windows.Forms.Timer(this.components);
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabs = new ToDoTasks.TabPagesControl();
            this.tpStatus = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.tpEditTask = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tpSync = new System.Windows.Forms.TabPage();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogInEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpRegisterNewAccount = new System.Windows.Forms.TabPage();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountConfirmPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.tabsFun = new ToDoTasks.TabPagesControl();
            this.tpFunStatus = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMinimizeToSystemTray = new System.Windows.Forms.Button();
            this.tpFunSchedule = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tpFunScheduleNewTask = new System.Windows.Forms.TabPage();
            this.tpFunScheduleEditTask = new System.Windows.Forms.TabPage();
            this.tpFunSettings = new System.Windows.Forms.TabPage();
            this.btnSettingsOK = new System.Windows.Forms.Button();
            this.tpFunSettingsSync = new System.Windows.Forms.TabPage();
            this.btnSyncCancel = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.tpFunLogin = new System.Windows.Forms.TabPage();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tpFunLoginNewAccount = new System.Windows.Forms.TabPage();
            this.btnAccountCancel = new System.Windows.Forms.Button();
            this.btnAccountOK = new System.Windows.Forms.Button();
            this.tpFunLogout = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panControl.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tpStatus.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpRegisterNewAccount.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.tabsFun.SuspendLayout();
            this.tpFunStatus.SuspendLayout();
            this.tpFunSchedule.SuspendLayout();
            this.tpFunSettings.SuspendLayout();
            this.tpFunSettingsSync.SuspendLayout();
            this.tpFunLogin.SuspendLayout();
            this.tpFunLoginNewAccount.SuspendLayout();
            this.tpFunLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.White;
            this.panMenu.Controls.Add(this.radTabLogin);
            this.panMenu.Controls.Add(this.radTabSettings);
            this.panMenu.Controls.Add(this.radTabSchedule);
            this.panMenu.Controls.Add(this.rabTabStatus);
            this.panMenu.Controls.Add(this.label1);
            this.panMenu.Controls.Add(this.picLogo);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(903, 70);
            this.panMenu.TabIndex = 0;
            // 
            // radTabLogin
            // 
            this.radTabLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radTabLogin.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTabLogin.BackColor = System.Drawing.Color.White;
            this.radTabLogin.FlatAppearance.BorderSize = 0;
            this.radTabLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.radTabLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTabLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTabLogin.Location = new System.Drawing.Point(783, 0);
            this.radTabLogin.Name = "radTabLogin";
            this.radTabLogin.Size = new System.Drawing.Size(120, 70);
            this.radTabLogin.TabIndex = 11;
            this.radTabLogin.TabStop = true;
            this.radTabLogin.Text = "Log in";
            this.radTabLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabLogin.UseVisualStyleBackColor = false;
            this.radTabLogin.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // radTabSettings
            // 
            this.radTabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radTabSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTabSettings.BackColor = System.Drawing.Color.White;
            this.radTabSettings.FlatAppearance.BorderSize = 0;
            this.radTabSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.radTabSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTabSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTabSettings.Location = new System.Drawing.Point(662, 0);
            this.radTabSettings.Name = "radTabSettings";
            this.radTabSettings.Size = new System.Drawing.Size(120, 70);
            this.radTabSettings.TabIndex = 10;
            this.radTabSettings.TabStop = true;
            this.radTabSettings.Text = "Settings";
            this.radTabSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabSettings.UseVisualStyleBackColor = false;
            this.radTabSettings.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // radTabSchedule
            // 
            this.radTabSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radTabSchedule.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTabSchedule.BackColor = System.Drawing.Color.White;
            this.radTabSchedule.FlatAppearance.BorderSize = 0;
            this.radTabSchedule.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.radTabSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.radTabSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTabSchedule.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTabSchedule.Location = new System.Drawing.Point(541, 0);
            this.radTabSchedule.Name = "radTabSchedule";
            this.radTabSchedule.Size = new System.Drawing.Size(120, 70);
            this.radTabSchedule.TabIndex = 9;
            this.radTabSchedule.TabStop = true;
            this.radTabSchedule.Text = "Schedule";
            this.radTabSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTabSchedule.UseVisualStyleBackColor = false;
            this.radTabSchedule.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // rabTabStatus
            // 
            this.rabTabStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rabTabStatus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rabTabStatus.BackColor = System.Drawing.Color.White;
            this.rabTabStatus.Checked = true;
            this.rabTabStatus.FlatAppearance.BorderSize = 0;
            this.rabTabStatus.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.rabTabStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(200)))));
            this.rabTabStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.rabTabStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rabTabStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rabTabStatus.Location = new System.Drawing.Point(420, 0);
            this.rabTabStatus.Name = "rabTabStatus";
            this.rabTabStatus.Size = new System.Drawing.Size(120, 70);
            this.rabTabStatus.TabIndex = 2;
            this.rabTabStatus.TabStop = true;
            this.rabTabStatus.Text = "Status";
            this.rabTabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rabTabStatus.UseVisualStyleBackColor = false;
            this.rabTabStatus.CheckedChanged += new System.EventHandler(this.radTab_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(161)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "To do tasks";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(46, 46);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panControl
            // 
            this.panControl.BackColor = System.Drawing.Color.White;
            this.panControl.Controls.Add(this.tabsFun);
            this.panControl.Controls.Add(this.lblDate);
            this.panControl.Controls.Add(this.lblTime);
            this.panControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panControl.Location = new System.Drawing.Point(0, 406);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(903, 80);
            this.panControl.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDate.Location = new System.Drawing.Point(12, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Jan 8th, 2014";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(103, 32);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "20:21:03";
            // 
            // timSys
            // 
            this.timSys.Enabled = true;
            this.timSys.Interval = 1000;
            this.timSys.Tick += new System.EventHandler(this.timSys_Tick);
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "To do tasks";
            this.tray.DoubleClick += new System.EventHandler(this.tray_DoubleClick);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tpStatus);
            this.tabs.Controls.Add(this.tpSchedule);
            this.tabs.Controls.Add(this.tpEditTask);
            this.tabs.Controls.Add(this.tpSettings);
            this.tabs.Controls.Add(this.tpSync);
            this.tabs.Controls.Add(this.tpLogin);
            this.tabs.Controls.Add(this.tpRegisterNewAccount);
            this.tabs.Controls.Add(this.tpAccount);
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(40, 95);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(821, 288);
            this.tabs.TabIndex = 3;
            this.tabs.TabStop = false;
            // 
            // tpStatus
            // 
            this.tpStatus.Controls.Add(this.button16);
            this.tpStatus.Controls.Add(this.button17);
            this.tpStatus.Controls.Add(this.button15);
            this.tpStatus.Controls.Add(this.button14);
            this.tpStatus.Controls.Add(this.button12);
            this.tpStatus.Controls.Add(this.button13);
            this.tpStatus.Controls.Add(this.button5);
            this.tpStatus.Controls.Add(this.button4);
            this.tpStatus.Controls.Add(this.button1);
            this.tpStatus.Location = new System.Drawing.Point(4, 24);
            this.tpStatus.Name = "tpStatus";
            this.tpStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatus.Size = new System.Drawing.Size(813, 260);
            this.tpStatus.TabIndex = 0;
            this.tpStatus.Text = "Status";
            this.tpStatus.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(429, 164);
            this.button16.Name = "button16";
            this.button16.Padding = new System.Windows.Forms.Padding(10);
            this.button16.Size = new System.Drawing.Size(45, 45);
            this.button16.TabIndex = 31;
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(480, 164);
            this.button17.Name = "button17";
            this.button17.Padding = new System.Windows.Forms.Padding(10);
            this.button17.Size = new System.Drawing.Size(45, 45);
            this.button17.TabIndex = 30;
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(731, 164);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(10);
            this.button15.Size = new System.Drawing.Size(45, 45);
            this.button15.TabIndex = 29;
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(578, 164);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(10);
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 28;
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(680, 164);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(10);
            this.button12.Size = new System.Drawing.Size(45, 45);
            this.button12.TabIndex = 27;
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(629, 164);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(10);
            this.button13.Size = new System.Drawing.Size(45, 45);
            this.button13.TabIndex = 26;
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(117, 164);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10);
            this.button5.Size = new System.Drawing.Size(108, 45);
            this.button5.TabIndex = 19;
            this.button5.Text = "Cancel";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(23, 164);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(88, 45);
            this.button4.TabIndex = 18;
            this.button4.Text = "OK";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Location = new System.Drawing.Point(4, 24);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedule.Size = new System.Drawing.Size(813, 260);
            this.tpSchedule.TabIndex = 1;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // tpEditTask
            // 
            this.tpEditTask.Location = new System.Drawing.Point(4, 24);
            this.tpEditTask.Name = "tpEditTask";
            this.tpEditTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditTask.Size = new System.Drawing.Size(813, 260);
            this.tpEditTask.TabIndex = 2;
            this.tpEditTask.Text = "Edit task";
            this.tpEditTask.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(813, 260);
            this.tpSettings.TabIndex = 3;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tpSync
            // 
            this.tpSync.Location = new System.Drawing.Point(4, 24);
            this.tpSync.Name = "tpSync";
            this.tpSync.Padding = new System.Windows.Forms.Padding(3);
            this.tpSync.Size = new System.Drawing.Size(813, 260);
            this.tpSync.TabIndex = 4;
            this.tpSync.Text = "Sync";
            this.tpSync.UseVisualStyleBackColor = true;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.label4);
            this.tpLogin.Controls.Add(this.txtLogInPassword);
            this.tpLogin.Controls.Add(this.label3);
            this.tpLogin.Controls.Add(this.txtLogInEmail);
            this.tpLogin.Controls.Add(this.label2);
            this.tpLogin.Location = new System.Drawing.Point(4, 24);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(813, 260);
            this.tpLogin.TabIndex = 5;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label4.Location = new System.Drawing.Point(378, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Log in";
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogInPassword.Location = new System.Drawing.Point(320, 132);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.Size = new System.Drawing.Size(222, 23);
            this.txtLogInPassword.TabIndex = 3;
            this.txtLogInPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(244, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtLogInEmail
            // 
            this.txtLogInEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogInEmail.Location = new System.Drawing.Point(320, 103);
            this.txtLogInEmail.Name = "txtLogInEmail";
            this.txtLogInEmail.Size = new System.Drawing.Size(222, 23);
            this.txtLogInEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(244, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // tpRegisterNewAccount
            // 
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountName);
            this.tpRegisterNewAccount.Controls.Add(this.label9);
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountConfirmPassword);
            this.tpRegisterNewAccount.Controls.Add(this.label8);
            this.tpRegisterNewAccount.Controls.Add(this.label5);
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountPassword);
            this.tpRegisterNewAccount.Controls.Add(this.label6);
            this.tpRegisterNewAccount.Controls.Add(this.txtAccountEmail);
            this.tpRegisterNewAccount.Controls.Add(this.label7);
            this.tpRegisterNewAccount.Location = new System.Drawing.Point(4, 24);
            this.tpRegisterNewAccount.Name = "tpRegisterNewAccount";
            this.tpRegisterNewAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegisterNewAccount.Size = new System.Drawing.Size(813, 260);
            this.tpRegisterNewAccount.TabIndex = 6;
            this.tpRegisterNewAccount.Text = "Register";
            this.tpRegisterNewAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountName.Location = new System.Drawing.Point(355, 100);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(209, 23);
            this.txtAccountName.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(227, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name:";
            // 
            // txtAccountConfirmPassword
            // 
            this.txtAccountConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountConfirmPassword.Location = new System.Drawing.Point(355, 187);
            this.txtAccountConfirmPassword.Name = "txtAccountConfirmPassword";
            this.txtAccountConfirmPassword.Size = new System.Drawing.Size(209, 23);
            this.txtAccountConfirmPassword.TabIndex = 11;
            this.txtAccountConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(227, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Re-type password:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label5.Location = new System.Drawing.Point(35, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(742, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Register new account";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountPassword.Location = new System.Drawing.Point(355, 158);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(209, 23);
            this.txtAccountPassword.TabIndex = 8;
            this.txtAccountPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(227, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // txtAccountEmail
            // 
            this.txtAccountEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountEmail.Location = new System.Drawing.Point(355, 129);
            this.txtAccountEmail.Name = "txtAccountEmail";
            this.txtAccountEmail.Size = new System.Drawing.Size(209, 23);
            this.txtAccountEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(227, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email:";
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.lblAccountName);
            this.tpAccount.Location = new System.Drawing.Point(4, 24);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(813, 260);
            this.tpAccount.TabIndex = 7;
            this.tpAccount.Text = "Account";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(93, 105);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(628, 37);
            this.lblAccountName.TabIndex = 5;
            this.lblAccountName.Text = "Welcome #";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabsFun
            // 
            this.tabsFun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsFun.Controls.Add(this.tpFunStatus);
            this.tabsFun.Controls.Add(this.tpFunSchedule);
            this.tabsFun.Controls.Add(this.tpFunScheduleNewTask);
            this.tabsFun.Controls.Add(this.tpFunScheduleEditTask);
            this.tabsFun.Controls.Add(this.tpFunSettings);
            this.tabsFun.Controls.Add(this.tpFunSettingsSync);
            this.tabsFun.Controls.Add(this.tpFunLogin);
            this.tabsFun.Controls.Add(this.tpFunLoginNewAccount);
            this.tabsFun.Controls.Add(this.tpFunLogout);
            this.tabsFun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsFun.Location = new System.Drawing.Point(375, 8);
            this.tabsFun.Name = "tabsFun";
            this.tabsFun.SelectedIndex = 0;
            this.tabsFun.Size = new System.Drawing.Size(494, 83);
            this.tabsFun.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabsFun.TabIndex = 32;
            this.tabsFun.TabStop = false;
            // 
            // tpFunStatus
            // 
            this.tpFunStatus.Controls.Add(this.btnAbout);
            this.tpFunStatus.Controls.Add(this.btnMinimizeToSystemTray);
            this.tpFunStatus.Location = new System.Drawing.Point(4, 24);
            this.tpFunStatus.Name = "tpFunStatus";
            this.tpFunStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tpFunStatus.Size = new System.Drawing.Size(486, 55);
            this.tpFunStatus.TabIndex = 0;
            this.tpFunStatus.Text = "tpFunStatus";
            this.tpFunStatus.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(435, 11);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10);
            this.btnAbout.Size = new System.Drawing.Size(45, 45);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMinimizeToSystemTray
            // 
            this.btnMinimizeToSystemTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeToSystemTray.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeToSystemTray.Image")));
            this.btnMinimizeToSystemTray.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizeToSystemTray.Location = new System.Drawing.Point(226, 11);
            this.btnMinimizeToSystemTray.Name = "btnMinimizeToSystemTray";
            this.btnMinimizeToSystemTray.Padding = new System.Windows.Forms.Padding(10);
            this.btnMinimizeToSystemTray.Size = new System.Drawing.Size(203, 45);
            this.btnMinimizeToSystemTray.TabIndex = 4;
            this.btnMinimizeToSystemTray.Text = "Minimize to system tray";
            this.btnMinimizeToSystemTray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizeToSystemTray.UseVisualStyleBackColor = true;
            this.btnMinimizeToSystemTray.Click += new System.EventHandler(this.btnMinimizeToSystemTray_Click);
            // 
            // tpFunSchedule
            // 
            this.tpFunSchedule.Controls.Add(this.button8);
            this.tpFunSchedule.Controls.Add(this.button6);
            this.tpFunSchedule.Controls.Add(this.button7);
            this.tpFunSchedule.Location = new System.Drawing.Point(4, 24);
            this.tpFunSchedule.Name = "tpFunSchedule";
            this.tpFunSchedule.Size = new System.Drawing.Size(486, 55);
            this.tpFunSchedule.TabIndex = 2;
            this.tpFunSchedule.Text = "tpFunSchedule";
            this.tpFunSchedule.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(374, 11);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10);
            this.button8.Size = new System.Drawing.Size(106, 45);
            this.button8.TabIndex = 22;
            this.button8.Text = "Month";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(153, 11);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10);
            this.button6.Size = new System.Drawing.Size(110, 45);
            this.button6.TabIndex = 20;
            this.button6.Text = "Normal";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(269, 11);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10);
            this.button7.Size = new System.Drawing.Size(99, 45);
            this.button7.TabIndex = 21;
            this.button7.Text = "Week";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // tpFunScheduleNewTask
            // 
            this.tpFunScheduleNewTask.Location = new System.Drawing.Point(4, 24);
            this.tpFunScheduleNewTask.Name = "tpFunScheduleNewTask";
            this.tpFunScheduleNewTask.Size = new System.Drawing.Size(486, 55);
            this.tpFunScheduleNewTask.TabIndex = 6;
            this.tpFunScheduleNewTask.Text = "tpFunScheduleNewTask";
            this.tpFunScheduleNewTask.UseVisualStyleBackColor = true;
            // 
            // tpFunScheduleEditTask
            // 
            this.tpFunScheduleEditTask.Location = new System.Drawing.Point(4, 24);
            this.tpFunScheduleEditTask.Name = "tpFunScheduleEditTask";
            this.tpFunScheduleEditTask.Size = new System.Drawing.Size(486, 55);
            this.tpFunScheduleEditTask.TabIndex = 7;
            this.tpFunScheduleEditTask.Text = "tpFunScheduleEditTask";
            this.tpFunScheduleEditTask.UseVisualStyleBackColor = true;
            // 
            // tpFunSettings
            // 
            this.tpFunSettings.Controls.Add(this.btnSettingsOK);
            this.tpFunSettings.Location = new System.Drawing.Point(4, 24);
            this.tpFunSettings.Name = "tpFunSettings";
            this.tpFunSettings.Size = new System.Drawing.Size(486, 55);
            this.tpFunSettings.TabIndex = 3;
            this.tpFunSettings.Text = "tpFunSettings";
            this.tpFunSettings.UseVisualStyleBackColor = true;
            // 
            // btnSettingsOK
            // 
            this.btnSettingsOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsOK.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsOK.Image")));
            this.btnSettingsOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsOK.Location = new System.Drawing.Point(392, 11);
            this.btnSettingsOK.Name = "btnSettingsOK";
            this.btnSettingsOK.Padding = new System.Windows.Forms.Padding(10);
            this.btnSettingsOK.Size = new System.Drawing.Size(88, 45);
            this.btnSettingsOK.TabIndex = 20;
            this.btnSettingsOK.Text = "OK";
            this.btnSettingsOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettingsOK.UseVisualStyleBackColor = true;
            // 
            // tpFunSettingsSync
            // 
            this.tpFunSettingsSync.Controls.Add(this.btnSyncCancel);
            this.tpFunSettingsSync.Controls.Add(this.btnSync);
            this.tpFunSettingsSync.Location = new System.Drawing.Point(4, 24);
            this.tpFunSettingsSync.Name = "tpFunSettingsSync";
            this.tpFunSettingsSync.Size = new System.Drawing.Size(486, 55);
            this.tpFunSettingsSync.TabIndex = 4;
            this.tpFunSettingsSync.Text = "tpFunSettingsSync";
            this.tpFunSettingsSync.UseVisualStyleBackColor = true;
            // 
            // btnSyncCancel
            // 
            this.btnSyncCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSyncCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnSyncCancel.Image")));
            this.btnSyncCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyncCancel.Location = new System.Drawing.Point(372, 11);
            this.btnSyncCancel.Name = "btnSyncCancel";
            this.btnSyncCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnSyncCancel.Size = new System.Drawing.Size(108, 45);
            this.btnSyncCancel.TabIndex = 24;
            this.btnSyncCancel.Text = "Cancel";
            this.btnSyncCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSyncCancel.UseVisualStyleBackColor = true;
            this.btnSyncCancel.Click += new System.EventHandler(this.btnSyncCancel_Click);
            // 
            // btnSync
            // 
            this.btnSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(272, 11);
            this.btnSync.Name = "btnSync";
            this.btnSync.Padding = new System.Windows.Forms.Padding(10);
            this.btnSync.Size = new System.Drawing.Size(94, 45);
            this.btnSync.TabIndex = 23;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // tpFunLogin
            // 
            this.tpFunLogin.Controls.Add(this.btnNewAccount);
            this.tpFunLogin.Controls.Add(this.btnLogIn);
            this.tpFunLogin.Location = new System.Drawing.Point(4, 24);
            this.tpFunLogin.Name = "tpFunLogin";
            this.tpFunLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpFunLogin.Size = new System.Drawing.Size(486, 55);
            this.tpFunLogin.TabIndex = 1;
            this.tpFunLogin.Text = "tpFunLogin";
            this.tpFunLogin.UseVisualStyleBackColor = true;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAccount.Image")));
            this.btnNewAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAccount.Location = new System.Drawing.Point(233, 11);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Padding = new System.Windows.Forms.Padding(10);
            this.btnNewAccount.Size = new System.Drawing.Size(140, 45);
            this.btnNewAccount.TabIndex = 27;
            this.btnNewAccount.Text = "New account";
            this.btnNewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.Location = new System.Drawing.Point(379, 11);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogIn.Size = new System.Drawing.Size(101, 45);
            this.btnLogIn.TabIndex = 26;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tpFunLoginNewAccount
            // 
            this.tpFunLoginNewAccount.Controls.Add(this.btnAccountCancel);
            this.tpFunLoginNewAccount.Controls.Add(this.btnAccountOK);
            this.tpFunLoginNewAccount.Location = new System.Drawing.Point(4, 24);
            this.tpFunLoginNewAccount.Name = "tpFunLoginNewAccount";
            this.tpFunLoginNewAccount.Size = new System.Drawing.Size(486, 55);
            this.tpFunLoginNewAccount.TabIndex = 5;
            this.tpFunLoginNewAccount.Text = "tpFunLoginNewAccount";
            this.tpFunLoginNewAccount.UseVisualStyleBackColor = true;
            // 
            // btnAccountCancel
            // 
            this.btnAccountCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountCancel.Image")));
            this.btnAccountCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountCancel.Location = new System.Drawing.Point(372, 11);
            this.btnAccountCancel.Name = "btnAccountCancel";
            this.btnAccountCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btnAccountCancel.Size = new System.Drawing.Size(108, 45);
            this.btnAccountCancel.TabIndex = 21;
            this.btnAccountCancel.Text = "Cancel";
            this.btnAccountCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountCancel.UseVisualStyleBackColor = true;
            this.btnAccountCancel.Click += new System.EventHandler(this.btnAccountCancel_Click);
            // 
            // btnAccountOK
            // 
            this.btnAccountOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountOK.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountOK.Image")));
            this.btnAccountOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountOK.Location = new System.Drawing.Point(278, 11);
            this.btnAccountOK.Name = "btnAccountOK";
            this.btnAccountOK.Padding = new System.Windows.Forms.Padding(10);
            this.btnAccountOK.Size = new System.Drawing.Size(88, 45);
            this.btnAccountOK.TabIndex = 20;
            this.btnAccountOK.Text = "OK";
            this.btnAccountOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccountOK.UseVisualStyleBackColor = true;
            this.btnAccountOK.Click += new System.EventHandler(this.btnAccountOK_Click);
            // 
            // tpFunLogout
            // 
            this.tpFunLogout.Controls.Add(this.btnLogOut);
            this.tpFunLogout.Location = new System.Drawing.Point(4, 24);
            this.tpFunLogout.Name = "tpFunLogout";
            this.tpFunLogout.Size = new System.Drawing.Size(486, 55);
            this.tpFunLogout.TabIndex = 8;
            this.tpFunLogout.Text = "tpFunLogout";
            this.tpFunLogout.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(370, 11);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogOut.Size = new System.Drawing.Size(110, 45);
            this.btnLogOut.TabIndex = 21;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(189)))), ((int)(((byte)(239)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(903, 486);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.panMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 510);
            this.Name = "frmMain";
            this.Text = "To do tasks";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panControl.ResumeLayout(false);
            this.panControl.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tpStatus.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.tpRegisterNewAccount.ResumeLayout(false);
            this.tpRegisterNewAccount.PerformLayout();
            this.tpAccount.ResumeLayout(false);
            this.tabsFun.ResumeLayout(false);
            this.tpFunStatus.ResumeLayout(false);
            this.tpFunSchedule.ResumeLayout(false);
            this.tpFunSettings.ResumeLayout(false);
            this.tpFunSettingsSync.ResumeLayout(false);
            this.tpFunLogin.ResumeLayout(false);
            this.tpFunLoginNewAccount.ResumeLayout(false);
            this.tpFunLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabTabStatus;
        private System.Windows.Forms.RadioButton radTabLogin;
        private System.Windows.Forms.RadioButton radTabSettings;
        private System.Windows.Forms.RadioButton radTabSchedule;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timSys;
        private TabPagesControl tabs;
        private System.Windows.Forms.TabPage tpStatus;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpEditTask;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpSync;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabPage tpRegisterNewAccount;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.TabPage tpAccount;
        private TabPagesControl tabsFun;
        private System.Windows.Forms.TabPage tpFunStatus;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMinimizeToSystemTray;
        private System.Windows.Forms.TabPage tpFunLogin;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TabPage tpFunSchedule;
        private System.Windows.Forms.TabPage tpFunScheduleNewTask;
        private System.Windows.Forms.TabPage tpFunScheduleEditTask;
        private System.Windows.Forms.TabPage tpFunSettings;
        private System.Windows.Forms.TabPage tpFunSettingsSync;
        private System.Windows.Forms.TabPage tpFunLoginNewAccount;
        private System.Windows.Forms.Button btnAccountOK;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogInEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TabPage tpFunLogout;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccountEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAccountConfirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSettingsOK;
        private System.Windows.Forms.Button btnSyncCancel;
        private System.Windows.Forms.Button btnAccountCancel;



    }
}

