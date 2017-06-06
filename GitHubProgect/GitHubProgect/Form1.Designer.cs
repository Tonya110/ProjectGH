namespace GitHubProgect
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
            this.S = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.Num2 = new System.Windows.Forms.NumericUpDown();
            this.Rez = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).BeginInit();
            this.SuspendLayout();
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(390, 49);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(75, 23);
            this.S.TabIndex = 0;
            this.S.Text = "+";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(390, 89);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(75, 23);
            this.R.TabIndex = 1;
            this.R.Text = "-";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(390, 137);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(75, 23);
            this.U.TabIndex = 2;
            this.U.Text = "*";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.U_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(390, 185);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(75, 23);
            this.D.TabIndex = 3;
            this.D.Text = "/";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(106, 80);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(120, 20);
            this.Num1.TabIndex = 4;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(106, 140);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(120, 20);
            this.Num2.TabIndex = 5;
            // 
            // Rez
            // 
            this.Rez.Location = new System.Drawing.Point(223, 271);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(100, 20);
            this.Rez.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 332);
            this.Controls.Add(this.Rez);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.D);
            this.Controls.Add(this.U);
            this.Controls.Add(this.R);
            this.Controls.Add(this.S);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.NumericUpDown Num2;
        private System.Windows.Forms.TextBox Rez;
    }
}

