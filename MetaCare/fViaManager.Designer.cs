﻿namespace MetaCare
{
    partial class fViaManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKey2Fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPasswordMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmnAcc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnBôiĐenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bỏChọnTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieVàTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýQuảngCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numLimitThreadUse = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDelays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMaxThread = new System.Windows.Forms.NumericUpDown();
            this.cbbTypeLogin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.ctmnAcc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitThreadUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1767, 721);
            this.panel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChose,
            this.cStt,
            this.cUid,
            this.cPassword,
            this.cKey2Fa,
            this.cEmail,
            this.cPasswordMail,
            this.cCookies,
            this.cToken,
            this.cStatus});
            this.dgv.ContextMenuStrip = this.ctmnAcc;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1721, 541);
            this.dgv.TabIndex = 1;
            // 
            // cChose
            // 
            this.cChose.FillWeight = 30F;
            this.cChose.HeaderText = "Chọn";
            this.cChose.MinimumWidth = 6;
            this.cChose.Name = "cChose";
            this.cChose.ReadOnly = true;
            // 
            // cStt
            // 
            this.cStt.FillWeight = 30F;
            this.cStt.HeaderText = "Stt";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            this.cStt.ReadOnly = true;
            // 
            // cUid
            // 
            this.cUid.FillWeight = 75F;
            this.cUid.HeaderText = "Uid";
            this.cUid.MinimumWidth = 6;
            this.cUid.Name = "cUid";
            this.cUid.ReadOnly = true;
            // 
            // cPassword
            // 
            this.cPassword.HeaderText = "Password";
            this.cPassword.MinimumWidth = 6;
            this.cPassword.Name = "cPassword";
            this.cPassword.ReadOnly = true;
            // 
            // cKey2Fa
            // 
            this.cKey2Fa.FillWeight = 65F;
            this.cKey2Fa.HeaderText = "Key 2FA";
            this.cKey2Fa.MinimumWidth = 6;
            this.cKey2Fa.Name = "cKey2Fa";
            this.cKey2Fa.ReadOnly = true;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 6;
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            // 
            // cPasswordMail
            // 
            this.cPasswordMail.HeaderText = "Password Mail";
            this.cPasswordMail.MinimumWidth = 6;
            this.cPasswordMail.Name = "cPasswordMail";
            this.cPasswordMail.ReadOnly = true;
            // 
            // cCookies
            // 
            this.cCookies.HeaderText = "Cookies";
            this.cCookies.MinimumWidth = 6;
            this.cCookies.Name = "cCookies";
            this.cCookies.ReadOnly = true;
            // 
            // cToken
            // 
            this.cToken.HeaderText = "Token";
            this.cToken.MinimumWidth = 6;
            this.cToken.Name = "cToken";
            this.cToken.ReadOnly = true;
            // 
            // cStatus
            // 
            this.cStatus.FillWeight = 125F;
            this.cStatus.HeaderText = "Process";
            this.cStatus.MinimumWidth = 6;
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            // 
            // ctmnAcc
            // 
            this.ctmnAcc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmnAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnBôiĐenToolStripMenuItem,
            this.chọnTấtCảToolStripMenuItem,
            this.bỏChọnTấtCảToolStripMenuItem,
            this.dánTàiKhoảnToolStripMenuItem,
            this.nhậpTàiKhoảnToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.quảnLýQuảngCáoToolStripMenuItem});
            this.ctmnAcc.Name = "contextMenuStrip1";
            this.ctmnAcc.Size = new System.Drawing.Size(203, 172);
            // 
            // chọnBôiĐenToolStripMenuItem
            // 
            this.chọnBôiĐenToolStripMenuItem.Name = "chọnBôiĐenToolStripMenuItem";
            this.chọnBôiĐenToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.chọnBôiĐenToolStripMenuItem.Text = "Chọn bôi đen";
            this.chọnBôiĐenToolStripMenuItem.Click += new System.EventHandler(this.chọnBôiĐenToolStripMenuItem_Click);
            // 
            // chọnTấtCảToolStripMenuItem
            // 
            this.chọnTấtCảToolStripMenuItem.Name = "chọnTấtCảToolStripMenuItem";
            this.chọnTấtCảToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.chọnTấtCảToolStripMenuItem.Text = "Chọn tất cả";
            this.chọnTấtCảToolStripMenuItem.Click += new System.EventHandler(this.chọnTấtCảToolStripMenuItem_Click);
            // 
            // bỏChọnTấtCảToolStripMenuItem
            // 
            this.bỏChọnTấtCảToolStripMenuItem.Name = "bỏChọnTấtCảToolStripMenuItem";
            this.bỏChọnTấtCảToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.bỏChọnTấtCảToolStripMenuItem.Text = "Bỏ chọn tất cả";
            this.bỏChọnTấtCảToolStripMenuItem.Click += new System.EventHandler(this.bỏChọnTấtCảToolStripMenuItem_Click);
            // 
            // dánTàiKhoảnToolStripMenuItem
            // 
            this.dánTàiKhoảnToolStripMenuItem.Name = "dánTàiKhoảnToolStripMenuItem";
            this.dánTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.dánTàiKhoảnToolStripMenuItem.Text = "Dán tài khoản";
            this.dánTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.dánTàiKhoảnToolStripMenuItem_Click);
            // 
            // nhậpTàiKhoảnToolStripMenuItem
            // 
            this.nhậpTàiKhoảnToolStripMenuItem.Name = "nhậpTàiKhoảnToolStripMenuItem";
            this.nhậpTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.nhậpTàiKhoảnToolStripMenuItem.Text = "Nhập tài khoản";
            this.nhậpTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.nhậpTàiKhoảnToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cookieVàTokenToolStripMenuItem});
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            // 
            // cookieVàTokenToolStripMenuItem
            // 
            this.cookieVàTokenToolStripMenuItem.Name = "cookieVàTokenToolStripMenuItem";
            this.cookieVàTokenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cookieVàTokenToolStripMenuItem.Text = "Cookie và Token";
            this.cookieVàTokenToolStripMenuItem.Click += new System.EventHandler(this.cookieVàTokenToolStripMenuItem_Click);
            // 
            // quảnLýQuảngCáoToolStripMenuItem
            // 
            this.quảnLýQuảngCáoToolStripMenuItem.Name = "quảnLýQuảngCáoToolStripMenuItem";
            this.quảnLýQuảngCáoToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.quảnLýQuảngCáoToolStripMenuItem.Text = "Quản lý quảng cáo";
            this.quảnLýQuảngCáoToolStripMenuItem.Click += new System.EventHandler(this.quảnLýQuảngCáoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.numLimitThreadUse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.cbbTypeProxy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numDelays);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numMaxThread);
            this.groupBox1.Controls.Add(this.cbbTypeLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1735, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(124, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 36);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 36);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // numLimitThreadUse
            // 
            this.numLimitThreadUse.Location = new System.Drawing.Point(888, 61);
            this.numLimitThreadUse.Margin = new System.Windows.Forms.Padding(4);
            this.numLimitThreadUse.Name = "numLimitThreadUse";
            this.numLimitThreadUse.Size = new System.Drawing.Size(55, 26);
            this.numLimitThreadUse.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(814, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP/ACC:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(814, 29);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 18);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Danh sách Proxy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbbTypeProxy
            // 
            this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeProxy.FormattingEnabled = true;
            this.cbbTypeProxy.Items.AddRange(new object[] {
            "None",
            "IP:PORT",
            "IP:PORT:USERNAME:PASSWORD"});
            this.cbbTypeProxy.Location = new System.Drawing.Point(510, 64);
            this.cbbTypeProxy.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeProxy.Name = "cbbTypeProxy";
            this.cbbTypeProxy.Size = new System.Drawing.Size(296, 26);
            this.cbbTypeProxy.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proxy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delays:";
            // 
            // numDelays
            // 
            this.numDelays.Location = new System.Drawing.Point(340, 57);
            this.numDelays.Margin = new System.Windows.Forms.Padding(4);
            this.numDelays.Name = "numDelays";
            this.numDelays.Size = new System.Drawing.Size(83, 26);
            this.numDelays.TabIndex = 4;
            this.numDelays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số luồng:";
            // 
            // numMaxThread
            // 
            this.numMaxThread.Location = new System.Drawing.Point(340, 19);
            this.numMaxThread.Margin = new System.Windows.Forms.Padding(4);
            this.numMaxThread.Name = "numMaxThread";
            this.numMaxThread.Size = new System.Drawing.Size(83, 26);
            this.numMaxThread.TabIndex = 2;
            this.numMaxThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbTypeLogin
            // 
            this.cbbTypeLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeLogin.FormattingEnabled = true;
            this.cbbTypeLogin.Items.AddRange(new object[] {
            "Cookie",
            "Uid|Password"});
            this.cbbTypeLogin.Location = new System.Drawing.Point(510, 25);
            this.cbbTypeLogin.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeLogin.Name = "cbbTypeLogin";
            this.cbbTypeLogin.Size = new System.Drawing.Size(296, 26);
            this.cbbTypeLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại log:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1735, 578);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1727, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hiển thị";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1727, 69);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chức năng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fViaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 721);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fViaManager";
            this.Text = "fViaManager";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ctmnAcc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitThreadUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTypeLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKey2Fa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPasswordMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCookies;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.ContextMenuStrip ctmnAcc;
        private System.Windows.Forms.ToolStripMenuItem chọnBôiĐenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnTấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýQuảngCáoToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDelays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMaxThread;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookieVàTokenToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbTypeProxy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLimitThreadUse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}