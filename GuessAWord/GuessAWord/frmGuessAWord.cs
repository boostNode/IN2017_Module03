/*
 *  Author: Troy Davis
 *  Project: GuessAWord - GUI (Chapter 6, Programming Exercise 10)
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

namespace GuessAWord
{
    // begin frmGuessAWord : Form
    public partial class frmGuessAWord : Form
    {
        // class scope variables
        int intRandomIndex;
        Random ranNumberGenerator = new Random();

        String[] strArrayWords = new String[] { "dog",
                                                "cat",
                                                "guess",
                                                "syntax",
                                                "iteration",
                                                "method",
                                                "array",
                                                "expression" };

        public frmGuessAWord()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Init();
        }

        // begin Init()
        //      Initializes form
        private void Init()
        {
            // disable init (start) button
            btnInit.Enabled = false;
            // display random word
            intRandomIndex = ranNumberGenerator.Next(0, strArrayWords.Length);
            lblWord.Text = strArrayWords[intRandomIndex];
            lblWord.Visible = true;
            // enable submissions
            txtGuess.Enabled = true;
            btnSubmit.Enabled = true;
        }
        // end Init()
    }
    // end frmGuessAWord : Form
}
