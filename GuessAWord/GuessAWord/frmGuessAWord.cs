/*
 *  Author: Troy Davis
 *  Project: GuessAWord - GUI (Chapter 6, Programming Exercise 10)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 7, 2017 
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

using System.Text.RegularExpressions;

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

        String strWord_Chosen, strWord_Displayed;

        char charGuess;
        char charPlaceholder = '*';

        Regex rgx = new Regex(@"^[a-zA-Z]$");

        public frmGuessAWord()
        {
            InitializeComponent();
            Init();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // initialize form
            Init();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // validate input (using regular expression for characters a-z OR A-Z)
            bool boolError = false;
            if( rgx.IsMatch(txtGuess.Text) )
            {
                charGuess = txtGuess.Text.ToString().ToLower()[0];
            }
            else
            {
                boolError = true;
            }
            // process input OR provide feedback on erroneous input
            if( boolError )
            {
                lblFeedback.Text = "Invalid Input: enter a single letter (a-z)!";
            }
            else
            {
                lblFeedback.Text = Update_WordDisplayed(strWord_Chosen, ref strWord_Displayed, charGuess);
                lblWord.Text = strWord_Displayed;
                if( strWord_Displayed == strWord_Chosen )
                {
                    GameOver();
                }
            }
        }

        // begin Init()
        //      Initializes form
        private void Init()
        {
            // disable init button
            btnInit.Enabled = false;
            // initialize chosen word (random)
            intRandomIndex = ranNumberGenerator.Next(0, strArrayWords.Length); // get random index to strArrayWords
            strWord_Chosen = strArrayWords[intRandomIndex].ToLower(); // populate strWordChosen. ensure all lowercase characters
            // initialize displayed word
            lblWord.Text = Init_WordDisplayed(strWord_Chosen, ref strWord_Displayed, charPlaceholder);
            // reset/enable submissions
            txtGuess.Text = "";
            txtGuess.Enabled = true;
            btnSubmit.Enabled = true;
            // reset feedback
            lblFeedback.Text = "";
        }
        // end Init()

        // begin Init_WordDisplayed()
        private String Init_WordDisplayed(String word_chosen, ref String word_displayed, char placeholder)
        {
            char charCurrent;
            // init word_displayed
            word_displayed = word_chosen; // basically matching length of word_displayed to length of word_chosen
            // replace all characters in word_displayed with placeholder
            for ( int i = 0 ; i < word_displayed.Length ; i++ )
            {
                charCurrent = word_chosen[i];
                word_displayed = word_displayed.Replace(charCurrent, placeholder);
            }
            return word_displayed;
        }
        // end Init_WordDisplayed()

        // begin Update_WordDisplayed()
        private String Update_WordDisplayed(String word_chosen, ref String word_displayed, char char_guess)
        {
            bool boolFoundLetter = false;
            for( int i = 0 ; i < word_chosen.Length ; i++ )
            {
                if( word_chosen[i] == char_guess )
                {
                    word_displayed = word_displayed.Insert(i, char_guess.ToString());
                    word_displayed = word_displayed.Remove(i + 1, 1);
                    boolFoundLetter = true;
                }
            }
            if( boolFoundLetter )
            {
                return "Yes, the letter '" + char_guess.ToString() + "' is in the word!";
            }
            else
            {
                return "Sorry, the letter '" + char_guess.ToString() + "' is not in the word!";
            }
        }
        // end Update_WordDisplayed()

        // begin GameOver()
        private void GameOver()
        {
            // disable input
            txtGuess.Enabled = false;
            btnSubmit.Enabled = false;
            // congratulate user
            lblFeedback.Text = "Congratulations, you got it!";
            // enable restart
            btnInit.Enabled = true;
        }
        // end GameOver()
    }
    // end frmGuessAWord : Form
}
