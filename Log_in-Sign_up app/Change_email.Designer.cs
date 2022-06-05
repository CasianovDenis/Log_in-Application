
namespace Log_in_Sign_up_app
{
    partial class Change_email
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
            this.exist_email_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_button = new System.Windows.Forms.Button();
            this.New_email_textBox = new System.Windows.Forms.TextBox();
            this.old_email_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exist_email_label
            // 
            this.exist_email_label.AutoSize = true;
            this.exist_email_label.Location = new System.Drawing.Point(108, 155);
            this.exist_email_label.Name = "exist_email_label";
            this.exist_email_label.Size = new System.Drawing.Size(115, 13);
            this.exist_email_label.TabIndex = 13;
            this.exist_email_label.Text = "This email already exist";
            this.exist_email_label.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Change Email";
            // 
            // change_button
            // 
            this.change_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_button.ForeColor = System.Drawing.Color.Black;
            this.change_button.Location = new System.Drawing.Point(128, 198);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(75, 23);
            this.change_button.TabIndex = 11;
            this.change_button.Text = "Change";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // New_email_textBox
            // 
            this.New_email_textBox.Location = new System.Drawing.Point(155, 111);
            this.New_email_textBox.Name = "New_email_textBox";
            this.New_email_textBox.Size = new System.Drawing.Size(100, 20);
            this.New_email_textBox.TabIndex = 10;
            // 
            // old_email_textBox
            // 
            this.old_email_textBox.Location = new System.Drawing.Point(155, 62);
            this.old_email_textBox.Name = "old_email_textBox";
            this.old_email_textBox.Size = new System.Drawing.Size(100, 20);
            this.old_email_textBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Old email";
            // 
            // Change_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(324, 248);
            this.Controls.Add(this.exist_email_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.New_email_textBox);
            this.Controls.Add(this.old_email_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Change_email";
            this.Text = "Change_email";
            this.Load += new System.EventHandler(this.Change_email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label exist_email_label;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button change_button;
        public System.Windows.Forms.TextBox New_email_textBox;
        public System.Windows.Forms.TextBox old_email_textBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}