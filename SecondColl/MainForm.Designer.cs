namespace SecondColl
{
    partial class MainForm
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
            label1 = new Label();
            gnomeSortButton = new Button();
            bitonicSortButton = new Button();
            transpositionSortButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 62);
            label1.MaximumSize = new Size(600, 0);
            label1.Name = "label1";
            label1.Size = new Size(599, 168);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать. \r\n\r\nЭто программа Тренажер по алгоритмам сортировки для школьников. Здесь вы сможете узнать больше о следующих 3 алгоритмах сортировки. Выберите один из них для тренировки.\r\n";
            // 
            // gnomeSortButton
            // 
            gnomeSortButton.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gnomeSortButton.Location = new Point(282, 316);
            gnomeSortButton.Name = "gnomeSortButton";
            gnomeSortButton.Size = new Size(190, 44);
            gnomeSortButton.TabIndex = 1;
            gnomeSortButton.Text = "Gnome sort";
            gnomeSortButton.UseVisualStyleBackColor = true;
            gnomeSortButton.Click += gnomeSortButton_Click;
            // 
            // bitonicSortButton
            // 
            bitonicSortButton.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bitonicSortButton.Location = new Point(74, 316);
            bitonicSortButton.Name = "bitonicSortButton";
            bitonicSortButton.Size = new Size(165, 44);
            bitonicSortButton.TabIndex = 2;
            bitonicSortButton.Text = "Bitonic sort";
            bitonicSortButton.UseVisualStyleBackColor = true;
            bitonicSortButton.Click += button1_Click;
            // 
            // transpositionSortButton
            // 
            transpositionSortButton.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            transpositionSortButton.Location = new Point(520, 316);
            transpositionSortButton.Name = "transpositionSortButton";
            transpositionSortButton.Size = new Size(165, 44);
            transpositionSortButton.TabIndex = 3;
            transpositionSortButton.Text = "Transposition sort";
            transpositionSortButton.UseVisualStyleBackColor = true;
            transpositionSortButton.Click += transpositionSortButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(74, 380);
            button1.Name = "button1";
            button1.Size = new Size(611, 44);
            button1.TabIndex = 4;
            button1.Text = "Сравнение алгоритмов";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(transpositionSortButton);
            Controls.Add(bitonicSortButton);
            Controls.Add(gnomeSortButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Тренажер по Алгоритмам";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button gnomeSortButton;
        private Button bitonicSortButton;
        private Button transpositionSortButton;
        private Button button1;
    }
}