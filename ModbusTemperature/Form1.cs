using NModbus.Device;
using ModbusTemperature.Model;
using System.IO.Ports;
using NModbus;
using NModbus.Serial;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ModbusTemperature.Utility;

namespace ModbusTemperature
{
    public partial class Form1 : Form
    {
        //        private System.Windows.Forms.Timer temperatureTimer;
        private bool isReading = false;
        private DateTime startTime;
        private List<ModelMaster> masterModels = new();
        private string badgeId = string.Empty;
        private int interval = 1000;
        private ModbusFactory factory = new ModbusFactory();
        private Form3? form3;
        public Form1()
        {
            InitializeComponent();
            //          temperatureTimer = new System.Windows.Forms.Timer();
            //temperatureTimer.Interval = 1000;
            //        temperatureTimer.Tick += TemperatureTimer_Tick;

        }
        private string[] GetSerialNumbersFromTextboxes()
        {
            return [
                textBox4.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                textBox9.Text,
                textBox10.Text,
                textBox11.Text,
                textBox12.Text,
            ];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLastTemperatureDataByScanCode();
            //  temperatureTimer.Interval = 1000;
            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
           // comboBox1.SelectedIndex = -1;

        }
        void LoadLastTemperatureDataByScanCode()
        {
            var detail = ModelMaster.GetLastTemperatureDataByScanCodeTime();
            LoadDataDetailToChart(detail);
        }
        private void LoadDataDetailToChart(List<ModelDetail> details)
        {
            //chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:sss";
            //chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            //chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            //chart1.Titles[0].Text = "Temperature Data, Serial Number: " + (details.Any() ? details.First().SerialNumber + " " + details.First().RecordedAt.ToString("yyyy") : "None");
            //chart1.Series[0].Points.Clear();
            //for (int i = 0; i < details.Count; i++)
            //{
            //    DataPoint point = new DataPoint();
            //    chart1.Series[0].Points.AddXY(details[i].RecordedAt, details[i].TemperatureData);
            //    chart1.Series[0].Points.Last().Label = details[i].TemperatureData + " *C - " + details[i].RecordedAt.ToString("HH:mm:ss");
            //}
        }
        /*private void TemperatureTimer_Tick(object? sender, EventArgs e)
        {
            //            ReadTemperature();
            string[] pathNames = new string[masterModels.Count];
            //Stop reading after 1 minute
            if (startTime.AddMinutes(1) <= DateTime.Now)
            {
                temperatureTimer.Stop();
                isReading = false;
                MessageBox.Show("Temperature reading has been automatically stopped after 1 minute.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //string imgPath = Path.Combine(AppContext.BaseDirectory, "chart1.jpg");
                //if (File.Exists(imgPath))
                //    File.Delete(imgPath);
                //chart1.SaveImage(Path.Combine(AppContext.BaseDirectory, "chart1.jpg"), ChartImageFormat.Jpeg);
                //PDFUtility.ImageToPdf(Path.Combine(AppContext.BaseDirectory, "chart1.jpg"), "pdf1.pdf");
            }
        }*/




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (!isReading)
        //    {
        //        // Mulai pembacaan suhu setiap detik
        //        isReading = false;
        //        temperatureTimer.Start();
        //        button1.Text = "Stop Reading";
        //    }
        //    else
        //    {

        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form3 = new Form3())
            {
                // Tampilkan Form3 sebagai dialog modal
                //if (form3.ShowDialog() == DialogResult.OK)
                //{
                    // Ambil nilai interval dari Form3
                    interval = form3.interval;
                //}
            }
            string[] serials = GetSerialNumbersFromTextboxes();
            // Periksa jika badgeId kosong
            if (string.IsNullOrWhiteSpace(badgeId))
            {
                MessageBox.Show("Badge ID belum diinput.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Jangan lanjutkan eksekusi
            }

            // Periksa jika tidak ada serial number yang diinput
            if (serials.All(serial => string.IsNullOrWhiteSpace(serial)))
            {
                MessageBox.Show("Serial Number belum diinput.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Jangan lanjutkan eksekusi
            }
            for (int i = 0; i < serials.Length; i++)
            {
                if (serials[i] != "")
                {
                    var masterModel = new ModelMaster();
                    masterModel.SerialNumber = serials[i];
                    masterModel.badgeId = badgeId;
                    masterModel.Interval = interval;
                    masterModels.Add(masterModel);
                }
            }
            Form2 frm = new Form2(masterModels.ToArray(), badgeId, interval, true);
            frm.Show();
            masterModels.Clear();
            badgeId = "";
            ClearTextboxes();
        }

        private void serialInputDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            Control ctrl = (Control)sender;
            int nextControls = ctrl.TabIndex >= 9 ? 2 : ctrl.TabIndex + 1;
            panel3.Controls.OfType<TextBox>().Where(x => x.TabIndex == nextControls).First().Focus();
            e.SuppressKeyPress = true;
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                badgeId = textBox13.Text;
                // Validasi apakah badgeId sudah ada di database
                if (!ModelMaster.IsBadgeIdExists(badgeId))
                {
                    // Tampilkan pesan peringatan jika Badge ID tidak ditemukan
                    MessageBox.Show(
                        "Badge ID Unregisterd",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    // Kosongkan textbox Badge ID untuk input ulang
                    textBox13.Clear();
                    return;
                }
                panel3.Controls.OfType<TextBox>().Where(x => x.TabIndex == 2).First().Focus();
                e.SuppressKeyPress = true;
            }

        }
        private void ClearTextboxes()
        {
            // Kosongkan Badge ID textbox
            textBox13.Text = "";

            // Kosongkan semua textboxes untuk serial numbers (TabIndex terkait)
            foreach (var textBox in panel3.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] scanSerial = GetSerialNumbersFromTextboxes();
            var lastMasterData = scanSerial.Any(x=>x!="") ? ModelMaster.GetMasterModelBySerial(scanSerial) :  ModelMaster.GetLastListMasterDataByScanCodeTime();
            if (lastMasterData is null)
            {
                MessageBox.Show("No Data Found");
                return;
            }
            Form2 frm = new Form2(lastMasterData.ToArray(), lastMasterData.FirstOrDefault()?.badgeId ?? "", lastMasterData.FirstOrDefault()?.Interval ?? interval, false);
            frm.Show();
        }

        //private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        //{

        //    switch (comboBox1.SelectedItem?.ToString())
        //    {
        //        case "1 Second":
        //            interval = 1000;
        //            break;
        //        case "1 Minute":
        //            interval = 1 * 60 * 1000;
        //            break;
        //        case "5 Minutes":
        //            interval = 5 * 60 * 1000;
        //            break;
        //        case "30 Minutes":
        //            interval = 30 * 60 * 1000;
        //            break;
        //        case "1 Hour":
        //            interval = 60 * 60 * 1000;
        //            break;
        //        case "2 Hours":
        //            interval = 2 * 60 * 60 * 1000;
        //            break;
        //        default:
        //            interval = 1000;
        //            break;
        //    }
        //    MessageBox.Show(
        //                    $"Timer interval set to {comboBox1.SelectedItem}",
        //                    "Timer Updated",
        //                    MessageBoxButtons.OK,
        //                    MessageBoxIcon.Information
        //                );
        //}

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form passwordForm = new Form
            {
                Text = "Masukkan Password",
                Size = new System.Drawing.Size(300, 150),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };
            Label label = new Label
            {
                Text = "Password:",
                Left = 10,
                Top = 20,
                Width = 80
            };

            TextBox textBox = new TextBox
            {
                Left = 100,
                Top = 20,
                Width = 150,
                PasswordChar = '*'
            };

            Button submitButton = new Button
            {
                Text = "Submit",
                Left = 100,
                Top = 60,
                Width = 70,
                DialogResult = DialogResult.OK
            };

            Button cancelButton = new Button
            {
                Text = "Cancel",
                Left = 180,
                Top = 60,
                Width = 70,
                DialogResult = DialogResult.Cancel
            };

            passwordForm.Controls.Add(label);
            passwordForm.Controls.Add(textBox);
            passwordForm.Controls.Add(submitButton);
            passwordForm.Controls.Add(cancelButton);

            passwordForm.AcceptButton = submitButton;
            passwordForm.CancelButton = cancelButton;

            DialogResult result = passwordForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (textBox.Text == "flex123") // Ganti dengan password yang Anda inginkan
                {
                    if (form3 == null || form3.IsDisposed)
                    {
                        form3 = new Form3();

                    }
                    form3.ShowDialog();
                }
                else
                {
                    // Jika password salah
                    MessageBox.Show("Password salah!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
