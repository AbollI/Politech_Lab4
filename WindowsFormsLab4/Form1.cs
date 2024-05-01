using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction frac1 = new Fraction(2, 3);

            if (frac1.GetError() == 0)
            {
                Fraction frac2 = frac1.Reverse();
                if (frac2.GetError() == 0)
                {
                    string strfrac1 = frac1.toString();
                    string strfrac2 = frac2.toString();
                    textBox1.Text = "Fraction1 = "+strfrac1+Environment.NewLine+"reverse Fraction1 = " + strfrac2;
                }
                else { textBox1.Text = "error, fraction with a numerator equal to 0 can't be reversed."; }
            }
            else { textBox1.Text = "error, denominator can't be equal to 0."; }
            int i = 1 + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(4, 5);
            Fraction f3 = new Fraction(6, 7);

            string init = "f1 = " + f1.toString() + Environment.NewLine + "f2 = " + f2.toString() + Environment.NewLine + "f3 = " + f3.toString() + Environment.NewLine;

            Fraction R = (f1 + f2) * (f1 - f3);

            textBox2.Text =init + Environment.NewLine + "R = " + R.toString() + Environment.NewLine + "1/R = " + R.Reverse().toString();
        }
    }
}
