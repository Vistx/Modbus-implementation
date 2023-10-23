
namespace SimpleFunctionGui
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.value_box = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.nmbus_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(290, 170);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modbus Connection Settings";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state.Location = new System.Drawing.Point(120, 140);
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
            this.label15.Location = new System.Drawing.Point(25, 138);
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
            this.shk_btn.Location = new System.Drawing.Point(157, 94);
            this.shk_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shk_btn.Name = "shk_btn";
            this.shk_btn.Size = new System.Drawing.Size(92, 25);
            this.shk_btn.TabIndex = 1;
            this.shk_btn.Text = "Disconnect";
            this.shk_btn.UseVisualStyleBackColor = true;
            this.shk_btn.Click += new System.EventHandler(this.shk_btn_Click);
            // 
            // l_btn
            // 
            this.l_btn.Location = new System.Drawing.Point(68, 94);
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
            this.nmbus_panel.Controls.Add(this.richTextBox2);
            this.nmbus_panel.Controls.Add(this.button2);
            this.nmbus_panel.Controls.Add(this.button1);
            this.nmbus_panel.Controls.Add(this.label2);
            this.nmbus_panel.Controls.Add(this.reg_box);
            this.nmbus_panel.Controls.Add(this.label1);
            this.nmbus_panel.Controls.Add(this.value_box);
            this.nmbus_panel.Enabled = false;
            this.nmbus_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbus_panel.Location = new System.Drawing.Point(308, 12);
            this.nmbus_panel.Name = "nmbus_panel";
            this.nmbus_panel.Size = new System.Drawing.Size(364, 352);
            this.nmbus_panel.TabIndex = 28;
            this.nmbus_panel.TabStop = false;
            this.nmbus_panel.Text = "NModbus4 Panel  Master Read/Write";
            // 
            // richTextBox2
            // 
            this.richTextBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.richTextBox2.Location = new System.Drawing.Point(35, 149);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(286, 167);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "- Register range from 0 to 15\n\n- Do not leave empty values in the register \n   or" +
    " value box when performing operations";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Register:";
            // 
            // reg_box
            // 
            this.reg_box.Location = new System.Drawing.Point(115, 55);
            this.reg_box.Name = "reg_box";
            this.reg_box.Size = new System.Drawing.Size(93, 22);
            this.reg_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value:";
            // 
            // value_box
            // 
            this.value_box.Location = new System.Drawing.Point(115, 96);
            this.value_box.Name = "value_box";
            this.value_box.Size = new System.Drawing.Size(93, 22);
            this.value_box.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(12, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(290, 142);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(118, 328);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(84, 25);
            this.clear_btn.TabIndex = 30;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 365);
            this.Controls.Add(this.clear_btn);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button clear_btn;
    }
}

