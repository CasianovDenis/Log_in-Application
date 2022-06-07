
namespace Log_in_Sign_up_app
{
    partial class Authorisation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Log_In_button = new System.Windows.Forms.Button();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sign_up_link = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Restore_pass_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Log_In_button
            // 
            this.Log_In_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_In_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_In_button.Location = new System.Drawing.Point(138, 260);
            this.Log_In_button.Name = "Log_In_button";
            this.Log_In_button.Size = new System.Drawing.Size(75, 23);
            this.Log_In_button.TabIndex = 0;
            this.Log_In_button.Text = "Log In";
            this.Log_In_button.UseVisualStyleBackColor = true;
            this.Log_In_button.Click += new System.EventHandler(this.Logn_In_button_Click);
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(136, 81);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(100, 20);
            this.usernametextBox.TabIndex = 2;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(136, 154);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordtextBox.TabIndex = 3;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Authorisation";
            // 
            // Sign_up_link
            // 
            this.Sign_up_link.AutoSize = true;
            this.Sign_up_link.BackColor = System.Drawing.Color.Transparent;
            this.Sign_up_link.LinkColor = System.Drawing.Color.White;
            this.Sign_up_link.Location = new System.Drawing.Point(237, 270);
            this.Sign_up_link.Name = "Sign_up_link";
            this.Sign_up_link.Size = new System.Drawing.Size(45, 13);
            this.Sign_up_link.TabIndex = 7;
            this.Sign_up_link.TabStop = true;
            this.Sign_up_link.Text = "Sign Up";
            this.Sign_up_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sign_up_link_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(136, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Remember";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Restore_pass_link
            // 
            this.Restore_pass_link.AutoSize = true;
            this.Restore_pass_link.LinkColor = System.Drawing.Color.White;
            this.Restore_pass_link.Location = new System.Drawing.Point(237, 305);
            this.Restore_pass_link.Name = "Restore_pass_link";
            this.Restore_pass_link.Size = new System.Drawing.Size(92, 13);
            this.Restore_pass_link.TabIndex = 9;
            this.Restore_pass_link.TabStop = true;
            this.Restore_pass_link.Text = "Forgot Password?";
            this.Restore_pass_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Restore_pass_link_LinkClicked);
            // 
            // Authorisation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(357, 355);
            this.Controls.Add(this.Restore_pass_link);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Sign_up_link);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.Log_In_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorisation";
            this.Text = "Authorisation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorisation_FormClosing);
            this.Load += new System.EventHandler(this.Authorisation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Log_In_button;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Sign_up_link;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel Restore_pass_link;
    }
}

