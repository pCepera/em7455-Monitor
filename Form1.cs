using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
//using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace em7455_Monitor
{
    public partial class Form1 : Form
    {
        #region Объявление переменных
        string dataOUT;
        string sendWith;
        string dataIN;
        Point lastPoint;
        string dataFirstPacket;

        //log at-command @ terminal
        StreamWriter objStreamWriterAT, objStreamWriterOUT;
        string pathATcom, pathOUTcom;
        string[] atComLog;

        //informations
        string dataImei, dataImsi, dataSimN, dataOperator, dataApn, dataTempC, dataVoltage;
        string dataFW, dataATI, dataModel, dataMeid, dataImeiSV, dataFSN, dataProduct, dataVid, dataAppPid, dataBootPid;
        string dataSmsCentre, dataRevision, dataBitmask;

        //monitor
        private readonly string[] separatingStrings = { " " };
        string dataCSQ, dataCSQsignal, dataCSQquality; int dataCSQsint, dataCSQqint;
        string dataLTEinfo, dataEARFCN, dataTAC, dataCellID, dataSNR, dataPCI, dataRSRQ, dataRSRP, dataRSSI;
        double dataRSRQint, dataRSRPint, dataRSSIint; int dataSNRint;
        string dataNETmode, dataNETstatus, dataLTEca, dataB1, dataB1bw, dataB1v, dataB2, dataB2bw, dataB2v;

        //band
        string dataBand, dataBandW, dataBandL, dataBandWN, dataBandLN, dataBandSet;
        string dataBandSet1, dataBandSet2;

        //autoboot & notifyboot
        StreamWriter objStreamWriterSETini;
        string pathSETini, autoBOOT, notifyBOOT, comBOOT;
        string[] SETini;

        string selectMode;
        #endregion
        public Form1()
        {
            InitializeComponent();
            this.Icon = em7455_Monitor.Properties.Resources.icon;
        }
        #region Начальные установки
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;
            sendWith = "Both";
            toolStripComboBox3.Text = "Top";

            toolStripComboBox1.Text = "Add to old data";
            toolStripComboBox2.Text = "Both";

            selectMode = "Monitor";
            cBoxSelectMode.Text = "Monitor";
            cBoxDataOut.Enabled = false;

            lblCSQsgrade.Text = ""; lblCSQqgrade.Text = ""; lblCSQsignal.Text = ""; lblCSQquality.Text = "";
            lblRSRQgrade.Text = ""; lblRSRPgrade.Text = ""; lblRSSIgrade.Text = ""; lblSNRgrade.Text = "";
            lblNETmode.Text = "";
            lblLTEca.Text = ""; lblLTEcaBW.Text = "";
            lblBandL.Text = ""; lblBandLN.Text = "";
            lblBandW.Text = ""; lblBandWN.Text = "";
            tbBandName.Text = "MyBand"; tbBANDnumber.Text = "0A";
            lblBANDset1.Text = ""; lblBANDset2.Text = "";
            lblBITMASKset.Text = "";

            notifyIcon1.Text = "please open com-port...";
            notifyIcon1.Icon = Properties.Resources.sn;

            pathATcom = System.IO.Directory.GetCurrentDirectory() + @"\log_at.txt";
            pathOUTcom = System.IO.Directory.GetCurrentDirectory() + @"\log_out.txt";
            // вывод набора АТ команд из лога в строку ввода
            atComLog = System.IO.File.ReadAllLines(pathATcom);
            cBoxDataOut.Items.AddRange(atComLog);
            saveToFileToolStripMenuItem.Checked = false;

            pathSETini = System.IO.Directory.GetCurrentDirectory() + @"\settings.ini";
            autoBOOT = File.ReadLines(pathSETini).Skip(1).First(); autoBOOT = autoBOOT.Split('=')[1].Trim();
            notifyBOOT = File.ReadLines(pathSETini).Skip(2).First(); notifyBOOT = notifyBOOT.Split('=')[1].Trim();
            comBOOT = File.ReadLines(pathSETini).Skip(3).First(); comBOOT = comBOOT.Split('=')[1].Trim();
            autoBootToolStripMenuItem.Checked = Convert.ToBoolean(autoBOOT);
            notifyBootToolStripMenuItem.Checked = Convert.ToBoolean(notifyBOOT);
            // Проверить чек авто-трея, если выбран - запустить свернутым
            if(Convert.ToBoolean(notifyBOOT) == true)
            {
                WindowState = FormWindowState.Minimized;
                //минимизация в трей
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.ShowInTaskbar = false;
                    notifyIcon1.Visible = true;
                }
            }
            cBoxComPort.Text = comBOOT;
        }
        #endregion
        #region Открытие/Закрытие порта, настройка значений порта, формирование исходящих пакетов
        // кнопка открытия порта
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                selectMode = "Monitor";

                serialPort1.Open();

                pbPort.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblStatusCom.Text = "ON";
                serialPort1.Write("AT" + "\r\n");

                // Запись в файл настроек выбранного ком порта
                string SETiniN = string.Empty;
                using (System.IO.StreamReader reader = System.IO.File.OpenText(pathSETini))
                {
                    SETiniN = reader.ReadToEnd();
                }
                    SETiniN = Regex.Replace(SETiniN, @"(comport)(.*?)[\n]", "comport = " + cBoxComPort.Text + "\n");
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathSETini))
                    {
                        file.Write(SETiniN);
                    }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }
        }
        // кнопка закрытия порта
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                selectMode = "Terminal"; Thread.Sleep(1000);
                serialPort1.Close();
                pbPort.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
                pbCSQsignal.Value = 0;
                pbCSQquality.Value = 0;
                lblCSQsgrade.Text = "";
                lblCSQqgrade.Text = "";
                lblRSRQgrade.Text = ""; lblRSRPgrade.Text = ""; lblRSSIgrade.Text = ""; lblSNRgrade.Text = "";
                lblLTEca.Text = ""; lblLTEcaBW.Text = "";
                notifyIcon1.Icon = Properties.Resources.sn;
                notifyIcon1.Text = "please open com-port...";
            }
        }
        // передача в порт по Button
        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = cBoxDataOut.Text;
                switch (sendWith)
                {
                    case "None":
                        serialPort1.Write(dataOUT);
                        Thread.Sleep(50);
                        break;
                    case "Both":
                        serialPort1.Write(dataOUT + "\r\n");
                        Thread.Sleep(50);
                        break;
                    case "New Line":
                        serialPort1.Write(dataOUT + "\n");
                        Thread.Sleep(50);
                        break;
                    case "Carriage Return":
                        serialPort1.Write(dataOUT + "\r");
                        Thread.Sleep(50);
                        break;
                    default:
                        break;
                }
            }
        }
        // передача в порт по Enter
        private void cBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Запись log AT commands
                try
                {
                    // Проверка, если введенной команды нет в файле log_at.txt -> дописать её в коней файла
                    string[] ATlist = File.ReadAllLines(pathATcom, Encoding.Default);
                    if (ATlist.Contains(dataOUT) == false)
                    {
                        objStreamWriterAT = new StreamWriter(pathATcom, true);
                        objStreamWriterAT.WriteLine(dataOUT);
                        objStreamWriterAT.Close();
                    }
                    atComLog = System.IO.File.ReadAllLines(pathATcom);
                    cBoxDataOut.Items.Clear();
                    cBoxDataOut.Items.AddRange(atComLog);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        // формирование исходящего пакета по Enter
        private void doSomething()
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = cBoxDataOut.Text;
                switch (sendWith)
                {
                    case "None":
                        serialPort1.Write(dataOUT);
                        Thread.Sleep(50);
                        break;
                    case "Both":
                        serialPort1.Write(dataOUT + "\r\n");
                        Thread.Sleep(50);
                        break;
                    case "New Line":
                        serialPort1.Write(dataOUT + "\n");
                        Thread.Sleep(50);
                        break;
                    case "Carriage Return":
                        serialPort1.Write(dataOUT + "\r");
                        Thread.Sleep(50);
                        break;
                    default:
                        break;
                }
            }
        }
        // установка переменной перевода строки для исходящего пакета
        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            switch (toolStripComboBox2.Text)
            {
                case "None":
                    sendWith = "None";
                    break;
                case "Both":
                    sendWith = "Both";
                    break;
                case "New Line":
                    sendWith = "New Line";
                    break;
                case "Carriage Return":
                    sendWith = "Carriage Return";
                    break;
                default:
                    break;
            }
        }
        // включение DTR
        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else { serialPort1.DtrEnable = false; }
        }
        // включение RTS
        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRtsEnable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else { serialPort1.RtsEnable = false; }
        }
        #endregion
        #region Вывод информации в Монитор, Терминал, Информация
        // вывод кол-ва исходящих символов
        private void cBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOUTlenght = cBoxDataOut.Text.Length;
            lblDataOutLenght.Text = string.Format("{0:00}", dataOUTlenght);
        }
        // Передача АТ команд в порт и чтение из него
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                switch (selectMode)
                {
                    case "Terminal":
                        Thread.Sleep(50); dataIN = serialPort1.ReadExisting();
                        this.Invoke(new EventHandler(showData));
                        //Запись лога ответов модема в log_out.txt, если выбран чек file-save to log file
                        if (saveToFileToolStripMenuItem.Checked)
                        {
                            objStreamWriterOUT = new StreamWriter(pathOUTcom, true);
                            objStreamWriterOUT.WriteLine(dataIN);
                            objStreamWriterOUT.Close();
                        }
                        // очистка буферов порта
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();
                        break;
                    case "Informations":
                        //first packet
                        Thread.Sleep(50); dataFirstPacket = serialPort1.ReadExisting();
                        //imei
                        serialPort1.Write("AT+CGSN" + "\r\n"); Thread.Sleep(50); dataImei = serialPort1.ReadExisting();
                        //imsi
                        serialPort1.Write("AT+CIMI" + "\r\n"); Thread.Sleep(50); dataImsi = serialPort1.ReadExisting();
                        //sim number
                        serialPort1.Write("AT+CNUM" + "\r\n"); Thread.Sleep(50); dataSimN = serialPort1.ReadExisting();
                        //sms centre
                        serialPort1.Write("AT+CSCA?" + "\r\n"); Thread.Sleep(50); dataSmsCentre = serialPort1.ReadExisting();
                        //operator
                        serialPort1.Write("AT+COPS?" + "\r\n"); Thread.Sleep(50); dataOperator = serialPort1.ReadExisting();
                        //apn
                        serialPort1.Write("AT+CGDCONT?" + "\r\n"); Thread.Sleep(50); dataApn = serialPort1.ReadExisting();
                        //temperatute
                        serialPort1.Write("AT!PCTEMP?" + "\r\n"); Thread.Sleep(50); dataTempC = serialPort1.ReadExisting();
                        //voltage
                        serialPort1.Write("AT!PCVOLT?" + "\r\n"); Thread.Sleep(50); dataVoltage = serialPort1.ReadExisting();
                        //firmware
                        serialPort1.Write("AT+GMR" + "\r\n"); Thread.Sleep(50); dataFW = serialPort1.ReadExisting();
                        //data from ati
                        serialPort1.Write("ATI" + "\r\n"); Thread.Sleep(50); dataATI = serialPort1.ReadExisting();
                        //data from usbinfo - product
                        serialPort1.Write("AT!USBINFO?" + "\r\n"); Thread.Sleep(50); dataProduct = serialPort1.ReadExisting();
                        //data revision
                        serialPort1.Write("AT!HWID?" + "\r\n"); Thread.Sleep(50); dataRevision = serialPort1.ReadExisting();
                        //data composition
                        serialPort1.Write("AT!USBCOMP?" + "\r\n"); Thread.Sleep(50); dataBitmask = serialPort1.ReadExisting();
                        // data band
                        serialPort1.Write("AT!BAND?" + "\r\n"); Thread.Sleep(50); dataBand = serialPort1.ReadExisting();

                        // data out-in
                        this.Invoke(new EventHandler(showDataInformations));
                        // очистка буферов порта
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();
                        selectMode = "Monitor"; serialPort1.Write("AT" + "\r\n");
                        break;
                    case "Monitor":
                    first:
                        //first packet
                        Thread.Sleep(500); if (!serialPort1.IsOpen) { selectMode = "Terminal"; break; }; dataFirstPacket = serialPort1.ReadExisting();
                        //signal CSQ
                        serialPort1.Write("AT+CSQ" + "\r\n"); Thread.Sleep(500); if (!serialPort1.IsOpen) { selectMode = "Terminal"; break; }; dataCSQ = serialPort1.ReadExisting();
                        // EARFCN, TAC, CellID, SNR, PCI, RSRQ, RSRP, RSSI
                        serialPort1.Write("AT!LTEINFO" + "\r\n"); Thread.Sleep(500); if (!serialPort1.IsOpen) { selectMode = "Terminal"; break; }; dataLTEinfo = serialPort1.ReadExisting();
                        // режим сети
                        serialPort1.Write("AT$QCSYSMODE?" + "\r\n"); Thread.Sleep(500); if (!serialPort1.IsOpen) { selectMode = "Terminal"; break; }; dataNETmode = serialPort1.ReadExisting();
                        // данные gstatus
                        serialPort1.Write("AT!GSTATUS?" + "\r\n"); Thread.Sleep(500); if (!serialPort1.IsOpen) { selectMode = "Terminal"; break; }; dataNETstatus = serialPort1.ReadExisting();
                        // output data monitor
                        this.Invoke(new EventHandler(showDataMonitor));
                        // очистка буферов порта
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();
                        // задержка
                        Thread.Sleep(3000);
                        if (selectMode == "Monitor" & serialPort1.IsOpen) { serialPort1.Write("ATI" + "\r\n"); goto first; }
                        break;
                    default:
                        break;
                }
            }
        }
        // Преобразование вывода в Informations
        private void showDataInformations(object sender, EventArgs e)
        {
            dataFirstPacket = "";
            if (dataImei != "") { dataImei = dataImei.Split('\n')[1]; lblImei.Text = dataImei; }
            if (dataImsi != "") { dataImsi = dataImsi.Split('\n')[1]; lblImsi.Text = dataImsi; }
            if (dataSimN != "") { dataSimN = dataSimN.Split('\n')[1]; if (dataSimN == "OK\r") { dataSimN = "not recorded"; } lblSimNumber.Text = dataSimN; }
            if (dataSmsCentre != "") { dataSmsCentre = dataSmsCentre.Split('\n')[1]; dataSmsCentre = dataSmsCentre.Split('"')[1]; lblSmsCentre.Text = dataSmsCentre; }
            if (dataOperator != "") { dataOperator = dataOperator.Split('\n')[1]; dataOperator = dataOperator.Split('"')[1]; lblOperator.Text = dataOperator; }
            if (dataApn != "") { dataApn = dataApn.Split('\n')[1]; dataApn = dataApn.Split('"')[3]; lblApn.Text = dataApn; }
            if (dataTempC != "") { dataTempC = dataTempC.Split('\n')[2]; lblTempC.Text = dataTempC; }
            if (dataVoltage != "") { dataVoltage = dataVoltage.Split('\n')[2]; lblVoltage.Text = dataVoltage; }
            if (dataFW != "") { dataFW = dataFW.Split('\n')[1]; lblFW.Text = dataFW; }

            if (dataModel != "") { dataModel = dataATI.Split('\n')[2]; dataModel = dataModel.Split(' ')[1]; lblModel.Text = dataModel; }
            if (dataMeid != "") { dataMeid = dataATI.Split('\n')[4]; dataMeid = dataMeid.Split(' ')[1]; lblMeid.Text = dataMeid; }
            if (dataImeiSV != "") { dataImeiSV = dataATI.Split('\n')[6]; dataImeiSV = dataImeiSV.Split(' ')[2]; lblImeiSV.Text = dataImeiSV; }
            if (dataFSN != "") { dataFSN = dataATI.Split('\n')[7]; dataFSN = dataFSN.Split(' ')[1]; lblFSN.Text = dataFSN; }

            if (dataVid != "") { dataVid = dataProduct.Split('\n')[1]; dataVid = dataVid.Split(' ')[1]; dataVid = dataVid.Split('x')[1]; lblVid.Text = dataVid; }
            if (dataAppPid != "") { dataAppPid = dataProduct.Split('\n')[2]; dataAppPid = dataAppPid.Split(' ')[2]; dataAppPid = dataAppPid.Split('x')[1]; lblAppPid.Text = dataAppPid; }
            if (dataBootPid != "") { dataBootPid = dataProduct.Split('\n')[3]; dataBootPid = dataBootPid.Split(' ')[2]; dataBootPid = dataBootPid.Split('x')[1]; lblBootPid.Text = dataBootPid; }

            if (dataRevision != "") { dataRevision = dataRevision.Split('\n')[1]; dataRevision = dataRevision.Split(' ')[1]; lblRevision.Text = dataRevision; }
            if (dataBitmask != "") { dataBitmask = dataBitmask.Split('\n')[3]; dataBitmask = dataBitmask.Split(' ')[2] + " - " + dataBitmask.Split(' ')[3]; lblBitmask.Text = dataBitmask; tbBitmask.Text = dataBitmask.Split(' ')[0]; }

            // Считывание текущих установок band и установка их в checkListBox вкладки band
            dataBand = dataBand.Split('\n')[2]; dataBand = dataBand.Split(',')[2];
            dataBandW = dataBand.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[0];
            dataBandL = dataBand.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[1];
            lblBandW.Text = dataBandW; lblBandL.Text = dataBandL;
            // lte
            if (dataBandL.Substring(5, 1) == "1") { chlbBand.SetItemChecked(12, true); } //band41
            if (dataBandL.Substring(9, 1) == "2") { chlbBand.SetItemChecked(11, true); } //band26
            if (dataBandL.Substring(9, 1) == "1") { chlbBand.SetItemChecked(10, true); } //band25
            if (dataBandL.Substring(9, 1) == "3") { chlbBand.SetItemChecked(10, true); chlbBand.SetItemChecked(11, true); } //band25, 26
            if (dataBandL.Substring(11, 1) == "8") { chlbBand.SetItemChecked(9, true); } //band20
            if (dataBandL.Substring(12, 1) == "1") { chlbBand.SetItemChecked(8, true); } //band13
            if (dataBandL.Substring(13, 1) == "8") { chlbBand.SetItemChecked(7, true); } //band12
            if (dataBandL.Substring(14, 1) == "8") { chlbBand.SetItemChecked(6, true); } //band8
            if (dataBandL.Substring(14, 1) == "4") { chlbBand.SetItemChecked(5, true); } //band7
            if (dataBandL.Substring(14, 1) == "1") { chlbBand.SetItemChecked(4, true); } //band5
            if (dataBandL.Substring(14, 1) == "5") { chlbBand.SetItemChecked(4, true); chlbBand.SetItemChecked(5, true); } //band5, 7
            if (dataBandL.Substring(14, 1) == "9") { chlbBand.SetItemChecked(4, true); chlbBand.SetItemChecked(6, true); } //band5, 8
            if (dataBandL.Substring(14, 1) == "C") { chlbBand.SetItemChecked(5, true); chlbBand.SetItemChecked(6, true); } //band7, 8
            if (dataBandL.Substring(14, 1) == "D") { chlbBand.SetItemChecked(4, true); chlbBand.SetItemChecked(5, true); chlbBand.SetItemChecked(6, true); } //band5, 7, 8
            if (dataBandL.Substring(15, 1) == "8") { chlbBand.SetItemChecked(3, true); } //band4
            if (dataBandL.Substring(15, 1) == "4") { chlbBand.SetItemChecked(2, true); } //band3
            if (dataBandL.Substring(15, 1) == "2") { chlbBand.SetItemChecked(1, true); } //band2
            if (dataBandL.Substring(15, 1) == "1") { chlbBand.SetItemChecked(0, true); } //band1
            if (dataBandL.Substring(15, 1) == "C") { chlbBand.SetItemChecked(3, true); chlbBand.SetItemChecked(2, true); } //band4, 3
            if (dataBandL.Substring(15, 1) == "A") { chlbBand.SetItemChecked(3, true); chlbBand.SetItemChecked(1, true); } //band4, 2
            if (dataBandL.Substring(15, 1) == "9") { chlbBand.SetItemChecked(3, true); chlbBand.SetItemChecked(0, true); } //band4, 1
            if (dataBandL.Substring(15, 1) == "6") { chlbBand.SetItemChecked(2, true); chlbBand.SetItemChecked(1, true); } //band3, 2
            if (dataBandL.Substring(15, 1) == "5") { chlbBand.SetItemChecked(2, true); chlbBand.SetItemChecked(0, true); } //band3, 1
            if (dataBandL.Substring(15, 1) == "3") { chlbBand.SetItemChecked(1, true); chlbBand.SetItemChecked(0, true); } //band2, 1
            if (dataBandL.Substring(15, 1) == "E") { chlbBand.SetItemChecked(3, true); chlbBand.SetItemChecked(2, true); chlbBand.SetItemChecked(1, true); } //band4, 3, 2
            if (dataBandL.Substring(15, 1) == "D") { chlbBand.SetItemChecked(3, true); chlbBand.SetItemChecked(2, true); chlbBand.SetItemChecked(0, true); } //band4, 3, 1
            if (dataBandL.Substring(15, 1) == "7") { chlbBand.SetItemChecked(2, true); chlbBand.SetItemChecked(1, true); chlbBand.SetItemChecked(0, true); } //band3, 2, 1
            if (dataBandL.Substring(15, 1) == "F") { chlbBand.SetItemChecked(3, true); chlbBand.SetItemChecked(2, true); chlbBand.SetItemChecked(1, true); chlbBand.SetItemChecked(0, true); } //band4, 3, 2, 1
            // wcdma
            if (dataBandW.Substring(3, 1) == "2") { chlbBand.SetItemChecked(18, true); } //bandW8
            if (dataBandW.Substring(9, 1) == "4") { chlbBand.SetItemChecked(17, true); } //bandW5
            if (dataBandW.Substring(9, 1) == "2") { chlbBand.SetItemChecked(16, true); } //bandW4
            if (dataBandW.Substring(9, 1) == "1") { chlbBand.SetItemChecked(15, true); } //bandW3
            if (dataBandW.Substring(9, 1) == "6") { chlbBand.SetItemChecked(17, true); chlbBand.SetItemChecked(16, true); } //bandW5, 4
            if (dataBandW.Substring(9, 1) == "5") { chlbBand.SetItemChecked(17, true); chlbBand.SetItemChecked(15, true); } //bandW5, 3
            if (dataBandW.Substring(9, 1) == "3") { chlbBand.SetItemChecked(16, true); chlbBand.SetItemChecked(15, true); } //bandW4, 3
            if (dataBandW.Substring(9, 1) == "7") { chlbBand.SetItemChecked(17, true); chlbBand.SetItemChecked(16, true); chlbBand.SetItemChecked(15, true); } //bandW5, 4, 3
            if (dataBandW.Substring(10, 1) == "8") { chlbBand.SetItemChecked(14, true); } //bandW2
            if (dataBandW.Substring(10, 1) == "4") { chlbBand.SetItemChecked(13, true); } //bandW1
            if (dataBandW.Substring(10, 1) == "C") { chlbBand.SetItemChecked(14, true); chlbBand.SetItemChecked(13, true); } //bandW2, 1
        }
        // Преобразование вывода инфы в Монитор
        private void showDataMonitor(object sender, EventArgs e)
        {
            //сигнал CSQ
            if (dataCSQ != "")
            {
                dataFirstPacket = "";
                dataCSQsignal = dataCSQ.Split('\n')[1]; dataCSQsignal = dataCSQsignal.Split(' ')[1];
                dataCSQquality = dataCSQsignal.Split(',')[1]; dataCSQsignal = dataCSQsignal.Split(',')[0];
                lblCSQsignal.Text = dataCSQsignal; lblCSQquality.Text = dataCSQquality;

                //цветное выделение надписей качества csq
                dataCSQsint = int.Parse(dataCSQsignal);
                dataCSQqint = int.Parse(dataCSQquality);
                if (dataCSQsint >= 0 & dataCSQsint <= 9) { lblCSQsgrade.ForeColor = Color.OrangeRed; lblCSQsgrade.Text = "Bad"; pbCSQsignal.Value = dataCSQsint; }
                else if (dataCSQsint >= 10 & dataCSQsint <= 14) { lblCSQsgrade.ForeColor = Color.Goldenrod; lblCSQsgrade.Text = "Middle"; pbCSQsignal.Value = dataCSQsint; }
                else if (dataCSQsint >= 15 & dataCSQsint <= 19) { lblCSQsgrade.ForeColor = Color.LimeGreen; lblCSQsgrade.Text = "Good"; pbCSQsignal.Value = dataCSQsint; }
                else if (dataCSQsint >= 20 & dataCSQsint <= 31) { lblCSQsgrade.ForeColor = Color.DodgerBlue; lblCSQsgrade.Text = "Excellent"; pbCSQsignal.Value = dataCSQsint; }
                else if (dataCSQsint == 99) { lblCSQsgrade.ForeColor = Color.Gray; lblCSQsgrade.Text = "no service"; pbCSQsignal.Value = 0; }
                if (dataCSQqint == 99) { lblCSQqgrade.ForeColor = Color.Gray; lblCSQqgrade.Text = "not known"; pbCSQquality.Value = 0; }
                else { pbCSQquality.Value = dataCSQqint; lblCSQqgrade.Text = ""; }
            }
            //lteinfo - EARFCN, TAC, CellID, SNR, PCI, RSRQ, RSRP, RSSI
            if (dataLTEinfo != "")
            {
                dataLTEinfo = dataLTEinfo.Split('\n')[3];
                dataEARFCN = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[0]; lblEARFCN.Text = dataEARFCN;
                dataTAC = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[3]; lblTAC.Text = dataTAC;
                dataCellID = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[4]; lblCELLID.Text = dataCellID;
                //SINR
                dataSNR = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[8]; lblSNR.Text = dataSNR;
                //цветное выделение надписей качества SNR
                dataSNRint = int.Parse(dataSNR);
                if (dataSNRint <= 0) { lblSNRgrade.ForeColor = Color.OrangeRed; lblSNRgrade.Text = "Bad"; }
                else if (dataSNRint > 0 & dataSNRint <= 13) { lblSNRgrade.ForeColor = Color.Goldenrod; lblSNRgrade.Text = "Middle"; }
                else if (dataSNRint > 13 & dataSNRint < 20) { lblSNRgrade.ForeColor = Color.LimeGreen; lblSNRgrade.Text = "Good"; }
                else if (dataSNRint >= 20) { lblSNRgrade.ForeColor = Color.DodgerBlue; lblSNRgrade.Text = "Excellent"; }
                dataPCI = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[9]; lblPCI.Text = dataPCI;
                //RSRQ
                dataRSRQ = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[10]; lblRSRQ.Text = dataRSRQ;
                //цветное выделение надписей качества rsrq
                dataRSRQ = dataRSRQ.Replace('.', ','); dataRSRQint = Convert.ToDouble(dataRSRQ);
                if (dataRSRQint < -20) { lblRSRQgrade.ForeColor = Color.OrangeRed; lblRSRQgrade.Text = "Bad"; }
                else if (dataRSRQint >= -20 & dataRSRQint <= -15) { lblRSRQgrade.ForeColor = Color.Goldenrod; lblRSRQgrade.Text = "Middle"; }
                else if (dataRSRQint > -15 & dataRSRQint < -10) { lblRSRQgrade.ForeColor = Color.LimeGreen; lblRSRQgrade.Text = "Good"; }
                else if (dataRSRQint >= -10) { lblRSRQgrade.ForeColor = Color.DodgerBlue; lblRSRQgrade.Text = "Excellent"; }
                //RSRP
                dataRSRP = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[11]; lblRSRP.Text = dataRSRP;
                //цветное выделение надписей качества rsrp
                dataRSRP = dataRSRP.Replace('.', ','); dataRSRPint = Convert.ToDouble(dataRSRP);
                if (dataRSRPint <= -100) { lblRSRPgrade.ForeColor = Color.OrangeRed; lblRSRPgrade.Text = "Bad"; }
                else if (dataRSRPint > -100 & dataRSRPint <= -90) { lblRSRPgrade.ForeColor = Color.Goldenrod; lblRSRPgrade.Text = "Middle"; }
                else if (dataRSRPint > -90 & dataRSRPint < -80) { lblRSRPgrade.ForeColor = Color.LimeGreen; lblRSRPgrade.Text = "Good"; }
                else if (dataRSRPint >= -80) { lblRSRPgrade.ForeColor = Color.DodgerBlue; lblRSRPgrade.Text = "Excellent"; }
                //RSSI
                dataRSSI = dataLTEinfo.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[12]; lblRSSI.Text = dataRSSI;
                //цветное выделение надписей качества rssi
                dataRSSI = dataRSSI.Replace('.', ','); dataRSSIint = Convert.ToDouble(dataRSSI);
                if (dataRSSIint <= -94) { lblRSSIgrade.ForeColor = Color.OrangeRed; lblRSSIgrade.Text = "Bad"; }
                else if (dataRSSIint >= -93 & dataRSSIint <= -85) { lblRSSIgrade.ForeColor = Color.Goldenrod; lblRSSIgrade.Text = "Middle"; }
                else if (dataRSSIint >= -84 & dataRSSIint <= -75) { lblRSSIgrade.ForeColor = Color.LimeGreen; lblRSSIgrade.Text = "Good"; }
                else if (dataRSSIint >= -74) { lblRSSIgrade.ForeColor = Color.DodgerBlue; lblRSSIgrade.Text = "Excellent"; }
            }
            //режим сети
            if (dataNETmode != "") { dataNETmode = dataNETmode.Split('\n')[1]; lblNETmode.Text = dataNETmode; }
            //данные gstatus
            //проверка на наличие агрегации
            if (dataNETstatus != "" & dataNETstatus.Length > 500)
            {
                dataLTEca = dataNETstatus.Split('\n')[7];
                dataLTEca = dataLTEca.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[3];
                switch (dataLTEca)
                {
                    case "NOT":
                        dataLTEca = "Not assigned"; lblLTEca.ForeColor = Color.Gray; lblLTEca.Text = dataLTEca;
                        dataB1v = dataNETstatus.Split('\n')[5];
                        dataB1 = dataB1v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[2];
                        dataB1bw = dataB1v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[5];
                        lblLTEcaBW.Text = dataB1 + " (" + dataB1bw + " MHz)";
                        //иконка в трее
                        if (dataCSQsint >= 0 & dataCSQsint <= 4) { notifyIcon1.Icon = Properties.Resources.s0; }
                        else if (dataCSQsint >= 5 & dataCSQsint <= 10) { notifyIcon1.Icon = Properties.Resources.s1; }
                        else if (dataCSQsint >= 11 & dataCSQsint <= 16) { notifyIcon1.Icon = Properties.Resources.s2; }
                        else if (dataCSQsint >= 17 & dataCSQsint <= 22) { notifyIcon1.Icon = Properties.Resources.s3; }
                        else if (dataCSQsint >= 23 & dataCSQsint <= 28) { notifyIcon1.Icon = Properties.Resources.s4; }
                        else if (dataCSQsint >= 29 & dataCSQsint <= 31) { notifyIcon1.Icon = Properties.Resources.s5; }
                        else if (dataCSQsint == 99) { notifyIcon1.Icon = Properties.Resources.sn; }
                        break;
                    case "INACTIVE":
                        dataLTEca = "Inactive"; lblLTEca.ForeColor = Color.Goldenrod; lblLTEca.Text = dataLTEca;
                        dataB1v = dataNETstatus.Split('\n')[5];
                        dataB1 = dataB1v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[2];
                        dataB1bw = dataB1v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[5];
                        //lblLTEcaBW.Text = dataB1 + " (" + dataB1bw + " MHz)";
                        dataB2v = dataNETstatus.Split('\n')[7];
                        dataB2 = dataB2v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[6];
                        dataB2 = dataB2.Split(':')[1];
                        dataB2v = dataNETstatus.Split('\n')[8];
                        dataB2bw = dataB2v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[2];
                        dataB2bw = dataB2bw.Split(':')[1];
                        lblLTEcaBW.Text = dataB1 + "(" + dataB1bw + ")" + " + " + dataB2 + "(" + dataB2bw + ")";
                        //иконка в трее
                        if (dataCSQsint >= 0 & dataCSQsint <= 4) { notifyIcon1.Icon = Properties.Resources.sa0; }
                        else if (dataCSQsint >= 5 & dataCSQsint <= 10) { notifyIcon1.Icon = Properties.Resources.sa1; }
                        else if (dataCSQsint >= 11 & dataCSQsint <= 16) { notifyIcon1.Icon = Properties.Resources.sa2; }
                        else if (dataCSQsint >= 17 & dataCSQsint <= 22) { notifyIcon1.Icon = Properties.Resources.sa3; }
                        else if (dataCSQsint >= 23 & dataCSQsint <= 28) { notifyIcon1.Icon = Properties.Resources.sa4; }
                        else if (dataCSQsint >= 29 & dataCSQsint <= 31) { notifyIcon1.Icon = Properties.Resources.sa5; }
                        else if (dataCSQsint == 99) { notifyIcon1.Icon = Properties.Resources.sn; }
                        break;
                    case "ACTIVE":
                        dataLTEca = "Active"; lblLTEca.ForeColor = Color.LimeGreen; lblLTEca.Text = dataLTEca;
                        dataB1v = dataNETstatus.Split('\n')[5];
                        dataB1 = dataB1v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[2];
                        dataB1bw = dataB1v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[5];

                        dataB2v = dataNETstatus.Split('\n')[7];
                        dataB2 = dataB2v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[6];
                        dataB2 = dataB2.Split(':')[1];
                        dataB2v = dataNETstatus.Split('\n')[8];
                        dataB2bw = dataB2v.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[2];
                        dataB2bw = dataB2bw.Split(':')[1];
                        lblLTEcaBW.Text = dataB1 + "(" + dataB1bw + ")" + " + " + dataB2 + "(" + dataB2bw + ")";
                        if (dataCSQsint >= 0 & dataCSQsint <= 4) { notifyIcon1.Icon = Properties.Resources.sca0; }
                        else if (dataCSQsint >= 5 & dataCSQsint <= 10) { notifyIcon1.Icon = Properties.Resources.sca1; }
                        else if (dataCSQsint >= 11 & dataCSQsint <= 16) { notifyIcon1.Icon = Properties.Resources.sca2; }
                        else if (dataCSQsint >= 17 & dataCSQsint <= 22) { notifyIcon1.Icon = Properties.Resources.sca3; }
                        else if (dataCSQsint >= 23 & dataCSQsint <= 28) { notifyIcon1.Icon = Properties.Resources.sca4; }
                        else if (dataCSQsint >= 29 & dataCSQsint <= 31) { notifyIcon1.Icon = Properties.Resources.sca5; }
                        else if (dataCSQsint == 99) { notifyIcon1.Icon = Properties.Resources.sn; }
                        break;
                    default:
                        break;
                }
            }
            //вывод информации в иконку трея
            notifyIcon1.Text = "RSSI:   " + dataRSSI + "\nRSRP: " + dataRSRP + "\nRSRQ: " + dataRSRQ + "\nLTE CA: " + lblLTEcaBW.Text;
        }
        // Преобразование вывода инфы в Терминал
        private void showData(object sender, EventArgs e)
        {
            int dataInLenght = dataIN.Length - 1;
            lblDataInLenght.Text = string.Format("{0:00}", dataInLenght);

            switch (toolStripComboBox1.Text)
            {
                case "Always update":
                    tBoxDataIn.Text = dataIN;
                    break;
                case "Add to old data":
                    switch (toolStripComboBox3.Text)
                    {
                        case "Top":
                            tBoxDataIn.Text = tBoxDataIn.Text.Insert(0, dataIN);
                            break;
                        case "Button":
                            tBoxDataIn.Text += dataIN;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region Интерфейс
        // Очистка окна Receiver - IN
        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tBoxDataIn.Text != "")
            {
                tBoxDataIn.Text = "";
            }
        }
        // Меню - About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Ceper@ for themselves...", "Creators", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Закрытие пограммы по Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                selectMode = "Terminal"; Thread.Sleep(1000);
                serialPort1.Close();
            }
            notifyIcon1.Visible = false;
            Application.Exit();
        }
        // Закрытие пограммы по label - х
        private void lblExit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                selectMode = "Terminal"; Thread.Sleep(1000);
                serialPort1.Close();
            }
            notifyIcon1.Visible = false;
            Application.Exit();
        }
        // Сворачивание программы по labal - _
        private void lblMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            //минимизация в трей
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }
        //вытащить из трея
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }
        // Преобразование цвета знака сворацивания программы
        private void lblMinimized_MouseEnter(object sender, EventArgs e)
        {
            lblMinimized.ForeColor = Color.Blue;        }
        private void lblMinimized_MouseLeave(object sender, EventArgs e)
        {
            lblMinimized.ForeColor = Color.Black;
        }
        // Преобразование цвета знака закрытия программы
        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Red;
        }
        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Black;
        }
        // Перемещение окна программы
        // 1. в основном окне
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        // Перемещение окна программы
        // 2. в строке меню
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion
        #region Режим работы программы
        // выбор режима работы
        private void cBoxSelectMode_DropDownClosed(object sender, EventArgs e)
         {
            switch (cBoxSelectMode.Text)
            {
                case "Terminal":
                    selectMode = "Terminal";
                    cBoxDataOut.Enabled = true;
                    btnSendData.Enabled = true;
                    tabControl.SelectedTab = tabPage3;
                    break;
                case "Monitor":
                    selectMode = "Monitor";
                    cBoxDataOut.Enabled = false;
                    btnSendData.Enabled = false;
                    if (serialPort1.IsOpen) { serialPort1.Write("AT" + "\r\n"); }
                    break;
                default:
                    break;
            }
        }
        // Активация отображения данных Information / Band
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (tabControl.SelectedTab == tabPage2)
                {
                    selectMode = "Informations"; cBoxSelectMode.SelectedItem = "Monitor";
                    cBoxDataOut.Enabled = false; btnSendData.Enabled = false;
                    serialPort1.Write("AT!ENTERCND=\"A710\"" + "\r\n");
                }
                if (tabControl.SelectedTab == tabPage1)
                {
                    selectMode = "Informations"; cBoxSelectMode.SelectedItem = "Monitor";
                    cBoxDataOut.Enabled = false; btnSendData.Enabled = false;
                    serialPort1.Write("AT!ENTERCND=\"A710\"" + "\r\n");
                }
            }
        }
        #endregion
        #region Настройка приоритетов сети и композиции
        // Выборка и расчет band
        private void chlbBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            long hexBandLTE = 0x0000000000000000, hexBandWCDMA = 0x0000000000000000;
            // LTE
            if (chlbBand.GetItemChecked(0) == true) { hexBandLTE += 0x0000000000000001; } //band1
            if (chlbBand.GetItemChecked(1) == true) { hexBandLTE += 0x0000000000000002; } //band2
            if (chlbBand.GetItemChecked(2) == true) { hexBandLTE += 0x0000000000000004; } //band3
            if (chlbBand.GetItemChecked(3) == true) { hexBandLTE += 0x0000000000000008; } //band4
            if (chlbBand.GetItemChecked(4) == true) { hexBandLTE += 0x0000000000000010; } //band5
            if (chlbBand.GetItemChecked(5) == true) { hexBandLTE += 0x0000000000000040; } //band7
            if (chlbBand.GetItemChecked(6) == true) { hexBandLTE += 0x0000000000000080; } //band8
            if (chlbBand.GetItemChecked(7) == true) { hexBandLTE += 0x0000000000000800; } //band12
            if (chlbBand.GetItemChecked(8) == true) { hexBandLTE += 0x0000000000001000; } //band13
            if (chlbBand.GetItemChecked(9) == true) { hexBandLTE += 0x0000000000080000; } //band20
            if (chlbBand.GetItemChecked(10) == true) { hexBandLTE += 0x0000000001000000; } //band25
            if (chlbBand.GetItemChecked(11) == true) { hexBandLTE += 0x0000000002000000; } //band26
            if (chlbBand.GetItemChecked(12) == true) { hexBandLTE += 0x0000010000000000; } //band41
            dataBandLN = Convert.ToString(hexBandLTE, 16);
            lblBandLN.Text = dataBandLN.ToUpper();
            // WCDMA
            if (chlbBand.GetItemChecked(13) == true) { hexBandWCDMA += 0x0000000000400000; } //band1
            if (chlbBand.GetItemChecked(14) == true) { hexBandWCDMA += 0x0000000000800000; } //band2
            if (chlbBand.GetItemChecked(15) == true) { hexBandWCDMA += 0x0000000001000000; } //band3
            if (chlbBand.GetItemChecked(16) == true) { hexBandWCDMA += 0x0000000002000000; } //band4
            if (chlbBand.GetItemChecked(17) == true) { hexBandWCDMA += 0x0000000004000000; } //band5
            if (chlbBand.GetItemChecked(18) == true) { hexBandWCDMA += 0x0002000000000000; } //band8
            dataBandWN = Convert.ToString(hexBandWCDMA, 16);
            lblBandWN.Text = dataBandWN.ToUpper();
            dataBandSet1 = "AT!BAND=" + tbBANDnumber.Text + ",\"" + tbBandName.Text + "\",";
            dataBandSet2 = lblBandWN.Text + "," + lblBandLN.Text;
            lblBANDset1.ForeColor = Color.OrangeRed; lblBANDset2.ForeColor = Color.OrangeRed;
            lblBANDset1.Text = dataBandSet1; lblBANDset2.Text = dataBandSet2;
            dataBandSet = dataBandSet1 + dataBandSet2;
        }
        // Установка выбранных band
        private void tbBandName_TextChanged(object sender, EventArgs e)
        {
            dataBandSet1 = "AT!BAND=" + tbBANDnumber.Text + ",\"" + tbBandName.Text + "\",";
            dataBandSet2 = lblBandWN.Text + "," + lblBandLN.Text;
            lblBANDset1.ForeColor = Color.OrangeRed; lblBANDset2.ForeColor = Color.OrangeRed;
            lblBANDset1.Text = dataBandSet1; lblBANDset2.Text = dataBandSet2;
            dataBandSet = dataBandSet1 + dataBandSet2;
        }
        private void tbBANDnumber_TextChanged(object sender, EventArgs e)
        {
            dataBandSet1 = "AT!BAND=" + tbBANDnumber.Text + ",\"" + tbBandName.Text + "\",";
            dataBandSet2 = lblBandWN.Text + "," + lblBandLN.Text;
            lblBANDset1.ForeColor = Color.OrangeRed; lblBANDset2.ForeColor = Color.OrangeRed;
            lblBANDset1.Text = dataBandSet1; lblBANDset2.Text = dataBandSet2;
            dataBandSet = dataBandSet1 + dataBandSet2;
        }
        private void btnSetBand_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & MessageBox.Show("You are sure?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                serialPort1.Write("AT!BAND=" + tbBANDnumber.Text + ",\"\",0,0\r\n"); Thread.Sleep(50);
                serialPort1.Write(dataBandSet + "\r\n"); Thread.Sleep(50);
                serialPort1.Write("AT!BAND=" + tbBANDnumber.Text + "\r\n"); Thread.Sleep(50);
            }
        }
        // Установка bitmask
        private void tbBitmask_TextChanged(object sender, EventArgs e)
        {
            lblBITMASKset.ForeColor = Color.OrangeRed;
            lblBITMASKset.Text = "AT!USBCOMP=1,1," + tbBitmask.Text;
        }
        private void btnBitmask_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are sure?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            { serialPort1.Write(lblBITMASKset.Text + "\r\n"); Thread.Sleep(50); }
            //serialPort1.Write(lblBITMASKset.Text + "\r\n"); Thread.Sleep(50);
        }
        #endregion
        #region Обработка log_out.txt
        // Очистка файла log_out.txt
        private void clearLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objStreamWriterOUT = new StreamWriter(pathOUTcom, false);
            objStreamWriterOUT.Write("");
            objStreamWriterOUT.Close();
        }
        // Открыть файл log_out.txt
        private void openLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(pathOUTcom);
        }
        #endregion
        #region Настройка автозапуска и запуска в трей
        // Запись в файл настроек значения авто-запуска программы
        private void autoBootToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            string SETiniN = string.Empty;
            using (System.IO.StreamReader reader = System.IO.File.OpenText(pathSETini))
            {
                SETiniN = reader.ReadToEnd();
            }
            if (autoBootToolStripMenuItem.Checked)
            {
                SETiniN = Regex.Replace(SETiniN, @"(autoboot)(.*?)[\n]", "autoboot = true\n");
                //SETiniN = SETiniN.Replace("autoboot = false", "autoboot = true");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathSETini))
                {
                    file.Write(SETiniN);
                }
            }
            else if (!autoBootToolStripMenuItem.Checked)
            {
                SETiniN = Regex.Replace(SETiniN, @"(autoboot)(.*?)[\n]", "autoboot = false\n");
                //SETiniN = SETiniN.Replace("autoboot = true", "autoboot = false");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathSETini))
                {
                    file.Write(SETiniN);
                }
            }
        }
        // Запись в файл настроек значения запуска в трей
        private void notifyBootToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            string SETiniN = string.Empty;
            using (System.IO.StreamReader reader = System.IO.File.OpenText(pathSETini))
            {
                SETiniN = reader.ReadToEnd();
            }
            if (notifyBootToolStripMenuItem.Checked)
            {
                SETiniN = Regex.Replace(SETiniN, @"(notifyboot)(.*?)[\n]", "notifyboot = true\n");
                //SETiniN = SETiniN.Replace("notifyboot = false", "notifyboot = true");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathSETini))
                {
                    file.Write(SETiniN);
                }
            }
            else if (!notifyBootToolStripMenuItem.Checked)
            {
                SETiniN = Regex.Replace(SETiniN, @"(notifyboot)(.*?)[\n]", "notifyboot = false\n");
                //SETiniN = SETiniN.Replace("notifyboot = true", "notifyboot = false");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathSETini))
                {
                    file.Write(SETiniN);
                }
            }
        }
        #endregion
    }
}