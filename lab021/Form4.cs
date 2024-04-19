using Lab021;
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

namespace lab021
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e, Form1 form1)
        {
            this.Hide();
            Form1 lab2a = new Form1();
            lab2a.ShowDialog();
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form2 lab2b = new Form2();
            lab2b.ShowDialog();
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            frmStudents lab2c = new frmStudents();
            lab2c.ShowDialog();
            this.Close();
        }
    }
}
