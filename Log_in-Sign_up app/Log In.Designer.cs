
namespace Log_in_Sign_up_app
{
    partial class Log_In
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
            this.label2 = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.change_username_button = new System.Windows.Forms.Button();
            this.change_email_button = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.auth2_button = new System.Windows.Forms.Button();
            this.auth2_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Data:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(25, 66);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(58, 13);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(25, 167);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(35, 13);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "Email:";
            // 
            // change_username_button
            // 
            this.change_username_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_username_button.Location = new System.Drawing.Point(28, 93);
            this.change_username_button.Name = "change_username_button";
            this.change_username_button.Size = new System.Drawing.Size(107, 23);
            this.change_username_button.TabIndex = 4;
            this.change_username_button.Text = "Change username";
            this.change_username_button.UseVisualStyleBackColor = true;
            this.change_username_button.Click += new System.EventHandler(this.change_username_button_Click);
            // 
            // change_email_button
            // 
            this.change_email_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_email_button.Location = new System.Drawing.Point(28, 201);
            this.change_email_button.Name = "change_email_button";
            this.change_email_button.Size = new System.Drawing.Size(107, 23);
            this.change_email_button.TabIndex = 5;
            this.change_email_button.Text = "Change email";
            this.change_email_button.UseVisualStyleBackColor = true;
            this.change_email_button.Click += new System.EventHandler(this.change_email_button_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbutton.Location = new System.Drawing.Point(334, 375);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // auth2_button
            // 
            this.auth2_button.Location = new System.Drawing.Point(28, 315);
            this.auth2_button.Name = "auth2_button";
            this.auth2_button.Size = new System.Drawing.Size(107, 23);
            this.auth2_button.TabIndex = 7;
            this.auth2_button.Text = "Enable";
            this.auth2_button.UseVisualStyleBackColor = true;
            this.auth2_button.Click += new System.EventHandler(this.auth2_button_Click);
            // 
            // auth2_label
            // 
            this.auth2_label.AutoSize = true;
            this.auth2_label.ForeColor = System.Drawing.Color.White;
            this.auth2_label.Location = new System.Drawing.Point(25, 275);
            this.auth2_label.Name = "auth2_label";
            this.auth2_label.Size = new System.Drawing.Size(131, 13);
            this.auth2_label.TabIndex = 8;
            this.auth2_label.Text = "Two-factor authentication:";
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.auth2_label);
            this.Controls.Add(this.auth2_button);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.change_email_button);
            this.Controls.Add(this.change_username_button);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.label2);
            this.Name = "Log_In";
            this.Text = "Log_In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Button change_username_button;
        private System.Windows.Forms.Button change_email_button;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button auth2_button;
        private System.Windows.Forms.Label auth2_label;
    }
}