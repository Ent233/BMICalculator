using System;
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
 * Description: An SplashForm with windows form
 * Version: 0.1 finished the Splash screen.
*/
namespace BMICalculator
{
    public partial class SplashForm : Form
    {
        //PROPERTIES
        public BMICalculator BMICalculator
        {
            get
            {
                return Program.bMICalculator;
            }
        }
        public SplashForm()
        {
            InitializeComponent();
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.BMICalculator.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
