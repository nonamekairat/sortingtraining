using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondColl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void gnomeSortButton_Click(object sender, EventArgs e)
        {
            this.FormClosing += (sender2, e2) =>
            {
                if (e2.CloseReason == CloseReason.UserClosing)
                {
                    // Cancel the default close action to allow us to open Form2
                    e2.Cancel = true;
                    this.Hide(); // Hide the current form
                    Form1 newForm = new Form1("gnome");
                    newForm.Show(); // Show the new form
                }
            };
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormClosing += (sender2, e2) =>
            {
                if (e2.CloseReason == CloseReason.UserClosing)
                {
                    // Cancel the default close action to allow us to open Form2
                    e2.Cancel = true;
                    this.Hide(); // Hide the current form
                    Form1 newForm = new Form1("bitonic");
                    newForm.Show(); // Show the new form
                }
            };
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void transpositionSortButton_Click(object sender, EventArgs e)
        {
            this.FormClosing += (sender2, e2) =>
            {
                if (e2.CloseReason == CloseReason.UserClosing)
                {
                    // Cancel the default close action to allow us to open Form2
                    e2.Cancel = true;
                    this.Hide(); // Hide the current form
                    Form1 newForm = new Form1("odd-even");
                    newForm.Show(); // Show the new form
                }

            };
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.FormClosing += (sender2, e2) =>
            {
                if (e2.CloseReason == CloseReason.UserClosing)
                {
                    // Cancel the default close action to allow us to open Form2
                    e2.Cancel = true;
                    this.Hide(); // Hide the current form
                    CompareSorts newForm = new CompareSorts();
                    newForm.Show(); // Show the new form
                }

            };
            this.Close();
        }
    }
}
