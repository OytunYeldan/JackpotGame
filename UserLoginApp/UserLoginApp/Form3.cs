using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace UserLoginApp
{
    public partial class Form3 : Form
    {
        private SQLiteConnection sqliteConnection = DatabaseHelper.GetConnection();
        private int currentBalance; // Kullanıcının mevcut bakiyesi
        private Random rnd = new Random(); // Rastgele sayı üretici
        private int a, b, c, move; // Slot makineleri için değişkenler
        private string connectionString = "Data Source=C:\\Users\\oytun\\Documents\\users_db.db;Version=3;Journal Mode=Wal;";

        private string currentUserEmail = "user@example.com"; // Veritabanında kullanıcıyı tanımlamak için e-posta ya da id kullanabilirsiniz

        public Form3(int userBalance) // Form1'den gelen kullanıcı bakiyesi
        {
            InitializeComponent();
            currentBalance = userBalance; // Form1'den gelen bakiyeyi al
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Kullanıcının mevcut bakiyesini formda göster
            label1.Text = "Balance: $" + currentBalance;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {
                // Rastgele değerler üret
                a = rnd.Next(1, 4);
                b = rnd.Next(1, 4);
                c = rnd.Next(1, 4);

                // PictureBox1 için resim seçimi
                if (a == 1)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\banana.png");
                }
                else if (a == 2)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\cherry.png");
                }
                else if (a == 3)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\bigwin.png");
                }

                // PictureBox2 için resim seçimi
                if (b == 1)
                {
                    pictureBox2.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\banana.png");
                }
                else if (b == 2)
                {
                    pictureBox2.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\cherry.png");
                }
                else if (b == 3)
                {
                    pictureBox2.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\bigwin.png");
                }

                // PictureBox3 için resim seçimi
                if (c == 1)
                {
                    pictureBox3.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\banana.png");
                }
                else if (c == 2)
                {
                    pictureBox3.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\cherry.png");
                }
                else if (c == 3)
                {
                    pictureBox3.Image = Image.FromFile(@"C:\Users\oytun\source\repos\UserLoginApp\UserLoginApp\Properties\bigwin.png");
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0;

                // Kazançları kontrol et ve güncelle
                int winnings = CalculateWinnings();
                currentBalance += winnings;
                label1.Text = "Balance: $" + currentBalance;

                // Veritabanını güncelle
                UpdateBalanceInDatabase(currentBalance);

                if (winnings > 0)
                {
                    MessageBox.Show("Congratulations! You won $" + winnings);
                }
            }
        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the Bid amount to play.");
            }
            else
            {
                int bidAmount;

                if (int.TryParse(textBox1.Text, out bidAmount)) // Kullanıcı girdisini doğrula
                {
                    if (bidAmount > currentBalance)
                    {
                        MessageBox.Show("Insufficient balance. Please enter a smaller amount.");
                    }
                    else
                    {
                        currentBalance -= bidAmount; // Bakiyeden düş
                        label1.Text = "Balance: $" + currentBalance; // Güncel bakiyeyi göster
                        UpdateBalanceInDatabase(currentBalance); // Veritabanında güncelle
                        timer1.Enabled = true; // Slot makinelerini çalıştır
                    }
                }
                else
                {
                    MessageBox.Show("Invalid bid amount. Please enter a valid number.");
                }
            }
        }

        private int CalculateWinnings()
        {
            int multiplier = 0;

            // Üçlü kombinasyonlar
            if (a == b && b == c)
            {
                if (a == 1) multiplier = 6; // 3 muz
                else if (a == 2) multiplier = 9; // 3 cherry
                else if (a == 3) multiplier = 30; // 3 big win
            }
            // İkili kombinasyonlar
            else if (a == b || b == c || a == c)
            {
                int pairValue = a == b ? a : (b == c ? b : a);
                if (pairValue == 1) multiplier = 2; // 2 muz
                else if (pairValue == 2) multiplier = 3; // 2 cherry
                else if (pairValue == 3) multiplier = 6; // 2 big win
            }

            return multiplier * int.Parse(textBox1.Text); // Bahis miktarı ile çarp
        }

        private void UpdateBalanceInDatabase(int newBalance)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE users SET balance = @Balance WHERE email = @Email";
                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Balance", newBalance);
                    command.Parameters.AddWithValue("@Email", currentUserEmail); // Kullanıcı e-posta bilgisi
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Diğer işlemler için bırakılmıştır
        }
    }
}
