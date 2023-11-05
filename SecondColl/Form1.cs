using System;
using System.Globalization;

namespace SecondColl
{
    public partial class Form1 : Form
    {

        string sortType;
        Functions functions;
        public Form1(string sortType)
        {
            this.sortType = sortType;
            InitializeComponent();
            functions = new Functions();

        }






        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += (sender2, e2) =>
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit(); // Close the application
                }
            };




            if (sortType == "odd-even")
            {
                label1.Text = "Четная нечетная сортировка";
            }
            else if (sortType == "gnome")
            {
                label1.Text = "Гномья сортировка";
            }
            else if (sortType == "bitonic")
            {
                label1.Text = "Битоническая сортировка";
            }
            else
            {
                label1.Text = "Bug";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            else
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }





        private void sortButton_Click(object sender, EventArgs e)
        {
            int[] array;
            if (comboBox1.SelectedIndex == 0)
            {
                int a = int.Parse(elementsNumber.Text);
                int b = int.Parse(fromNumber.Text);
                int c = int.Parse(toNumber.Text);

                array = functions.createRandomArray(a, b, c);
            }
            else
            {
                array = functions.createArrayFromString(directArray.Text);
            }

            ShowSorting p = new ShowSorting(array, sortType);
            p.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prevbutton_Click(object sender, EventArgs e)
        {
            this.FormClosing += (sender2, e2) =>
            {
                if (e2.CloseReason == CloseReason.UserClosing)
                {
                    // Cancel the default close action to allow us to open Form2
                    e2.Cancel = true;
                    this.Hide(); // Hide the current form
                    MainForm newForm = new MainForm();
                    newForm.Show(); // Show the new form
                }

            };
            this.Close();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            SortInfo form = new SortInfo(sortType);
            form.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}