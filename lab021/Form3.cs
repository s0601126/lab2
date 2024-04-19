using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab021
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void frmStudents_load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");
        }
        private void lstStudents_Click(object sender, EventArgs e)
        {
                string selectedItem = lstStudents.SelectedItem.ToString();
                lblMessage.Text = "The following item is selected: " + selectedItem;
        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
                string selectedItem = lstStudents.SelectedItem.ToString();
                lstStudents.Items.Remove(lstStudents.SelectedItem);
                lblMessage.Text = "The following item is deleted: " + selectedItem;
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = txtName.Text;
                lstStudents.Items.Add(newItem);
                lblMessage.Text = "The following item is added: " + newItem;
                txtName.Text = string.Empty;
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
