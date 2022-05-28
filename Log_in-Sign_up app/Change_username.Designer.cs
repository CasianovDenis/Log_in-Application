
namespace Log_in_Sign_up_app
{
    partial class Change_username
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
            this.old_username_textBox = new System.Windows.Forms.TextBox();
            this.New_username_textBox = new System.Windows.Forms.TextBox();
            this.change_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exist_username_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New username";
            // 
            // old_username_textBox
            // 
            this.old_username_textBox.Location = new System.Drawing.Point(141, 44);
            this.old_username_textBox.Name = "old_username_textBox";
            this.old_username_textBox.Size = new System.Drawing.Size(100, 20);
            this.old_username_textBox.TabIndex = 2;
            // 
            // New_username_textBox
            // 
            this.New_username_textBox.Location = new System.Drawing.Point(141, 93);
            this.New_username_textBox.Name = "New_username_textBox";
            this.New_username_textBox.Size = new System.Drawing.Size(100, 20);
            this.New_username_textBox.TabIndex = 3;
            // 
            // change_button
            // 
            this.change_button.ForeColor = System.Drawing.Color.Black;
            this.change_button.Location = new System.Drawing.Point(114, 180);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(75, 23);
            this.change_button.TabIndex = 4;
            this.change_button.Text = "Change";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change Username";
            // 
            // exist_username_label
            // 
            this.exist_username_label.AutoSize = true;
            this.exist_username_label.Location = new System.Drawing.Point(94, 137);
            this.exist_username_label.Name = "exist_username_label";
            this.exist_username_label.Size = new System.Drawing.Size(137, 13);
            this.exist_username_label.TabIndex = 6;
            this.exist_username_label.Text = "This username already exist";
            this.exist_username_label.Visible = false;
            // 
            // Change_username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(325, 215);
            this.Controls.Add(this.exist_username_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.New_username_textBox);
            this.Controls.Add(this.old_username_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Change_username";
            this.Text = "Change_username";
            this.Load += new System.EventHandler(this.Change_username_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox old_username_textBox;
        private System.Windows.Forms.TextBox New_username_textBox;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exist_username_label;
    }
}