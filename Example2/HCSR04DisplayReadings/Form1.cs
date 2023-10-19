using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Device;
using System.IO.Ports;
using System.Windows.Forms;

namespace HCSR04DisplayReadings
{
    public partial class Form1 : Form
    {
        SerialPort _port;
        ModbusSerialMaster _master;
  
        public Form1()
        {
            InitializeComponent();
            _baudrate.SelectedIndex = 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }


        private void com_porta_DropDown(object sender, EventArgs e)
        {
            String[] portet = SerialPort.GetPortNames();//referenca per io.
            com_porta.Items.Clear();
            com_porta.Items.AddRange(portet);
        }



        private void l_btn_Click(object sender, EventArgs e)
        {
            try
            {
                _port = new SerialPort(com_porta.Text, Convert.ToInt32(_baudrate.Text));
                _port.ReadTimeout = 1000;
                _port.WriteTimeout = 1000;
                _port.Open();
                label_state.Text = "Connected";
                label_state.ForeColor = Color.Green;
                nmbus_panel.Enabled = true;
                _master = ModbusSerialMaster.CreateRtu(_port);
                _master.Transport.ReadTimeout = 1300;
                richTextBox1.AppendText("Connected to COM as Master");
                shk_btn.Enabled = true;
                l_btn.Enabled = false;
                timer1.Interval = Int16.Parse(timer_int_box.Text);
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing Went wrong", "More Info:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label_state.Text = "Disconected";
                label_state.ForeColor = Color.Red;
            }
        }



        private void shk_btn_Click(object sender, EventArgs e)
        {
            _master.Dispose();
            _master = null;

            // Destroy serial port
            _port.Close();
            _port.Dispose();
            _port = null;
            shk_btn.Enabled = false;
            l_btn.Enabled = true;
            nmbus_panel.Enabled = false;
            richTextBox1.Clear();
            timer1.Stop();
        }
      

        
      
        private void timer1_Tick(object sender, EventArgs e)
        {
           ushort[] ESP32_Registers = _master.ReadHoldingRegisters(1,0,15);
            temp_reading_label.Text = ESP32_Registers[0].ToString()+" cm";







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    


}

