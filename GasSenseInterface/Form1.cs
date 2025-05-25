using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GasSenseInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM3"; // Change COM3 to the appropriate port for your Arduino
            serialPort.BaudRate = 9600; // Should match the baud rate of your Arduino
            serialPort.DataReceived += SerialPort_DataReceived;
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            string[] values = data.Split(',');

            if (values.Length == 2)
            {
                string sensorValue = values[0];
                string gasPercentage = values[1];

                UpdateUI(sensorValue, gasPercentage);
            }
        }

        private void UpdateUI(string sensorValue, string gasPercentage)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    UpdateUI(sensorValue, gasPercentage);
                });
                return;
            }

            labelSensorValue.Text = sensorValue;
            labelGasPercentage.Text = gasPercentage;
            float result = float.Parse(labelGasPercentage.Text);
            if(result>25.0)
            {
                labelPercentCircle.ForeColor = Color.Red;
                labelCircleValue.ForeColor = Color.Red;
                labelLED.ForeColor = Color.Red;
            }
            else
            {
                labelPercentCircle.ForeColor = Color.Yellow;
                labelCircleValue.ForeColor = Color.Yellow;
                labelLED.ForeColor = Color.Lime;

            }
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
        }

        private void labelGasPercentage_Click(object sender, EventArgs e)
        {

        }
    }

 }    

