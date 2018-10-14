using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDegrees_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtDegrees.Text;
            double degrees = double.Parse(input);

            double CtoK = Celsius2Kelvin(degrees);
            double CtoF = Celsius2Fahrenheit(degrees);
            double FtoC = Fahrenheit2Celsius(degrees);

            if (rdCtoK.Checked)
            {

                lblResult.Text = CtoK.ToString("0.00");
            }

            if (rdCtoF.Checked)
            {
                lblResult.Text = CtoF.ToString("0.00");
            }

            if (rdFtoC.Checked)
            {
                lblResult.Text = FtoC.ToString("0.00");
            }
        }

        private void rdCtoK_CheckedChanged(object sender, EventArgs e)
        {

        }

        //..C to K conversion 
        static double Celsius2Kelvin(double degrees)
        {
            return degrees + 273;
        }

        //.. C to F conversion
        static double Celsius2Fahrenheit(double degrees)
        {
            return  (degrees * 9 / 5 + 32);
        }

        //.. F to C conversion 
        static double Fahrenheit2Celsius(double degrees)
        {
            return ((degrees - 32) * 5 / 9);
        }
    }
}
