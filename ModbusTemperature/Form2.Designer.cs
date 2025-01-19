namespace ModbusTemperature
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            button1 = new Button();
            panel5 = new Panel();
            linkLabel8 = new LinkLabel();
            linkLabel7 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label13 = new Label();
            panel6 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Data Temperature";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Size = new Size(964, 616);
            chart1.TabIndex = 6;
            chart1.Text = "Chart Temperature Data";
            chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            title1.Name = "Title1";
            title1.Text = "Temperature Chart";
            title2.Name = "test";
            chart1.Titles.Add(title1);
            chart1.Titles.Add(title2);
            chart1.Click += chart1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(1248, 668);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(chart1);
            panel3.Location = new Point(243, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(964, 616);
            panel3.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(805, 114);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 41);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 658);
            panel2.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MistyRose;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 83);
            panel4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 35);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 5;
            label3.Text = "User Id :  x x x x";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(55, 562);
            button1.Name = "button1";
            button1.Size = new Size(91, 40);
            button1.TabIndex = 10;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.BackColor = Color.PeachPuff;
            panel5.Controls.Add(linkLabel8);
            panel5.Controls.Add(linkLabel7);
            panel5.Controls.Add(linkLabel6);
            panel5.Controls.Add(linkLabel5);
            panel5.Controls.Add(linkLabel4);
            panel5.Controls.Add(linkLabel3);
            panel5.Controls.Add(linkLabel2);
            panel5.Controls.Add(linkLabel1);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(0, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 241);
            panel5.TabIndex = 8;
            // 
            // linkLabel8
            // 
            linkLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel8.AutoEllipsis = true;
            linkLabel8.AutoSize = true;
            linkLabel8.BackColor = Color.DodgerBlue;
            linkLabel8.Location = new Point(7, 175);
            linkLabel8.Name = "linkLabel8";
            linkLabel8.Size = new Size(44, 15);
            linkLabel8.TabIndex = 22;
            linkLabel8.TabStop = true;
            linkLabel8.Text = "Serial 8";
            linkLabel8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel7
            // 
            linkLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel7.AutoEllipsis = true;
            linkLabel7.AutoSize = true;
            linkLabel7.BackColor = Color.DodgerBlue;
            linkLabel7.Location = new Point(7, 160);
            linkLabel7.Name = "linkLabel7";
            linkLabel7.Size = new Size(44, 15);
            linkLabel7.TabIndex = 21;
            linkLabel7.TabStop = true;
            linkLabel7.Text = "Serial 7";
            linkLabel7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel6
            // 
            linkLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel6.AutoEllipsis = true;
            linkLabel6.AutoSize = true;
            linkLabel6.BackColor = Color.DodgerBlue;
            linkLabel6.Location = new Point(7, 145);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(44, 15);
            linkLabel6.TabIndex = 20;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Serial 6";
            linkLabel6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel5
            // 
            linkLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel5.AutoEllipsis = true;
            linkLabel5.AutoSize = true;
            linkLabel5.BackColor = Color.DodgerBlue;
            linkLabel5.Location = new Point(7, 130);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(44, 15);
            linkLabel5.TabIndex = 19;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Serial 5";
            linkLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel4
            // 
            linkLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel4.AutoEllipsis = true;
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.DodgerBlue;
            linkLabel4.Location = new Point(7, 115);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(44, 15);
            linkLabel4.TabIndex = 18;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Serial 4";
            linkLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel3.AutoEllipsis = true;
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.DodgerBlue;
            linkLabel3.Location = new Point(7, 100);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(44, 15);
            linkLabel3.TabIndex = 17;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Serial 3";
            linkLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel2.AutoEllipsis = true;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.DodgerBlue;
            linkLabel2.Location = new Point(7, 85);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(44, 15);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Serial 2";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.DodgerBlue;
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(7, 68);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(44, 15);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Serial 1";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.Font = new Font("Rockwell", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 19);
            label13.Name = "label13";
            label13.Size = new Size(202, 25);
            label13.TabIndex = 14;
            label13.Text = "Serial Number";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Aqua;
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(0, 322);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 201);
            panel6.TabIndex = 9;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 139);
            label12.Name = "label12";
            label12.Size = new Size(212, 18);
            label12.TabIndex = 16;
            label12.Text = "Estimation Stop";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 84);
            label11.Name = "label11";
            label11.Size = new Size(212, 17);
            label11.TabIndex = 15;
            label11.Text = "Start Running : ";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 19);
            label10.Name = "label10";
            label10.Size = new Size(212, 17);
            label10.TabIndex = 14;
            label10.Text = "Date : ";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 668);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Panel panel5;
        private Panel panel6;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox1;
        private Label label13;
        private LinkLabel linkLabel8;
        private LinkLabel linkLabel7;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
    }
}