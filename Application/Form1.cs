using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace serial_port_comunication
{
    public partial class MainWindow : Form
    {
        System.IO.Ports.SerialPort serialPort;

        delegate void delegate1();
        delegate1 mydelegate;


        public MainWindow()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            

            serialPort.DataReceived +=new SerialDataReceivedEventHandler(DataReceivedHandler);
            mydelegate = new delegate1(displayReceived);

      
        }

        private void displayReceived(/*object sender, SerialDataReceivedEventArgs e*/)
        {
            string message = "";
            try
            {
                message = serialPort.ReadLine();
            }
            catch(Exception ex)
            {
                message = "Receiving message goes wrong";
            }

            if (inPlaceCheckBox.Checked)
            {
                receivedMessageTextBox.Text = message;
            }
            else
            {
                receivedMessageTextBox.Text += message + Environment.NewLine;
            }
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            receivedMessageTextBox.Invoke(mydelegate);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            updateAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                MessageBox.Show("Already connected to the device");
            }
            else
            {
                try
                {
                    serialPort.PortName = this.comPortComboBox.Text;
                    serialPort.BaudRate = Int32.Parse(this.baudRateComboBox.Text);
                    serialPort.DataBits = Int32.Parse(this.dataBitsComboBox.Text);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.parityComboBox.Text);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.stopBitsComboBox.Text);
                    this.connectButton.BackColor = System.Drawing.Color.FromArgb(0, 80, 0);
                    serialPort.Open();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Connection error: " + exc.Message);
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                string value = messageTextBox.Text;
                int len = value.Length;
                string final = "L ";
                for (int i = 0; i < 5 - value.Length; i++)
                {
                    final += '0';
                }
                final += value;
                sendMessageTextBox.Text += value + " LUX" + Environment.NewLine;
                serialPort.Write(final);
                messageTextBox.Clear();
            }
            else
            {
                MessageBox.Show("You have no connection to the device");
            }
        }

        private void rescanButton_Click(object sender, EventArgs e)
        {
            updateAvailablePorts();
        }

        private void updateAvailablePorts()
        { 
            comPortComboBox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comPortComboBox.Items.Add(s);
            }
        }

        private void clearRecivedMessageButton_Click(object sender, EventArgs e)
        {
            receivedMessageTextBox.Clear();
        }

        private void clearSendMessageButton_Click(object sender, EventArgs e)
        {
            sendMessageTextBox.Clear();
        }
    }
}
