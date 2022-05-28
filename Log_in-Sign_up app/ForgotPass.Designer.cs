
namespace Log_in_Sign_up_app
{
    partial class ForgotPass
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.restore_pass_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.display_pass_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Restore Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(118, 119);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(129, 20);
            this.emailtextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Insert you email";
            // 
            // restore_pass_button
            // 
            this.restore_pass_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restore_pass_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restore_pass_button.Location = new System.Drawing.Point(65, 193);
            this.restore_pass_button.Name = "restore_pass_button";
            this.restore_pass_button.Size = new System.Drawing.Size(88, 23);
            this.restore_pass_button.TabIndex = 11;
            this.restore_pass_button.Text = "Restore pass";
            this.restore_pass_button.UseVisualStyleBackColor = true;
            this.restore_pass_button.Click += new System.EventHandler(this.restore_pass_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(171, 192);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 12;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // display_pass_label
            // 
            this.display_pass_label.AutoSize = true;
            this.display_pass_label.ForeColor = System.Drawing.Color.White;
            this.display_pass_label.Location = new System.Drawing.Point(118, 158);
            this.display_pass_label.Name = "display_pass_label";
            this.display_pass_label.Size = new System.Drawing.Size(59, 13);
            this.display_pass_label.TabIndex = 13;
            this.display_pass_label.Text = "forgot pass";
            this.display_pass_label.Visible = false;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.display_pass_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.restore_pass_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtextBox);
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restore_pass_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label display_pass_label;
    }
}