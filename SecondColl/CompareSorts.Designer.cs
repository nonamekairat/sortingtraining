namespace SecondColl
{
    partial class CompareSorts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            label7 = new Label();
            elementsNumber = new TextBox();
            label3 = new Label();
            label5 = new Label();
            fromNumber = new TextBox();
            toNumber = new TextBox();
            label4 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            directArray = new TextBox();
            label6 = new Label();
            sortButton = new Button();
            panel1 = new Panel();
            prevbutton = new Button();
            transpositionCountLabel = new Label();
            bitonicCountLabel = new Label();
            gnomeCountLabel = new Label();
            transpositionTimeLabel = new Label();
            bitonicTimeLabel = new Label();
            gnomeTimeLabel = new Label();
            label13 = new Label();
            label14 = new Label();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            countLabel = new Label();
            timeLabel = new Label();
            label1 = new Label();
            afterSortingText = new TextBox();
            beforeSortingText = new TextBox();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(elementsNumber);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(fromNumber);
            groupBox2.Controls.Add(toNumber);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(931, 125);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 38);
            label7.Name = "label7";
            label7.Size = new Size(229, 28);
            label7.TabIndex = 18;
            label7.Text = "количество элементов";
            // 
            // elementsNumber
            // 
            elementsNumber.Location = new Point(37, 74);
            elementsNumber.Name = "elementsNumber";
            elementsNumber.Size = new Size(220, 27);
            elementsNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(346, 41);
            label3.Name = "label3";
            label3.Size = new Size(211, 28);
            label3.TabIndex = 3;
            label3.Text = "диапазон элементов";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(441, 73);
            label5.Name = "label5";
            label5.Size = new Size(35, 28);
            label5.TabIndex = 7;
            label5.Text = "до";
            // 
            // fromNumber
            // 
            fromNumber.Location = new Point(379, 74);
            fromNumber.Name = "fromNumber";
            fromNumber.Size = new Size(52, 27);
            fromNumber.TabIndex = 4;
            // 
            // toNumber
            // 
            toNumber.Location = new Point(479, 74);
            toNumber.Name = "toNumber";
            toNumber.Size = new Size(52, 27);
            toNumber.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(346, 74);
            label4.Name = "label4";
            label4.Size = new Size(33, 28);
            label4.TabIndex = 5;
            label4.Text = "от";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 208);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 1;
            label2.Text = "исходный массив";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "случайные числа", "свой массив", "варианты массивов" });
            comboBox1.Location = new Point(165, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(313, 31);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "случайные числа";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(directArray);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(28, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(931, 71);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // directArray
            // 
            directArray.Location = new Point(151, 26);
            directArray.Name = "directArray";
            directArray.Size = new Size(774, 27);
            directArray.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 22);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 10;
            label6.Text = "ваш массив";
            // 
            // sortButton
            // 
            sortButton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sortButton.Location = new Point(502, 19);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(172, 38);
            sortButton.TabIndex = 16;
            sortButton.Text = "Отсортировать";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(prevbutton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(transpositionCountLabel);
            panel1.Controls.Add(bitonicCountLabel);
            panel1.Controls.Add(gnomeCountLabel);
            panel1.Controls.Add(transpositionTimeLabel);
            panel1.Controls.Add(bitonicTimeLabel);
            panel1.Controls.Add(gnomeTimeLabel);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(countLabel);
            panel1.Controls.Add(timeLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(afterSortingText);
            panel1.Controls.Add(beforeSortingText);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(sortButton);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 700);
            panel1.TabIndex = 17;
            // 
            // prevbutton
            // 
            prevbutton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prevbutton.ForeColor = SystemColors.ActiveCaptionText;
            prevbutton.Location = new Point(22, 22);
            prevbutton.Name = "prevbutton";
            prevbutton.Size = new Size(94, 35);
            prevbutton.TabIndex = 36;
            prevbutton.Text = "назад";
            prevbutton.UseVisualStyleBackColor = true;
            prevbutton.Click += prevbutton_Click;
            // 
            // transpositionCountLabel
            // 
            transpositionCountLabel.AutoSize = true;
            transpositionCountLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            transpositionCountLabel.Location = new Point(648, 547);
            transpositionCountLabel.Name = "transpositionCountLabel";
            transpositionCountLabel.Size = new Size(27, 28);
            transpositionCountLabel.TabIndex = 35;
            transpositionCountLabel.Text = "0";
            // 
            // bitonicCountLabel
            // 
            bitonicCountLabel.AutoSize = true;
            bitonicCountLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bitonicCountLabel.Location = new Point(326, 547);
            bitonicCountLabel.Name = "bitonicCountLabel";
            bitonicCountLabel.Size = new Size(27, 28);
            bitonicCountLabel.TabIndex = 34;
            bitonicCountLabel.Text = "0";
            // 
            // gnomeCountLabel
            // 
            gnomeCountLabel.AutoSize = true;
            gnomeCountLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gnomeCountLabel.Location = new Point(28, 547);
            gnomeCountLabel.Name = "gnomeCountLabel";
            gnomeCountLabel.Size = new Size(27, 28);
            gnomeCountLabel.TabIndex = 33;
            gnomeCountLabel.Text = "0";
            // 
            // transpositionTimeLabel
            // 
            transpositionTimeLabel.AutoSize = true;
            transpositionTimeLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            transpositionTimeLabel.Location = new Point(648, 454);
            transpositionTimeLabel.Name = "transpositionTimeLabel";
            transpositionTimeLabel.Size = new Size(27, 28);
            transpositionTimeLabel.TabIndex = 32;
            transpositionTimeLabel.Text = "0";
            // 
            // bitonicTimeLabel
            // 
            bitonicTimeLabel.AutoSize = true;
            bitonicTimeLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bitonicTimeLabel.Location = new Point(326, 454);
            bitonicTimeLabel.Name = "bitonicTimeLabel";
            bitonicTimeLabel.Size = new Size(27, 28);
            bitonicTimeLabel.TabIndex = 31;
            bitonicTimeLabel.Text = "0";
            // 
            // gnomeTimeLabel
            // 
            gnomeTimeLabel.AutoSize = true;
            gnomeTimeLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gnomeTimeLabel.Location = new Point(28, 454);
            gnomeTimeLabel.Name = "gnomeTimeLabel";
            gnomeTimeLabel.Size = new Size(27, 28);
            gnomeTimeLabel.TabIndex = 30;
            gnomeTimeLabel.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(648, 500);
            label13.Name = "label13";
            label13.Size = new Size(217, 28);
            label13.TabIndex = 29;
            label13.Text = "количество итераций";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(648, 404);
            label14.Name = "label14";
            label14.Size = new Size(69, 28);
            label14.TabIndex = 28;
            label14.Text = "Время";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(326, 500);
            label11.Name = "label11";
            label11.Size = new Size(217, 28);
            label11.TabIndex = 27;
            label11.Text = "количество итераций";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(326, 404);
            label12.Name = "label12";
            label12.Size = new Size(69, 28);
            label12.TabIndex = 26;
            label12.Text = "Время";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(648, 355);
            label10.Name = "label10";
            label10.Size = new Size(294, 28);
            label10.TabIndex = 25;
            label10.Text = "Четная нечетная сортировка";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(326, 355);
            label9.Name = "label9";
            label9.Size = new Size(259, 28);
            label9.TabIndex = 24;
            label9.Text = "Битоническая сортировка";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(28, 355);
            label8.Name = "label8";
            label8.Size = new Size(199, 28);
            label8.TabIndex = 23;
            label8.Text = "Гномья сортировка";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            countLabel.Location = new Point(28, 500);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(217, 28);
            countLabel.TabIndex = 22;
            countLabel.Text = "количество итераций";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(28, 404);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(69, 28);
            timeLabel.TabIndex = 21;
            timeLabel.Text = "Время";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 270);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 20;
            label1.Text = "Отсортированный массив";
            // 
            // afterSortingText
            // 
            afterSortingText.Location = new Point(302, 257);
            afterSortingText.Multiline = true;
            afterSortingText.Name = "afterSortingText";
            afterSortingText.ScrollBars = ScrollBars.Vertical;
            afterSortingText.Size = new Size(657, 64);
            afterSortingText.TabIndex = 19;
            // 
            // beforeSortingText
            // 
            beforeSortingText.Location = new Point(217, 199);
            beforeSortingText.Multiline = true;
            beforeSortingText.Name = "beforeSortingText";
            beforeSortingText.ScrollBars = ScrollBars.Vertical;
            beforeSortingText.Size = new Size(742, 46);
            beforeSortingText.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Location = new Point(22, 63);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(931, 125);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "неотсортированный массив", "почти отсортированный массив", "на половину отсортированный массив" });
            comboBox2.Location = new Point(37, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(494, 31);
            comboBox2.TabIndex = 36;
            comboBox2.Text = "неотсортированный массив";
            // 
            // CompareSorts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1018, 700);
            Controls.Add(panel1);
            Name = "CompareSorts";
            Text = "Тренажер по Алгоритмам";
            Load += CompareSorts_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label2;
        private TextBox elementsNumber;
        private Label label3;
        private Label label5;
        private TextBox fromNumber;
        private TextBox toNumber;
        private Label label4;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox directArray;
        private Label label6;
        private Button sortButton;
        private Panel panel1;
        private Label gnomeTimeLabel;
        private Label label13;
        private Label label14;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label countLabel;
        private Label timeLabel;
        private Label label1;
        private TextBox afterSortingText;
        private Label label7;
        private TextBox beforeSortingText;
        private Label transpositionCountLabel;
        private Label bitonicCountLabel;
        private Label gnomeCountLabel;
        private Label transpositionTimeLabel;
        private Label bitonicTimeLabel;
        private ComboBox comboBox2;
        private GroupBox groupBox3;
        private Button prevbutton;
    }
}