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
            this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.cAdAccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dánTKQCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTKQCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPTTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnVàThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấtLượngTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressLoad = new System.Windows.Forms.ProgressBar();
            this.ckbAddGroup = new System.Windows.Forms.CheckBox();
            this.ckbRemoveLimit = new System.Windows.Forms.CheckBox();
            this.ckbApproveHold = new System.Windows.Forms.CheckBox();
            this.ckbDeleteCredit = new System.Windows.Forms.CheckBox();
            this.ckbRemoveInBM = new System.Windows.Forms.CheckBox();
            this.ckbSetLimit = new System.Windows.Forms.CheckBox();
            this.tbLimitSet = new System.Windows.Forms.TextBox();
            this.btnLoadGroup = new System.Windows.Forms.Button();
            this.cbbGroups = new System.Windows.Forms.ComboBox();
            this.btnLoadUser = new System.Windows.Forms.Button();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbPublishCamp = new System.Windows.Forms.CheckBox();
            this.ckbPublishAdSet = new System.Windows.Forms.CheckBox();
            this.ckbPublishAd = new System.Windows.Forms.CheckBox();
            this.ckbDiscardDraft = new System.Windows.Forms.CheckBox();
            this.ckbDeleteAllCamp = new System.Windows.Forms.CheckBox();
            this.rtbTargetPE = new System.Windows.Forms.RichTextBox();
            this.btnLoadPE = new System.Windows.Forms.Button();
            this.ckbShareBM = new System.Windows.Forms.CheckBox();
            this.tbBusinessIdShare = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressLoad);
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
            this.panel1.Size = new System.Drawing.Size(1474, 657);
            this.panel1.TabIndex = 0;
            // 
            // numDelays
            // 
            this.numDelays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numDelays.Location = new System.Drawing.Point(1157, 612);
            this.numDelays.Name = "numDelays";
            this.numDelays.Size = new System.Drawing.Size(55, 22);
            this.numDelays.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1092, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delays:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(1367, 588);
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
            this.btnStart.Location = new System.Drawing.Point(1251, 588);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // numMaxThread
            // 
            this.numMaxThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxThread.Location = new System.Drawing.Point(1157, 584);
            this.numMaxThread.Name = "numMaxThread";
            this.numMaxThread.Size = new System.Drawing.Size(55, 22);
            this.numMaxThread.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1092, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số luồng:";
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Location = new System.Drawing.Point(1088, 12);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(386, 555);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(378, 528);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "SetCamp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLoadUser);
            this.groupBox2.Controls.Add(this.cbbUser);
            this.groupBox2.Controls.Add(this.btnLoadGroup);
            this.groupBox2.Controls.Add(this.tbLimitSet);
            this.groupBox2.Controls.Add(this.cbbGroups);
            this.groupBox2.Controls.Add(this.ckbSetLimit);
            this.groupBox2.Controls.Add(this.ckbRemoveInBM);
            this.groupBox2.Controls.Add(this.ckbDeleteCredit);
            this.groupBox2.Controls.Add(this.ckbApproveHold);
            this.groupBox2.Controls.Add(this.ckbRemoveLimit);
            this.groupBox2.Controls.Add(this.ckbAddGroup);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 225);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý tài khoản";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 628);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 601);
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
            this.tabControl2.Size = new System.Drawing.Size(1056, 595);
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
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 568);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "TKQC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadTKQC
            // 
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
            this.cbbTypeLoadTKQC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeLoadTKQC.FormattingEnabled = true;
            this.cbbTypeLoadTKQC.Items.AddRange(new object[] {
            "Tất cả",
            "TK tạo từ BM",
            "TK được share vào BM"});
            this.cbbTypeLoadTKQC.Location = new System.Drawing.Point(131, 6);
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
            this.cChose,
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
            this.cAdAccountStatus,
            this.cProcess});
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Location = new System.Drawing.Point(6, 34);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(1036, 528);
            this.dgv.TabIndex = 0;
            // 
            // cChose
            // 
            this.cChose.FillWeight = 30F;
            this.cChose.HeaderText = "Chose";
            this.cChose.Name = "cChose";
            // 
            // cStt
            // 
            this.cStt.FillWeight = 30F;
            this.cStt.HeaderText = "Stt";
            this.cStt.Name = "cStt";
            // 
            // cAdAccountId
            // 
            this.cAdAccountId.HeaderText = "ID";
            this.cAdAccountId.Name = "cAdAccountId";
            // 
            // cAdAccountName
            // 
            this.cAdAccountName.HeaderText = "Name";
            this.cAdAccountName.Name = "cAdAccountName";
            // 
            // cAdAccountCurrency
            // 
            this.cAdAccountCurrency.FillWeight = 30F;
            this.cAdAccountCurrency.HeaderText = "Tiền tệ";
            this.cAdAccountCurrency.Name = "cAdAccountCurrency";
            // 
            // cAdAccountLimit
            // 
            this.cAdAccountLimit.FillWeight = 30F;
            this.cAdAccountLimit.HeaderText = "Limit";
            this.cAdAccountLimit.Name = "cAdAccountLimit";
            // 
            // cAdAccountThreshold
            // 
            this.cAdAccountThreshold.FillWeight = 30F;
            this.cAdAccountThreshold.HeaderText = "Ngưỡng";
            this.cAdAccountThreshold.Name = "cAdAccountThreshold";
            // 
            // cAdAccountBalance
            // 
            this.cAdAccountBalance.FillWeight = 30F;
            this.cAdAccountBalance.HeaderText = "Nợ";
            this.cAdAccountBalance.Name = "cAdAccountBalance";
            // 
            // cAdAccountTotalAmount
            // 
            this.cAdAccountTotalAmount.FillWeight = 30F;
            this.cAdAccountTotalAmount.HeaderText = "Tổng chi";
            this.cAdAccountTotalAmount.Name = "cAdAccountTotalAmount";
            // 
            // cPayment
            // 
            this.cPayment.FillWeight = 45F;
            this.cPayment.HeaderText = "Payment";
            this.cPayment.Name = "cPayment";
            // 
            // cAdAccountRegionAndTimezone
            // 
            this.cAdAccountRegionAndTimezone.FillWeight = 65F;
            this.cAdAccountRegionAndTimezone.HeaderText = "QG/Múi giờ";
            this.cAdAccountRegionAndTimezone.Name = "cAdAccountRegionAndTimezone";
            // 
            // cAdAccountCampaign
            // 
            this.cAdAccountCampaign.FillWeight = 40F;
            this.cAdAccountCampaign.HeaderText = "Campaign";
            this.cAdAccountCampaign.Name = "cAdAccountCampaign";
            // 
            // cAdAccountStatus
            // 
            this.cAdAccountStatus.FillWeight = 40F;
            this.cAdAccountStatus.HeaderText = "Status";
            this.cAdAccountStatus.Name = "cAdAccountStatus";
            // 
            // cProcess
            // 
            this.cProcess.HeaderText = "Process";
            this.cProcess.Name = "cProcess";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dánTKQCToolStripMenuItem,
            this.checkTKQCToolStripMenuItem,
            this.checkPTTTToolStripMenuItem,
            this.mởChromeToolStripMenuItem,
            this.hóaĐơnVàThanhToánToolStripMenuItem,
            this.chấtLượngTàiKhoảnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 136);
            // 
            // dánTKQCToolStripMenuItem
            // 
            this.dánTKQCToolStripMenuItem.Name = "dánTKQCToolStripMenuItem";
            this.dánTKQCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dánTKQCToolStripMenuItem.Text = "Dán TKQC";
            // 
            // checkTKQCToolStripMenuItem
            // 
            this.checkTKQCToolStripMenuItem.Name = "checkTKQCToolStripMenuItem";
            this.checkTKQCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.checkTKQCToolStripMenuItem.Text = "Check TKQC";
            // 
            // checkPTTTToolStripMenuItem
            // 
            this.checkPTTTToolStripMenuItem.Name = "checkPTTTToolStripMenuItem";
            this.checkPTTTToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.checkPTTTToolStripMenuItem.Text = "Check PTTT";
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
            // progressLoad
            // 
            this.progressLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLoad.Location = new System.Drawing.Point(743, 630);
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.Size = new System.Drawing.Size(323, 23);
            this.progressLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressLoad.TabIndex = 9;
            // 
            // ckbAddGroup
            // 
            this.ckbAddGroup.AutoSize = true;
            this.ckbAddGroup.Location = new System.Drawing.Point(7, 22);
            this.ckbAddGroup.Name = "ckbAddGroup";
            this.ckbAddGroup.Size = new System.Drawing.Size(116, 18);
            this.ckbAddGroup.TabIndex = 0;
            this.ckbAddGroup.Text = "Thêm vào nhóm";
            this.ckbAddGroup.UseVisualStyleBackColor = true;
            // 
            // ckbRemoveLimit
            // 
            this.ckbRemoveLimit.AutoSize = true;
            this.ckbRemoveLimit.Location = new System.Drawing.Point(6, 46);
            this.ckbRemoveLimit.Name = "ckbRemoveLimit";
            this.ckbRemoveLimit.Size = new System.Drawing.Size(66, 18);
            this.ckbRemoveLimit.TabIndex = 1;
            this.ckbRemoveLimit.Text = "Gỡ limit";
            this.ckbRemoveLimit.UseVisualStyleBackColor = true;
            // 
            // ckbApproveHold
            // 
            this.ckbApproveHold.AutoSize = true;
            this.ckbApproveHold.Location = new System.Drawing.Point(7, 70);
            this.ckbApproveHold.Name = "ckbApproveHold";
            this.ckbApproveHold.Size = new System.Drawing.Size(87, 18);
            this.ckbApproveHold.TabIndex = 2;
            this.ckbApproveHold.Text = "Duyệt Hold";
            this.ckbApproveHold.UseVisualStyleBackColor = true;
            // 
            // ckbDeleteCredit
            // 
            this.ckbDeleteCredit.AutoSize = true;
            this.ckbDeleteCredit.Location = new System.Drawing.Point(170, 46);
            this.ckbDeleteCredit.Name = "ckbDeleteCredit";
            this.ckbDeleteCredit.Size = new System.Drawing.Size(69, 18);
            this.ckbDeleteCredit.TabIndex = 3;
            this.ckbDeleteCredit.Text = "Xóa thẻ";
            this.ckbDeleteCredit.UseVisualStyleBackColor = true;
            // 
            // ckbRemoveInBM
            // 
            this.ckbRemoveInBM.AutoSize = true;
            this.ckbRemoveInBM.Location = new System.Drawing.Point(170, 70);
            this.ckbRemoveInBM.Name = "ckbRemoveInBM";
            this.ckbRemoveInBM.Size = new System.Drawing.Size(92, 18);
            this.ckbRemoveInBM.TabIndex = 4;
            this.ckbRemoveInBM.Text = "Xóa khỏi BM";
            this.ckbRemoveInBM.UseVisualStyleBackColor = true;
            // 
            // ckbSetLimit
            // 
            this.ckbSetLimit.AutoSize = true;
            this.ckbSetLimit.Location = new System.Drawing.Point(7, 112);
            this.ckbSetLimit.Name = "ckbSetLimit";
            this.ckbSetLimit.Size = new System.Drawing.Size(70, 18);
            this.ckbSetLimit.TabIndex = 5;
            this.ckbSetLimit.Text = "Set limit";
            this.ckbSetLimit.UseVisualStyleBackColor = true;
            // 
            // tbLimitSet
            // 
            this.tbLimitSet.Location = new System.Drawing.Point(83, 108);
            this.tbLimitSet.Name = "tbLimitSet";
            this.tbLimitSet.Size = new System.Drawing.Size(100, 22);
            this.tbLimitSet.TabIndex = 6;
            // 
            // btnLoadGroup
            // 
            this.btnLoadGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadGroup.Location = new System.Drawing.Point(2, 145);
            this.btnLoadGroup.Name = "btnLoadGroup";
            this.btnLoadGroup.Size = new System.Drawing.Size(92, 23);
            this.btnLoadGroup.TabIndex = 9;
            this.btnLoadGroup.Text = "Load Nhóm";
            this.btnLoadGroup.UseVisualStyleBackColor = true;
            // 
            // cbbGroups
            // 
            this.cbbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroups.FormattingEnabled = true;
            this.cbbGroups.Location = new System.Drawing.Point(114, 147);
            this.cbbGroups.Name = "cbbGroups";
            this.cbbGroups.Size = new System.Drawing.Size(216, 22);
            this.cbbGroups.TabIndex = 8;
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadUser.Location = new System.Drawing.Point(2, 182);
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Size = new System.Drawing.Size(92, 23);
            this.btnLoadUser.TabIndex = 11;
            this.btnLoadUser.Text = "Load User";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            // 
            // cbbUser
            // 
            this.cbbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(114, 184);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(216, 22);
            this.cbbUser.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBusinessIdShare);
            this.groupBox1.Controls.Add(this.ckbShareBM);
            this.groupBox1.Controls.Add(this.btnLoadPE);
            this.groupBox1.Controls.Add(this.rtbTargetPE);
            this.groupBox1.Controls.Add(this.ckbDeleteAllCamp);
            this.groupBox1.Controls.Add(this.ckbDiscardDraft);
            this.groupBox1.Controls.Add(this.ckbPublishAd);
            this.groupBox1.Controls.Add(this.ckbPublishAdSet);
            this.groupBox1.Controls.Add(this.ckbPublishCamp);
            this.groupBox1.Location = new System.Drawing.Point(6, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campaign";
            // 
            // ckbPublishCamp
            // 
            this.ckbPublishCamp.AutoSize = true;
            this.ckbPublishCamp.Location = new System.Drawing.Point(6, 21);
            this.ckbPublishCamp.Name = "ckbPublishCamp";
            this.ckbPublishCamp.Size = new System.Drawing.Size(113, 18);
            this.ckbPublishCamp.TabIndex = 3;
            this.ckbPublishCamp.Text = "Đăng chiến dịch";
            this.ckbPublishCamp.UseVisualStyleBackColor = true;
            // 
            // ckbPublishAdSet
            // 
            this.ckbPublishAdSet.AutoSize = true;
            this.ckbPublishAdSet.Location = new System.Drawing.Point(125, 21);
            this.ckbPublishAdSet.Name = "ckbPublishAdSet";
            this.ckbPublishAdSet.Size = new System.Drawing.Size(90, 18);
            this.ckbPublishAdSet.TabIndex = 4;
            this.ckbPublishAdSet.Text = "Đăng Nhóm";
            this.ckbPublishAdSet.UseVisualStyleBackColor = true;
            // 
            // ckbPublishAd
            // 
            this.ckbPublishAd.AutoSize = true;
            this.ckbPublishAd.Location = new System.Drawing.Point(221, 21);
            this.ckbPublishAd.Name = "ckbPublishAd";
            this.ckbPublishAd.Size = new System.Drawing.Size(118, 18);
            this.ckbPublishAd.TabIndex = 5;
            this.ckbPublishAd.Text = "Đăng Quảng Cáo";
            this.ckbPublishAd.UseVisualStyleBackColor = true;
            // 
            // ckbDiscardDraft
            // 
            this.ckbDiscardDraft.AutoSize = true;
            this.ckbDiscardDraft.Location = new System.Drawing.Point(5, 54);
            this.ckbDiscardDraft.Name = "ckbDiscardDraft";
            this.ckbDiscardDraft.Size = new System.Drawing.Size(77, 18);
            this.ckbDiscardDraft.TabIndex = 6;
            this.ckbDiscardDraft.Text = "Xóa nháp";
            this.ckbDiscardDraft.UseVisualStyleBackColor = true;
            // 
            // ckbDeleteAllCamp
            // 
            this.ckbDeleteAllCamp.AutoSize = true;
            this.ckbDeleteAllCamp.Location = new System.Drawing.Point(88, 54);
            this.ckbDeleteAllCamp.Name = "ckbDeleteAllCamp";
            this.ckbDeleteAllCamp.Size = new System.Drawing.Size(96, 18);
            this.ckbDeleteAllCamp.TabIndex = 7;
            this.ckbDeleteAllCamp.Text = "Xóa All Camp";
            this.ckbDeleteAllCamp.UseVisualStyleBackColor = true;
            // 
            // rtbTargetPE
            // 
            this.rtbTargetPE.Location = new System.Drawing.Point(7, 91);
            this.rtbTargetPE.Name = "rtbTargetPE";
            this.rtbTargetPE.Size = new System.Drawing.Size(349, 96);
            this.rtbTargetPE.TabIndex = 8;
            this.rtbTargetPE.Text = "";
            // 
            // btnLoadPE
            // 
            this.btnLoadPE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPE.Location = new System.Drawing.Point(264, 193);
            this.btnLoadPE.Name = "btnLoadPE";
            this.btnLoadPE.Size = new System.Drawing.Size(92, 23);
            this.btnLoadPE.TabIndex = 12;
            this.btnLoadPE.Text = "Get PE";
            this.btnLoadPE.UseVisualStyleBackColor = true;
            // 
            // ckbShareBM
            // 
            this.ckbShareBM.AutoSize = true;
            this.ckbShareBM.Location = new System.Drawing.Point(7, 234);
            this.ckbShareBM.Name = "ckbShareBM";
            this.ckbShareBM.Size = new System.Drawing.Size(100, 18);
            this.ckbShareBM.TabIndex = 13;
            this.ckbShareBM.Text = "Share vào BM";
            this.ckbShareBM.UseVisualStyleBackColor = true;
            // 
            // tbBusinessIdShare
            // 
            this.tbBusinessIdShare.Location = new System.Drawing.Point(114, 231);
            this.tbBusinessIdShare.Name = "tbBusinessIdShare";
            this.tbBusinessIdShare.Size = new System.Drawing.Size(134, 22);
            this.tbBusinessIdShare.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 657);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThread)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChose;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdAccountStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProcess;
        private System.Windows.Forms.Button btnLoadBM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
        private System.Windows.Forms.ProgressBar progressLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBusinessIdShare;
        private System.Windows.Forms.CheckBox ckbShareBM;
        private System.Windows.Forms.Button btnLoadPE;
        private System.Windows.Forms.RichTextBox rtbTargetPE;
        private System.Windows.Forms.CheckBox ckbDeleteAllCamp;
        private System.Windows.Forms.CheckBox ckbDiscardDraft;
        private System.Windows.Forms.CheckBox ckbPublishAd;
        private System.Windows.Forms.CheckBox ckbPublishAdSet;
        private System.Windows.Forms.CheckBox ckbPublishCamp;
        private System.Windows.Forms.Button btnLoadUser;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.Button btnLoadGroup;
        private System.Windows.Forms.TextBox tbLimitSet;
        private System.Windows.Forms.ComboBox cbbGroups;
        private System.Windows.Forms.CheckBox ckbSetLimit;
        private System.Windows.Forms.CheckBox ckbRemoveInBM;
        private System.Windows.Forms.CheckBox ckbDeleteCredit;
        private System.Windows.Forms.CheckBox ckbApproveHold;
        private System.Windows.Forms.CheckBox ckbRemoveLimit;
        private System.Windows.Forms.CheckBox ckbAddGroup;
    }
}

