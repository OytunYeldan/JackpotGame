using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UserLoginApp
{
    public partial class Form1 : Form
    {
        // user_balance değişkenini burada tanımladık
        public static int user_balance;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();
            registerForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen e-posta ve şifre alanlarını doldurun.");
                return;
            }

            try
            {
                // SQLite bağlantısını aç
                using (SQLiteConnection sqliteConnection = DatabaseHelper.GetConnection())
                {
                    sqliteConnection.Open();
                    string query = "SELECT balance FROM users WHERE email = @Email AND password = @Password";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, sqliteConnection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Kullanıcıyı kontrol et
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            // Kullanıcının bakiyesini al ve user_balance'a ata
                            user_balance = Convert.ToInt32(result);
                            MessageBox.Show("Giriş başarılı! Bakiyeniz: $" + user_balance);

                            // Form3'e yönlendir ve user_balance'ı geçir
                            Form3 form3 = new Form3(user_balance); // user_balance parametresi ekledik
                            form3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("E-posta veya şifre hatalı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
