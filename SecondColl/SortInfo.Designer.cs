namespace SecondColl
{
    partial class SortInfo
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
            mainText = new Label();
            label2 = new Label();
            sortGif = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            label1 = new Label();
            workingFlowText = new Label();
            label3 = new Label();
            sortSpeedText = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)sortGif).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainText
            // 
            mainText.AutoSize = true;
            mainText.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mainText.Location = new Point(3, 0);
            mainText.MaximumSize = new Size(1000, 0);
            mainText.Name = "mainText";
            mainText.Size = new Size(132, 28);
            mainText.TabIndex = 0;
            mainText.Text = "mainText";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(418, 32);
            label2.Name = "label2";
            label2.Size = new Size(292, 51);
            label2.TabIndex = 1;
            label2.Text = "Gnome Sort";
            label2.Click += label2_Click;
            // 
            // sortGif
            // 
            sortGif.Location = new Point(150, 12);
            sortGif.Margin = new Padding(12, 12, 12, 3);
            sortGif.Name = "sortGif";
            sortGif.Size = new Size(694, 403);
            sortGif.TabIndex = 2;
            sortGif.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(mainText);
            flowLayoutPanel1.Controls.Add(sortGif);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(workingFlowText);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(sortSpeedText);
            flowLayoutPanel1.Location = new Point(47, 110);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1123, 1000);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 421);
            label4.Margin = new Padding(3, 3, 3, 12);
            label4.MaximumSize = new Size(1000, 0);
            label4.MinimumSize = new Size(1000, 0);
            label4.Name = "label4";
            label4.Size = new Size(1000, 23);
            label4.TabIndex = 7;
            label4.Text = "Иллюстрация алгоритма";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 468);
            label1.Margin = new Padding(3, 12, 3, 0);
            label1.MaximumSize = new Size(1000, 0);
            label1.MinimumSize = new Size(1000, 0);
            label1.Name = "label1";
            label1.Size = new Size(1000, 39);
            label1.TabIndex = 4;
            label1.Text = "Принцип работы:";
            // 
            // workingFlowText
            // 
            workingFlowText.AutoSize = true;
            workingFlowText.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            workingFlowText.Location = new Point(3, 510);
            workingFlowText.Margin = new Padding(3, 3, 3, 0);
            workingFlowText.MaximumSize = new Size(1000, 0);
            workingFlowText.Name = "workingFlowText";
            workingFlowText.Size = new Size(237, 28);
            workingFlowText.TabIndex = 3;
            workingFlowText.Text = "workingFlowText";
            workingFlowText.Click += workingFlowText_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 562);
            label3.Margin = new Padding(3, 24, 3, 0);
            label3.MaximumSize = new Size(1000, 0);
            label3.MinimumSize = new Size(1000, 0);
            label3.Name = "label3";
            label3.Size = new Size(1000, 39);
            label3.TabIndex = 6;
            label3.Text = "Скорость сортировки:";
            // 
            // sortSpeedText
            // 
            sortSpeedText.AutoSize = true;
            sortSpeedText.Font = new Font("Lucida Sans Typewriter", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sortSpeedText.Location = new Point(3, 604);
            sortSpeedText.Margin = new Padding(3, 3, 3, 100);
            sortSpeedText.MaximumSize = new Size(1000, 0);
            sortSpeedText.MinimumSize = new Size(1000, 0);
            sortSpeedText.Name = "sortSpeedText";
            sortSpeedText.Size = new Size(1000, 28);
            sortSpeedText.TabIndex = 5;
            sortSpeedText.Text = "sortSpeedText";
            sortSpeedText.Click += sortSpeedText_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 753);
            panel1.TabIndex = 4;
            // 
            // SortInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1282, 753);
            Controls.Add(panel1);
            Name = "SortInfo";
            Text = "Тренажер по Алгоритмам";
            Load += SortInfo_Load;
            ((System.ComponentModel.ISupportInitialize)sortGif).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label mainText;
        private Label label2;
        private PictureBox sortGif;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label workingFlowText;
        private Label label1;
        private Label label3;
        private Label sortSpeedText;
        private Panel panel1;
        private Label label4;
    }
}