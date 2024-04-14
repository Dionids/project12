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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("1.txt");
            string a = f.ReadLine();
            label1.Text = "Вы вошли как " + a;
            f.Close();
            StreamReader p = new StreamReader("2.txt");
            string s = p.ReadLine();
            p.Close();
            label2.Text = "Уровень доступа: " + s;
            if (s =="1") // Директор
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
            if (s == "2") // Сис.админ, сотрудники СБ, зам.дир
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = true;
            }
            if (s == "3") // Бухгалтер
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            if (s == "4") // Консультанты
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = true;
            }
            if (s == "5") // Клиенты
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form5 = new Form5();
            form5.Show();
        }
    }
}
