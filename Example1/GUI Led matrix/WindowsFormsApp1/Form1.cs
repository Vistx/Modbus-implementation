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
using EasyModbus;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        Color on1 = Color.Red;
        Color off1 = Color.FromArgb(255, 192, 192);
        ModbusClient ArduinoLed;
        int[] decnum_meg = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
       




        char[] column1= { '0', '0', '0', '0', '0', '0','0',  '0' };
        char[] column2 = { '0', '0', '0', '0', '0', '0', '0','0' };
        char[] column3 = { '0', '0', '0', '0', '0', '0', '0','0' };
        char[] column4 = { '0', '0', '0', '0', '0', '0', '0','0' };
        char[] column5 = { '0', '0', '0', '0', '0', '0', '0','0' };
        char[] column6 = { '0', '0', '0', '0', '0', '0', '0','0' };
        char[] column7 = { '0', '0', '0', '0', '0', '0', '0','0' };
        char[] column8 = { '0', '0', '0', '0', '0', '0', '0','0' };

        int bin_to_dec(string k)
        {
            
            int binaryNumber = int.Parse(k);
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
            
        }

        public Form1()  
        {
            
            InitializeComponent();
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            if (column1[0]=='1') { ovalPictureBox1.BackColor = off1; column1[0] = '0'; }
            else if(column1[0] =='0') { ovalPictureBox1.BackColor = on1; column1[0] = '1'; }
            
        }


        private void _Convert()
        {
            string k1 = new string(column1);
            string k2 = new string(column2);
            string k3 = new string(column3);
            string k4 = new string(column4);
            string k5 = new string(column5);
            string k6 = new string(column6);
            string k7 = new string(column7);
            string k8 = new string(column8);
            textBox1.Text = k1;
            textBox2.Text = k2;
            textBox3.Text = k3;
            textBox4.Text = k4;
            textBox5.Text = k5;
            textBox6.Text = k6;
            textBox7.Text = k7;
            textBox8.Text = k8;
            richTextBox1.Text = k1 + "\n" + k2 + "\n" + k3 + "\n" + k4 + "\n" + k5 + "\n" + k6 + "\n" + k7 + "\n" + k8;

            int[] decnum = new int[8];
            decnum[0] = bin_to_dec(k1);
            decnum[1] = bin_to_dec(k2);
            decnum[2] = bin_to_dec(k3);
            decnum[3] = bin_to_dec(k4);
            decnum[4] = bin_to_dec(k5);
            decnum[5] = bin_to_dec(k6);
            decnum[6] = bin_to_dec(k7);
            decnum[7] = bin_to_dec(k8);
            decnum_meg = decnum;

            string[] hexVlera = new string[8];
            hexVlera[0] = decnum[0].ToString("X");
            hexVlera[1] = decnum[1].ToString("X");
            hexVlera[2] = decnum[2].ToString("X");
            hexVlera[3] = decnum[3].ToString("X");
            hexVlera[4] = decnum[4].ToString("X");
            hexVlera[5] = decnum[5].ToString("X");
            hexVlera[6] = decnum[6].ToString("X");
            hexVlera[7] = decnum[7].ToString("X");

            richTextBox2.Text = Convert.ToString(decnum[0] + "," + decnum[1] + "," + decnum[2] + "," + decnum[3] + "," + decnum[4] + "," + decnum[5] + "," + decnum[6] + "," + decnum[7]);
            richTextBox3.Text = Convert.ToString(hexVlera[0] + "," + hexVlera[1] + "," + hexVlera[2] + "," + hexVlera[3] + "," + hexVlera[4] + "," + hexVlera[5] + "," + hexVlera[6] + "," + hexVlera[7]);
            mesazhi_lbl.Text = richTextBox2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            _Convert();
        }

        private void ovalPictureBox16_Click(object sender, EventArgs e)
        {
            if (column1[1] == '1') { ovalPictureBox16.BackColor = off1; column1[1] = '0'; }
            else if (column1[1] == '0') { ovalPictureBox16.BackColor = on1; column1[1] = '1'; }
        }

        private void ovalPictureBox24_Click(object sender, EventArgs e)
        {
            if (column1[2] == '1') { ovalPictureBox24.BackColor = off1; column1[2] = '0'; }
            else if (column1[2] == '0') { ovalPictureBox24.BackColor = on1; column1[2] = '1'; }
        }

        private void ovalPictureBox32_Click(object sender, EventArgs e)
        {
            if (column1[3] == '1') { ovalPictureBox32.BackColor = off1; column1[3] = '0'; }
            else if (column1[3] == '0') { ovalPictureBox32.BackColor = on1; column1[3] = '1'; }
        }

        private void ovalPictureBox64_Click(object sender, EventArgs e)
        {
            if (column1[4] == '1') { ovalPictureBox64.BackColor = off1; column1[4] = '0'; }
            else if (column1[4] == '0') { ovalPictureBox64.BackColor = on1; column1[4] = '1'; }
        }

        private void ovalPictureBox56_Click(object sender, EventArgs e)
        {
            if (column1[5] == '1') { ovalPictureBox56.BackColor = off1; column1[5] = '0'; }
            else if (column1[5] == '0') { ovalPictureBox56.BackColor = on1; column1[5] = '1'; }
        }

        private void ovalPictureBox48_Click(object sender, EventArgs e)
        {
            if (column1[6] == '1') { ovalPictureBox48.BackColor = off1; column1[6] = '0'; }
            else if (column1[6] == '0') { ovalPictureBox48.BackColor = on1; column1[6] = '1'; }
        }

        private void ovalPictureBox40_Click(object sender, EventArgs e)
        {
            if (column1[7] == '1') { ovalPictureBox40.BackColor = off1; column1[7] = '0'; }
            else if (column1[7] == '0') { ovalPictureBox40.BackColor = on1; column1[7] = '1'; }
        }

        private void ovalPictureBox2_Click(object sender, EventArgs e)
        {
            if (column2[0] == '1') { ovalPictureBox2.BackColor = off1; column2[0] = '0'; }
            else if (column2[0] == '0') { ovalPictureBox2.BackColor = on1; column2[0] = '1'; }
        }

        private void ovalPictureBox15_Click(object sender, EventArgs e)
        {
            if (column2[1] == '1') { ovalPictureBox15.BackColor = off1; column2[1] = '0'; }
            else if (column2[1] == '0') { ovalPictureBox15.BackColor = on1; column2[1] = '1'; }
        }

        private void ovalPictureBox23_Click(object sender, EventArgs e)
        {
            if (column2[2] == '1') { ovalPictureBox23.BackColor = off1; column2[2] = '0'; }
            else if (column2[2] == '0') { ovalPictureBox23.BackColor = on1; column2[2] = '1'; }
        }

        private void ovalPictureBox31_Click(object sender, EventArgs e)
        {
            if (column2[3] == '1') { ovalPictureBox31.BackColor = off1; column2[3] = '0'; }
            else if (column2[3] == '0') { ovalPictureBox31.BackColor = on1; column2[3] = '1'; }
        }

        private void ovalPictureBox63_Click(object sender, EventArgs e)
        {
            if (column2[4] == '1') { ovalPictureBox63.BackColor = off1; column2[4] = '0'; }
            else if (column2[4] == '0') { ovalPictureBox63.BackColor = on1; column2[4] = '1'; }
        }

        private void ovalPictureBox55_Click(object sender, EventArgs e)
        {
            if (column2[5] == '1') { ovalPictureBox55.BackColor = off1; column2[5] = '0'; }
            else if (column2[5] == '0') { ovalPictureBox55.BackColor = on1; column2[5] = '1'; }
        }

        private void ovalPictureBox47_Click(object sender, EventArgs e)
        {
            if (column2[6] == '1') { ovalPictureBox47.BackColor = off1; column2[6] = '0'; }
            else if (column2[6] == '0') { ovalPictureBox47.BackColor = on1; column2[6] = '1'; }
        }

        private void ovalPictureBox39_Click(object sender, EventArgs e)
        {
            if (column2[7] == '1') { ovalPictureBox39.BackColor = off1; column2[7] = '0'; }
            else if (column2[7] == '0') { ovalPictureBox39.BackColor = on1; column2[7] = '1'; }
        }

        private void ovalPictureBox4_Click(object sender, EventArgs e)
        {
            if (column3[0] == '1') { ovalPictureBox4.BackColor = off1; column3[0] = '0'; }
            else if (column3[0] == '0') { ovalPictureBox4.BackColor = on1; column3[0] = '1'; }
        }

        private void ovalPictureBox14_Click(object sender, EventArgs e)
        {
            if (column3[1] == '1') { ovalPictureBox14.BackColor = off1; column3[1] = '0'; }
            else if (column3[1] == '0') { ovalPictureBox14.BackColor = on1; column3[1] = '1'; }
        }

        private void ovalPictureBox22_Click(object sender, EventArgs e)
        {
            if (column3[2] == '1') { ovalPictureBox22.BackColor = off1; column3[2] = '0'; }
            else if (column3[2] == '0') { ovalPictureBox22.BackColor = on1; column3[2] = '1'; }
        }

        private void ovalPictureBox30_Click(object sender, EventArgs e)
        {
            if (column3[3] == '1') { ovalPictureBox30.BackColor = off1; column3[3] = '0'; }
            else if (column3[3] == '0') { ovalPictureBox30.BackColor = on1; column3[3] = '1'; }
        }

        private void ovalPictureBox62_Click(object sender, EventArgs e)
        {
            if (column3[4] == '1') { ovalPictureBox62.BackColor = off1; column3[4] = '0'; }
            else if (column3[4] == '0') { ovalPictureBox62.BackColor = on1; column3[4] = '1'; }
        }

        private void ovalPictureBox54_Click(object sender, EventArgs e)
        {
            if (column3[5] == '1') { ovalPictureBox54.BackColor = off1; column3[5] = '0'; }
            else if (column3[5] == '0') { ovalPictureBox54.BackColor = on1; column3[5] = '1'; }
        }

        private void ovalPictureBox46_Click(object sender, EventArgs e)
        {
            if (column3[6] == '1') { ovalPictureBox46.BackColor = off1; column3[6] = '0'; }
            else if (column3[6] == '0') { ovalPictureBox46.BackColor = on1; column3[6] = '1'; }
        }

        private void ovalPictureBox38_Click(object sender, EventArgs e)
        {
            if (column3[7] == '1') { ovalPictureBox38.BackColor = off1; column3[7] = '0'; }
            else if (column3[7] == '0') { ovalPictureBox38.BackColor = on1; column3[7] = '1'; }
        }

        private void ovalPictureBox3_Click(object sender, EventArgs e)
        {
            if (column4[0] == '1') { ovalPictureBox3.BackColor = off1; column4[0] = '0'; }
            else if (column4[0] == '0') { ovalPictureBox3.BackColor = on1; column4[0] = '1'; }
        }

        private void ovalPictureBox13_Click(object sender, EventArgs e)
        {
            if (column4[1] == '1') { ovalPictureBox13.BackColor = off1; column4[1] = '0'; }
            else if (column4[1] == '0') { ovalPictureBox13.BackColor = on1; column4[1] = '1'; }
        }

        private void ovalPictureBox21_Click(object sender, EventArgs e)
        {
            if (column4[2] == '1') { ovalPictureBox21.BackColor = off1; column4[2] = '0'; }
            else if (column4[2] == '0') { ovalPictureBox21.BackColor = on1; column4[2] = '1'; }
        }

        private void ovalPictureBox29_Click(object sender, EventArgs e)
        {
            if (column4[3] == '1') { ovalPictureBox29.BackColor = off1; column4[3] = '0'; }
            else if (column4[3] == '0') { ovalPictureBox29.BackColor = on1; column4[3] = '1'; }
        }

        private void ovalPictureBox61_Click(object sender, EventArgs e)
        {
            if (column4[4] == '1') { ovalPictureBox61.BackColor = off1; column4[4] = '0'; }
            else if (column4[4] == '0') { ovalPictureBox61.BackColor = on1; column4[4] = '1'; }
        }

        private void ovalPictureBox53_Click(object sender, EventArgs e)
        {
            if (column4[5] == '1') { ovalPictureBox53.BackColor = off1; column4[5] = '0'; }
            else if (column4[5] == '0') { ovalPictureBox53.BackColor = on1; column4[5] = '1'; }
        }

        private void ovalPictureBox45_Click(object sender, EventArgs e)
        {
            if (column4[6] == '1') { ovalPictureBox45.BackColor = off1; column4[6] = '0'; }
            else if (column4[6] == '0') { ovalPictureBox45.BackColor = on1; column4[6] = '1'; }
        }

        private void ovalPictureBox37_Click(object sender, EventArgs e)
        {
            if (column4[7] == '1') { ovalPictureBox37.BackColor = off1; column4[7] = '0'; }
            else if (column4[7] == '0') { ovalPictureBox37.BackColor = on1; column4[7] = '1'; }
        }

        private void ovalPictureBox8_Click(object sender, EventArgs e)
        {
            if (column5[0] == '1') { ovalPictureBox8.BackColor = off1; column5[0] = '0'; }
            else if (column5[0] == '0') { ovalPictureBox8.BackColor = on1; column5[0] = '1'; }
        }

        private void ovalPictureBox12_Click(object sender, EventArgs e)
        {
            if (column5[1] == '1') { ovalPictureBox12.BackColor = off1; column5[1] = '0'; }
            else if (column5[1] == '0') { ovalPictureBox12.BackColor = on1; column5[1] = '1'; }
        }

        private void ovalPictureBox20_Click(object sender, EventArgs e)
        {
            if (column5[2] == '1') { ovalPictureBox20.BackColor = off1; column5[2] = '0'; }
            else if (column5[2] == '0') { ovalPictureBox20.BackColor = on1; column5[2] = '1'; }
        }

        private void ovalPictureBox28_Click(object sender, EventArgs e)
        {
            if (column5[3] == '1') { ovalPictureBox28.BackColor = off1; column5[3] = '0'; }
            else if (column5[3] == '0') { ovalPictureBox28.BackColor = on1; column5[3] = '1'; }
        }

        private void ovalPictureBox60_Click(object sender, EventArgs e)
        {
            if (column5[4] == '1') { ovalPictureBox60.BackColor = off1; column5[4] = '0'; }
            else if (column5[4] == '0') { ovalPictureBox60.BackColor = on1; column5[4] = '1'; }
        }

        private void ovalPictureBox52_Click(object sender, EventArgs e)
        {
            if (column5[5] == '1') { ovalPictureBox52.BackColor = off1; column5[5] = '0'; }
            else if (column5[5] == '0') { ovalPictureBox52.BackColor = on1; column5[5] = '1'; }
        }

        private void ovalPictureBox44_Click(object sender, EventArgs e)
        {
            if (column5[6] == '1') { ovalPictureBox44.BackColor = off1; column5[6] = '0'; }
            else if (column5[6] == '0') { ovalPictureBox44.BackColor = on1; column5[6] = '1'; }
        }

        private void ovalPictureBox36_Click(object sender, EventArgs e)
        {
            if (column5[7] == '1') { ovalPictureBox36.BackColor = off1; column5[7] = '0'; }
            else if (column5[7] == '0') { ovalPictureBox36.BackColor = on1; column5[7] = '1'; }
        }

        private void ovalPictureBox7_Click(object sender, EventArgs e)
        {
            if (column6[0] == '1') { ovalPictureBox7.BackColor = off1; column6[0] = '0'; }
            else if (column6[0] == '0') { ovalPictureBox7.BackColor = on1; column6[0] = '1'; }

        }

        private void ovalPictureBox11_Click(object sender, EventArgs e)
        {
            if (column6[1] == '1') { ovalPictureBox11.BackColor = off1; column6[1] = '0'; }
            else if (column6[1] == '0') { ovalPictureBox11.BackColor = on1; column6[1] = '1'; }

        }

        private void ovalPictureBox19_Click(object sender, EventArgs e)
        {
            if (column6[2] == '1') { ovalPictureBox19.BackColor = off1; column6[2] = '0'; }
            else if (column6[2] == '0') { ovalPictureBox19.BackColor = on1; column6[2] = '1'; }

        }

        private void ovalPictureBox27_Click(object sender, EventArgs e)
        {
            if (column6[3] == '1') { ovalPictureBox27.BackColor = off1; column6[3] = '0'; }
            else if (column6[3] == '0') { ovalPictureBox27.BackColor = on1; column6[3] = '1'; }
        }

        private void ovalPictureBox59_Click(object sender, EventArgs e)
        {
            if (column6[4] == '1') { ovalPictureBox59.BackColor = off1; column6[4] = '0'; }
            else if (column6[4] == '0') { ovalPictureBox59.BackColor = on1; column6[4] = '1'; }
        }

        private void ovalPictureBox51_Click(object sender, EventArgs e)
        {
            if (column6[5] == '1') { ovalPictureBox51.BackColor = off1; column6[5] = '0'; }
            else if (column6[5] == '0') { ovalPictureBox51.BackColor = on1; column6[5] = '1'; }
        }

        private void ovalPictureBox43_Click(object sender, EventArgs e)
        {

            if (column6[6] == '1') { ovalPictureBox43.BackColor = off1; column6[6] = '0'; }
            else if (column6[6] == '0') { ovalPictureBox43.BackColor = on1; column6[6] = '1'; }

        }

        private void ovalPictureBox35_Click(object sender, EventArgs e)
        {
            if (column6[7] == '1') { ovalPictureBox35.BackColor = off1; column6[7] = '0'; }
            else if (column6[7] == '0') { ovalPictureBox35.BackColor = on1; column6[7] = '1'; }
        }

        private void ovalPictureBox6_Click(object sender, EventArgs e)
        {
            if (column7[0] == '1') { ovalPictureBox6.BackColor = off1; column7[0] = '0'; }
            else if (column7[0] == '0') { ovalPictureBox6.BackColor = on1; column7[0] = '1'; }
        }

        private void ovalPictureBox10_Click(object sender, EventArgs e)
        {
            if (column7[1] == '1') { ovalPictureBox10.BackColor = off1; column7[1] = '0'; }
            else if (column7[1] == '0') { ovalPictureBox10.BackColor = on1; column7[1] = '1'; }
        }

        private void ovalPictureBox18_Click(object sender, EventArgs e)
        {
            if (column7[2] == '1') { ovalPictureBox18.BackColor = off1; column7[2] = '0'; }
            else if (column7[2] == '0') { ovalPictureBox18.BackColor = on1; column7[2] = '1'; }
        }

        private void ovalPictureBox26_Click(object sender, EventArgs e)
        {
            if (column7[3] == '1') { ovalPictureBox26.BackColor = off1; column7[3] = '0'; }
            else if (column7[3] == '0') { ovalPictureBox26.BackColor = on1; column7[3] = '1'; }
        }

        private void ovalPictureBox58_Click(object sender, EventArgs e)
        {
            if (column7[4] == '1') { ovalPictureBox58.BackColor = off1; column7[4] = '0'; }
            else if (column7[4] == '0') { ovalPictureBox58.BackColor = on1; column7[4] = '1'; }
        }

        private void ovalPictureBox50_Click(object sender, EventArgs e)
        {
            if (column7[5] == '1') { ovalPictureBox50.BackColor = off1; column7[5] = '0'; }
            else if (column7[5] == '0') { ovalPictureBox50.BackColor = on1; column7[5] = '1'; }
        }

        private void ovalPictureBox42_Click(object sender, EventArgs e)
        {
            if (column7[6] == '1') { ovalPictureBox42.BackColor = off1; column7[6] = '0'; }
            else if (column7[6] == '0') { ovalPictureBox42.BackColor = on1; column7[6] = '1'; }
        }

        private void ovalPictureBox34_Click(object sender, EventArgs e)
        {
            if (column7[7] == '1') { ovalPictureBox34.BackColor = off1; column7[7] = '0'; }
            else if (column7[7] == '0') { ovalPictureBox34.BackColor = on1; column7[7] = '1'; }
        }

        private void ovalPictureBox5_Click(object sender, EventArgs e)
        {
            if (column8[0] == '1') { ovalPictureBox5.BackColor = off1; column8[0] = '0'; }
            else if (column8[0] == '0') { ovalPictureBox5.BackColor = on1; column8[0] = '1'; }
        }

        private void ovalPictureBox9_Click(object sender, EventArgs e)
        {
            if (column8[1] == '1') { ovalPictureBox9.BackColor = off1; column8[1] = '0'; }
            else if (column8[1] == '0') { ovalPictureBox9.BackColor = on1; column8[1] = '1'; }
        }

        private void ovalPictureBox17_Click(object sender, EventArgs e)
        {
            if (column8[2] == '1') { ovalPictureBox17.BackColor = off1; column8[2] = '0'; }
            else if (column8[2] == '0') { ovalPictureBox17.BackColor = on1; column8[2] = '1'; }
        }

        private void ovalPictureBox25_Click(object sender, EventArgs e)
        {
            if (column8[3] == '1') { ovalPictureBox25.BackColor = off1; column8[3] = '0'; }
            else if (column8[3] == '0') { ovalPictureBox25.BackColor = on1; column8[3] = '1'; }
        }

        private void ovalPictureBox57_Click(object sender, EventArgs e)
        {
            if (column8[4] == '1') { ovalPictureBox57.BackColor = off1; column8[4] = '0'; }
            else if (column8[4] == '0') { ovalPictureBox57.BackColor = on1; column8[4] = '1'; }
        }

        private void ovalPictureBox49_Click(object sender, EventArgs e)
        {
            if (column8[5] == '1') { ovalPictureBox49.BackColor = off1; column8[5] = '0'; }
            else if (column8[5] == '0') { ovalPictureBox49.BackColor = on1; column8[5] = '1'; }
        }

        private void ovalPictureBox41_Click(object sender, EventArgs e)
        {
            if (column8[6] == '1') { ovalPictureBox41.BackColor = off1; column8[6] = '0'; }
            else if (column8[6] == '0') { ovalPictureBox41.BackColor = on1; column8[6] = '1'; }
        }

        private void ovalPictureBox33_Click(object sender, EventArgs e)
        {

            if (column8[7] == '1') { ovalPictureBox33.BackColor = off1; column8[7] = '0'; }
            else if (column8[7] == '0') { ovalPictureBox33.BackColor = on1; column8[7] = '1'; }
        }

        private void com_porta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void com_porta_DropDown(object sender, EventArgs e)
        {
            String[] portet = SerialPort.GetPortNames();//referenca per io.
            com_porta.Items.Clear();
            com_porta.Items.AddRange(portet);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            for (int i = 1; i <= 247; i++)  //DERI 247 Slave
            {
                s_id.Items.Add(Convert.ToString(i));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _baudrate.Text = "115200";
            s_id.Text = "1";
        }

        private void l_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoLed = new ModbusClient(com_porta.Text);
                ArduinoLed.Parity = System.IO.Ports.Parity.None;
                ArduinoLed.Baudrate = int.Parse(_baudrate.Text);
                ArduinoLed.UnitIdentifier = Convert.ToByte(s_id.Text);
                ArduinoLed.Connect();
                l_btn.Enabled = false;
                dergo_.Enabled = true;
                shk_btn.Enabled = true;
                progressBar1.Value = 100;
                label16.Text = "Connected";
                label16.ForeColor = Color.Green;

            }
            catch (Exception)
            {
                label16.Text = "Something Went Wrong!";
                label16.ForeColor = Color.Red;
            }
        }

        private void shk_btn_Click(object sender, EventArgs e)
        {
            ArduinoLed.Disconnect();
            l_btn.Enabled = true;
            dergo_.Enabled = false;
            shk_btn.Enabled = false;
            label16.Text = "Disconnected";
            label16.ForeColor = Color.Red;
            progressBar1.Value = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _Convert();
            ArduinoLed.WriteMultipleRegisters(0, decnum_meg);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dergo_.Enabled = false;
            shk_btn.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
