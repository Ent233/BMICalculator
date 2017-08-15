﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: LF
 * Date: August 15, 2017
 * Description: An BMI Calculator with windows form
 * Version: 0.2 finished the calculate function.
*/
namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        double bmi = 0;
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImperialB.Checked = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WeightL_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strHeight = textBox1.Text;
            string strWeight = textBox2.Text;
            double douHeight = Convert.ToDouble(strHeight);
            double douWeight = Convert.ToDouble(strWeight);
            if (MetricB.Checked==true)
            {
                bmi = douWeight / (douHeight * douHeight);
            }
            else
            {
                bmi = douWeight * 703 / (douHeight * douHeight);
            }
            string strBmi = Convert.ToString(bmi);
            textBox3.Text = strBmi;
            int intBmi = (int)Math.Round(bmi);
            if(bmi<18.5)
            {
                textBox4.Text = "You are underweight.";
            }
            else
            {
                if(bmi>=18.5&&bmi<=24.9)
                {
                    textBox4.Text = "You are normal.";
                }
                else
                {
                    if(bmi>24.9&&bmi<=29.9)
                    {
                        textBox4.Text = "You are overweight.";
                    }
                    else
                    {
                        textBox4.Text = "You are obese.";
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
