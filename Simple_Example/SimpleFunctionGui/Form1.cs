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

namespace SimpleFunctionGui
{
    public partial class Form1 : Form
    {

       
        SerialPort _port;
        ModbusSerialMaster _master;
        public Form1()
        {
            InitializeComponent();
            _baudrate.SelectedIndex = 2;
            
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
                richTextBox1.AppendText("Connected to Com Port as Device Master");
                shk_btn.Enabled = true;
                l_btn.Enabled = false;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong!!", "More Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label_state.Text = "Disconnected";
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
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ushort reg_value = ushort.Parse(reg_box.Text);

                if (reg_value >= 0 & reg_value <= 15 & !string.IsNullOrWhiteSpace(reg_box.Text))
                {
                    ushort[] val = _master.ReadHoldingRegisters(1, reg_value, 1);
                    value_box.Text = val[0].ToString();
                    richTextBox1.AppendText("\n");
                    richTextBox1.AppendText("In Reg:[" + reg_value + "]  is the value :" + val[0].ToString());
                }
                else
                {
                    richTextBox1.AppendText("\nInvalid input");
                }
            }
            catch (Exception)
            {
                richTextBox1.AppendText("\nInvalid input");
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            ushort reg_value = ushort.Parse(reg_box.Text);
            ushort value = ushort.Parse(value_box.Text);

            if (reg_value >= 0 & reg_value <= 15 & !string.IsNullOrWhiteSpace(value_box.Text) & !string.IsNullOrWhiteSpace(reg_box.Text))
            {
                _master.WriteSingleRegister(1, reg_value, value);
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText("In Reg:["+reg_value+"] Wrote  Value "+ value_box.Text);

            }
            else
            {
                richTextBox1.AppendText("\nInvalid input");
                
            }
            }
            catch (Exception)
            {
                richTextBox1.AppendText("");
                richTextBox1.AppendText("Invalid input");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }
    }

    


}

