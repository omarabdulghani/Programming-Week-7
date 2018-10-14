using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string inputOne = txtNumberOne.Text;
            int numberone = int.Parse(inputOne);

            string inputTwo = txtNumberTwo.Text;
            int numbertwo = int.Parse(inputTwo);

            double calc = Plus(numberone, numbertwo);
            



            lblResult.Text = calc.ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string inputOne = txtNumberOne.Text;
            int numberone = int.Parse(inputOne);

            string inputTwo = txtNumberTwo.Text;
            int numbertwo = int.Parse(inputTwo);

            double calc = Minus(numberone, numbertwo);




            lblResult.Text = calc.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            string inputOne = txtNumberOne.Text;
            int numberone = int.Parse(inputOne);

            string inputTwo = txtNumberTwo.Text;
            int numbertwo = int.Parse(inputTwo);

            double calc = Product(numberone, numbertwo);




            lblResult.Text = calc.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string inputOne = txtNumberOne.Text;
            double numberone = int.Parse(inputOne);

            string inputTwo = txtNumberTwo.Text;
            double numbertwo = int.Parse(inputTwo);

            double calc = Division(numberone, numbertwo);




            lblResult.Text = calc.ToString("0.000");

        }
        //..subprogram addition 

        static double Plus(int numb1, int numb2)
        {

       
            return numb1 + numb2;
        }
        //..subprogram subtraction

        static double Minus(int numb1, int numb2)
        {


            return numb1 - numb2;
        }
        //..subprogram product

        static double Product(int numb1, int numb2)
        {


            return numb1 * numb2;
        }
        //..subprogram division

        static double Division(double numb1, double numb2)
        {


            return numb1 / numb2;
        }
    }

    }

