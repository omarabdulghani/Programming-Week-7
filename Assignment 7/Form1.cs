using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSquareRef_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;
            int number = int.Parse(input);

            SquareByReference(ref number);
            lblResult.Text = number.ToString();
        }

        private void SquareRefOut_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;
            int number = int.Parse(input);
            int square;
            SquareByReferenceOut(number, out square);

            lblResult.Text = square.ToString();

        }

        private void btnSquareValue_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;
            int number = int.Parse(input);
            int square = SquareByValue(number);

            lblResult.Text = square.ToString();


        }
        //subprogram Sqaure by refrence

        static void SquareByReference(ref int numb)
        {
           
             numb *= numb;

        }

        //subprogram Sqaure by refrence out

        static void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }

        //subprogram Sqaure by value

        static int SquareByValue(int number)
        {
            return number * number;
        }
    }
}
