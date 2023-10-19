
namespace HCSR04DisplayReadings
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_state = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._baudrate = new System.Windows.Forms.ComboBox();
            this.com_porta = new System.Windows.Forms.ComboBox();
            this.shk_btn = new System.Windows.Forms.Button();
            this.l_btn = new System.Windows.Forms.Button();
            this.nmbus_panel = new System.Windows.Forms.GroupBox();
            this.temp_reading_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer_int_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.nmbus_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.timer_int_box);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_state);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this._baudrate);
            this.groupBox2.Controls.Add(this.com_porta);
            this.groupBox2.Controls.Add(this.shk_btn);
            this.groupBox2.Controls.Add(this.l_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(290, 208);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modbus Settings";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state.Location = new System.Drawing.Point(102, 178);
            this.label_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(20, 25);
            this.label_state.TabIndex = 26;
            this.label_state.Text = "~";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 176);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 18);
            this.label15.TabIndex = 10;
            this.label15.Text = "State :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "BaudRate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "ComPort";
            // 
            // _baudrate
            // 
            this._baudrate.FormattingEnabled = true;
            this._baudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this._baudrate.Location = new System.Drawing.Point(133, 54);
            this._baudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._baudrate.Name = "_baudrate";
            this._baudrate.Size = new System.Drawing.Size(108, 24);
            this._baudrate.TabIndex = 3;
            // 
            // com_porta
            // 
            this.com_porta.FormattingEnabled = true;
            this.com_porta.Location = new System.Drawing.Point(133, 22);
            this.com_porta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_porta.Name = "com_porta";
            this.com_porta.Size = new System.Drawing.Size(108, 24);
            this.com_porta.TabIndex = 2;
            this.com_porta.DropDown += new System.EventHandler(this.com_porta_DropDown);
            // 
            // shk_btn
            // 
            this.shk_btn.Enabled = false;
            this.shk_btn.Location = new System.Drawing.Point(146, 137);
            this.shk_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shk_btn.Name = "shk_btn";
            this.shk_btn.Size = new System.Drawing.Size(95, 25);
            this.shk_btn.TabIndex = 1;
            this.shk_btn.Text = "Disconnect";
            this.shk_btn.UseVisualStyleBackColor = true;
            this.shk_btn.Click += new System.EventHandler(this.shk_btn_Click);
            // 
            // l_btn
            // 
            this.l_btn.Location = new System.Drawing.Point(57, 137);
            this.l_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.l_btn.Name = "l_btn";
            this.l_btn.Size = new System.Drawing.Size(84, 25);
            this.l_btn.TabIndex = 0;
            this.l_btn.Text = "Connect";
            this.l_btn.UseVisualStyleBackColor = true;
            this.l_btn.Click += new System.EventHandler(this.l_btn_Click);
            // 
            // nmbus_panel
            // 
            this.nmbus_panel.Controls.Add(this.temp_reading_label);
            this.nmbus_panel.Controls.Add(this.label1);
            this.nmbus_panel.Enabled = false;
            this.nmbus_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbus_panel.Location = new System.Drawing.Point(308, 12);
            this.nmbus_panel.Name = "nmbus_panel";
            this.nmbus_panel.Size = new System.Drawing.Size(329, 381);
            this.nmbus_panel.TabIndex = 28;
            this.nmbus_panel.TabStop = false;
            this.nmbus_panel.Text = "NModbus4 Panel  Master";
            // 
            // temp_reading_label
            // 
            this.temp_reading_label.AutoSize = true;
            this.temp_reading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_reading_label.ForeColor = System.Drawing.Color.Navy;
            this.temp_reading_label.Location = new System.Drawing.Point(207, 84);
            this.temp_reading_label.Name = "temp_reading_label";
            this.temp_reading_label.Size = new System.Drawing.Size(0, 32);
            this.temp_reading_label.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance(cm): ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(12, 224);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(290, 169);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Update Interval: ";
            // 
            // timer_int_box
            // 
            this.timer_int_box.Location = new System.Drawing.Point(133, 93);
            this.timer_int_box.Name = "timer_int_box";
            this.timer_int_box.Size = new System.Drawing.Size(71, 22);
            this.timer_int_box.TabIndex = 2;
            this.timer_int_box.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "milisec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 398);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nmbus_panel);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.nmbus_panel.ResumeLayout(false);
            this.nmbus_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox _baudrate;
        private System.Windows.Forms.ComboBox com_porta;
        private System.Windows.Forms.Button shk_btn;
        private System.Windows.Forms.Button l_btn;
        private System.Windows.Forms.GroupBox nmbus_panel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temp_reading_label;
        private System.Windows.Forms.TextBox timer_int_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

