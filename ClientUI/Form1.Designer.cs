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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnQuarantine = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
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
            this.lTitleReportVirus = new System.Windows.Forms.Label();
            this.lTitleReportCountFile = new System.Windows.Forms.Label();
            this.lTitleReportDir = new System.Windows.Forms.Label();
            this.lTitleReportDateEnd = new System.Windows.Forms.Label();
            this.lTitleReportDateStart = new System.Windows.Forms.Label();
            this.flowReportPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleReport = new System.Windows.Forms.Label();
            this.pUpdate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pMonitoring.SuspendLayout();
            this.pEditAddMon.SuspendLayout();
            this.pQuarantine.SuspendLayout();
            this.pReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(34, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 23);
            this.label1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(256, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "a";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(256, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "b";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(256, 59);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "c";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
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
            this.btnUpdate.BackgroundImage = global::ClientUI.Properties.Resources.Update;
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
            this.pSearch.Controls.Add(this.numericUpDown1);
            this.pSearch.Controls.Add(this.textBox1);
            this.pSearch.Controls.Add(this.button1);
            this.pSearch.Controls.Add(this.checkBox3);
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Controls.Add(this.checkBox2);
            this.pSearch.Controls.Add(this.checkBox1);
            this.pSearch.Location = new System.Drawing.Point(1118, 159);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(105, 74);
            this.pSearch.TabIndex = 9;
            this.pSearch.Visible = false;
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
            this.pEditAddMon.Location = new System.Drawing.Point(146, 86);
            this.pEditAddMon.Name = "pEditAddMon";
            this.pEditAddMon.Size = new System.Drawing.Size(630, 307);
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
            // 
            // lTitleReportVirus
            // 
            this.lTitleReportVirus.AutoSize = true;
            this.lTitleReportVirus.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportVirus.Location = new System.Drawing.Point(790, 118);
            this.lTitleReportVirus.Name = "lTitleReportVirus";
            this.lTitleReportVirus.Size = new System.Drawing.Size(36, 15);
            this.lTitleReportVirus.TabIndex = 7;
            this.lTitleReportVirus.Text = "Угроз";
            // 
            // lTitleReportCountFile
            // 
            this.lTitleReportCountFile.AutoSize = true;
            this.lTitleReportCountFile.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportCountFile.Location = new System.Drawing.Point(680, 118);
            this.lTitleReportCountFile.Name = "lTitleReportCountFile";
            this.lTitleReportCountFile.Size = new System.Drawing.Size(111, 15);
            this.lTitleReportCountFile.TabIndex = 6;
            this.lTitleReportCountFile.Text = "Проверено файлов";
            // 
            // lTitleReportDir
            // 
            this.lTitleReportDir.AutoSize = true;
            this.lTitleReportDir.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lTitleReportDir.Location = new System.Drawing.Point(295, 120);
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
            this.pUpdate.Location = new System.Drawing.Point(1119, 298);
            this.pUpdate.Name = "pUpdate";
            this.pUpdate.Size = new System.Drawing.Size(62, 54);
            this.pUpdate.TabIndex = 13;
            this.pUpdate.Visible = false;
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
            this.MaximumSize = new System.Drawing.Size(1340, 600);
            this.MinimumSize = new System.Drawing.Size(940, 600);
            this.Name = "Form1";
            this.Text = "NW Antivirus";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pMonitoring.ResumeLayout(false);
            this.pMonitoring.PerformLayout();
            this.pEditAddMon.ResumeLayout(false);
            this.pEditAddMon.PerformLayout();
            this.pQuarantine.ResumeLayout(false);
            this.pQuarantine.PerformLayout();
            this.pReport.ResumeLayout(false);
            this.pReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
    }
}

