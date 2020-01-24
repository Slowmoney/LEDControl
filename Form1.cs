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
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {


            // port.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addPorts();
            // label1.Text = Properties.Settings.Default.indexcom.ToString();

            //label2.Text = Properties.Settings.Default.indexbaud.ToString();
            comboBox1.SelectedIndex = Properties.Settings.Default.indexcom;
            comboBox2.SelectedIndex = Properties.Settings.Default.indexbaud;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }
        private void addPorts() {
            comboBox1.Items.Clear();
            enableComPorts = SerialPort.GetPortNames();

            foreach (string port in enableComPorts)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
            addPorts();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            command.Text = button1.Text.Length.ToString();
            if (button1.Text.Length == 5)
            {
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
                    serialPort1.BaudRate = Int16.Parse(comboBox2.Text); ;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    serialPort1.ReadTimeout = 1000;
                    serialPort1.WriteTimeout = 1000;
                    serialPort1.Open();

                    Properties.Settings.Default.indexcom = comboBox1.SelectedIndex;
                    Properties.Settings.Default.indexbaud = comboBox2.SelectedIndex;
                    Properties.Settings.Default.Save();
                    info.Text = comboBox2.SelectedIndex.ToString();
                    // command.Text = comboBox1.SelectedIndex.ToString();
                    serialPort1.Write("r");

                    button1.Text = "CLOSE";
                }
                catch (System.InvalidOperationException err)
                {

                    info.Text = err.Message;
                    return;
                }
                catch (System.UnauthorizedAccessException err) {
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


        }
        private delegate void fill(String data);
        private void fillData(String data) {
            command.Text = data;
            string[] spdata = data.Split('\r', '\n');
            trackBar1.Value = Convert.ToInt16(spdata[2].Substring(1));


            //  RadioButton btn = (RadioButton)this.Controls["m30"];
            //  btn.Enabled = false;

            RadioButton mode = (RadioButton)this.Controls.Find(spdata[0], true)[0];
            mode.Checked = true;
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String a = serialPort1.ReadExisting();
            Invoke(new fill(fillData),new object[] { a });
            
        }
    }
}
