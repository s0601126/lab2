using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab021
{
    public partial class Form1 : Form
    {
        private int price;
        private string payment;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(textBox1.Text);
            int total = price * quantity;

            label2.Text = "Total Price:" + total + "\n Payment method is " + payment;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }
    }
}

