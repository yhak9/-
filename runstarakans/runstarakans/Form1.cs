using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runstarakans
{
    public partial class Form1 : Form
    {
        string name1, name2;
        int flag1;
        int x1, x2;

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "";

            pictureBox1.Left = 1;
            pictureBox2.Left = 1;

            x1 = 0; 
            x2 = 0;
            flag1 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Имя не введено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                flag1 = 1;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            name1 = textBox2.Text;
            name2 = textBox3.Text;

            if (flag1 != 0) 
            {
                Random rnd = new Random();

                
                int count = rnd.Next(8);
                x1 += count;
                label1.Text = x1.ToString();
                pictureBox1.Left = x1;

               
                count = rnd.Next(8);
                x2 += count;
                label2.Text = x2.ToString();
                pictureBox2.Left = x2;

               
                if ((x1 >= 882) || (x2 >= 882))
                {
                    flag1 = 0;

                    if (x1 >= 882)
                    {
                        label3.Text = $"игрок {name1} победил!";
                    }
                    else if (x2 >= 882)
                    {
                        label3.Text = $"игрок {name2} победил!";
                    }

                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "";


            pictureBox1.Left = 1;
            pictureBox2.Left = 1;

        }
    }
}
