namespace ClientUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnQuarantine = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.lTitleScan = new System.Windows.Forms.Label();
            this.pProgressScan = new System.Windows.Forms.Panel();
            this.bScanStop = new System.Windows.Forms.Button();
            this.progressScan = new System.Windows.Forms.ProgressBar();
            this.bScanStart = new System.Windows.Forms.Button();
            this.bOpenFolder = new System.Windows.Forms.Button();
            this.lSearch = new System.Windows.Forms.Label();
            this.tSearchPath = new System.Windows.Forms.TextBox();
            this.lDropSearch = new System.Windows.Forms.Label();
            this.rdSearch = new System.Windows.Forms.RadioButton();
            this.rqSearch = new System.Windows.Forms.RadioButton();
            this.pMonitoring = new System.Windows.Forms.Panel();
            this.pEditAddMon = new System.Windows.Forms.Panel();
            this.bSaveEditAddMon = new System.Windows.Forms.Button();
            this.bCloseEditAddMon = new System.Windows.Forms.Button();
            this.rdEditAddMon = new System.Windows.Forms.RadioButton();
            this.rqEditAddMon = new System.Windows.Forms.RadioButton();
            this.tEditAddMon = new System.Windows.Forms.TextBox();
            this.lEditAddMon = new System.Windows.Forms.Label();
            this.addMonitoring = new System.Windows.Forms.Button();
            this.editMonitoring = new System.Windows.Forms.Button();
            this.selectAllElementMonitoring = new System.Windows.Forms.Button();
            this.removeMonitoring = new System.Windows.Forms.Button();
            this.flowPanelMonitoring = new System.Windows.Forms.FlowLayoutPanel();
            this.titleMonitor = new System.Windows.Forms.Label();
            this.pQuarantine = new System.Windows.Forms.Panel();
            this.bQRemove = new System.Windows.Forms.Button();
            this.bQRecavery = new System.Windows.Forms.Button();
            this.lQTitleType = new System.Windows.Forms.Label();
            this.lQTitleFile = new System.Windows.Forms.Label();
            this.lQTitleDate = new System.Windows.Forms.Label();
            this.flowQuarantinePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleQuarantine = new System.Windows.Forms.Label();
            this.pReport = new System.Windows.Forms.Panel();
            this.flowFilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitleReportVirus = new System.Windows.Forms.Label();
            this.lTitleReportCountFile = new System.Windows.Forms.Label();
            this.lTitleReportDir = new System.Windows.Forms.Label();
            this.lTitleReportDateEnd = new System.Windows.Forms.Label();
            this.lTitleReportDateStart = new System.Windows.Forms.Label();
            this.flowReportPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleReport = new System.Windows.Forms.Label();
            this.pUpdate = new System.Windows.Forms.Panel();
            this.lFlatTitlePath = new System.Windows.Forms.Label();
            this.lFlatTitleTime = new System.Windows.Forms.Label();
            this.bUpdateOpenDialog = new System.Windows.Forms.Button();
            this.lTitlePath = new System.Windows.Forms.Label();
            this.lTitleTime = new System.Windows.Forms.Label();
            this.nmUpdate = new System.Windows.Forms.NumericUpDown();
            this.ncUpdate = new System.Windows.Forms.NumericUpDown();
            this.rdUpdate = new System.Windows.Forms.RadioButton();
            this.rqUpdate = new System.Windows.Forms.RadioButton();
            this.tUpdate = new System.Windows.Forms.TextBox();
            this.bUpdateDelete = new System.Windows.Forms.Button();
            this.bUpdateAdd = new System.Windows.Forms.Button();
            this.flowUpdatePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitleUpdate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pProgressScan.SuspendLayout();
            this.pMonitoring.SuspendLayout();
            this.pEditAddMon.SuspendLayout();
            this.pQuarantine.SuspendLayout();
            this.pReport.SuspendLayout();
            this.pUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImage = global::ClientUI.Properties.Resources.green;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnMonitoring);
            this.flowLayoutPanel1.Controls.Add(this.btnQuarantine);
            this.flowLayoutPanel1.Controls.Add(this.btnReport);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(179, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 154);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::ClientUI.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSearch.Size = new System.Drawing.Size(112, 154);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.btnMonitoring.BackgroundImage = global::ClientUI.Properties.Resources.Monitoring;
            this.btnMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMonitoring.FlatAppearance.BorderSize = 0;
            this.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonitoring.Location = new System.Drawing.Point(112, 0);
            this.btnMonitoring.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMonitoring.Size = new System.Drawing.Size(112, 154);
            this.btnMonitoring.TabIndex = 1;
            this.btnMonitoring.UseVisualStyleBackColor = false;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnQuarantine
            // 
            this.btnQuarantine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuarantine.BackColor = System.Drawing.Color.Transparent;
            this.btnQuarantine.BackgroundImage = global::ClientUI.Properties.Resources.Quarantine;
            this.btnQuarantine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuarantine.FlatAppearance.BorderSize = 0;
            this.btnQuarantine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuarantine.Location = new System.Drawing.Point(224, 0);
            this.btnQuarantine.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuarantine.Name = "btnQuarantine";
            this.btnQuarantine.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnQuarantine.Size = new System.Drawing.Size(112, 154);
            this.btnQuarantine.TabIndex = 2;
            this.btnQuarantine.UseVisualStyleBackColor = false;
            this.btnQuarantine.Click += new System.EventHandler(this.btnQuarantine_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImage = global::ClientUI.Properties.Resources.Report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Location = new System.Drawing.Point(336, 0);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReport.Size = new System.Drawing.Size(112, 154);
            this.btnReport.TabIndex = 3;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = global::ClientUI.Properties.Resources.Time;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(448, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUpdate.Size = new System.Drawing.Size(112, 154);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClientUI.Properties.Resources.green;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 154);
            this.panel1.TabIndex = 8;
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.LightCyan;
            this.pSearch.Controls.Add(this.lTitleScan);
            this.pSearch.Controls.Add(this.pProgressScan);
            this.pSearch.Controls.Add(this.bScanStart);
            this.pSearch.Controls.Add(this.bOpenFolder);
            this.pSearch.Controls.Add(this.lSearch);
            this.pSearch.Controls.Add(this.tSearchPath);
            this.pSearch.Controls.Add(this.lDropSearch);
            this.pSearch.Controls.Add(this.rdSearch);
            this.pSearch.Controls.Add(this.rqSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(924, 407);
            this.pSearch.TabIndex = 9;
            this.pSearch.Visible = false;
            // 
            // lTitleScan
            // 
            this.lTitleScan.AutoSize = true;
            this.lTitleScan.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitleScan.Location = new System.Drawing.Point(325, 27);
            this.lTitleScan.Name = "lTitleScan";
            this.lTitleScan.Size = new System.Drawing.Size(276, 54);
            this.lTitleScan.TabIndex = 8;
            this.lTitleScan.Text = "Сканирование";
            // 
            // pProgressScan
            // 
            this.pProgressScan.Controls.Add(this.bScanStop);
            this.pProgressScan.Controls.Add(this.progressScan);
            this.pProgressScan.Location = new System.Drawing.Point(179, 84);
            this.pProgressScan.Name = "pProgressScan";
            this.pProgressScan.Size = new System.Drawing.Size(561, 301);
            this.pProgressScan.TabIndex = 7;
            this.pProgressScan.Visible = false;
            // 
            // bScanStop
            // 
            this.bScanStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bScanStop.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.bScanStop.Location = new System.Drawing.Point(148, 35);
            this.bScanStop.Name = "bScanStop";
            this.bScanStop.Size = new System.Drawing.Size(267, 49);
            this.bScanStop.TabIndex = 1;
            this.bScanStop.Text = "Остановить сканирование";
            this.bScanStop.UseVisualStyleBackColor = true;
            this.bScanStop.Click += new System.EventHandler(this.bScanStop_Click);
            // 
            // progressScan
            // 
            this.progressScan.BackColor = System.Drawing.Color.LightCyan;
            this.progressScan.Location = new System.Drawing.Point(0, 131);
            this.progressScan.Name = "progressScan";
            this.progressScan.Size = new System.Drawing.Size(561, 103);
            this.progressScan.Step = 1;
            this.progressScan.TabIndex = 0;
            // 
            // bScanStart
            // 
            this.bScanStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bScanStart.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.bScanStart.Location = new System.Drawing.Point(291, 84);
            this.bScanStart.Name = "bScanStart";
            this.bScanStart.Size = new System.Drawing.Size(336, 42);
            this.bScanStart.TabIndex = 6;
            this.bScanStart.Text = "Начать сканирование";
            this.bScanStart.UseVisualStyleBackColor = true;
            this.bScanStart.Click += new System.EventHandler(this.bScanStart_Click);
            // 
            // bOpenFolder
            // 
            this.bOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bOpenFolder.Location = new System.Drawing.Point(710, 172);
            this.bOpenFolder.Name = "bOpenFolder";
            this.bOpenFolder.Size = new System.Drawing.Size(30, 23);
            this.bOpenFolder.TabIndex = 5;
            this.bOpenFolder.Text = "...";
            this.bOpenFolder.UseVisualStyleBackColor = true;
            this.bOpenFolder.Click += new System.EventHandler(this.bOpenFolder_Click);
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lSearch.Location = new System.Drawing.Point(176, 174);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(38, 19);
            this.lSearch.TabIndex = 4;
            this.lSearch.Text = "Путь:";
            // 
            // tSearchPath
            // 
            this.tSearchPath.Location = new System.Drawing.Point(217, 174);
            this.tSearchPath.Name = "tSearchPath";
            this.tSearchPath.Size = new System.Drawing.Size(487, 20);
            this.tSearchPath.TabIndex = 3;
            // 
            // lDropSearch
            // 
            this.lDropSearch.AllowDrop = true;
            this.lDropSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lDropSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lDropSearch.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lDropSearch.Location = new System.Drawing.Point(180, 198);
            this.lDropSearch.Name = "lDropSearch";
            this.lDropSearch.Size = new System.Drawing.Size(560, 172);
            this.lDropSearch.TabIndex = 2;
            this.lDropSearch.Text = "Перетащите сюда папку или файл";
            this.lDropSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lDropSearch.DragDrop += new System.Windows.Forms.DragEventHandler(this.lDropSearch_DragDrop);
            this.lDropSearch.DragEnter += new System.Windows.Forms.DragEventHandler(this.lDropSearch_DragEnter);
            // 
            // rdSearch
            // 
            this.rdSearch.AutoSize = true;
            this.rdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdSearch.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rdSearch.Location = new System.Drawing.Point(551, 134);
            this.rdSearch.Name = "rdSearch";
            this.rdSearch.Size = new System.Drawing.Size(90, 29);
            this.rdSearch.TabIndex = 1;
            this.rdSearch.Text = "Удалять";
            this.rdSearch.UseVisualStyleBackColor = true;
            // 
            // rqSearch
            // 
            this.rqSearch.AutoSize = true;
            this.rqSearch.Checked = true;
            this.rqSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rqSearch.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rqSearch.Location = new System.Drawing.Point(282, 134);
            this.rqSearch.Name = "rqSearch";
            this.rqSearch.Size = new System.Drawing.Size(201, 29);
            this.rqSearch.TabIndex = 0;
            this.rqSearch.TabStop = true;
            this.rqSearch.Text = "Помещать в карантин";
            this.rqSearch.UseVisualStyleBackColor = true;
            // 
            // pMonitoring
            // 
            this.pMonitoring.BackColor = System.Drawing.Color.LightCyan;
            this.pMonitoring.Controls.Add(this.pEditAddMon);
            this.pMonitoring.Controls.Add(this.addMonitoring);
            this.pMonitoring.Controls.Add(this.editMonitoring);
            this.pMonitoring.Controls.Add(this.selectAllElementMonitoring);
            this.pMonitoring.Controls.Add(this.removeMonitoring);
            this.pMonitoring.Controls.Add(this.flowPanelMonitoring);
            this.pMonitoring.Controls.Add(this.titleMonitor);
            this.pMonitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMonitoring.Location = new System.Drawing.Point(0, 0);
            this.pMonitoring.Name = "pMonitoring";
            this.pMonitoring.Size = new System.Drawing.Size(924, 407);
            this.pMonitoring.TabIndex = 10;
            this.pMonitoring.Visible = false;
            // 
            // pEditAddMon
            // 
            this.pEditAddMon.Controls.Add(this.bSaveEditAddMon);
            this.pEditAddMon.Controls.Add(this.bCloseEditAddMon);
            this.pEditAddMon.Controls.Add(this.rdEditAddMon);
            this.pEditAddMon.Controls.Add(this.rqEditAddMon);
            this.pEditAddMon.Controls.Add(this.tEditAddMon);
            this.pEditAddMon.Controls.Add(this.lEditAddMon);
            this.pEditAddMon.Location = new System.Drawing.Point(146, 96);
            this.pEditAddMon.Name = "pEditAddMon";
            this.pEditAddMon.Size = new System.Drawing.Size(630, 297);
            this.pEditAddMon.TabIndex = 5;
            this.pEditAddMon.Visible = false;
            // 
            // bSaveEditAddMon
            // 
            this.bSaveEditAddMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSaveEditAddMon.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.bSaveEditAddMon.Location = new System.Drawing.Point(369, 234);
            this.bSaveEditAddMon.Name = "bSaveEditAddMon";
            this.bSaveEditAddMon.Size = new System.Drawing.Size(120, 49);
            this.bSaveEditAddMon.TabIndex = 5;
            this.bSaveEditAddMon.Text = "Сохранить";
            this.bSaveEditAddMon.UseVisualStyleBackColor = true;
            this.bSaveEditAddMon.Click += new System.EventHandler(this.bSaveEditAddMon_Click);
            // 
            // bCloseEditAddMon
            // 
            this.bCloseEditAddMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCloseEditAddMon.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.bCloseEditAddMon.Location = new System.Drawing.Point(137, 234);
            this.bCloseEditAddMon.Name = "bCloseEditAddMon";
            this.bCloseEditAddMon.Size = new System.Drawing.Size(120, 49);
            this.bCloseEditAddMon.TabIndex = 4;
            this.bCloseEditAddMon.Text = "Отмена";
            this.bCloseEditAddMon.UseVisualStyleBackColor = true;
            this.bCloseEditAddMon.Click += new System.EventHandler(this.bCloseEditAddMon_Click);
            // 
            // rdEditAddMon
            // 
            this.rdEditAddMon.AutoSize = true;
            this.rdEditAddMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdEditAddMon.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.rdEditAddMon.Location = new System.Drawing.Point(82, 142);
            this.rdEditAddMon.Name = "rdEditAddMon";
            this.rdEditAddMon.Size = new System.Drawing.Size(81, 25);
            this.rdEditAddMon.TabIndex = 3;
            this.rdEditAddMon.TabStop = true;
            this.rdEditAddMon.Text = "Удалять";
            this.rdEditAddMon.UseVisualStyleBackColor = true;
            // 
            // rqEditAddMon
            // 
            this.rqEditAddMon.AutoSize = true;
            this.rqEditAddMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rqEditAddMon.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.rqEditAddMon.Location = new System.Drawing.Point(82, 98);
            this.rqEditAddMon.Name = "rqEditAddMon";
            this.rqEditAddMon.Size = new System.Drawing.Size(179, 25);
            this.rqEditAddMon.TabIndex = 2;
            this.rqEditAddMon.TabStop = true;
            this.rqEditAddMon.Text = "Помещать в карантин";
            this.rqEditAddMon.UseVisualStyleBackColor = true;
            // 
            // tEditAddMon
            // 
            this.tEditAddMon.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tEditAddMon.Location = new System.Drawing.Point(82, 34);
            this.tEditAddMon.Name = "tEditAddMon";
            this.tEditAddMon.Size = new System.Drawing.Size(487, 29);
            this.tEditAddMon.TabIndex = 1;
            // 
            // lEditAddMon
            // 
            this.lEditAddMon.AutoSize = true;
            this.lEditAddMon.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lEditAddMon.Location = new System.Drawing.Point(20, 38);
            this.lEditAddMon.Name = "lEditAddMon";
            this.lEditAddMon.Size = new System.Drawing.Size(45, 21);
            this.lEditAddMon.TabIndex = 0;
            this.lEditAddMon.Text = "Путь:";
            // 
            // addMonitoring
            // 
            this.addMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMonitoring.Location = new System.Drawing.Point(297, 106);
            this.addMonitoring.Name = "addMonitoring";
            this.addMonitoring.Size = new System.Drawing.Size(89, 23);
            this.addMonitoring.TabIndex = 2;
            this.addMonitoring.Text = "Добавить";
            this.addMonitoring.UseVisualStyleBackColor = true;
            this.addMonitoring.Click += new System.EventHandler(this.addMonitoring_Click);
            // 
            // editMonitoring
            // 
            this.editMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editMonitoring.Location = new System.Drawing.Point(392, 106);
            this.editMonitoring.Name = "editMonitoring";
            this.editMonitoring.Size = new System.Drawing.Size(117, 23);
            this.editMonitoring.TabIndex = 3;
            this.editMonitoring.Text = "Редактировать";
            this.editMonitoring.UseVisualStyleBackColor = true;
            this.editMonitoring.Click += new System.EventHandler(this.editMonitoring_Click);
            // 
            // selectAllElementMonitoring
            // 
            this.selectAllElementMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectAllElementMonitoring.Location = new System.Drawing.Point(184, 106);
            this.selectAllElementMonitoring.Name = "selectAllElementMonitoring";
            this.selectAllElementMonitoring.Size = new System.Drawing.Size(107, 23);
            this.selectAllElementMonitoring.TabIndex = 1;
            this.selectAllElementMonitoring.Text = "Выбрать все";
            this.selectAllElementMonitoring.UseVisualStyleBackColor = true;
            this.selectAllElementMonitoring.Click += new System.EventHandler(this.selectAllElementMonitoring_Click);
            // 
            // removeMonitoring
            // 
            this.removeMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeMonitoring.Location = new System.Drawing.Point(515, 106);
            this.removeMonitoring.Name = "removeMonitoring";
            this.removeMonitoring.Size = new System.Drawing.Size(77, 23);
            this.removeMonitoring.TabIndex = 4;
            this.removeMonitoring.Text = "Удалить";
            this.removeMonitoring.UseVisualStyleBackColor = true;
            this.removeMonitoring.Click += new System.EventHandler(this.removeMonitoring_Click);
            // 
            // flowPanelMonitoring
            // 
            this.flowPanelMonitoring.AutoScroll = true;
            this.flowPanelMonitoring.BackColor = System.Drawing.Color.LightCyan;
            this.flowPanelMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelMonitoring.Location = new System.Drawing.Point(184, 135);
            this.flowPanelMonitoring.Name = "flowPanelMonitoring";
            this.flowPanelMonitoring.Size = new System.Drawing.Size(592, 247);
            this.flowPanelMonitoring.TabIndex = 1;
            // 
            // titleMonitor
            // 
            this.titleMonitor.AutoSize = true;
            this.titleMonitor.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleMonitor.Location = new System.Drawing.Point(244, 31);
            this.titleMonitor.Name = "titleMonitor";
            this.titleMonitor.Size = new System.Drawing.Size(453, 54);
            this.titleMonitor.TabIndex = 0;
            this.titleMonitor.Text = "Мониторинг директорий";
            // 
            // pQuarantine
            // 
            this.pQuarantine.BackColor = System.Drawing.Color.LightCyan;
            this.pQuarantine.Controls.Add(this.bQRemove);
            this.pQuarantine.Controls.Add(this.bQRecavery);
            this.pQuarantine.Controls.Add(this.lQTitleType);
            this.pQuarantine.Controls.Add(this.lQTitleFile);
            this.pQuarantine.Controls.Add(this.lQTitleDate);
            this.pQuarantine.Controls.Add(this.flowQuarantinePanel);
            this.pQuarantine.Controls.Add(this.TitleQuarantine);
            this.pQuarantine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQuarantine.Location = new System.Drawing.Point(0, 0);
            this.pQuarantine.Name = "pQuarantine";
            this.pQuarantine.Size = new System.Drawing.Size(924, 407);
            this.pQuarantine.TabIndex = 11;
            this.pQuarantine.Visible = false;
            // 
            // bQRemove
            // 
            this.bQRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bQRemove.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.bQRemove.Location = new System.Drawing.Point(515, 353);
            this.bQRemove.Name = "bQRemove";
            this.bQRemove.Size = new System.Drawing.Size(112, 35);
            this.bQRemove.TabIndex = 4;
            this.bQRemove.Text = "Удалить";
            this.bQRemove.UseVisualStyleBackColor = true;
            this.bQRemove.Click += new System.EventHandler(this.bQRemove_Click);
            // 
            // bQRecavery
            // 
            this.bQRecavery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bQRecavery.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.bQRecavery.Location = new System.Drawing.Point(291, 353);
            this.bQRecavery.Name = "bQRecavery";
            this.bQRecavery.Size = new System.Drawing.Size(112, 35);
            this.bQRecavery.TabIndex = 0;
            this.bQRecavery.Text = "Восстановить";
            this.bQRecavery.UseVisualStyleBackColor = true;
            this.bQRecavery.Click += new System.EventHandler(this.bQRecavery_Click);
            // 
            // lQTitleType
            // 
            this.lQTitleType.AutoSize = true;
            this.lQTitleType.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lQTitleType.Location = new System.Drawing.Point(651, 110);
            this.lQTitleType.Name = "lQTitleType";
            this.lQTitleType.Size = new System.Drawing.Size(66, 15);
            this.lQTitleType.TabIndex = 6;
            this.lQTitleType.Text = "Тип вируса";
            // 
            // lQTitleFile
            // 
            this.lQTitleFile.AutoSize = true;
            this.lQTitleFile.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lQTitleFile.Location = new System.Drawing.Point(256, 110);
            this.lQTitleFile.Name = "lQTitleFile";
            this.lQTitleFile.Size = new System.Drawing.Size(73, 15);
            this.lQTitleFile.TabIndex = 5;
            this.lQTitleFile.Text = "Путь к файлу";
            // 
            // lQTitleDate
            // 
            this.lQTitleDate.AutoSize = true;
            this.lQTitleDate.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lQTitleDate.Location = new System.Drawing.Point(100, 110);
            this.lQTitleDate.Name = "lQTitleDate";
            this.lQTitleDate.Size = new System.Drawing.Size(150, 15);
            this.lQTitleDate.TabIndex = 4;
            this.lQTitleDate.Text = "Дата занесения в карантин";
            // 
            // flowQuarantinePanel
            // 
            this.flowQuarantinePanel.AutoScroll = true;
            this.flowQuarantinePanel.BackColor = System.Drawing.Color.LightCyan;
            this.flowQuarantinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowQuarantinePanel.Location = new System.Drawing.Point(62, 129);
            this.flowQuarantinePanel.Name = "flowQuarantinePanel";
            this.flowQuarantinePanel.Size = new System.Drawing.Size(803, 216);
            this.flowQuarantinePanel.TabIndex = 3;
            // 
            // TitleQuarantine
            // 
            this.TitleQuarantine.AutoSize = true;
            this.TitleQuarantine.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleQuarantine.Location = new System.Drawing.Point(363, 42);
            this.TitleQuarantine.Name = "TitleQuarantine";
            this.TitleQuarantine.Size = new System.Drawing.Size(186, 54);
            this.TitleQuarantine.TabIndex = 2;
            this.TitleQuarantine.Text = "Карантин";
            // 
            // pReport
            // 
            this.pReport.BackColor = System.Drawing.Color.LightCyan;
            this.pReport.Controls.Add(this.flowFilePanel);
            this.pReport.Controls.Add(this.lTitleReportVirus);
            this.pReport.Controls.Add(this.lTitleReportCountFile);
            this.pReport.Controls.Add(this.lTitleReportDir);
            this.pReport.Controls.Add(this.lTitleReportDateEnd);
            this.pReport.Controls.Add(this.lTitleReportDateStart);
            this.pReport.Controls.Add(this.flowReportPanel);
            this.pReport.Controls.Add(this.TitleReport);
            this.pReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReport.Location = new System.Drawing.Point(0, 0);
            this.pReport.Name = "pReport";
            this.pReport.Size = new System.Drawing.Size(924, 407);
            this.pReport.TabIndex = 12;
            this.pReport.Visible = false;
            this.pReport.Click += new System.EventHandler(this.pReport_Click);
            // 
            // flowFilePanel
            // 
            this.flowFilePanel.AutoScroll = true;
            this.flowFilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowFilePanel.Location = new System.Drawing.Point(32, 101);
            this.flowFilePanel.Name = "flowFilePanel";
            this.flowFilePanel.Size = new System.Drawing.Size(859, 283);
            this.flowFilePanel.TabIndex = 8;
            this.flowFilePanel.Visible = false;
            // 
            // lTitleReportVirus
            // 
            this.lTitleReportVirus.AutoSize = true;
            this.lTitleReportVirus.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportVirus.Location = new System.Drawing.Point(689, 118);
            this.lTitleReportVirus.Name = "lTitleReportVirus";
            this.lTitleReportVirus.Size = new System.Drawing.Size(36, 15);
            this.lTitleReportVirus.TabIndex = 7;
            this.lTitleReportVirus.Text = "Угроз";
            // 
            // lTitleReportCountFile
            // 
            this.lTitleReportCountFile.AutoSize = true;
            this.lTitleReportCountFile.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportCountFile.Location = new System.Drawing.Point(579, 118);
            this.lTitleReportCountFile.Name = "lTitleReportCountFile";
            this.lTitleReportCountFile.Size = new System.Drawing.Size(111, 15);
            this.lTitleReportCountFile.TabIndex = 6;
            this.lTitleReportCountFile.Text = "Проверено файлов";
            // 
            // lTitleReportDir
            // 
            this.lTitleReportDir.AutoSize = true;
            this.lTitleReportDir.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportDir.Location = new System.Drawing.Point(297, 118);
            this.lTitleReportDir.Name = "lTitleReportDir";
            this.lTitleReportDir.Size = new System.Drawing.Size(102, 15);
            this.lTitleReportDir.TabIndex = 5;
            this.lTitleReportDir.Text = "Директория/файл";
            // 
            // lTitleReportDateEnd
            // 
            this.lTitleReportDateEnd.AutoSize = true;
            this.lTitleReportDateEnd.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportDateEnd.Location = new System.Drawing.Point(156, 118);
            this.lTitleReportDateEnd.Name = "lTitleReportDateEnd";
            this.lTitleReportDateEnd.Size = new System.Drawing.Size(138, 15);
            this.lTitleReportDateEnd.TabIndex = 4;
            this.lTitleReportDateEnd.Text = "Дата и время окончания";
            // 
            // lTitleReportDateStart
            // 
            this.lTitleReportDateStart.AutoSize = true;
            this.lTitleReportDateStart.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportDateStart.Location = new System.Drawing.Point(33, 118);
            this.lTitleReportDateStart.Name = "lTitleReportDateStart";
            this.lTitleReportDateStart.Size = new System.Drawing.Size(117, 15);
            this.lTitleReportDateStart.TabIndex = 3;
            this.lTitleReportDateStart.Text = "Дата и время начала";
            // 
            // flowReportPanel
            // 
            this.flowReportPanel.AutoScroll = true;
            this.flowReportPanel.BackColor = System.Drawing.Color.LightCyan;
            this.flowReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowReportPanel.Location = new System.Drawing.Point(32, 136);
            this.flowReportPanel.Name = "flowReportPanel";
            this.flowReportPanel.Size = new System.Drawing.Size(859, 247);
            this.flowReportPanel.TabIndex = 2;
            // 
            // TitleReport
            // 
            this.TitleReport.AutoSize = true;
            this.TitleReport.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleReport.Location = new System.Drawing.Point(349, 40);
            this.TitleReport.Name = "TitleReport";
            this.TitleReport.Size = new System.Drawing.Size(220, 54);
            this.TitleReport.TabIndex = 1;
            this.TitleReport.Text = "Отчетность";
            // 
            // pUpdate
            // 
            this.pUpdate.BackColor = System.Drawing.Color.LightCyan;
            this.pUpdate.Controls.Add(this.lFlatTitlePath);
            this.pUpdate.Controls.Add(this.lFlatTitleTime);
            this.pUpdate.Controls.Add(this.bUpdateOpenDialog);
            this.pUpdate.Controls.Add(this.lTitlePath);
            this.pUpdate.Controls.Add(this.lTitleTime);
            this.pUpdate.Controls.Add(this.nmUpdate);
            this.pUpdate.Controls.Add(this.ncUpdate);
            this.pUpdate.Controls.Add(this.rdUpdate);
            this.pUpdate.Controls.Add(this.rqUpdate);
            this.pUpdate.Controls.Add(this.tUpdate);
            this.pUpdate.Controls.Add(this.bUpdateDelete);
            this.pUpdate.Controls.Add(this.bUpdateAdd);
            this.pUpdate.Controls.Add(this.flowUpdatePanel);
            this.pUpdate.Controls.Add(this.lTitleUpdate);
            this.pUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUpdate.Location = new System.Drawing.Point(0, 0);
            this.pUpdate.Name = "pUpdate";
            this.pUpdate.Size = new System.Drawing.Size(924, 407);
            this.pUpdate.TabIndex = 13;
            this.pUpdate.Visible = false;
            // 
            // lFlatTitlePath
            // 
            this.lFlatTitlePath.AutoSize = true;
            this.lFlatTitlePath.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFlatTitlePath.Location = new System.Drawing.Point(232, 204);
            this.lFlatTitlePath.Name = "lFlatTitlePath";
            this.lFlatTitlePath.Size = new System.Drawing.Size(30, 15);
            this.lFlatTitlePath.TabIndex = 14;
            this.lFlatTitlePath.Text = "Путь";
            // 
            // lFlatTitleTime
            // 
            this.lFlatTitleTime.AutoSize = true;
            this.lFlatTitleTime.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFlatTitleTime.Location = new System.Drawing.Point(176, 204);
            this.lFlatTitleTime.Name = "lFlatTitleTime";
            this.lFlatTitleTime.Size = new System.Drawing.Size(41, 15);
            this.lFlatTitleTime.TabIndex = 13;
            this.lFlatTitleTime.Text = "Время";
            // 
            // bUpdateOpenDialog
            // 
            this.bUpdateOpenDialog.Location = new System.Drawing.Point(714, 177);
            this.bUpdateOpenDialog.Name = "bUpdateOpenDialog";
            this.bUpdateOpenDialog.Size = new System.Drawing.Size(25, 20);
            this.bUpdateOpenDialog.TabIndex = 12;
            this.bUpdateOpenDialog.Text = "...";
            this.bUpdateOpenDialog.UseVisualStyleBackColor = true;
            this.bUpdateOpenDialog.Click += new System.EventHandler(this.bUpdateOpenDialog_Click);
            // 
            // lTitlePath
            // 
            this.lTitlePath.AutoSize = true;
            this.lTitlePath.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitlePath.Location = new System.Drawing.Point(175, 178);
            this.lTitlePath.Name = "lTitlePath";
            this.lTitlePath.Size = new System.Drawing.Size(38, 19);
            this.lTitlePath.TabIndex = 11;
            this.lTitlePath.Text = "Путь:";
            // 
            // lTitleTime
            // 
            this.lTitleTime.AutoSize = true;
            this.lTitleTime.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitleTime.Location = new System.Drawing.Point(175, 153);
            this.lTitleTime.Name = "lTitleTime";
            this.lTitleTime.Size = new System.Drawing.Size(51, 19);
            this.lTitleTime.TabIndex = 10;
            this.lTitleTime.Text = "Время:";
            // 
            // nmUpdate
            // 
            this.nmUpdate.Location = new System.Drawing.Point(286, 154);
            this.nmUpdate.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmUpdate.Name = "nmUpdate";
            this.nmUpdate.Size = new System.Drawing.Size(49, 20);
            this.nmUpdate.TabIndex = 9;
            // 
            // ncUpdate
            // 
            this.ncUpdate.Location = new System.Drawing.Point(230, 154);
            this.ncUpdate.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ncUpdate.Name = "ncUpdate";
            this.ncUpdate.Size = new System.Drawing.Size(49, 20);
            this.ncUpdate.TabIndex = 8;
            // 
            // rdUpdate
            // 
            this.rdUpdate.AutoSize = true;
            this.rdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdUpdate.Location = new System.Drawing.Point(559, 155);
            this.rdUpdate.Name = "rdUpdate";
            this.rdUpdate.Size = new System.Drawing.Size(67, 17);
            this.rdUpdate.TabIndex = 7;
            this.rdUpdate.Text = "Удалять";
            this.rdUpdate.UseVisualStyleBackColor = true;
            // 
            // rqUpdate
            // 
            this.rqUpdate.AutoSize = true;
            this.rqUpdate.Checked = true;
            this.rqUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rqUpdate.Location = new System.Drawing.Point(403, 154);
            this.rqUpdate.Name = "rqUpdate";
            this.rqUpdate.Size = new System.Drawing.Size(137, 17);
            this.rqUpdate.TabIndex = 6;
            this.rqUpdate.TabStop = true;
            this.rqUpdate.Text = "Помещать в карантин";
            this.rqUpdate.UseVisualStyleBackColor = true;
            // 
            // tUpdate
            // 
            this.tUpdate.Location = new System.Drawing.Point(230, 178);
            this.tUpdate.Name = "tUpdate";
            this.tUpdate.Size = new System.Drawing.Size(478, 20);
            this.tUpdate.TabIndex = 5;
            // 
            // bUpdateDelete
            // 
            this.bUpdateDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bUpdateDelete.Location = new System.Drawing.Point(176, 119);
            this.bUpdateDelete.Name = "bUpdateDelete";
            this.bUpdateDelete.Size = new System.Drawing.Size(75, 23);
            this.bUpdateDelete.TabIndex = 4;
            this.bUpdateDelete.Text = "Удалить";
            this.bUpdateDelete.UseVisualStyleBackColor = true;
            this.bUpdateDelete.Click += new System.EventHandler(this.bUpdateDelete_Click);
            // 
            // bUpdateAdd
            // 
            this.bUpdateAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bUpdateAdd.Location = new System.Drawing.Point(267, 119);
            this.bUpdateAdd.Name = "bUpdateAdd";
            this.bUpdateAdd.Size = new System.Drawing.Size(75, 23);
            this.bUpdateAdd.TabIndex = 3;
            this.bUpdateAdd.Text = "Добавить";
            this.bUpdateAdd.UseVisualStyleBackColor = true;
            this.bUpdateAdd.Click += new System.EventHandler(this.bUpdateAdd_Click);
            // 
            // flowUpdatePanel
            // 
            this.flowUpdatePanel.AutoScroll = true;
            this.flowUpdatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowUpdatePanel.Location = new System.Drawing.Point(121, 220);
            this.flowUpdatePanel.Name = "flowUpdatePanel";
            this.flowUpdatePanel.Size = new System.Drawing.Size(685, 162);
            this.flowUpdatePanel.TabIndex = 2;
            // 
            // lTitleUpdate
            // 
            this.lTitleUpdate.AutoSize = true;
            this.lTitleUpdate.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitleUpdate.Location = new System.Drawing.Point(346, 52);
            this.lTitleUpdate.Name = "lTitleUpdate";
            this.lTitleUpdate.Size = new System.Drawing.Size(229, 54);
            this.lTitleUpdate.TabIndex = 1;
            this.lTitleUpdate.Text = "Расписание";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClientUI.Properties.Resources.green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 561);
            this.Controls.Add(this.pSearch);
            this.Controls.Add(this.pUpdate);
            this.Controls.Add(this.pReport);
            this.Controls.Add(this.pQuarantine);
            this.Controls.Add(this.pMonitoring);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1340, 600);
            this.MinimumSize = new System.Drawing.Size(940, 600);
            this.Name = "Form1";
            this.Text = "NW Antivirus";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pProgressScan.ResumeLayout(false);
            this.pMonitoring.ResumeLayout(false);
            this.pMonitoring.PerformLayout();
            this.pEditAddMon.ResumeLayout(false);
            this.pEditAddMon.PerformLayout();
            this.pQuarantine.ResumeLayout(false);
            this.pQuarantine.PerformLayout();
            this.pReport.ResumeLayout(false);
            this.pReport.PerformLayout();
            this.pUpdate.ResumeLayout(false);
            this.pUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMonitoring;
        private System.Windows.Forms.Button btnQuarantine;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Panel pMonitoring;
        private System.Windows.Forms.Panel pQuarantine;
        private System.Windows.Forms.Panel pReport;
        private System.Windows.Forms.Panel pUpdate;
        private System.Windows.Forms.Label titleMonitor;
        private System.Windows.Forms.FlowLayoutPanel flowPanelMonitoring;
        private System.Windows.Forms.Button addMonitoring;
        private System.Windows.Forms.Button removeMonitoring;
        private System.Windows.Forms.Button selectAllElementMonitoring;
        private System.Windows.Forms.Button editMonitoring;
        private System.Windows.Forms.Label TitleReport;
        private System.Windows.Forms.Label lTitleReportDateStart;
        private System.Windows.Forms.FlowLayoutPanel flowReportPanel;
        private System.Windows.Forms.Label lTitleReportVirus;
        private System.Windows.Forms.Label lTitleReportCountFile;
        private System.Windows.Forms.Label lTitleReportDir;
        private System.Windows.Forms.Label lTitleReportDateEnd;
        private System.Windows.Forms.Panel pEditAddMon;
        private System.Windows.Forms.Button bSaveEditAddMon;
        private System.Windows.Forms.Button bCloseEditAddMon;
        private System.Windows.Forms.RadioButton rdEditAddMon;
        private System.Windows.Forms.RadioButton rqEditAddMon;
        private System.Windows.Forms.TextBox tEditAddMon;
        private System.Windows.Forms.Label lEditAddMon;
        private System.Windows.Forms.FlowLayoutPanel flowQuarantinePanel;
        private System.Windows.Forms.Label TitleQuarantine;
        private System.Windows.Forms.Label lQTitleType;
        private System.Windows.Forms.Label lQTitleFile;
        private System.Windows.Forms.Label lQTitleDate;
        private System.Windows.Forms.Button bQRecavery;
        private System.Windows.Forms.Button bQRemove;
        private System.Windows.Forms.Label lDropSearch;
        private System.Windows.Forms.RadioButton rdSearch;
        private System.Windows.Forms.RadioButton rqSearch;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox tSearchPath;
        private System.Windows.Forms.Button bOpenFolder;
        private System.Windows.Forms.Panel pProgressScan;
        private System.Windows.Forms.ProgressBar progressScan;
        private System.Windows.Forms.Button bScanStart;
        private System.Windows.Forms.Label lTitleScan;
        private System.Windows.Forms.Button bScanStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lFlatTitlePath;
        private System.Windows.Forms.Label lFlatTitleTime;
        private System.Windows.Forms.Button bUpdateOpenDialog;
        private System.Windows.Forms.Label lTitlePath;
        private System.Windows.Forms.Label lTitleTime;
        private System.Windows.Forms.NumericUpDown nmUpdate;
        private System.Windows.Forms.NumericUpDown ncUpdate;
        private System.Windows.Forms.RadioButton rdUpdate;
        private System.Windows.Forms.RadioButton rqUpdate;
        private System.Windows.Forms.TextBox tUpdate;
        private System.Windows.Forms.Button bUpdateDelete;
        private System.Windows.Forms.Button bUpdateAdd;
        private System.Windows.Forms.FlowLayoutPanel flowUpdatePanel;
        private System.Windows.Forms.Label lTitleUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowFilePanel;
    }
}

