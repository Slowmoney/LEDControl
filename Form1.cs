using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Collections.Generic;
namespace LEDControl
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        string[] enableComPorts;
        public Form1()
        {
            InitializeComponent();

            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);

            // добавляем событие на изменение окна
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {


            // port.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            addPorts();

            menu_port.SelectedIndex = comboBox1.SelectedIndex = Properties.Settings.Default.indexcom;
             menu_baud.SelectedIndex = comboBox2.SelectedIndex = Properties.Settings.Default.indexbaud;




            this.ShowInTaskbar = false;

        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            Hide();
        }
        private void addPorts() {
            comboBox1.Items.Clear();
            enableComPorts = SerialPort.GetPortNames();

            foreach (string port in enableComPorts)
            {
                menu_port.Items.Add(port);
                comboBox1.Items.Add(port);
            }
           // menu_port.MaxDropDownItems = enableComPorts.Length;
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            addPorts();
        }
        private void Popup(object sender, EventArgs e)
        {
            this.Show();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;
            }
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
          //  notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            this.ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            EnablePort();
        }
        private void menu_port_change(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = menu_port.SelectedIndex;
        }
        private void menu_baud_change(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = menu_baud.SelectedIndex;
        }
        private void EnablePort() {

            command.Text = button1.Text.Length.ToString();
            if (button1.Text.Length == 5)
            {
                panel1.Enabled = false;
                serialPort1.Close();
                button1.Text = "OPEN";
            }
            else
            {
                //   label1.Text = comboBox2.Text;
                if (comboBox2.SelectedIndex == -1)
                {
                    info.Text = "lol";
                    return;
                }

                try
                {
                    // настройки порта
                    serialPort1.PortName = enableComPorts[comboBox1.SelectedIndex];
                    serialPort1.BaudRate = Int32.Parse(comboBox2.Text); ;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    serialPort1.ReadTimeout = 100;
                    serialPort1.WriteTimeout = 100;
                    serialPort1.Open();

                    Properties.Settings.Default.indexcom = comboBox1.SelectedIndex;
                    Properties.Settings.Default.indexbaud = comboBox2.SelectedIndex;
                    Properties.Settings.Default.Save();
                    info.Text = comboBox2.SelectedIndex.ToString();
                    // command.Text = comboBox1.SelectedIndex.ToString();
                    serialPort1.Write("r");
panel1.Enabled = true;
                    button1.Text = "CLOSE";
                }
                catch (System.InvalidOperationException err)
                {

                    info.Text = err.Message;
                    return;
                }
                catch (System.UnauthorizedAccessException err)
                {
                    info.Text = err.Message;
                    return;
                }
            }
            
        }


        private void TrackBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            info.Text = trackBar1.Value.ToString();
            try
            {
                serialPort1.Write("b" + trackBar1.Value.ToString());
            }
            catch (System.InvalidOperationException)
            {
                info.Text = "ERROR PORT CLOSED";
            }
        }
        private void Select_Mode(object sender, EventArgs e)
        {

            RadioButton rb = sender as RadioButton;
            info.Text = rb.Text;
            command.Text = rb.Name;
            try
            {
                serialPort1.Write(rb.Name);
            }
            catch (System.InvalidOperationException) {
                info.Text = "ERROR PORT CLOSED";
            }
            panel1.Enabled = false;
            timer1.Enabled = true;

        }
        private delegate void fill(String data);
        private void fillData(String data) {
            command.Text = data;
            if (data == "Start\n") {
                //  serialPort1.Close();
                serialPort1.Write("r");
                panel1.Enabled = false;
                return;
            }
            if (data == "OK\n") {
                panel1.Enabled = true;
                return;
            }
            try
            {
                string[] spdata = data.Split('\r', '\n');

                trackBar1.Value = Convert.ToInt16(spdata[2].Substring(1));
                trackBar2.Value = Convert.ToInt16(spdata[4].Substring(1));

                //  RadioButton btn = (RadioButton)this.Controls["m30"];
                //  btn.Enabled = false;

                RadioButton mode = (RadioButton)this.Controls.Find(spdata[0], true)[0];
                mode.Checked = true;
                panel1.Enabled = true;
            }
            catch {

            }
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String a = serialPort1.ReadExisting();
            Invoke(new fill(fillData),new object[] { a });
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            timer1.Enabled = false;
        }

        private void TrackBar2_MouseCaptureChanged(object sender, EventArgs e)
        {
            info.Text = trackBar2.Value.ToString();
            try
            {
                serialPort1.Write("d" + trackBar2.Value.ToString());
            }
            catch (System.InvalidOperationException)
            {
                info.Text = "ERROR PORT CLOSED";
            }
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
