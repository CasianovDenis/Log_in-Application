
namespace Log_in_Sign_up_app
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label2;
            this.create_acc_button = new System.Windows.Forms.Button();
            this.signUp_LogInDataSet = new Log_in_Sign_up_app.SignUp_LogInDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Log_in_Sign_up_app.SignUp_LogInDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Log_in_Sign_up_app.SignUp_LogInDataSetTableAdapters.TableAdapterManager();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.incorect_format_label = new System.Windows.Forms.Label();
            this.username_eror_label = new System.Windows.Forms.Label();
            this.password_eror_label = new System.Windows.Forms.Label();
            this.exist_email_label = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.signUp_LogInDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = System.Drawing.Color.White;
            usernameLabel.Location = new System.Drawing.Point(116, 189);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 12;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(118, 272);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(116, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 18;
            label2.Text = "Email:";
            // 
            // create_acc_button
            // 
            this.create_acc_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_acc_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_acc_button.Location = new System.Drawing.Point(116, 356);
            this.create_acc_button.Name = "create_acc_button";
            this.create_acc_button.Size = new System.Drawing.Size(78, 36);
            this.create_acc_button.TabIndex = 11;
            this.create_acc_button.Text = "Create Account";
            this.create_acc_button.UseVisualStyleBackColor = true;
            this.create_acc_button.Click += new System.EventHandler(this.create_acc_button_Click);
            // 
            // signUp_LogInDataSet
            // 
            this.signUp_LogInDataSet.DataSetName = "SignUp_LogInDataSet";
            this.signUp_LogInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.signUp_LogInDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Log_in_Sign_up_app.SignUp_LogInDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(180, 186);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(141, 20);
            this.usernameTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(180, 269);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(141, 20);
            this.passwordTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create Account";
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(246, 356);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 16;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(180, 80);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(141, 20);
            this.emailtextBox.TabIndex = 17;
            // 
            // incorect_format_label
            // 
            this.incorect_format_label.AutoSize = true;
            this.incorect_format_label.ForeColor = System.Drawing.Color.Red;
            this.incorect_format_label.Location = new System.Drawing.Point(177, 116);
            this.incorect_format_label.Name = "incorect_format_label";
            this.incorect_format_label.Size = new System.Drawing.Size(117, 13);
            this.incorect_format_label.TabIndex = 19;
            this.incorect_format_label.Text = "Format email is incorect";
            this.incorect_format_label.Visible = false;
            // 
            // username_eror_label
            // 
            this.username_eror_label.AutoSize = true;
            this.username_eror_label.ForeColor = System.Drawing.Color.Red;
            this.username_eror_label.Location = new System.Drawing.Point(177, 225);
            this.username_eror_label.Name = "username_eror_label";
            this.username_eror_label.Size = new System.Drawing.Size(137, 13);
            this.username_eror_label.TabIndex = 20;
            this.username_eror_label.Text = "This username already exist";
            this.username_eror_label.Visible = false;
            // 
            // password_eror_label
            // 
            this.password_eror_label.AutoSize = true;
            this.password_eror_label.ForeColor = System.Drawing.Color.Red;
            this.password_eror_label.Location = new System.Drawing.Point(82, 311);
            this.password_eror_label.Name = "password_eror_label";
            this.password_eror_label.Size = new System.Drawing.Size(334, 13);
            this.password_eror_label.TabIndex = 21;
            this.password_eror_label.Text = "Password is not secure,needed 6+ word,uppercase word and number";
            this.password_eror_label.Visible = false;
            // 
            // exist_email_label
            // 
            this.exist_email_label.AutoSize = true;
            this.exist_email_label.ForeColor = System.Drawing.Color.Red;
            this.exist_email_label.Location = new System.Drawing.Point(177, 154);
            this.exist_email_label.Name = "exist_email_label";
            this.exist_email_label.Size = new System.Drawing.Size(115, 13);
            this.exist_email_label.TabIndex = 22;
            this.exist_email_label.Text = "This email already exist";
            this.exist_email_label.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.exist_email_label);
            this.Controls.Add(this.password_eror_label);
            this.Controls.Add(this.username_eror_label);
            this.Controls.Add(this.incorect_format_label);
            this.Controls.Add(label2);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.create_acc_button);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signUp_LogInDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button create_acc_button;
        private SignUp_LogInDataSet signUp_LogInDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private SignUp_LogInDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private SignUp_LogInDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label incorect_format_label;
        private System.Windows.Forms.Label username_eror_label;
        private System.Windows.Forms.Label password_eror_label;
        private System.Windows.Forms.Label exist_email_label;
    }
}