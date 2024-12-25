using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginApp
{
    public partial class Form2 : Form
    {
        private SQLiteConnection sqliteConnection = DatabaseHelper.GetConnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void txtEmailRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRegister_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmailRegister.Text.Trim();
            string password = txtPasswordRegister.Text.Trim();

            // ComboBox'tan seçilen değeri al
            string selectedValue = comboBoxRegister.SelectedItem?.ToString();

            // Alanların doğruluğunu kontrol et
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || selectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ComboBox'tan int olarak balance değerini dönüştür
            if (!int.TryParse(selectedValue, out int balance))
            {
                MessageBox.Show("ComboBox'taki değer bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Veritabanı bağlantısını aç
                sqliteConnection.Open();

                // Kullanıcıyı eklemek için SQL sorgusu
                string query = "INSERT INTO users (email, password, balance) VALUES (@Email, @Password, @Balance)";
                using (SQLiteCommand command = new SQLiteCommand(query, sqliteConnection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Balance", balance);

                    // Sorguyu çalıştır
                    int result = command.ExecuteNonQuery();

                    // Kullanıcı başarıyla eklendiyse bilgi mesajı göster
                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();

                        // Formdaki alanları temizle
                        txtEmailRegister.Clear();
                        txtPasswordRegister.Clear();
                        comboBoxRegister.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Veritabanı hatası durumunda mesaj göster
                MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                sqliteConnection.Close();
            }
        }
    }
}
