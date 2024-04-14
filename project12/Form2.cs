using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool successfulLogin = false;
            StreamReader reader = new StreamReader("based.txt");


            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            var fullAlphabet = alphabet + alphabet.ToLower();
            var letterQty = fullAlphabet.Length;


            string DecryptText(string input)
            {
                string decrypted = "";
                foreach (char c in input)
                {
                    int index = fullAlphabet.IndexOf(c);
                    if (index == -1)
                    {
                        decrypted += c; 
                    }
                    else
                    {
                        int newIndex = index - 2;
                        if (newIndex < 0) newIndex += letterQty; 
                        decrypted += fullAlphabet[newIndex];
                    }
                }
                return decrypted;
            }

            string log = comboBox1.Text;
            string par = textBox1.Text;
            string storedUsername, storedEncryptedPassword, storedExtraInfo;
            while ((storedUsername = reader.ReadLine()) != null &&
                   (storedEncryptedPassword = reader.ReadLine()) != null &&
                   (storedExtraInfo = reader.ReadLine()) != null)
            {

                string decryptedUsername = DecryptText(storedUsername);
                string decryptedPassword = DecryptText(storedEncryptedPassword);

                if (decryptedUsername == log && decryptedPassword == par)
                {
                    successfulLogin = true;
                    using (StreamWriter writer = new StreamWriter("2.txt", false))
                    {
                        writer.WriteLine(storedExtraInfo); 
                    }
                    break;
                }
            }
            reader.Close();

            if (successfulLogin && !string.IsNullOrEmpty(log))
            {
                using (StreamWriter writer = new StreamWriter("1.txt", false))
                {
                    writer.WriteLine(log);
                }
                MessageBox.Show("Успешный вход как " + log);
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Ошибка ввода пароля");
            }
        }

    }
}
