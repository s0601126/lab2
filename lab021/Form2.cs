using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab021
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = true;
            picSunny.Visible = false;
            label2.Text = "It's going to be a snowy day today, " + textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            label2.Text = "It's going to be a cloudy day today, " + textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picRainy_Click(object sender, EventArgs e)
        {
        }

        private void picSnowy_Click(object sender, EventArgs e)
        {
           }

        private void picSunny_Click(object sender, EventArgs e)
        {
        }

        private void picCloudy_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = true;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            label2.Text = "It's going to be a rainly day today, " + textBox1.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = true;
            label2.Text = "It's going to be a sunny day today, " + textBox1.Text;
        }
    }
}
