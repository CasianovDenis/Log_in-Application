
namespace Log_in_Sign_up_app
{
    partial class Verifieaf2
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
            this.pinlabel = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verifie_button = new System.Windows.Forms.Button();
            this.confirme_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pinlabel
            // 
            this.pinlabel.AutoSize = true;
            this.pinlabel.Location = new System.Drawing.Point(75, 152);
            this.pinlabel.Name = "pinlabel";
            this.pinlabel.Size = new System.Drawing.Size(25, 13);
            this.pinlabel.TabIndex = 13;
            this.pinlabel.Text = "Pin:";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(75, 55);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(24, 13);
            this.infolabel.TabIndex = 12;
            this.infolabel.Text = "text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirme 2fa";
            // 
            // verifie_button
            // 
            this.verifie_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifie_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.verifie_button.Location = new System.Drawing.Point(146, 228);
            this.verifie_button.Name = "verifie_button";
            this.verifie_button.Size = new System.Drawing.Size(75, 23);
            this.verifie_button.TabIndex = 9;
            this.verifie_button.Text = "Verifie";
            this.verifie_button.UseVisualStyleBackColor = true;
            this.verifie_button.Click += new System.EventHandler(this.verifie_button_Click);
            // 
            // confirme_textBox
            // 
            this.confirme_textBox.Location = new System.Drawing.Point(135, 152);
            this.confirme_textBox.Name = "confirme_textBox";
            this.confirme_textBox.Size = new System.Drawing.Size(106, 20);
            this.confirme_textBox.TabIndex = 7;
            // 
            // Verifiedaf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(350, 334);
            this.Controls.Add(this.pinlabel);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verifie_button);
            this.Controls.Add(this.confirme_textBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Verifiedaf2";
            this.Text = "Verifiedaf2";
            this.Load += new System.EventHandler(this.Verifiedaf2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pinlabel;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button verifie_button;
        private System.Windows.Forms.TextBox confirme_textBox;
    }
}