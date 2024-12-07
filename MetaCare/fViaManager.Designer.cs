namespace MetaCare
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnBôiĐenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bỏChọnTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieVàTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýQuảngCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numDelays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMaxThread = new System.Windows.Forms.NumericUpDown();
            this.cbbTypeLogin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 521);
            this.panel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Location = new System.Drawing.Point(12, 95);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1301, 414);
            this.dgv.TabIndex = 1;
            // 
            // cChose
            // 
            this.cChose.FillWeight = 30F;
            this.cChose.HeaderText = "Chọn";
            this.cChose.Name = "cChose";
            this.cChose.ReadOnly = true;
            // 
            // cStt
            // 
            this.cStt.FillWeight = 30F;
            this.cStt.HeaderText = "Stt";
            this.cStt.Name = "cStt";
            this.cStt.ReadOnly = true;
            // 
            // cUid
            // 
            this.cUid.FillWeight = 75F;
            this.cUid.HeaderText = "Uid";
            this.cUid.Name = "cUid";
            this.cUid.ReadOnly = true;
            // 
            // cPassword
            // 
            this.cPassword.HeaderText = "Password";
            this.cPassword.Name = "cPassword";
            this.cPassword.ReadOnly = true;
            // 
            // cKey2Fa
            // 
            this.cKey2Fa.FillWeight = 65F;
            this.cKey2Fa.HeaderText = "Key 2FA";
            this.cKey2Fa.Name = "cKey2Fa";
            this.cKey2Fa.ReadOnly = true;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            // 
            // cPasswordMail
            // 
            this.cPasswordMail.HeaderText = "Password Mail";
            this.cPasswordMail.Name = "cPasswordMail";
            this.cPasswordMail.ReadOnly = true;
            // 
            // cCookies
            // 
            this.cCookies.HeaderText = "Cookies";
            this.cCookies.Name = "cCookies";
            this.cCookies.ReadOnly = true;
            // 
            // cToken
            // 
            this.cToken.HeaderText = "Token";
            this.cToken.Name = "cToken";
            this.cToken.ReadOnly = true;
            // 
            // cStatus
            // 
            this.cStatus.FillWeight = 125F;
            this.cStatus.HeaderText = "Process";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnBôiĐenToolStripMenuItem,
            this.chọnTấtCảToolStripMenuItem,
            this.bỏChọnTấtCảToolStripMenuItem,
            this.dánTàiKhoảnToolStripMenuItem,
            this.nhậpTàiKhoảnToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.quảnLýQuảngCáoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 158);
            // 
            // chọnBôiĐenToolStripMenuItem
            // 
            this.chọnBôiĐenToolStripMenuItem.Name = "chọnBôiĐenToolStripMenuItem";
            this.chọnBôiĐenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.chọnBôiĐenToolStripMenuItem.Text = "Chọn bôi đen";
            this.chọnBôiĐenToolStripMenuItem.Click += new System.EventHandler(this.chọnBôiĐenToolStripMenuItem_Click);
            // 
            // chọnTấtCảToolStripMenuItem
            // 
            this.chọnTấtCảToolStripMenuItem.Name = "chọnTấtCảToolStripMenuItem";
            this.chọnTấtCảToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.chọnTấtCảToolStripMenuItem.Text = "Chọn tất cả";
            this.chọnTấtCảToolStripMenuItem.Click += new System.EventHandler(this.chọnTấtCảToolStripMenuItem_Click);
            // 
            // bỏChọnTấtCảToolStripMenuItem
            // 
            this.bỏChọnTấtCảToolStripMenuItem.Name = "bỏChọnTấtCảToolStripMenuItem";
            this.bỏChọnTấtCảToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bỏChọnTấtCảToolStripMenuItem.Text = "Bỏ chọn tất cả";
            this.bỏChọnTấtCảToolStripMenuItem.Click += new System.EventHandler(this.bỏChọnTấtCảToolStripMenuItem_Click);
            // 
            // dánTàiKhoảnToolStripMenuItem
            // 
            this.dánTàiKhoảnToolStripMenuItem.Name = "dánTàiKhoảnToolStripMenuItem";
            this.dánTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dánTàiKhoảnToolStripMenuItem.Text = "Dán tài khoản";
            this.dánTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.dánTàiKhoảnToolStripMenuItem_Click);
            // 
            // nhậpTàiKhoảnToolStripMenuItem
            // 
            this.nhậpTàiKhoảnToolStripMenuItem.Name = "nhậpTàiKhoảnToolStripMenuItem";
            this.nhậpTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nhậpTàiKhoảnToolStripMenuItem.Text = "Nhập tài khoản";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cookieVàTokenToolStripMenuItem});
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            // 
            // cookieVàTokenToolStripMenuItem
            // 
            this.cookieVàTokenToolStripMenuItem.Name = "cookieVàTokenToolStripMenuItem";
            this.cookieVàTokenToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cookieVàTokenToolStripMenuItem.Text = "Cookie và Token";
            this.cookieVàTokenToolStripMenuItem.Click += new System.EventHandler(this.cookieVàTokenToolStripMenuItem_Click);
            // 
            // quảnLýQuảngCáoToolStripMenuItem
            // 
            this.quảnLýQuảngCáoToolStripMenuItem.Name = "quảnLýQuảngCáoToolStripMenuItem";
            this.quảnLýQuảngCáoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.quảnLýQuảngCáoToolStripMenuItem.Text = "Quản lý quảng cáo";
            this.quảnLýQuảngCáoToolStripMenuItem.Click += new System.EventHandler(this.quảnLýQuảngCáoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numDelays);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numMaxThread);
            this.groupBox1.Controls.Add(this.cbbTypeLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1301, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delays:";
            // 
            // numDelays
            // 
            this.numDelays.Location = new System.Drawing.Point(77, 42);
            this.numDelays.Name = "numDelays";
            this.numDelays.Size = new System.Drawing.Size(62, 22);
            this.numDelays.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số luồng:";
            // 
            // numMaxThread
            // 
            this.numMaxThread.Location = new System.Drawing.Point(77, 15);
            this.numMaxThread.Name = "numMaxThread";
            this.numMaxThread.Size = new System.Drawing.Size(62, 22);
            this.numMaxThread.TabIndex = 2;
            // 
            // cbbTypeLogin
            // 
            this.cbbTypeLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeLogin.FormattingEnabled = true;
            this.cbbTypeLogin.Items.AddRange(new object[] {
            "Cookie",
            "Uid|Password"});
            this.cbbTypeLogin.Location = new System.Drawing.Point(205, 31);
            this.cbbTypeLogin.Name = "cbbTypeLogin";
            this.cbbTypeLogin.Size = new System.Drawing.Size(150, 22);
            this.cbbTypeLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại log:";
            // 
            // fViaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 521);
            this.Controls.Add(this.panel1);
            this.Name = "fViaManager";
            this.Text = "fViaManager";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
    }
}