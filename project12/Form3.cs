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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            var fullAlphabet = alphabet + alphabet.ToLower();
            var letterQty = fullAlphabet.Length;


            string EncryptText(string input)
            {
                string encrypted = "";
                foreach (char c in input)
                {
                    int index = fullAlphabet.IndexOf(c);
                    if (index == -1)
                    {
                        encrypted += c; 
                    }
                    else
                    {
                        encrypted += fullAlphabet[(index + 2) % letterQty];
                    }
                }
                return encrypted;
            }

            string encryptedUsername = EncryptText(comboBox1.Text);
            string encryptedPassword = EncryptText(textBox1.Text);
            string encryptedExtraInfo = EncryptText(comboBox4.Text);

            using (StreamWriter f = new StreamWriter("based.txt"))
            {
                f.WriteLine(encryptedUsername);
                f.WriteLine(encryptedPassword);
                f.WriteLine(encryptedExtraInfo);
            }
        }

    }
}
