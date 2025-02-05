namespace MetaCare
{
    partial class Form1
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
            this.numDelays = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numMaxThread = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadTKQC = new System.Windows.Forms.Button();
            this.cbbTypeLoadTKQC = new System.Windows.Forms.ComboBox();
            this.btnLoadBM = new System.Windows.Forms.Button();
            this.cbbBusinessManager = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ctmnTKQC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dánTKQCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTKQCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPTTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnVàThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấtLượngTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountRegionAndTimezone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountCampaign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGHCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdAccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.ctmnTKQC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numDelays);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.numMaxThread);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tabControl3);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 522);
            this.panel1.TabIndex = 0;
            // 
            // numDelays
            // 
            this.numDelays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numDelays.Location = new System.Drawing.Point(1157, 477);
            this.numDelays.Name = "numDelays";
            this.numDelays.Size = new System.Drawing.Size(55, 22);
            this.numDelays.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1092, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delays:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(1367, 453);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStop.Size = new System.Drawing.Size(95, 40);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(1251, 453);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // numMaxThread
            // 
            this.numMaxThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxThread.Location = new System.Drawing.Point(1157, 449);
            this.numMaxThread.Name = "numMaxThread";
            this.numMaxThread.Size = new System.Drawing.Size(55, 22);
            this.numMaxThread.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1092, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số luồng:";
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Location = new System.Drawing.Point(1088, 12);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(386, 420);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(378, 393);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "SetCamp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 362);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campaign";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hiển thị";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1056, 489);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoadTKQC);
            this.tabPage2.Controls.Add(this.cbbTypeLoadTKQC);
            this.tabPage2.Controls.Add(this.btnLoadBM);
            this.tabPage2.Controls.Add(this.cbbBusinessManager);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 462);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "TKQC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadTKQC
            // 
            this.btnLoadTKQC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTKQC.Location = new System.Drawing.Point(6, 4);
            this.btnLoadTKQC.Name = "btnLoadTKQC";
            this.btnLoadTKQC.Size = new System.Drawing.Size(119, 23);
            this.btnLoadTKQC.TabIndex = 7;
            this.btnLoadTKQC.Text = "Load TKQC";
            this.btnLoadTKQC.UseVisualStyleBackColor = true;
            this.btnLoadTKQC.Click += new System.EventHandler(this.btnLoadTKQC_Click);
            // 
            // cbbTypeLoadTKQC
            // 
            this.cbbTypeLoadTKQC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTypeLoadTKQC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeLoadTKQC.FormattingEnabled = true;
            this.cbbTypeLoadTKQC.Items.AddRange(new object[] {
            "Tất cả",
            "TK tạo từ BM",
            "TK được share vào BM"});
            this.cbbTypeLoadTKQC.Location = new System.Drawing.Point(132, 6);
            this.cbbTypeLoadTKQC.Name = "cbbTypeLoadTKQC";
            this.cbbTypeLoadTKQC.Size = new System.Drawing.Size(216, 22);
            this.cbbTypeLoadTKQC.TabIndex = 6;
            // 
            // btnLoadBM
            // 
            this.btnLoadBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadBM.Location = new System.Drawing.Point(745, 3);
            this.btnLoadBM.Name = "btnLoadBM";
            this.btnLoadBM.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBM.TabIndex = 5;
            this.btnLoadBM.Text = "Load BM";
            this.btnLoadBM.UseVisualStyleBackColor = true;
            // 
            // cbbBusinessManager
            // 
            this.cbbBusinessManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBusinessManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBusinessManager.FormattingEnabled = true;
            this.cbbBusinessManager.Location = new System.Drawing.Point(826, 5);
            this.cbbBusinessManager.Name = "cbbBusinessManager";
            this.cbbBusinessManager.Size = new System.Drawing.Size(216, 22);
            this.cbbBusinessManager.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cAdAccountId,
            this.cAdAccountName,
            this.cAdAccountCurrency,
            this.cAdAccountLimit,
            this.cAdAccountThreshold,
            this.cAdAccountBalance,
            this.cAdAccountTotalAmount,
            this.cPayment,
            this.cAdAccountRegionAndTimezone,
            this.cAdAccountCampaign,
            this.cGHCT,
            this.cAdAccountStatus,
            this.cProcess});
            this.dgv.Location = new System.Drawing.Point(6, 34);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(1036, 421);
            this.dgv.TabIndex = 0;
            // 
            // ctmnTKQC
            // 
            this.ctmnTKQC.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmnTKQC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dánTKQCToolStripMenuItem,
            this.checkTKQCToolStripMenuItem,
            this.checkPTTTToolStripMenuItem,
            this.mởChromeToolStripMenuItem,
            this.hóaĐơnVàThanhToánToolStripMenuItem,
            this.chấtLượngTàiKhoảnToolStripMenuItem});
            this.ctmnTKQC.Name = "contextMenuStrip1";
            this.ctmnTKQC.Size = new System.Drawing.Size(202, 158);
            // 
            // dánTKQCToolStripMenuItem
            // 
            this.dánTKQCToolStripMenuItem.Name = "dánTKQCToolStripMenuItem";
            this.dánTKQCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dánTKQCToolStripMenuItem.Text = "Dán TKQC";
            this.dánTKQCToolStripMenuItem.Click += new System.EventHandler(this.dánTKQCToolStripMenuItem_Click);
            // 
            // checkTKQCToolStripMenuItem
            // 
            this.checkTKQCToolStripMenuItem.Name = "checkTKQCToolStripMenuItem";
            this.checkTKQCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.checkTKQCToolStripMenuItem.Text = "Check TKQC";
            this.checkTKQCToolStripMenuItem.Click += new System.EventHandler(this.checkTKQCToolStripMenuItem_Click);
            // 
            // checkPTTTToolStripMenuItem
            // 
            this.checkPTTTToolStripMenuItem.Name = "checkPTTTToolStripMenuItem";
            this.checkPTTTToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.checkPTTTToolStripMenuItem.Text = "Check PTTT";
            this.checkPTTTToolStripMenuItem.Click += new System.EventHandler(this.checkPTTTToolStripMenuItem_Click);
            // 
            // mởChromeToolStripMenuItem
            // 
            this.mởChromeToolStripMenuItem.Name = "mởChromeToolStripMenuItem";
            this.mởChromeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mởChromeToolStripMenuItem.Text = "Trình quản lý quảng cáo";
            // 
            // hóaĐơnVàThanhToánToolStripMenuItem
            // 
            this.hóaĐơnVàThanhToánToolStripMenuItem.Name = "hóaĐơnVàThanhToánToolStripMenuItem";
            this.hóaĐơnVàThanhToánToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.hóaĐơnVàThanhToánToolStripMenuItem.Text = "Hóa đơn và thanh toán";
            // 
            // chấtLượngTàiKhoảnToolStripMenuItem
            // 
            this.chấtLượngTàiKhoảnToolStripMenuItem.Name = "chấtLượngTàiKhoảnToolStripMenuItem";
            this.chấtLượngTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.chấtLượngTàiKhoảnToolStripMenuItem.Text = "Chất lượng tài khoản";
            // 
            // cStt
            // 
            this.cStt.FillWeight = 30F;
            this.cStt.HeaderText = "Stt";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            // 
            // cAdAccountId
            // 
            this.cAdAccountId.HeaderText = "ID";
            this.cAdAccountId.MinimumWidth = 6;
            this.cAdAccountId.Name = "cAdAccountId";
            // 
            // cAdAccountName
            // 
            this.cAdAccountName.HeaderText = "Name";
            this.cAdAccountName.MinimumWidth = 6;
            this.cAdAccountName.Name = "cAdAccountName";
            // 
            // cAdAccountCurrency
            // 
            this.cAdAccountCurrency.FillWeight = 30F;
            this.cAdAccountCurrency.HeaderText = "Tiền tệ";
            this.cAdAccountCurrency.MinimumWidth = 6;
            this.cAdAccountCurrency.Name = "cAdAccountCurrency";
            // 
            // cAdAccountLimit
            // 
            this.cAdAccountLimit.FillWeight = 30F;
            this.cAdAccountLimit.HeaderText = "Limit";
            this.cAdAccountLimit.MinimumWidth = 6;
            this.cAdAccountLimit.Name = "cAdAccountLimit";
            // 
            // cAdAccountThreshold
            // 
            this.cAdAccountThreshold.FillWeight = 30F;
            this.cAdAccountThreshold.HeaderText = "Ngưỡng";
            this.cAdAccountThreshold.MinimumWidth = 6;
            this.cAdAccountThreshold.Name = "cAdAccountThreshold";
            // 
            // cAdAccountBalance
            // 
            this.cAdAccountBalance.FillWeight = 30F;
            this.cAdAccountBalance.HeaderText = "Nợ";
            this.cAdAccountBalance.MinimumWidth = 6;
            this.cAdAccountBalance.Name = "cAdAccountBalance";
            // 
            // cAdAccountTotalAmount
            // 
            this.cAdAccountTotalAmount.FillWeight = 30F;
            this.cAdAccountTotalAmount.HeaderText = "Tổng chi";
            this.cAdAccountTotalAmount.MinimumWidth = 6;
            this.cAdAccountTotalAmount.Name = "cAdAccountTotalAmount";
            // 
            // cPayment
            // 
            this.cPayment.FillWeight = 45F;
            this.cPayment.HeaderText = "Payment";
            this.cPayment.MinimumWidth = 6;
            this.cPayment.Name = "cPayment";
            // 
            // cAdAccountRegionAndTimezone
            // 
            this.cAdAccountRegionAndTimezone.FillWeight = 65F;
            this.cAdAccountRegionAndTimezone.HeaderText = "QG/Múi giờ";
            this.cAdAccountRegionAndTimezone.MinimumWidth = 6;
            this.cAdAccountRegionAndTimezone.Name = "cAdAccountRegionAndTimezone";
            // 
            // cAdAccountCampaign
            // 
            this.cAdAccountCampaign.FillWeight = 40F;
            this.cAdAccountCampaign.HeaderText = "Campaign";
            this.cAdAccountCampaign.MinimumWidth = 6;
            this.cAdAccountCampaign.Name = "cAdAccountCampaign";
            // 
            // cGHCT
            // 
            this.cGHCT.FillWeight = 35F;
            this.cGHCT.HeaderText = "GHCT";
            this.cGHCT.Name = "cGHCT";
            // 
            // cAdAccountStatus
            // 
            this.cAdAccountStatus.FillWeight = 40F;
            this.cAdAccountStatus.HeaderText = "Status";
            this.cAdAccountStatus.MinimumWidth = 6;
            this.cAdAccountStatus.Name = "cAdAccountStatus";
            // 
            // cProcess
            // 
            this.cProcess.HeaderText = "Process";
            this.cProcess.MinimumWidth = 6;
            this.cProcess.Name = "cProcess";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 522);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ctmnTKQC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbbBusinessManager;
        private System.Windows.Forms.Button btnLoadBM;
        private System.Windows.Forms.ContextMenuStrip ctmnTKQC;
        private System.Windows.Forms.ToolStripMenuItem dánTKQCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTKQCToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numMaxThread;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numDelays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem mởChromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPTTTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnVàThanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấtLượngTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadTKQC;
        private System.Windows.Forms.ComboBox cbbTypeLoadTKQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountRegionAndTimezone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountCampaign;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGHCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProcess;
    }
}

