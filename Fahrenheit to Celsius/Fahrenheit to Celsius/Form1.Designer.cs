namespace Fahrenheit_to_Celsius
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
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOutput8 = new System.Windows.Forms.Label();
            this.lblOutput12 = new System.Windows.Forms.Label();
            this.lblOutput5 = new System.Windows.Forms.Label();
            this.txtInput8 = new System.Windows.Forms.TextBox();
            this.txtInput12 = new System.Windows.Forms.TextBox();
            this.txtInput5 = new System.Windows.Forms.TextBox();
            this.lblHotCold1 = new System.Windows.Forms.Label();
            this.lblHotCold2 = new System.Windows.Forms.Label();
            this.lblHotCold3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(269, 267);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(72, 23);
            this.btnFahrenheit.TabIndex = 0;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(433, 267);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnCelsius.TabIndex = 1;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "8:00 am";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "12:00 pm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "5:00 pm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Output";
            // 
            // lblOutput8
            // 
            this.lblOutput8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput8.Location = new System.Drawing.Point(523, 79);
            this.lblOutput8.Name = "lblOutput8";
            this.lblOutput8.Size = new System.Drawing.Size(89, 22);
            this.lblOutput8.TabIndex = 7;
            // 
            // lblOutput12
            // 
            this.lblOutput12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput12.Location = new System.Drawing.Point(523, 117);
            this.lblOutput12.Name = "lblOutput12";
            this.lblOutput12.Size = new System.Drawing.Size(86, 25);
            this.lblOutput12.TabIndex = 8;
            // 
            // lblOutput5
            // 
            this.lblOutput5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput5.Location = new System.Drawing.Point(523, 157);
            this.lblOutput5.Name = "lblOutput5";
            this.lblOutput5.Size = new System.Drawing.Size(89, 30);
            this.lblOutput5.TabIndex = 9;
            // 
            // txtInput8
            // 
            this.txtInput8.Location = new System.Drawing.Point(192, 88);
            this.txtInput8.Name = "txtInput8";
            this.txtInput8.Size = new System.Drawing.Size(100, 20);
            this.txtInput8.TabIndex = 10;
            // 
            // txtInput12
            // 
            this.txtInput12.Location = new System.Drawing.Point(192, 122);
            this.txtInput12.Name = "txtInput12";
            this.txtInput12.Size = new System.Drawing.Size(100, 20);
            this.txtInput12.TabIndex = 11;
            // 
            // txtInput5
            // 
            this.txtInput5.Location = new System.Drawing.Point(192, 158);
            this.txtInput5.Name = "txtInput5";
            this.txtInput5.Size = new System.Drawing.Size(100, 20);
            this.txtInput5.TabIndex = 12;
            // 
            // lblHotCold1
            // 
            this.lblHotCold1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHotCold1.Location = new System.Drawing.Point(638, 87);
            this.lblHotCold1.Name = "lblHotCold1";
            this.lblHotCold1.Size = new System.Drawing.Size(94, 21);
            this.lblHotCold1.TabIndex = 13;
            this.lblHotCold1.Visible = false;
            // 
            // lblHotCold2
            // 
            this.lblHotCold2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHotCold2.Location = new System.Drawing.Point(638, 124);
            this.lblHotCold2.Name = "lblHotCold2";
            this.lblHotCold2.Size = new System.Drawing.Size(91, 20);
            this.lblHotCold2.TabIndex = 14;
            this.lblHotCold2.Visible = false;
            // 
            // lblHotCold3
            // 
            this.lblHotCold3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHotCold3.Location = new System.Drawing.Point(641, 165);
            this.lblHotCold3.Name = "lblHotCold3";
            this.lblHotCold3.Size = new System.Drawing.Size(91, 22);
            this.lblHotCold3.TabIndex = 15;
            this.lblHotCold3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHotCold3);
            this.Controls.Add(this.lblHotCold2);
            this.Controls.Add(this.lblHotCold1);
            this.Controls.Add(this.txtInput5);
            this.Controls.Add(this.txtInput12);
            this.Controls.Add(this.txtInput8);
            this.Controls.Add(this.lblOutput5);
            this.Controls.Add(this.lblOutput12);
            this.Controls.Add(this.lblOutput8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnFahrenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOutput8;
        private System.Windows.Forms.Label lblOutput12;
        private System.Windows.Forms.Label lblOutput5;
        private System.Windows.Forms.TextBox txtInput8;
        private System.Windows.Forms.TextBox txtInput12;
        private System.Windows.Forms.TextBox txtInput5;
        private System.Windows.Forms.Label lblHotCold1;
        private System.Windows.Forms.Label lblHotCold2;
        private System.Windows.Forms.Label lblHotCold3;
    }
}

