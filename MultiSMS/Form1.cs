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

namespace MultiSMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //////////////Dodawanie aktywnych portów do listy
            foreach (string s in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(s);
            }
            
            cbBaudrate.SelectedIndex = 2; //domyslnie 9600
            cbParity.SelectedIndex = 0;
            cbDataBits.SelectedIndex = 3;
            cbStopBit.SelectedIndex = 0;
            cbHandshake.SelectedIndex = 0;
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cbPort.SelectedItem.ToString();
            serialPort1.BaudRate = Int32.Parse(cbBaudrate.Text);
            serialPort1.Parity = (Parity)cbParity.SelectedIndex;
            serialPort1.DataBits = Int32.Parse(cbDataBits.Text);
            serialPort1.StopBits = (StopBits)(cbStopBit.SelectedIndex+1);
            serialPort1.Handshake = (Handshake)cbHandshake.SelectedIndex;
            serialPort1.DtrEnable = cbDTR.Checked;
            serialPort1.RtsEnable = cbRTS.Checked;
            if(!serialPort1.IsOpen)
            {
                serialPort1.Open();
                btnConnect.BackColor = Color.Green;
            }

            

        }
    }
}
