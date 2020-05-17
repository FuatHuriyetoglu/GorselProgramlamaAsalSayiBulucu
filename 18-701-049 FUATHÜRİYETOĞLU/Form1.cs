using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_701_049_FUATHÜRİYETOĞLU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int s1 = Convert.ToInt32(numericUpDown1.Text);
            int s2 = Convert.ToInt32(numericUpDown2.Text);
            Console.WriteLine();
            for (int sayi = s1; sayi <= s2; sayi++)
            {
                int kontrol = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol == 1)
                {
                    listBox1.Items.Add(sayi + " Asal değidir");
                }
                else
                {
                    listBox1.Items.Add(sayi + " Asaldır");
                    sayac++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
