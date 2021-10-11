
using System;

namespace em7455_Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRtsEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.pbPort = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyBootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMinimized = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxSelectMode = new System.Windows.Forms.ComboBox();
            this.lblCSQsignal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbCSQsignal = new System.Windows.Forms.ProgressBar();
            this.lblCSQsgrade = new System.Windows.Forms.Label();
            this.pbCSQquality = new System.Windows.Forms.ProgressBar();
            this.lblCSQquality = new System.Windows.Forms.Label();
            this.lblCSQqgrade = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEARFCN = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTAC = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCELLID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblSNR = new System.Windows.Forms.Label();
            this.lblRSSI = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblRSRP = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblRSRQ = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblPCI = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblRSSIgrade = new System.Windows.Forms.Label();
            this.lblRSRPgrade = new System.Windows.Forms.Label();
            this.lblRSRQgrade = new System.Windows.Forms.Label();
            this.lblSNRgrade = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblNETmode = new System.Windows.Forms.Label();
            this.lblLTEca = new System.Windows.Forms.Label();
            this.lblLTEcaBW = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblBANDset2 = new System.Windows.Forms.Label();
            this.lblBANDset1 = new System.Windows.Forms.Label();
            this.btnSetBand = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tbBANDnumber = new System.Windows.Forms.TextBox();
            this.tbBandName = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblBandLN = new System.Windows.Forms.Label();
            this.lblBandWN = new System.Windows.Forms.Label();
            this.lblBandL = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chlbBand = new System.Windows.Forms.CheckedListBox();
            this.lblBandW = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblBITMASKset = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btnBitmask = new System.Windows.Forms.Button();
            this.tbBitmask = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.lblBitmask = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblBootPid = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblAppPid = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblFSN = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblImeiSV = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblMeid = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFW = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblVid = new System.Windows.Forms.Label();
            this.lblTempC = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblApn = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSimNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblImsi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSmsCentre = new System.Windows.Forms.Label();
            this.lblImei = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblDataInLenght = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.cBoxDataOut = new System.Windows.Forms.ComboBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLenght = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRtsEnable);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(407, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(251, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // chBoxRtsEnable
            // 
            this.chBoxRtsEnable.AutoSize = true;
            this.chBoxRtsEnable.Location = new System.Drawing.Point(137, 166);
            this.chBoxRtsEnable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chBoxRtsEnable.Name = "chBoxRtsEnable";
            this.chBoxRtsEnable.Size = new System.Drawing.Size(105, 21);
            this.chBoxRtsEnable.TabIndex = 11;
            this.chBoxRtsEnable.Text = "RTS enable";
            this.chBoxRtsEnable.UseVisualStyleBackColor = true;
            this.chBoxRtsEnable.CheckedChanged += new System.EventHandler(this.chBoxRtsEnable_CheckedChanged);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Location = new System.Drawing.Point(25, 166);
            this.chBoxDtrEnable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(106, 21);
            this.chBoxDtrEnable.TabIndex = 10;
            this.chBoxDtrEnable.Text = "DTR enable";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "parity bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "stop bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "data bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "com port";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(121, 135);
            this.cBoxParityBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(121, 106);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(121, 75);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(121, 46);
            this.cBoxBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.Text = "115200";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(121, 16);
            this.cBoxComPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(121, 24);
            this.cBoxComPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(407, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(251, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblStatusCom);
            this.groupBox8.Controls.Add(this.pbPort);
            this.groupBox8.Location = new System.Drawing.Point(87, 12);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(155, 60);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Status";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Monaco", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCom.Location = new System.Drawing.Point(57, 10);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(43, 22);
            this.lblStatusCom.TabIndex = 7;
            this.lblStatusCom.Text = "OFF";
            // 
            // pbPort
            // 
            this.pbPort.BackColor = System.Drawing.SystemColors.Control;
            this.pbPort.Location = new System.Drawing.Point(43, 34);
            this.pbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPort.Name = "pbPort";
            this.pbPort.Size = new System.Drawing.Size(69, 14);
            this.pbPort.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(5, 48);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(5, 20);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transmitterToolStripMenuItem,
            this.receiverToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(665, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.openLogFileToolStripMenuItem,
            this.clearLogFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Checked = true;
            this.saveToFileToolStripMenuItem.CheckOnClick = true;
            this.saveToFileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveToFileToolStripMenuItem.Text = "Save log to file";
            // 
            // openLogFileToolStripMenuItem
            // 
            this.openLogFileToolStripMenuItem.Name = "openLogFileToolStripMenuItem";
            this.openLogFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openLogFileToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openLogFileToolStripMenuItem.Text = "Open log file";
            this.openLogFileToolStripMenuItem.Click += new System.EventHandler(this.openLogFileToolStripMenuItem_Click);
            // 
            // clearLogFileToolStripMenuItem
            // 
            this.clearLogFileToolStripMenuItem.Name = "clearLogFileToolStripMenuItem";
            this.clearLogFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearLogFileToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.clearLogFileToolStripMenuItem.Text = "Clear log file";
            this.clearLogFileToolStripMenuItem.Click += new System.EventHandler(this.clearLogFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transmitterToolStripMenuItem
            // 
            this.transmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endLineToolStripMenuItem});
            this.transmitterToolStripMenuItem.Name = "transmitterToolStripMenuItem";
            this.transmitterToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.transmitterToolStripMenuItem.Text = "Transmitter";
            // 
            // endLineToolStripMenuItem
            // 
            this.endLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.endLineToolStripMenuItem.Name = "endLineToolStripMenuItem";
            this.endLineToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.endLineToolStripMenuItem.Text = "End Line";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "None",
            "Both",
            "New Line",
            "Carriage Return"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox2.DropDownClosed += new System.EventHandler(this.toolStripComboBox2_DropDownClosed);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.showDataWithToolStripMenuItem,
            this.positionToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // showDataWithToolStripMenuItem
            // 
            this.showDataWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.showDataWithToolStripMenuItem.Name = "showDataWithToolStripMenuItem";
            this.showDataWithToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.showDataWithToolStripMenuItem.Text = "Show data With";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Always update",
            "Add to old data"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.positionToolStripMenuItem.Text = "Position";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "Top",
            "Button"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 28);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoBootToolStripMenuItem,
            this.notifyBootToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // autoBootToolStripMenuItem
            // 
            this.autoBootToolStripMenuItem.Checked = true;
            this.autoBootToolStripMenuItem.CheckOnClick = true;
            this.autoBootToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoBootToolStripMenuItem.Name = "autoBootToolStripMenuItem";
            this.autoBootToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoBootToolStripMenuItem.Text = "Auto boot";
            this.autoBootToolStripMenuItem.CheckedChanged += new System.EventHandler(this.autoBootToolStripMenuItem_CheckedChanged);
            // 
            // notifyBootToolStripMenuItem
            // 
            this.notifyBootToolStripMenuItem.Checked = true;
            this.notifyBootToolStripMenuItem.CheckOnClick = true;
            this.notifyBootToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyBootToolStripMenuItem.Name = "notifyBootToolStripMenuItem";
            this.notifyBootToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.notifyBootToolStripMenuItem.Text = "Notify boot";
            this.notifyBootToolStripMenuItem.CheckedChanged += new System.EventHandler(this.notifyBootToolStripMenuItem_CheckedChanged);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblMinimized
            // 
            this.lblMinimized.AutoSize = true;
            this.lblMinimized.BackColor = System.Drawing.Color.White;
            this.lblMinimized.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinimized.Location = new System.Drawing.Point(601, 1);
            this.lblMinimized.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimized.Name = "lblMinimized";
            this.lblMinimized.Size = new System.Drawing.Size(21, 22);
            this.lblMinimized.TabIndex = 8;
            this.lblMinimized.Text = "_";
            this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
            this.lblMinimized.MouseEnter += new System.EventHandler(this.lblMinimized_MouseEnter);
            this.lblMinimized.MouseLeave += new System.EventHandler(this.lblMinimized_MouseLeave);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.White;
            this.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExit.Location = new System.Drawing.Point(633, 1);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 22);
            this.lblExit.TabIndex = 9;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBoxSelectMode);
            this.groupBox3.Location = new System.Drawing.Point(0, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(176, 52);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select mode";
            // 
            // cBoxSelectMode
            // 
            this.cBoxSelectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSelectMode.FormattingEnabled = true;
            this.cBoxSelectMode.Items.AddRange(new object[] {
            "Monitor",
            "Terminal"});
            this.cBoxSelectMode.Location = new System.Drawing.Point(8, 20);
            this.cBoxSelectMode.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxSelectMode.Name = "cBoxSelectMode";
            this.cBoxSelectMode.Size = new System.Drawing.Size(160, 24);
            this.cBoxSelectMode.TabIndex = 14;
            this.cBoxSelectMode.DropDownClosed += new System.EventHandler(this.cBoxSelectMode_DropDownClosed);
            // 
            // lblCSQsignal
            // 
            this.lblCSQsignal.AutoSize = true;
            this.lblCSQsignal.Location = new System.Drawing.Point(89, 272);
            this.lblCSQsignal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCSQsignal.Name = "lblCSQsignal";
            this.lblCSQsignal.Size = new System.Drawing.Size(34, 17);
            this.lblCSQsignal.TabIndex = 17;
            this.lblCSQsignal.Text = "sign";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "CSQ";
            // 
            // pbCSQsignal
            // 
            this.pbCSQsignal.BackColor = System.Drawing.SystemColors.Control;
            this.pbCSQsignal.Location = new System.Drawing.Point(124, 274);
            this.pbCSQsignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCSQsignal.Maximum = 31;
            this.pbCSQsignal.Name = "pbCSQsignal";
            this.pbCSQsignal.Size = new System.Drawing.Size(69, 14);
            this.pbCSQsignal.Step = 1;
            this.pbCSQsignal.TabIndex = 8;
            // 
            // lblCSQsgrade
            // 
            this.lblCSQsgrade.AutoSize = true;
            this.lblCSQsgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCSQsgrade.Location = new System.Drawing.Point(199, 272);
            this.lblCSQsgrade.Name = "lblCSQsgrade";
            this.lblCSQsgrade.Size = new System.Drawing.Size(52, 17);
            this.lblCSQsgrade.TabIndex = 22;
            this.lblCSQsgrade.Text = "sgrade";
            // 
            // pbCSQquality
            // 
            this.pbCSQquality.BackColor = System.Drawing.SystemColors.Control;
            this.pbCSQquality.Location = new System.Drawing.Point(124, 290);
            this.pbCSQquality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCSQquality.Maximum = 7;
            this.pbCSQquality.Name = "pbCSQquality";
            this.pbCSQquality.Size = new System.Drawing.Size(69, 14);
            this.pbCSQquality.Step = 1;
            this.pbCSQquality.TabIndex = 23;
            // 
            // lblCSQquality
            // 
            this.lblCSQquality.AutoSize = true;
            this.lblCSQquality.Location = new System.Drawing.Point(89, 287);
            this.lblCSQquality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCSQquality.Name = "lblCSQquality";
            this.lblCSQquality.Size = new System.Drawing.Size(35, 17);
            this.lblCSQquality.TabIndex = 24;
            this.lblCSQquality.Text = "qual";
            // 
            // lblCSQqgrade
            // 
            this.lblCSQqgrade.AutoSize = true;
            this.lblCSQqgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCSQqgrade.Location = new System.Drawing.Point(199, 287);
            this.lblCSQqgrade.Name = "lblCSQqgrade";
            this.lblCSQqgrade.Size = new System.Drawing.Size(53, 17);
            this.lblCSQqgrade.TabIndex = 25;
            this.lblCSQqgrade.Text = "qgrade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "EARFCN";
            // 
            // lblEARFCN
            // 
            this.lblEARFCN.AutoSize = true;
            this.lblEARFCN.Location = new System.Drawing.Point(85, 117);
            this.lblEARFCN.Name = "lblEARFCN";
            this.lblEARFCN.Size = new System.Drawing.Size(48, 17);
            this.lblEARFCN.TabIndex = 27;
            this.lblEARFCN.Text = "earfcn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "TAC";
            // 
            // lblTAC
            // 
            this.lblTAC.AutoSize = true;
            this.lblTAC.Location = new System.Drawing.Point(85, 134);
            this.lblTAC.Name = "lblTAC";
            this.lblTAC.Size = new System.Drawing.Size(27, 17);
            this.lblTAC.TabIndex = 29;
            this.lblTAC.Text = "tac";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "Cell ID";
            // 
            // lblCELLID
            // 
            this.lblCELLID.AutoSize = true;
            this.lblCELLID.Location = new System.Drawing.Point(85, 152);
            this.lblCELLID.Name = "lblCELLID";
            this.lblCELLID.Size = new System.Drawing.Size(40, 17);
            this.lblCELLID.TabIndex = 31;
            this.lblCELLID.Text = "cellid";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 236);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 17);
            this.label24.TabIndex = 32;
            this.label24.Text = "SNR";
            // 
            // lblSNR
            // 
            this.lblSNR.AutoSize = true;
            this.lblSNR.Location = new System.Drawing.Point(89, 236);
            this.lblSNR.Name = "lblSNR";
            this.lblSNR.Size = new System.Drawing.Size(28, 17);
            this.lblSNR.TabIndex = 33;
            this.lblSNR.Text = "snr";
            // 
            // lblRSSI
            // 
            this.lblRSSI.AutoSize = true;
            this.lblRSSI.Location = new System.Drawing.Point(85, 254);
            this.lblRSSI.Name = "lblRSSI";
            this.lblRSSI.Size = new System.Drawing.Size(30, 17);
            this.lblRSSI.TabIndex = 41;
            this.lblRSSI.Text = "rssi";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 254);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 17);
            this.label30.TabIndex = 40;
            this.label30.Text = "RSSI";
            // 
            // lblRSRP
            // 
            this.lblRSRP.AutoSize = true;
            this.lblRSRP.Location = new System.Drawing.Point(85, 218);
            this.lblRSRP.Name = "lblRSRP";
            this.lblRSRP.Size = new System.Drawing.Size(33, 17);
            this.lblRSRP.TabIndex = 39;
            this.lblRSRP.Text = "rsrp";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 218);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 17);
            this.label34.TabIndex = 38;
            this.label34.Text = "RSRP";
            // 
            // lblRSRQ
            // 
            this.lblRSRQ.AutoSize = true;
            this.lblRSRQ.Location = new System.Drawing.Point(85, 199);
            this.lblRSRQ.Name = "lblRSRQ";
            this.lblRSRQ.Size = new System.Drawing.Size(33, 17);
            this.lblRSRQ.TabIndex = 37;
            this.lblRSRQ.Text = "rsrq";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(19, 199);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 17);
            this.label38.TabIndex = 36;
            this.label38.Text = "RSRQ";
            // 
            // lblPCI
            // 
            this.lblPCI.AutoSize = true;
            this.lblPCI.Location = new System.Drawing.Point(85, 169);
            this.lblPCI.Name = "lblPCI";
            this.lblPCI.Size = new System.Drawing.Size(26, 17);
            this.lblPCI.TabIndex = 35;
            this.lblPCI.Text = "pci";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(19, 169);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(29, 17);
            this.label40.TabIndex = 34;
            this.label40.Text = "PCI";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(145, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "dBm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(145, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 17);
            this.label18.TabIndex = 44;
            this.label18.Text = "dBm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(145, 199);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 17);
            this.label22.TabIndex = 43;
            this.label22.Text = "dB";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(145, 236);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 17);
            this.label26.TabIndex = 42;
            this.label26.Text = "dB";
            // 
            // lblRSSIgrade
            // 
            this.lblRSSIgrade.AutoSize = true;
            this.lblRSSIgrade.Location = new System.Drawing.Point(198, 254);
            this.lblRSSIgrade.Name = "lblRSSIgrade";
            this.lblRSSIgrade.Size = new System.Drawing.Size(76, 17);
            this.lblRSSIgrade.TabIndex = 49;
            this.lblRSSIgrade.Text = "RSSIgrade";
            // 
            // lblRSRPgrade
            // 
            this.lblRSRPgrade.AutoSize = true;
            this.lblRSRPgrade.Location = new System.Drawing.Point(198, 218);
            this.lblRSRPgrade.Name = "lblRSRPgrade";
            this.lblRSRPgrade.Size = new System.Drawing.Size(83, 17);
            this.lblRSRPgrade.TabIndex = 48;
            this.lblRSRPgrade.Text = "RSRPgrade";
            // 
            // lblRSRQgrade
            // 
            this.lblRSRQgrade.AutoSize = true;
            this.lblRSRQgrade.Location = new System.Drawing.Point(198, 199);
            this.lblRSRQgrade.Name = "lblRSRQgrade";
            this.lblRSRQgrade.Size = new System.Drawing.Size(85, 17);
            this.lblRSRQgrade.TabIndex = 47;
            this.lblRSRQgrade.Text = "RSRQgrade";
            // 
            // lblSNRgrade
            // 
            this.lblSNRgrade.AutoSize = true;
            this.lblSNRgrade.Location = new System.Drawing.Point(198, 236);
            this.lblSNRgrade.Name = "lblSNRgrade";
            this.lblSNRgrade.Size = new System.Drawing.Size(74, 17);
            this.lblSNRgrade.TabIndex = 46;
            this.lblSNRgrade.Text = "SNRgrade";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 93);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 17);
            this.label28.TabIndex = 50;
            this.label28.Text = "Net mode";
            // 
            // lblNETmode
            // 
            this.lblNETmode.AutoSize = true;
            this.lblNETmode.Location = new System.Drawing.Point(85, 93);
            this.lblNETmode.Name = "lblNETmode";
            this.lblNETmode.Size = new System.Drawing.Size(71, 17);
            this.lblNETmode.TabIndex = 51;
            this.lblNETmode.Text = "NETmode";
            // 
            // lblLTEca
            // 
            this.lblLTEca.AutoSize = true;
            this.lblLTEca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLTEca.Location = new System.Drawing.Point(270, 117);
            this.lblLTEca.Name = "lblLTEca";
            this.lblLTEca.Size = new System.Drawing.Size(49, 17);
            this.lblLTEca.TabIndex = 52;
            this.lblLTEca.Text = "LTEca";
            // 
            // lblLTEcaBW
            // 
            this.lblLTEcaBW.AutoSize = true;
            this.lblLTEcaBW.Location = new System.Drawing.Point(270, 134);
            this.lblLTEcaBW.Name = "lblLTEcaBW";
            this.lblLTEcaBW.Size = new System.Drawing.Size(126, 17);
            this.lblLTEcaBW.TabIndex = 54;
            this.lblLTEcaBW.Text = "B13(15) + B20(10)";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(199, 125);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(56, 17);
            this.label36.TabIndex = 55;
            this.label36.Text = "LTE CA";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblBANDset2);
            this.tabPage1.Controls.Add(this.lblBANDset1);
            this.tabPage1.Controls.Add(this.btnSetBand);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.tbBANDnumber);
            this.tabPage1.Controls.Add(this.tbBandName);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.lblBandLN);
            this.tabPage1.Controls.Add(this.lblBandWN);
            this.tabPage1.Controls.Add(this.lblBandL);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.lblBandW);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(647, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Band";
            // 
            // lblBANDset2
            // 
            this.lblBANDset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBANDset2.Location = new System.Drawing.Point(298, 219);
            this.lblBANDset2.Name = "lblBANDset2";
            this.lblBANDset2.Size = new System.Drawing.Size(339, 23);
            this.lblBANDset2.TabIndex = 64;
            this.lblBANDset2.Text = "atBANDset";
            this.lblBANDset2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBANDset1
            // 
            this.lblBANDset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBANDset1.Location = new System.Drawing.Point(298, 196);
            this.lblBANDset1.Name = "lblBANDset1";
            this.lblBANDset1.Size = new System.Drawing.Size(339, 23);
            this.lblBANDset1.TabIndex = 63;
            this.lblBANDset1.Text = "atBANDset";
            this.lblBANDset1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetBand
            // 
            this.btnSetBand.Location = new System.Drawing.Point(500, 123);
            this.btnSetBand.Name = "btnSetBand";
            this.btnSetBand.Size = new System.Drawing.Size(75, 23);
            this.btnSetBand.TabIndex = 62;
            this.btnSetBand.Text = "Set Band";
            this.btnSetBand.UseVisualStyleBackColor = true;
            this.btnSetBand.Click += new System.EventHandler(this.btnSetBand_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(304, 140);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(58, 17);
            this.label42.TabIndex = 61;
            this.label42.Text = "Number";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(304, 111);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(45, 17);
            this.label41.TabIndex = 60;
            this.label41.Text = "Name";
            // 
            // tbBANDnumber
            // 
            this.tbBANDnumber.Location = new System.Drawing.Point(376, 137);
            this.tbBANDnumber.Name = "tbBANDnumber";
            this.tbBANDnumber.Size = new System.Drawing.Size(100, 22);
            this.tbBANDnumber.TabIndex = 59;
            this.tbBANDnumber.Text = "0A";
            this.tbBANDnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBANDnumber.TextChanged += new System.EventHandler(this.tbBANDnumber_TextChanged);
            // 
            // tbBandName
            // 
            this.tbBandName.Location = new System.Drawing.Point(376, 108);
            this.tbBandName.Name = "tbBandName";
            this.tbBandName.Size = new System.Drawing.Size(100, 22);
            this.tbBandName.TabIndex = 56;
            this.tbBandName.Text = "MyBand";
            this.tbBandName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBandName.TextChanged += new System.EventHandler(this.tbBandName_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(301, 58);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(39, 17);
            this.label39.TabIndex = 58;
            this.label39.Text = "New:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(301, 41);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 17);
            this.label32.TabIndex = 57;
            this.label32.Text = "Old:";
            // 
            // lblBandLN
            // 
            this.lblBandLN.Location = new System.Drawing.Point(500, 58);
            this.lblBandLN.Name = "lblBandLN";
            this.lblBandLN.Size = new System.Drawing.Size(137, 17);
            this.lblBandLN.TabIndex = 56;
            this.lblBandLN.Text = "bandLN";
            this.lblBandLN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBandWN
            // 
            this.lblBandWN.Location = new System.Drawing.Point(343, 58);
            this.lblBandWN.Name = "lblBandWN";
            this.lblBandWN.Size = new System.Drawing.Size(137, 17);
            this.lblBandWN.TabIndex = 55;
            this.lblBandWN.Text = "bandWN";
            this.lblBandWN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBandL
            // 
            this.lblBandL.AutoSize = true;
            this.lblBandL.Location = new System.Drawing.Point(497, 41);
            this.lblBandL.Name = "lblBandL";
            this.lblBandL.Size = new System.Drawing.Size(43, 17);
            this.lblBandL.TabIndex = 54;
            this.lblBandL.Text = "bandl";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chlbBand);
            this.groupBox5.Location = new System.Drawing.Point(8, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(283, 321);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // chlbBand
            // 
            this.chlbBand.BackColor = System.Drawing.SystemColors.Control;
            this.chlbBand.FormattingEnabled = true;
            this.chlbBand.Items.AddRange(new object[] {
            "LTE B1  (2100  MHz)",
            "LTE B2  (1900  MHz)",
            "LTE B3  (1800  MHz)",
            "LTE B4  (2100  MHz)",
            "LTE B5  (850    MHz)",
            "LTE B7  (2600  MHz)",
            "LTE B8  (900    MHz)",
            "LTE B12 (700   MHz)",
            "LTE B13 (700   MHz)",
            "LTE B20 (800   MHz)",
            "LTE B25 (1900 MHz)",
            "LTE B26 (850   MHz)",
            "LTE B41 (2500 MHz)",
            "UMTS/HSPA B1 (2100 MHz)",
            "UMTS/HSPA B2 (1900 MHz)",
            "UMTS/HSPA B3 (1700 MHz)",
            "UMTS/HSPA B4 (1700 MHz)",
            "UMTS/HSPA B5 (850   MHz)",
            "UMTS/HSPA B8 (900   MHz)"});
            this.chlbBand.Location = new System.Drawing.Point(7, 20);
            this.chlbBand.Margin = new System.Windows.Forms.Padding(4);
            this.chlbBand.Name = "chlbBand";
            this.chlbBand.Size = new System.Drawing.Size(267, 293);
            this.chlbBand.TabIndex = 0;
            this.chlbBand.SelectedIndexChanged += new System.EventHandler(this.chlbBand_SelectedIndexChanged);
            // 
            // lblBandW
            // 
            this.lblBandW.AutoSize = true;
            this.lblBandW.Location = new System.Drawing.Point(341, 41);
            this.lblBandW.Name = "lblBandW";
            this.lblBandW.Size = new System.Drawing.Size(49, 17);
            this.lblBandW.TabIndex = 53;
            this.lblBandW.Text = "bandw";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(647, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.lblBitmask);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.lblRevision);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.lblBootPid);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.lblAppPid);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.lblFSN);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.lblImeiSV);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.lblMeid);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.lblModel);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lblFW);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblVid);
            this.groupBox4.Controls.Add(this.lblTempC);
            this.groupBox4.Controls.Add(this.lblVoltage);
            this.groupBox4.Controls.Add(this.lblApn);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblOperator);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblSimNumber);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblImsi);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblSmsCentre);
            this.groupBox4.Controls.Add(this.lblImei);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(9, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(628, 320);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblBITMASKset);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.btnBitmask);
            this.groupBox6.Controls.Add(this.tbBitmask);
            this.groupBox6.Location = new System.Drawing.Point(277, 104);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 144);
            this.groupBox6.TabIndex = 53;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Set bitmask";
            // 
            // lblBITMASKset
            // 
            this.lblBITMASKset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBITMASKset.Location = new System.Drawing.Point(9, 111);
            this.lblBITMASKset.Name = "lblBITMASKset";
            this.lblBITMASKset.Size = new System.Drawing.Size(317, 23);
            this.lblBITMASKset.TabIndex = 65;
            this.lblBITMASKset.Text = "atBITMASKset";
            this.lblBITMASKset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(11, 55);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(312, 49);
            this.label43.TabIndex = 67;
            this.label43.Text = "diag      -  0001   nmea    - 0004\r\nmodem -  0008    rmnet0 - 0100\r\nrmnet     - 0" +
    "400    mbim   - 1000";
            // 
            // btnBitmask
            // 
            this.btnBitmask.Location = new System.Drawing.Point(139, 21);
            this.btnBitmask.Name = "btnBitmask";
            this.btnBitmask.Size = new System.Drawing.Size(64, 23);
            this.btnBitmask.TabIndex = 66;
            this.btnBitmask.Text = "Set";
            this.btnBitmask.UseVisualStyleBackColor = true;
            this.btnBitmask.Click += new System.EventHandler(this.btnBitmask_Click);
            // 
            // tbBitmask
            // 
            this.tbBitmask.Location = new System.Drawing.Point(14, 22);
            this.tbBitmask.Name = "tbBitmask";
            this.tbBitmask.Size = new System.Drawing.Size(105, 22);
            this.tbBitmask.TabIndex = 65;
            this.tbBitmask.Text = "bitmask";
            this.tbBitmask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBitmask.TextChanged += new System.EventHandler(this.tbBitmask_TextChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(283, 84);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 17);
            this.label37.TabIndex = 52;
            this.label37.Text = "Bitmask";
            // 
            // lblBitmask
            // 
            this.lblBitmask.AutoSize = true;
            this.lblBitmask.Location = new System.Drawing.Point(345, 84);
            this.lblBitmask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitmask.Name = "lblBitmask";
            this.lblBitmask.Size = new System.Drawing.Size(56, 17);
            this.lblBitmask.TabIndex = 51;
            this.lblBitmask.Text = "bitmask";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(17, 135);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 17);
            this.label35.TabIndex = 50;
            this.label35.Text = "Revision";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(109, 135);
            this.lblRevision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(57, 17);
            this.lblRevision.TabIndex = 49;
            this.lblRevision.Text = "revision";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(283, 68);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 17);
            this.label33.TabIndex = 48;
            this.label33.Text = "BootPID";
            // 
            // lblBootPid
            // 
            this.lblBootPid.AutoSize = true;
            this.lblBootPid.Location = new System.Drawing.Point(345, 68);
            this.lblBootPid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBootPid.Name = "lblBootPid";
            this.lblBootPid.Size = new System.Drawing.Size(55, 17);
            this.lblBootPid.TabIndex = 47;
            this.lblBootPid.Text = "bootpid";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(283, 52);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 17);
            this.label31.TabIndex = 46;
            this.label31.Text = "AppPID";
            // 
            // lblAppPid
            // 
            this.lblAppPid.AutoSize = true;
            this.lblAppPid.Location = new System.Drawing.Point(345, 52);
            this.lblAppPid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppPid.Name = "lblAppPid";
            this.lblAppPid.Size = new System.Drawing.Size(51, 17);
            this.lblAppPid.TabIndex = 45;
            this.lblAppPid.Text = "apppid";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 100);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 17);
            this.label29.TabIndex = 44;
            this.label29.Text = "FSN";
            // 
            // lblFSN
            // 
            this.lblFSN.AutoSize = true;
            this.lblFSN.Location = new System.Drawing.Point(109, 100);
            this.lblFSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFSN.Name = "lblFSN";
            this.lblFSN.Size = new System.Drawing.Size(27, 17);
            this.lblFSN.TabIndex = 43;
            this.lblFSN.Text = "fsn";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 84);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 17);
            this.label27.TabIndex = 42;
            this.label27.Text = "IMEI SV";
            // 
            // lblImeiSV
            // 
            this.lblImeiSV.AutoSize = true;
            this.lblImeiSV.Location = new System.Drawing.Point(109, 84);
            this.lblImeiSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImeiSV.Name = "lblImeiSV";
            this.lblImeiSV.Size = new System.Drawing.Size(51, 17);
            this.lblImeiSV.TabIndex = 41;
            this.lblImeiSV.Text = "imei sv";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 36);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 17);
            this.label25.TabIndex = 40;
            this.label25.Text = "MEID";
            // 
            // lblMeid
            // 
            this.lblMeid.AutoSize = true;
            this.lblMeid.Location = new System.Drawing.Point(109, 36);
            this.lblMeid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeid.Name = "lblMeid";
            this.lblMeid.Size = new System.Drawing.Size(38, 17);
            this.lblMeid.TabIndex = 39;
            this.lblMeid.Text = "meid";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 20);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 17);
            this.label23.TabIndex = 38;
            this.label23.Text = "Model";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(109, 20);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 37;
            this.lblModel.Text = "model";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 263);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 17);
            this.label21.TabIndex = 36;
            this.label21.Text = "Firmware";
            // 
            // lblFW
            // 
            this.lblFW.AutoSize = true;
            this.lblFW.Location = new System.Drawing.Point(109, 263);
            this.lblFW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFW.Name = "lblFW";
            this.lblFW.Size = new System.Drawing.Size(61, 17);
            this.lblFW.TabIndex = 35;
            this.lblFW.Text = "firmware";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(283, 36);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 17);
            this.label19.TabIndex = 34;
            this.label19.Text = "VID";
            // 
            // lblVid
            // 
            this.lblVid.AutoSize = true;
            this.lblVid.Location = new System.Drawing.Point(345, 36);
            this.lblVid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVid.Name = "lblVid";
            this.lblVid.Size = new System.Drawing.Size(26, 17);
            this.lblVid.TabIndex = 33;
            this.lblVid.Text = "vid";
            // 
            // lblTempC
            // 
            this.lblTempC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTempC.Location = new System.Drawing.Point(17, 283);
            this.lblTempC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempC.Name = "lblTempC";
            this.lblTempC.Size = new System.Drawing.Size(583, 16);
            this.lblTempC.TabIndex = 32;
            this.lblTempC.Text = "temperature";
            this.lblTempC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVoltage
            // 
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVoltage.Location = new System.Drawing.Point(17, 299);
            this.lblVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(583, 17);
            this.lblVoltage.TabIndex = 31;
            this.lblVoltage.Text = "voltage";
            this.lblVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApn
            // 
            this.lblApn.AutoSize = true;
            this.lblApn.Location = new System.Drawing.Point(109, 231);
            this.lblApn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApn.Name = "lblApn";
            this.lblApn.Size = new System.Drawing.Size(32, 17);
            this.lblApn.TabIndex = 30;
            this.lblApn.Text = "apn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 231);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "APN";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(109, 199);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(62, 17);
            this.lblOperator.TabIndex = 28;
            this.lblOperator.Text = "operator";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 199);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Operator";
            // 
            // lblSimNumber
            // 
            this.lblSimNumber.AutoSize = true;
            this.lblSimNumber.Location = new System.Drawing.Point(109, 183);
            this.lblSimNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimNumber.Name = "lblSimNumber";
            this.lblSimNumber.Size = new System.Drawing.Size(81, 17);
            this.lblSimNumber.TabIndex = 26;
            this.lblSimNumber.Text = "SimNumber";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 183);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "SIM number";
            // 
            // lblImsi
            // 
            this.lblImsi.AutoSize = true;
            this.lblImsi.Location = new System.Drawing.Point(109, 52);
            this.lblImsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImsi.Name = "lblImsi";
            this.lblImsi.Size = new System.Drawing.Size(32, 17);
            this.lblImsi.TabIndex = 24;
            this.lblImsi.Text = "Imsi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "IMSI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "SMS Centre";
            // 
            // lblSmsCentre
            // 
            this.lblSmsCentre.AutoSize = true;
            this.lblSmsCentre.Location = new System.Drawing.Point(109, 215);
            this.lblSmsCentre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSmsCentre.Name = "lblSmsCentre";
            this.lblSmsCentre.Size = new System.Drawing.Size(77, 17);
            this.lblSmsCentre.TabIndex = 21;
            this.lblSmsCentre.Text = "SmsCentre";
            // 
            // lblImei
            // 
            this.lblImei.AutoSize = true;
            this.lblImei.Location = new System.Drawing.Point(109, 68);
            this.lblImei.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImei.Name = "lblImei";
            this.lblImei.Size = new System.Drawing.Size(33, 17);
            this.lblImei.TabIndex = 10;
            this.lblImei.Text = "Imei";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "IMEI";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(647, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Terminal";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblDataInLenght);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Location = new System.Drawing.Point(321, 284);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Size = new System.Drawing.Size(140, 39);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            // 
            // lblDataInLenght
            // 
            this.lblDataInLenght.AutoSize = true;
            this.lblDataInLenght.Location = new System.Drawing.Point(88, 18);
            this.lblDataInLenght.Name = "lblDataInLenght";
            this.lblDataInLenght.Size = new System.Drawing.Size(24, 17);
            this.lblDataInLenght.TabIndex = 6;
            this.lblDataInLenght.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "IN lenght:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tBoxDataIn);
            this.groupBox12.Controls.Add(this.cBoxDataOut);
            this.groupBox12.Controls.Add(this.btnSendData);
            this.groupBox12.Location = new System.Drawing.Point(4, 4);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(636, 281);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Font = new System.Drawing.Font("Monaco", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDataIn.Location = new System.Drawing.Point(7, 53);
            this.tBoxDataIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIn.Size = new System.Drawing.Size(621, 221);
            this.tBoxDataIn.TabIndex = 6;
            this.tBoxDataIn.WordWrap = false;
            // 
            // cBoxDataOut
            // 
            this.cBoxDataOut.FormattingEnabled = true;
            this.cBoxDataOut.Location = new System.Drawing.Point(7, 19);
            this.cBoxDataOut.Name = "cBoxDataOut";
            this.cBoxDataOut.Size = new System.Drawing.Size(546, 24);
            this.cBoxDataOut.TabIndex = 56;
            this.cBoxDataOut.Text = "at";
            this.cBoxDataOut.TextChanged += new System.EventHandler(this.cBoxDataOut_TextChanged);
            this.cBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBoxDataOut_KeyDown);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(559, 18);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(71, 25);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLenght);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(191, 284);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(120, 39);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // lblDataOutLenght
            // 
            this.lblDataOutLenght.AutoSize = true;
            this.lblDataOutLenght.Location = new System.Drawing.Point(89, 18);
            this.lblDataOutLenght.Name = "lblDataOutLenght";
            this.lblDataOutLenght.Size = new System.Drawing.Size(24, 17);
            this.lblDataOutLenght.TabIndex = 6;
            this.lblDataOutLenght.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "OUT lenght:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(7, 309);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(655, 368);
            this.tabControl.TabIndex = 19;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(665, 681);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.lblLTEcaBW);
            this.Controls.Add(this.lblLTEca);
            this.Controls.Add(this.lblNETmode);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblRSSIgrade);
            this.Controls.Add(this.lblRSRPgrade);
            this.Controls.Add(this.lblRSRQgrade);
            this.Controls.Add(this.lblSNRgrade);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblRSSI);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lblRSRP);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.lblRSRQ);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.lblPCI);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.lblSNR);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblCELLID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblTAC);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblEARFCN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblCSQqgrade);
            this.Controls.Add(this.lblCSQquality);
            this.Controls.Add(this.pbCSQquality);
            this.Controls.Add(this.lblCSQsgrade);
            this.Controls.Add(this.pbCSQsignal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblCSQsignal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblMinimized);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "em7455 Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pbPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRtsEnable;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDataWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxSelectMode;
        private System.Windows.Forms.Label lblCSQsignal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pbCSQsignal;
        private System.Windows.Forms.Label lblCSQsgrade;
        private System.Windows.Forms.ProgressBar pbCSQquality;
        private System.Windows.Forms.Label lblCSQquality;
        private System.Windows.Forms.Label lblCSQqgrade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEARFCN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTAC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblCELLID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblSNR;
        private System.Windows.Forms.Label lblRSSI;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblRSRP;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblRSRQ;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblPCI;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblRSSIgrade;
        private System.Windows.Forms.Label lblRSRPgrade;
        private System.Windows.Forms.Label lblRSRQgrade;
        private System.Windows.Forms.Label lblSNRgrade;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblNETmode;
        private System.Windows.Forms.Label lblLTEca;
        private System.Windows.Forms.Label lblLTEcaBW;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblBANDset2;
        private System.Windows.Forms.Label lblBANDset1;
        private System.Windows.Forms.Button btnSetBand;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbBANDnumber;
        private System.Windows.Forms.TextBox tbBandName;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblBandLN;
        private System.Windows.Forms.Label lblBandWN;
        private System.Windows.Forms.Label lblBandL;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox chlbBand;
        private System.Windows.Forms.Label lblBandW;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblBitmask;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblBootPid;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblAppPid;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblFSN;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblImeiSV;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblMeid;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFW;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblVid;
        private System.Windows.Forms.Label lblTempC;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblApn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSimNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblImsi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSmsCentre;
        private System.Windows.Forms.Label lblImei;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblDataInLenght;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblDataOutLenght;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBitmask;
        private System.Windows.Forms.TextBox tbBitmask;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lblBITMASKset;
        private System.Windows.Forms.ComboBox cBoxDataOut;
        private System.Windows.Forms.ToolStripMenuItem clearLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoBootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyBootToolStripMenuItem;
    }
}

