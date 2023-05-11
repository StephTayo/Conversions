using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    /*
     * Allows length conversion between metric and imperial systems
     * 
     */
    public partial class Form1 : Form
    {
        // conversion constants
        const double CM_IN_INCH = 2.54;
        const int INCHES_IN_FOOT = 12;

        public Form1()
        {
            InitializeComponent();
        }

        // convert from feet and inches to centimeters
        private void btnToMetric_Click(object sender, EventArgs e)
        {
            int feet, inches; // full feet and inches
            double centimeters;

            // get feet and inches
            feet = Convert.ToInt32(txtFeet.Text);
            inches = Convert.ToInt32(txtInches.Text);

            // convert to centimeters
            centimeters = ToCentimeters(feet, inches);

            // display centimeters
            txtCentimeters.Text = centimeters.ToString();
        }

        private double ToCentimeters(int feet, int inches)
        {
            int totalInches = feet * INCHES_IN_FOOT + inches;
            double cm = totalInches * CM_IN_INCH;
            return cm;
        }

        // convert from centimeters to feet and inches
        private void btnToImperial_Click(object sender, EventArgs e)
        {
            double centimeters;
            int feet, inches;

            // get centimeters
            centimeters = Convert.ToDouble(txtCentimeters.Text);

            // calculate feet and inches
            ToFeetAndInches(centimeters, out feet, out inches);

            // display feet and inches
            txtFeet.Text = feet.ToString();
            txtInches.Text = inches.ToString();
        }

        // converts centimeters to feet and inches
        private void ToFeetAndInches(double cm, out int feet, out int inches)
        {
            int totalInches = (int)Math.Round(cm / CM_IN_INCH);
            feet = totalInches / INCHES_IN_FOOT; // int division
            inches = totalInches % INCHES_IN_FOOT; // remainder
        }


    }// class
}// namespace
