namespace Laba1
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
            textBox_ProbabilityA = new TextBox();
            textBox_ProbabilityB = new TextBox();
            textBox_ProbabilityC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton_Independent = new RadioButton();
            radioButton_Incompatible = new RadioButton();
            numericUpDown_Steps = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_Frequency = new TextBox();
            textBox_Probability = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button_Test = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Steps).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_ProbabilityA
            // 
            textBox_ProbabilityA.Dock = DockStyle.Fill;
            textBox_ProbabilityA.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ProbabilityA.Location = new Point(56, 3);
            textBox_ProbabilityA.Name = "textBox_ProbabilityA";
            textBox_ProbabilityA.Size = new Size(842, 29);
            textBox_ProbabilityA.TabIndex = 0;
            // 
            // textBox_ProbabilityB
            // 
            textBox_ProbabilityB.Dock = DockStyle.Fill;
            textBox_ProbabilityB.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ProbabilityB.Location = new Point(55, 3);
            textBox_ProbabilityB.Name = "textBox_ProbabilityB";
            textBox_ProbabilityB.Size = new Size(843, 29);
            textBox_ProbabilityB.TabIndex = 1;
            // 
            // textBox_ProbabilityC
            // 
            textBox_ProbabilityC.Dock = DockStyle.Fill;
            textBox_ProbabilityC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ProbabilityC.Location = new Point(56, 3);
            textBox_ProbabilityC.Name = "textBox_ProbabilityC";
            textBox_ProbabilityC.Size = new Size(842, 29);
            textBox_ProbabilityC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 36);
            label1.TabIndex = 3;
            label1.Text = "P(A)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 35);
            label2.TabIndex = 4;
            label2.Text = "P(B)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 35);
            label3.TabIndex = 5;
            label3.Text = "P(C)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton_Independent
            // 
            radioButton_Independent.AutoSize = true;
            radioButton_Independent.Checked = true;
            radioButton_Independent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_Independent.Location = new Point(290, 3);
            radioButton_Independent.Name = "radioButton_Independent";
            radioButton_Independent.RightToLeft = RightToLeft.No;
            radioButton_Independent.Size = new Size(152, 28);
            radioButton_Independent.TabIndex = 6;
            radioButton_Independent.TabStop = true;
            radioButton_Independent.Text = "Независимые";
            radioButton_Independent.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_Independent.UseVisualStyleBackColor = true;
            // 
            // radioButton_Incompatible
            // 
            radioButton_Incompatible.AutoSize = true;
            radioButton_Incompatible.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_Incompatible.Location = new Point(448, 3);
            radioButton_Incompatible.Name = "radioButton_Incompatible";
            radioButton_Incompatible.Size = new Size(163, 28);
            radioButton_Incompatible.TabIndex = 7;
            radioButton_Incompatible.Text = "Несовместные";
            radioButton_Incompatible.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_Incompatible.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Steps
            // 
            numericUpDown_Steps.Dock = DockStyle.Fill;
            numericUpDown_Steps.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_Steps.Location = new Point(132, 3);
            numericUpDown_Steps.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown_Steps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Steps.Name = "numericUpDown_Steps";
            numericUpDown_Steps.Size = new Size(766, 29);
            numericUpDown_Steps.TabIndex = 8;
            numericUpDown_Steps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 35);
            label4.TabIndex = 9;
            label4.Text = "Число шагов";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 35);
            label5.TabIndex = 10;
            label5.Text = "Частота D";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 35);
            label6.TabIndex = 11;
            label6.Text = "Вероятность D";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Frequency
            // 
            textBox_Frequency.Dock = DockStyle.Fill;
            textBox_Frequency.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Frequency.Location = new Point(109, 3);
            textBox_Frequency.Name = "textBox_Frequency";
            textBox_Frequency.ReadOnly = true;
            textBox_Frequency.Size = new Size(789, 29);
            textBox_Frequency.TabIndex = 12;
            // 
            // textBox_Probability
            // 
            textBox_Probability.Dock = DockStyle.Fill;
            textBox_Probability.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Probability.Location = new Point(155, 3);
            textBox_Probability.Name = "textBox_Probability";
            textBox_Probability.ReadOnly = true;
            textBox_Probability.Size = new Size(743, 29);
            textBox_Probability.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(button_Test, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(907, 361);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(label4, 0, 0);
            tableLayoutPanel8.Controls.Add(numericUpDown_Steps, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Top;
            tableLayoutPanel8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel8.Location = new Point(3, 168);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(901, 35);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox_Frequency, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(3, 250);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(901, 35);
            tableLayoutPanel5.TabIndex = 17;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(textBox_ProbabilityC, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel6.Location = new Point(3, 127);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(901, 35);
            tableLayoutPanel6.TabIndex = 17;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label2, 0, 0);
            tableLayoutPanel7.Controls.Add(textBox_ProbabilityB, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel7.Location = new Point(3, 86);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(901, 35);
            tableLayoutPanel7.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(textBox_Probability, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel4.Location = new Point(3, 291);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(901, 35);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(radioButton_Incompatible, 2, 0);
            tableLayoutPanel2.Controls.Add(radioButton_Independent, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(901, 35);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(textBox_ProbabilityA, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel3.Location = new Point(3, 44);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(901, 36);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // button_Test
            // 
            button_Test.Dock = DockStyle.Fill;
            button_Test.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Test.Location = new Point(3, 209);
            button_Test.Name = "button_Test";
            button_Test.Size = new Size(901, 35);
            button_Test.TabIndex = 15;
            button_Test.Text = "Испытать";
            button_Test.UseVisualStyleBackColor = true;
            button_Test.Click += button_Test_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 361);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(345, 400);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Steps).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_ProbabilityA;
        private TextBox textBox_ProbabilityB;
        private TextBox textBox_ProbabilityC;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton_Independent;
        private RadioButton radioButton_Incompatible;
        private NumericUpDown numericUpDown_Steps;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_Frequency;
        private TextBox textBox_Probability;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_Test;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel4;
    }
}