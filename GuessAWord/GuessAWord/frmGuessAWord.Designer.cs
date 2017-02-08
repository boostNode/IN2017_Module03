namespace GuessAWord
{
    partial class frmGuessAWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuessAWord));
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblDivider02 = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblInstructions01 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblDivider01 = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.BackColor = System.Drawing.Color.Blue;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFeedback.Location = new System.Drawing.Point(12, 208);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(3);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Padding = new System.Windows.Forms.Padding(2);
            this.lblFeedback.Size = new System.Drawing.Size(260, 60);
            this.lblFeedback.TabIndex = 7;
            this.lblFeedback.Text = "feedback";
            // 
            // lblDivider02
            // 
            this.lblDivider02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDivider02.Location = new System.Drawing.Point(12, 198);
            this.lblDivider02.Margin = new System.Windows.Forms.Padding(3);
            this.lblDivider02.Name = "lblDivider02";
            this.lblDivider02.Size = new System.Drawing.Size(260, 4);
            this.lblDivider02.TabIndex = 6;
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(149, 166);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(26, 26);
            this.txtGuess.TabIndex = 4;
            this.txtGuess.Text = "a";
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGuess
            // 
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(12, 166);
            this.lblGuess.Margin = new System.Windows.Forms.Padding(3);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblGuess.Size = new System.Drawing.Size(140, 26);
            this.lblGuess.TabIndex = 3;
            this.lblGuess.Text = "Enter a letter (a-z):";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInstructions01
            // 
            this.lblInstructions01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions01.ForeColor = System.Drawing.Color.Green;
            this.lblInstructions01.Location = new System.Drawing.Point(12, 12);
            this.lblInstructions01.Margin = new System.Windows.Forms.Padding(3);
            this.lblInstructions01.Name = "lblInstructions01";
            this.lblInstructions01.Size = new System.Drawing.Size(260, 72);
            this.lblInstructions01.TabIndex = 0;
            this.lblInstructions01.Text = resources.GetString("lblInstructions01.Text");
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(197, 166);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnInit
            // 
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.Location = new System.Drawing.Point(172, 274);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(100, 26);
            this.btnInit.TabIndex = 8;
            this.btnInit.Text = "Play Again";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // lblDivider01
            // 
            this.lblDivider01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDivider01.Location = new System.Drawing.Point(12, 156);
            this.lblDivider01.Margin = new System.Windows.Forms.Padding(3);
            this.lblDivider01.Name = "lblDivider01";
            this.lblDivider01.Size = new System.Drawing.Size(260, 4);
            this.lblDivider01.TabIndex = 2;
            // 
            // lblWord
            // 
            this.lblWord.BackColor = System.Drawing.Color.Green;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWord.Location = new System.Drawing.Point(12, 90);
            this.lblWord.Margin = new System.Windows.Forms.Padding(3);
            this.lblWord.Name = "lblWord";
            this.lblWord.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lblWord.Size = new System.Drawing.Size(260, 60);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "word";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGuessAWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblDivider01);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblDivider02);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblInstructions01);
            this.Name = "frmGuessAWord";
            this.Text = "Guess a Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblDivider02;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblInstructions01;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label lblDivider01;
        private System.Windows.Forms.Label lblWord;
    }
}

