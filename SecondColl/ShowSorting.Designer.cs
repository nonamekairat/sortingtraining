namespace SecondColl
{
    partial class ShowSorting
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
            beforeSortingText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            afterSortingText = new TextBox();
            timeLabel = new Label();
            countLabel = new Label();
            iterationsTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // beforeSortingText
            // 
            beforeSortingText.Location = new Point(33, 98);
            beforeSortingText.Multiline = true;
            beforeSortingText.Name = "beforeSortingText";
            beforeSortingText.ScrollBars = ScrollBars.Vertical;
            beforeSortingText.Size = new Size(303, 134);
            beforeSortingText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 67);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 1;
            label1.Text = "Исходный массив";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 254);
            label2.Name = "label2";
            label2.Size = new Size(259, 28);
            label2.TabIndex = 3;
            label2.Text = "Отсортированный массив";
            label2.Click += label2_Click;
            // 
            // afterSortingText
            // 
            afterSortingText.Location = new Point(33, 293);
            afterSortingText.Multiline = true;
            afterSortingText.Name = "afterSortingText";
            afterSortingText.ScrollBars = ScrollBars.Vertical;
            afterSortingText.Size = new Size(303, 133);
            afterSortingText.TabIndex = 2;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(308, 30);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(69, 28);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "Время";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            countLabel.Location = new Point(458, 30);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(217, 28);
            countLabel.TabIndex = 5;
            countLabel.Text = "количество итераций";
            // 
            // iterationsTextBox
            // 
            iterationsTextBox.Location = new Point(402, 98);
            iterationsTextBox.Multiline = true;
            iterationsTextBox.Name = "iterationsTextBox";
            iterationsTextBox.ScrollBars = ScrollBars.Vertical;
            iterationsTextBox.Size = new Size(359, 328);
            iterationsTextBox.TabIndex = 6;
            iterationsTextBox.TextChanged += iterationsTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(402, 67);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 7;
            label5.Text = "Итерации";
            // 
            // ShowSorting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(iterationsTextBox);
            Controls.Add(countLabel);
            Controls.Add(timeLabel);
            Controls.Add(label2);
            Controls.Add(afterSortingText);
            Controls.Add(label1);
            Controls.Add(beforeSortingText);
            Name = "ShowSorting";
            Text = "Тренажер по Алгоритмам";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox beforeSortingText;
        private Label label1;
        private Label label2;
        private TextBox afterSortingText;
        private Label timeLabel;
        private Label countLabel;
        private TextBox iterationsTextBox;
        private Label label5;
    }
}