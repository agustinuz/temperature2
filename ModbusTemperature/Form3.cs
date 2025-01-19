using Microsoft.Data.SqlClient;
using ModbusTemperature.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusTemperature
{
    public partial class Form3 : Form
    {
        public int interval { get; private set; } = 1000;
        public Form3()
        {
            InitializeComponent();
            InitializeComboBox2();
        }
        private void InitializeComboBox2()
        {
            comboBox2.Items.AddRange(new string[]
            {
                "1 Second",
                "1 Minute",
                "5 Minutes",
                "30 Minutes",
                "1 Hour",
                "2 Hours"
            });
            comboBox2.SelectedIndex = 0; // Default ke "1 Second"
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Badge ID tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            {
                var Employee = new ModelEmployee
                {
                    badgeId = textBox1.Text,
                    RecordedAt = DateTime.Now
                };
                SaveEmployeeToDatabase(Employee);
            }
        }
        private void SaveEmployeeToDatabase(ModelEmployee Employee)
        {
            try
            {
                using (var connection = ConfigDB.GetConnection())
                {
                    connection.Open();

                    // Query SQL untuk menyimpan data
                    string query = "INSERT INTO Employee (BadgeId, RecordedAt) VALUES (@BadgeId, @RecordedAt)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        // Menambahkan parameter untuk query
                        command.Parameters.AddWithValue("@BadgeId", Employee.badgeId);
                        command.Parameters.AddWithValue("@RecordedAt", Employee.RecordedAt);

                        // Menjalankan perintah INSERT
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan kesalahan jika terjadi error
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem?.ToString())
            {
                case "1 Second":
                    interval = 1000;
                    break;
                case "1 Minute":
                    interval = 1 * 60 * 1000;
                    break;
                case "5 Minutes":
                    interval = 5 * 60 * 1000;
                    break;
                case "30 Minutes":
                    interval = 30 * 60 * 1000;
                    break;
                case "1 Hour":
                    interval = 60 * 60 * 1000;
                    break;
                case "2 Hours":
                    interval = 2 * 60 * 60 * 1000;
                    break;
                default:
                    interval = 1000;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih interval terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set DialogResult agar Form1 tahu bahwa nilai interval telah diperbarui
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
