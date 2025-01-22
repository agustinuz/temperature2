namespace ModbusTemperature
{
    partial class Form3
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
            panel1 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 593);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(31, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 381);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(166, 313);
            button3.Name = "button3";
            button3.Size = new Size(152, 31);
            button3.TabIndex = 12;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(166, 253);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(187, 23);
            comboBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label6.Location = new Point(35, 260);
            label6.Name = "label6";
            label6.Size = new Size(105, 18);
            label6.TabIndex = 10;
            label6.Text = "Port Modbus";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(166, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 23);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label5.Location = new Point(35, 219);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 8;
            label5.Text = "Timer Reading";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.Location = new Point(35, 170);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 6;
            label4.Text = "Temp Timer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.Location = new Point(166, 104);
            label3.Name = "label3";
            label3.Size = new Size(135, 18);
            label3.TabIndex = 5;
            label3.Text = "Link Send Status";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(35, 120);
            button2.Name = "button2";
            button2.Size = new Size(102, 28);
            button2.TabIndex = 4;
            button2.Text = "Save Link";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.Location = new Point(166, 120);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 28);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label2.Location = new Point(195, 34);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 1;
            label2.Text = "Setting";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(92, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 107);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(140, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 28);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(12, 45);
            button1.Name = "button1";
            button1.Size = new Size(84, 28);
            button1.TabIndex = 1;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(105, 10);
            label1.Name = "label1";
            label1.Size = new Size(175, 18);
            label1.TabIndex = 0;
            label1.Text = "Create New Employee";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 611);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Button button3;
    }
}