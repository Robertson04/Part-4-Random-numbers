namespace Part_4_Random_numbers
{
    partial class RandomNumbers
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
            this.lblnumbers = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.btnint = new System.Windows.Forms.Button();
            this.btndub = new System.Windows.Forms.Button();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnumbers
            // 
            this.lblnumbers.AutoSize = true;
            this.lblnumbers.Location = new System.Drawing.Point(53, 244);
            this.lblnumbers.Name = "lblnumbers";
            this.lblnumbers.Size = new System.Drawing.Size(35, 13);
            this.lblnumbers.TabIndex = 0;
            this.lblnumbers.Text = "label1";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(53, 35);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(180, 13);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "Enter a minimum and maximum value";
            // 
            // btnint
            // 
            this.btnint.Location = new System.Drawing.Point(53, 180);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(75, 23);
            this.btnint.TabIndex = 2;
            this.btnint.Text = "Interger";
            this.btnint.UseVisualStyleBackColor = true;
            this.btnint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndub
            // 
            this.btndub.Location = new System.Drawing.Point(194, 180);
            this.btndub.Name = "btndub";
            this.btndub.Size = new System.Drawing.Size(75, 23);
            this.btndub.TabIndex = 3;
            this.btndub.Text = "Double";
            this.btndub.UseVisualStyleBackColor = true;
            this.btndub.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(53, 86);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(48, 13);
            this.lblmin.TabIndex = 4;
            this.lblmin.Text = "Minimum";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(53, 136);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(51, 13);
            this.lblmax.TabIndex = 5;
            this.lblmax.Text = "Maximum";
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(169, 86);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(100, 20);
            this.txtmin.TabIndex = 6;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(169, 136);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 20);
            this.txtmax.TabIndex = 7;
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.btndub);
            this.Controls.Add(this.btnint);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.lblnumbers);
            this.Name = "RandomNumbers";
            this.Text = "RandomNumbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumbers;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Button btnint;
        private System.Windows.Forms.Button btndub;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
    }
}

