namespace SecondColl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            elementsNumber = new TextBox();
            fromNumber = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toNumber = new TextBox();
            comboBox1 = new ComboBox();
            directArray = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            sortButton = new Button();
            prevbutton = new Button();
            infoButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(251, 16);
            label1.Name = "label1";
            label1.Size = new Size(428, 51);
            label1.TabIndex = 0;
            label1.Text = "Гномья сортировка";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 41);
            label2.Name = "label2";
            label2.Size = new Size(229, 28);
            label2.TabIndex = 1;
            label2.Text = "количество элементов";
            // 
            // elementsNumber
            // 
            elementsNumber.Location = new Point(37, 74);
            elementsNumber.Name = "elementsNumber";
            elementsNumber.Size = new Size(220, 27);
            elementsNumber.TabIndex = 2;
            // 
            // fromNumber
            // 
            fromNumber.Location = new Point(379, 74);
            fromNumber.Name = "fromNumber";
            fromNumber.Size = new Size(52, 27);
            fromNumber.TabIndex = 4;
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
            // toNumber
            // 
            toNumber.Location = new Point(479, 74);
            toNumber.Name = "toNumber";
            toNumber.Size = new Size(52, 27);
            toNumber.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "случайные числа", "свой массив" });
            comboBox1.Location = new Point(79, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 31);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "случайные числа";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // directArray
            // 
            directArray.Location = new Point(151, 26);
            directArray.Name = "directArray";
            directArray.Size = new Size(547, 27);
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
            label6.Click += label6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(directArray);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(30, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 71);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(elementsNumber);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(fromNumber);
            groupBox2.Controls.Add(toNumber);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(30, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(726, 125);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // sortButton
            // 
            sortButton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sortButton.Location = new Point(58, 284);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(172, 38);
            sortButton.TabIndex = 13;
            sortButton.Text = "Отсортировать";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // prevbutton
            // 
            prevbutton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prevbutton.ForeColor = SystemColors.ActiveCaptionText;
            prevbutton.Location = new Point(30, 32);
            prevbutton.Name = "prevbutton";
            prevbutton.Size = new Size(94, 35);
            prevbutton.TabIndex = 14;
            prevbutton.Text = "назад";
            prevbutton.UseVisualStyleBackColor = true;
            prevbutton.Click += prevbutton_Click;
            // 
            // infoButton
            // 
            infoButton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoButton.ForeColor = SystemColors.ActiveCaptionText;
            infoButton.Location = new Point(251, 282);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(266, 42);
            infoButton.TabIndex = 15;
            infoButton.Text = "Информация об Алгоритме";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 523);
            Controls.Add(infoButton);
            Controls.Add(prevbutton);
            Controls.Add(sortButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Тренажер по Алгоритмам";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox elementsNumber;
        private TextBox fromNumber;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox toNumber;
        private ComboBox comboBox1;
        private TextBox directArray;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button sortButton;
        private Button prevbutton;
        private Button infoButton;
    }
}