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
            label1.Text = Properties.Settings.Default.indexcom.ToString();
            comboBox1.SelectedIndex = Properties.Settings.Default.indexcom ;
            comboBox2.SelectedIndex  = Properties.Settings.Default.indexbaud;
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
         //   label1.Text = comboBox2.Text;
        if (comboBox2.SelectedIndex == -1) {
                label1.Text = "lol";
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
                label1.Text = "OPEN";
                Properties.Settings.Default.indexcom = comboBox1.SelectedIndex;
                Properties.Settings.Default.indexbaud = comboBox2.SelectedIndex;
                label2.Text = comboBox1.SelectedIndex.ToString();
            }
            catch
            {
                label1.Text = "ERROR";
                return;
            }
        }

        private void TrackBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            serialPort1.Write("b" + trackBar1.Value.ToString());
        }
        private void Select_Mode(object sender, EventArgs e)
        {
            
            RadioButton rb = sender as RadioButton;
            label1.Text = rb.Text;
            label2.Text = rb.Name;
            serialPort1.Write(rb.Name);

        }




    }
}
