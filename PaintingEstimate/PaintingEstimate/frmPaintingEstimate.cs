/*
 *  Author: Troy Davis
 *  Project: Painting Estimate Application - GUI (Chapter 7, Programming Exercise 3)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 5, 2017 
 *  Revision: Original
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingEstimate
{
    public partial class frmPaintingEstimate : Form
    {
        // define class global variables
        double dblLength = 0.0;
        double dblWidth = 0.0;
        double dblHeight = 9.0;
        double dblCostPerSqFt = 6.00;

        bool boolErrLength = false;
        bool boolErrWidth = false;
        bool boolErrHeight = false;
        bool boolErrCostPerSqFt = false;

        public frmPaintingEstimate()
        {
            InitializeComponent();

            // initialize form
            FormFeedback();
        }

        // form input - get length
        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            // validate input
            boolErrLength = false;
            if ( txtLength.Text != "" )
            {
                // parse input to Double, handle non-numeric input
                if (!Double.TryParse(txtLength.Text, out dblLength))
                {
                    boolErrLength = true;
                    dblLength = 0.0;
                }
                // TO DO - range checking goes here (if desired)
            }
            else
            {
                txtLength.Text = "0";
                dblLength = 0.0;
            }
            FormFeedback();
        }

        // form input - get width
        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            // validate input
            boolErrWidth = false;
            if ( txtWidth.Text != "" )
            {
                // parse input to Double, handle non-numeric input
                if (!Double.TryParse(txtWidth.Text, out dblWidth))
                {
                    boolErrWidth = true;
                    dblWidth = 0.0;
                }
                // TO DO - range checking goes here (if desired)
            }
            else
            {
                txtWidth.Text = "0";
                dblWidth = 0.0;
            }
            FormFeedback();
        }

        // form input - get height
        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            // validate input
            boolErrHeight = false;
            if ( txtHeight.Text != "" )
            {
                // parse input to Double, handle non-numeric input
                if (!Double.TryParse(txtHeight.Text, out dblHeight))
                {
                    boolErrHeight = true;
                    dblHeight = 0.0;
                }
                // TO DO - range checking goes here (if desired)
            }
            else
            {
                txtHeight.Text = "9";
                dblHeight = 9.0;
            }
            FormFeedback();
        }

        // form input - get cost per square foot
        private void txtCostPerSqFt_TextChanged(object sender, EventArgs e)
        {
            // validate input
            boolErrCostPerSqFt = false;
            if (txtCostPerSqFt.Text != "")
            {
                // parse input to Double, handle non-numeric input
                if (!Double.TryParse(txtCostPerSqFt.Text, out dblCostPerSqFt))
                {
                    boolErrCostPerSqFt = true;
                    dblCostPerSqFt = 0.0;
                }
                // TO DO - range checking goes here (if desired)
            }
            else
            {
                txtCostPerSqFt.Text = "6.00";
                dblCostPerSqFt = 6.00;
            }
            FormFeedback();
        }

        //  ComputeEstimate method
        //
        //      Inputs:
        //          double      length      length of room in feet, decimal value or whole number
        //          double      width       width of room in feet, decimal value or whole number
        //          double      height      (optional) height of room in feet, decimal value or whole number (default is 9.0 feet)
        //          double      cost        (optional) cost per square foot to paint room, decimal value or whole number (default is $6.00 per sq/ft)
        //
        //      Outputs:
        //          double      dblEstimate returned (note: walls only, does not include cost paint ceiling) 
        //   
        private double ComputeEstimate(double length, double width, double height = 9.0, double cost = 6.00)
        {
            double dblEstimate = 2.0 * ( ( length * height ) + ( width * height ) ) * cost;

            return dblEstimate;
        }

        //  FormFeedback method
        //
        //      Inputs:
        //          None
        //
        //      Outputs:
        //          Displays feedback on form (lblFeedback) if form input validation errors are present
        //          Calls ComputeEstimate if form input is valid
        //
        private void FormFeedback()
        {
            String strFeedback = "";

            // build feedback string
            if( boolErrLength )
            {
                strFeedback += "- length must be a whole or decimal number\n";
            }

            if ( boolErrWidth )
            {
                strFeedback += "- width must be a whole or decimal number\n";
            }

            if ( boolErrHeight )
            {
                strFeedback += "- height must be a whole or decimal number\n";
            }

            if ( boolErrCostPerSqFt )
            {
                strFeedback += "- cost must be a whole or decimal number\n";
            }

            // output feedback
            lblFeedback.Text = strFeedback;
            if ( strFeedback != "" )
            {
                lblFeedback.Visible = true;
                txtEstimate.Text = "error";
            }
            else
            {
                lblFeedback.Visible = false;
                txtEstimate.Text = ComputeEstimate(dblLength, dblWidth, dblHeight, dblCostPerSqFt).ToString("C2");
            }
        }
    }
}
