namespace DailySpecial
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdayBox = new System.Windows.Forms.TextBox();
            this.btnspecialButton = new System.Windows.Forms.Button();
            this.lbloutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a day number to see our special ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "For Example, Sunday = 1";
            // 
            // txtdayBox
            // 
            this.txtdayBox.Location = new System.Drawing.Point(301, 158);
            this.txtdayBox.Name = "txtdayBox";
            this.txtdayBox.Size = new System.Drawing.Size(100, 20);
            this.txtdayBox.TabIndex = 2;
            // 
            // btnspecialButton
            // 
            this.btnspecialButton.Location = new System.Drawing.Point(310, 213);
            this.btnspecialButton.Name = "btnspecialButton";
            this.btnspecialButton.Size = new System.Drawing.Size(75, 23);
            this.btnspecialButton.TabIndex = 3;
            this.btnspecialButton.Text = "Get special";
            this.btnspecialButton.UseVisualStyleBackColor = true;
            this.btnspecialButton.Click += new System.EventHandler(this.btnspecialButton_Click);
            // 
            // lbloutputLabel
            // 
            this.lbloutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbloutputLabel.Location = new System.Drawing.Point(301, 277);
            this.lbloutputLabel.Name = "lbloutputLabel";
            this.lbloutputLabel.Size = new System.Drawing.Size(100, 23);
            this.lbloutputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutputLabel);
            this.Controls.Add(this.btnspecialButton);
            this.Controls.Add(this.txtdayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdayBox;
        private System.Windows.Forms.Button btnspecialButton;
        private System.Windows.Forms.Label lbloutputLabel;
    }
}

