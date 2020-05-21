using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Телефон
{
    public partial class Form1 : Form
    {
        int z;

        
    public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(textBox2.Text) == "Трубка")
            { textBox2.Text = "Номер"; }
            if ((checkBox1.Checked == true) & ((Convert.ToString(textBox2.Text) == "Данные") || (Convert.ToString(textBox2.Text) == "Занято")))
            {
                System.Windows.Forms.Application.Restart();
                System.Environment.Exit(1);
            }
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            string a0 = Convert.ToString(0);
            textBox1.Text = textBox1.Text + a0;
            z++;

        }
        private void Б1_Click(object sender, EventArgs e)
        {
            string a1 = Convert.ToString(1);
            textBox1.Text = textBox1.Text + a1;
            z++;
        }       
        private void Б2_Click_1(object sender, EventArgs e)
        {
            string a2 = Convert.ToString(2);
            textBox1.Text = textBox1.Text + a2;
            z++;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            string a3 = Convert.ToString(3);
            textBox1.Text = textBox1.Text + a3;
            z++;
        }

        private void Б4_Click_1(object sender, EventArgs e)
        {
            string a4 = Convert.ToString(4);
            textBox1.Text = textBox1.Text + a4;
            z++;
        }

        private void Б5_Click_1(object sender, EventArgs e)
        {
            string a5 = Convert.ToString(5);
            textBox1.Text = textBox1.Text + a5;
            z++;
        }

        private void Б6_Click_1(object sender, EventArgs e)
        {
            string a6 = Convert.ToString(6);
            textBox1.Text = textBox1.Text + a6;
            z++;
        }

        private void Б7_Click_1(object sender, EventArgs e)
        {
            string a7 = Convert.ToString(7);
            textBox1.Text = textBox1.Text + a7;
            z++;
        }

        private void Б8_Click_1(object sender, EventArgs e)
        {
            string a8 = Convert.ToString(8);
            textBox1.Text = textBox1.Text + a8;
            z++;
        }

        private void Б9_Click_1(object sender, EventArgs e)
        {
            string a9 = Convert.ToString(9);
            textBox1.Text = textBox1.Text + a9;
            z++;
        }

        private void Б11_Click_1(object sender, EventArgs e)
        {
            string a11 = Convert.ToString('*');
            System.Windows.Forms.Application.Restart();
            System.Environment.Exit(1);
        }

        private void Б12_Click_1(object sender, EventArgs e)
        {
            string a12 = Convert.ToString("111");
            textBox1.Text = textBox1.Text + a12;
            z++;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;          
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             if (z == 3)
            {
                textBox2.Text = "Вызов";
            } 
            if (z != 3)
            {
                textBox2.Text = "Ошибка";
               
            }
            if (Convert.ToString(textBox2.Text)== "Вызов")
            {
                Random rnd = new Random();
                int f00 = rnd.Next(1,2);
                if (f00 == 1)
                {
                    textBox2.Text = "Занято";
                }
                if (f00 == 2)
                {
                    textBox2.Text = "Данные";
                }
            }
        }
    }

}
