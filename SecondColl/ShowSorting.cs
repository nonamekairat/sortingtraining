using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SecondColl
{
    public partial class ShowSorting : Form
    {

        string sortType;
        Sorts sorts;
        public ShowSorting(int[] array, string sortType)
        {
            sorts = new Sorts(array);
            InitializeComponent();
            this.sortType = sortType;
            string res = string.Join(", ", array);
            beforeSortingText.Text = res;
            // Создайте объект Stopwatch
            Stopwatch timer = new Stopwatch();
            bool ascending = true;
            // Начните отсчет времени
            timer.Start();


            if (sortType == "odd-even")
            {
                sorts.OddEven_Sort();
            }
            else if (sortType == "gnome")
            {
                sorts.GnomeSort();
            }
            else if (sortType == "bitonic")
            {
                sorts.BitonicSort(ascending);
            }

            // Получите время в секундах
            TimeSpan прошедшееВремя = timer.Elapsed;
            double time = прошедшееВремя.TotalSeconds;

            afterSortingText.Text = string.Join(", ", array);
            for (int i = 0; i < sorts.iterations.Count; i++)
            {
                iterationsTextBox.AppendText(sorts.iterations[i]);
                iterationsTextBox.AppendText(Environment.NewLine);
                iterationsTextBox.AppendText(Environment.NewLine);

            }

            countLabel.Text += " " + sorts.counter;
            timeLabel.Text += " " + time;
        }







        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iterationsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
