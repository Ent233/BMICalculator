namespace BMICalculator
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ImperialB = new System.Windows.Forms.RadioButton();
            this.MetricB = new System.Windows.Forms.RadioButton();
            this.HeightL = new System.Windows.Forms.Label();
            this.WeightL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MetricB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ImperialB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 223);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(3, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(2, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 38);
            this.textBox3.TabIndex = 5;
            // 
            // ImperialB
            // 
            this.ImperialB.AutoSize = true;
            this.ImperialB.Location = new System.Drawing.Point(3, 3);
            this.ImperialB.Name = "ImperialB";
            this.ImperialB.Size = new System.Drawing.Size(128, 35);
            this.ImperialB.TabIndex = 5;
            this.ImperialB.TabStop = true;
            this.ImperialB.Text = "Imperial";
            this.ImperialB.UseVisualStyleBackColor = true;
            // 
            // MetricB
            // 
            this.MetricB.AutoSize = true;
            this.MetricB.Location = new System.Drawing.Point(152, 3);
            this.MetricB.Name = "MetricB";
            this.MetricB.Size = new System.Drawing.Size(106, 35);
            this.MetricB.TabIndex = 6;
            this.MetricB.TabStop = true;
            this.MetricB.Text = "Metric";
            this.MetricB.UseVisualStyleBackColor = true;
            // 
            // HeightL
            // 
            this.HeightL.AutoSize = true;
            this.HeightL.Location = new System.Drawing.Point(3, 55);
            this.HeightL.Name = "HeightL";
            this.HeightL.Size = new System.Drawing.Size(136, 31);
            this.HeightL.TabIndex = 7;
            this.HeightL.Text = "My Height";
            this.HeightL.Click += new System.EventHandler(this.label1_Click);
            // 
            // WeightL
            // 
            this.WeightL.AutoSize = true;
            this.WeightL.Location = new System.Drawing.Point(3, 110);
            this.WeightL.Name = "WeightL";
            this.WeightL.Size = new System.Drawing.Size(141, 31);
            this.WeightL.TabIndex = 8;
            this.WeightL.Text = "My Weight";
            this.WeightL.Click += new System.EventHandler(this.WeightL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton MetricB;
        private System.Windows.Forms.RadioButton ImperialB;
        private System.Windows.Forms.Label HeightL;
        private System.Windows.Forms.Label WeightL;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

