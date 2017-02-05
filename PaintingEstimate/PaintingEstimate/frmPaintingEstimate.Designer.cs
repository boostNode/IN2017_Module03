namespace PaintingEstimate
{
    partial class frmPaintingEstimate
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
            this.lblInstructions01 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtCostPerSqFt = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstimate = new System.Windows.Forms.TextBox();
            this.lblDivider01 = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions01
            // 
            this.lblInstructions01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions01.ForeColor = System.Drawing.Color.Green;
            this.lblInstructions01.Location = new System.Drawing.Point(13, 13);
            this.lblInstructions01.Name = "lblInstructions01";
            this.lblInstructions01.Size = new System.Drawing.Size(258, 36);
            this.lblInstructions01.TabIndex = 0;
            this.lblInstructions01.Text = "Enter parameters below to compute painting estimate:";
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(12, 49);
            this.lblLength.Name = "lblLength";
            this.lblLength.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblLength.Size = new System.Drawing.Size(160, 26);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length (ft):";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(178, 49);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(80, 26);
            this.txtLength.TabIndex = 2;
            this.txtLength.Text = "0";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(178, 81);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(80, 26);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.Text = "0";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(12, 81);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblWidth.Size = new System.Drawing.Size(160, 26);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width (ft):";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(178, 113);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(80, 26);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.Text = "9";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(12, 113);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblHeight.Size = new System.Drawing.Size(160, 26);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Ceiling Height (ft):";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCostPerSqFt
            // 
            this.txtCostPerSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPerSqFt.Location = new System.Drawing.Point(178, 145);
            this.txtCostPerSqFt.Name = "txtCostPerSqFt";
            this.txtCostPerSqFt.Size = new System.Drawing.Size(80, 26);
            this.txtCostPerSqFt.TabIndex = 8;
            this.txtCostPerSqFt.Text = "6.00";
            this.txtCostPerSqFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostPerSqFt.TextChanged += new System.EventHandler(this.txtCostPerSqFt_TextChanged);
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(12, 145);
            this.lblCost.Name = "lblCost";
            this.lblCost.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCost.Size = new System.Drawing.Size(160, 26);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost ($ per sq/ft):";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(178, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "6.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cost (per sq/ft):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtEstimate
            // 
            this.txtEstimate.Enabled = false;
            this.txtEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimate.Location = new System.Drawing.Point(138, 187);
            this.txtEstimate.Name = "txtEstimate";
            this.txtEstimate.Size = new System.Drawing.Size(120, 26);
            this.txtEstimate.TabIndex = 10;
            this.txtEstimate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDivider01
            // 
            this.lblDivider01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDivider01.Location = new System.Drawing.Point(26, 177);
            this.lblDivider01.Margin = new System.Windows.Forms.Padding(3);
            this.lblDivider01.Name = "lblDivider01";
            this.lblDivider01.Size = new System.Drawing.Size(232, 4);
            this.lblDivider01.TabIndex = 11;
            // 
            // lblFeedback
            // 
            this.lblFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFeedback.Location = new System.Drawing.Point(12, 221);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(258, 64);
            this.lblFeedback.TabIndex = 12;
            this.lblFeedback.Text = "feedback";
            // 
            // lblEstimate
            // 
            this.lblEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimate.Location = new System.Drawing.Point(12, 187);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEstimate.Size = new System.Drawing.Size(120, 26);
            this.lblEstimate.TabIndex = 9;
            this.lblEstimate.Text = "Estimate:";
            this.lblEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPaintingEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblDivider01);
            this.Controls.Add(this.txtEstimate);
            this.Controls.Add(this.lblEstimate);
            this.Controls.Add(this.txtCostPerSqFt);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblInstructions01);
            this.Name = "frmPaintingEstimate";
            this.Text = "Painting Estimate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions01;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtCostPerSqFt;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEstimate;
        private System.Windows.Forms.Label lblDivider01;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblEstimate;
    }
}

