using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Reflection;

namespace SecondColl
{
    public partial class CompareSorts : Form
    {

        Functions functions;
        public CompareSorts()
        {
            InitializeComponent();
            functions = new Functions();

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {






            if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void CompareSorts_Load(object sender, EventArgs e)
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
            else if (comboBox1.SelectedIndex == 1)
            {
                array = functions.createArrayFromString(directArray.Text);

            }
            else
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    array = new[] { 105, 89, 150, 3, 118, 14, 91, 86, 179, 186, 78, 94, 4, 181, 171, 163, 102, 4, 121, 78, 171, 89, 42, 70, 44, 116, 164, 24, 36, 143, 37, 38, 72, 154, 144, 59, 25, 101, 186, 14, 55, 61, 144, 196, 131, 69, 142, 178, 32, 122, 8, 113, 119, 98, 84, 195, 64, 67, 179, 15, 63, 5, 181, 135, 17, 135, 196, 130, 38, 126, 2, 184, 63, 161, 189, 161, 158, 3, 110, 62, 140, 127, 23, 184, 76, 100, 137, 135, 176, 101, 134, 122, 24, 165, 188, 93, 138, 6, 174, 60, 90, 106, 156, 165, 151, 199, 160, 136, 65, 195, 180, 61, 35, 48, 188, 138, 193, 65, 109, 111, 173, 130, 41, 194, 24, 189, 36, 37, 113, 188, 157, 137, 108, 9, 124, 136, 177, 148, 89, 183, 29, 131, 145, 44, 117, 197, 150, 58, 193, 122, 3, 25, 40, 64, 93, 109, 199, 44, 142, 61, 55, 16, 37, 143, 164, 172, 24, 45, 98, 80, 64, 158, 179, 104, 151, 47, 153, 52, 4, 119, 43, 44, 122, 59, 27, 117, 129, 164, 182, 101, 60, 166, 36, 12, 102, 135, 40, 150, 158, 37 };
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    array = new[] { 2, 3, 3, 3, 4, 4, 5, 6, 8, 9, 14, 14, 15, 16, 17, 23, 24, 24, 24, 24, 25, 25, 27, 29, 32, 35, 36, 36, 36, 37, 37, 37, 37, 38, 38, 40, 40, 41, 42, 43, 44, 44, 44, 45, 47, 48, 52, 55, 55, 58, 59, 59, 60, 60, 61, 61, 61, 62, 63, 63, 64, 64, 4, 64, 65, 65, 67, 69, 70, 72, 76, 78, 78, 80, 84, 86, 89, 89, 89, 90, 91, 93, 93, 94, 98, 98, 100, 101, 101, 101, 102, 102, 104, 105, 106, 108, 109, 109, 110, 111, 113, 113, 116, 117, 117, 118, 119, 119, 121, 122, 122, 122, 122, 124, 44, 126, 127, 129, 130, 130, 131, 131, 134, 135, 135, 135, 135, 136, 136, 137, 137, 138, 138, 140, 142, 142, 143, 143, 144, 144, 145, 148, 150, 150, 150, 151, 151, 153, 154, 156, 157, 158, 158, 158, 160, 161, 161, 163, 164, 164, 164, 165, 165, 166, 171, 171, 172, 173, 174, 176, 177, 178, 179, 179, 179, 180, 181, 181, 182, 183, 184, 184, 186, 186, 188, 188, 188, 189, 189, 193, 193, 194, 195, 195, 196, 196, 197, 199, 199, 12 };
                }
                else
                {
                    array = new[] { 70, 155, 118, 39, 133, 9, 101, 138, 169, 113, 39, 35, 121, 165, 7, 168, 181, 30, 129, 2, 152, 60, 45, 175, 186, 30, 3, 42, 1, 32, 50, 166, 60, 180, 66, 128, 158, 1, 166, 187, 94, 115, 8, 122, 20, 39, 62, 83, 72, 161, 70, 105, 153, 23, 196, 105, 156, 128, 9, 87, 109, 163, 24, 18, 58, 148, 134, 28, 92, 127, 139, 8, 200, 197, 12, 58, 174, 57, 52, 200, 135, 121, 131, 3, 52, 91, 112, 123, 99, 47, 119, 139, 49, 5, 56, 121, 5, 80, 165, 24, 2, 5, 7, 7, 8, 12, 13, 15, 15, 22, 23, 23, 23, 27, 32, 34, 34, 34, 36, 39, 44, 45, 45, 46, 46, 49, 53, 55, 55, 56, 59, 61, 62, 64, 65, 67, 71, 77, 81, 82, 83, 83, 84, 85, 90, 94, 95, 96, 100, 100, 106, 106, 109, 112, 112, 114, 115, 115, 118, 121, 123, 129, 131, 132, 132, 132, 135, 135, 136, 137, 137, 138, 138, 138, 140, 140, 143, 144, 145, 150, 153, 155, 156, 156, 166, 167, 171, 171, 179, 180, 181, 181, 184, 184, 186, 188, 188, 188, 192, 193 };

                }

            }

            Sorts sorts;
            Sorts sorts2;
            Sorts sorts3;

            sorts = new Sorts(array);
            sorts2 = new Sorts(array);
            sorts3 = new Sorts(array);

            string res = string.Join(", ", array);
            beforeSortingText.Text = res;
            // Создайте объект Stopwatch
            Stopwatch timer = new Stopwatch();
            // Начните отсчет времени
            timer.Start();
            sorts.OddEven_Sort();


            // Получите время в секундах
            TimeSpan прошедшееВремя = timer.Elapsed;
            double odd_even_timer = прошедшееВремя.TotalSeconds;

            transpositionCountLabel.Text = sorts.counter.ToString();
            transpositionTimeLabel.Text = odd_even_timer.ToString();



            timer = new Stopwatch();
            // Начните отсчет времени
            timer.Start();

            sorts2.BitonicSort(true);


            // Получите время в секундах
            прошедшееВремя = timer.Elapsed;
            double bitonic_timer = прошедшееВремя.TotalSeconds;

            bitonicCountLabel.Text = sorts2.counter.ToString();
            bitonicTimeLabel.Text = bitonic_timer.ToString();


            timer = new Stopwatch();
            // Начните отсчет времени
            timer.Start();
            sorts3.GnomeSort();


            // Получите время в секундах
            прошедшееВремя = timer.Elapsed;
            double gnome_sort = прошедшееВремя.TotalSeconds;

            gnomeCountLabel.Text = sorts3.counter.ToString();
            gnomeTimeLabel.Text = gnome_sort.ToString();


            afterSortingText.Text = string.Join(", ", sorts.array);

        }


        void backup()
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
    }
}
