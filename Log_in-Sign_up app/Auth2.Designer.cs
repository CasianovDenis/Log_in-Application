
namespace Log_in_Sign_up_app
{
    partial class Auth2
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
            this.confirme_textBox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.keylabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.pinlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirme_textBox
            // 
            this.confirme_textBox.Location = new System.Drawing.Point(115, 236);
            this.confirme_textBox.Name = "confirme_textBox";
            this.confirme_textBox.Size = new System.Drawing.Size(106, 20);
            this.confirme_textBox.TabIndex = 0;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(55, 109);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(58, 13);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Username:";
            // 
            // save_button
            // 
            this.save_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.save_button.Location = new System.Drawing.Point(126, 299);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // keylabel
            // 
            this.keylabel.AutoSize = true;
            this.keylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keylabel.Location = new System.Drawing.Point(54, 158);
            this.keylabel.Name = "keylabel";
            this.keylabel.Size = new System.Drawing.Size(34, 16);
            this.keylabel.TabIndex = 3;
            this.keylabel.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(111, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirme 2fa";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(55, 55);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(24, 13);
            this.infolabel.TabIndex = 5;
            this.infolabel.Text = "text";
            // 
            // pinlabel
            // 
            this.pinlabel.AutoSize = true;
            this.pinlabel.Location = new System.Drawing.Point(55, 236);
            this.pinlabel.Name = "pinlabel";
            this.pinlabel.Size = new System.Drawing.Size(25, 13);
            this.pinlabel.TabIndex = 6;
            this.pinlabel.Text = "Pin:";
            // 
            // Auth2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(353, 343);
            this.Controls.Add(this.pinlabel);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keylabel);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.confirme_textBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Auth2";
            this.Text = "Auth2";
            this.Load += new System.EventHandler(this.Auth2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox confirme_textBox;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label keylabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label pinlabel;
    }
}