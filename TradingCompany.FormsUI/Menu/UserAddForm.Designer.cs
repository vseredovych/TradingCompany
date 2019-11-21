﻿namespace TradingCompany.FormsUI.Menu
{
    partial class UserAddForm
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
            this.combobox_role = new System.Windows.Forms.ComboBox();
            this.textbox_surname = new System.Windows.Forms.TextBox();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_role = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_verify_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_verify_password = new System.Windows.Forms.Label();
            this.checkbox_pwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // combobox_role
            // 
            this.combobox_role.FormattingEnabled = true;
            this.combobox_role.Location = new System.Drawing.Point(247, 190);
            this.combobox_role.Name = "combobox_role";
            this.combobox_role.Size = new System.Drawing.Size(100, 21);
            this.combobox_role.TabIndex = 34;
            // 
            // textbox_surname
            // 
            this.textbox_surname.Location = new System.Drawing.Point(247, 128);
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(100, 20);
            this.textbox_surname.TabIndex = 27;
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(247, 158);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(100, 20);
            this.textbox_email.TabIndex = 29;
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(247, 93);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(100, 20);
            this.textbox_name.TabIndex = 25;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Location = new System.Drawing.Point(111, 194);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(29, 13);
            this.label_role.TabIndex = 32;
            this.label_role.Text = "Role";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(111, 161);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 30;
            this.label_email.Text = "Email";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(111, 131);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(49, 13);
            this.label_surname.TabIndex = 28;
            this.label_surname.Text = "Surname";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(111, 96);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 26;
            this.label_name.Text = "Name";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(272, 303);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 31;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(114, 303);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 33;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(247, 228);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(100, 20);
            this.textbox_password.TabIndex = 35;
            this.textbox_password.UseSystemPasswordChar = true;
            // 
            // textbox_verify_password
            // 
            this.textbox_verify_password.Location = new System.Drawing.Point(247, 260);
            this.textbox_verify_password.Name = "textbox_verify_password";
            this.textbox_verify_password.Size = new System.Drawing.Size(100, 20);
            this.textbox_verify_password.TabIndex = 36;
            this.textbox_verify_password.UseSystemPasswordChar = true;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(111, 231);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 37;
            this.label_password.Text = "Password";
            // 
            // label_verify_password
            // 
            this.label_verify_password.AutoSize = true;
            this.label_verify_password.Location = new System.Drawing.Point(111, 265);
            this.label_verify_password.Name = "label_verify_password";
            this.label_verify_password.Size = new System.Drawing.Size(82, 13);
            this.label_verify_password.TabIndex = 38;
            this.label_verify_password.Text = "Verify Password";
            // 
            // checkbox_pwd
            // 
            this.checkbox_pwd.AutoSize = true;
            this.checkbox_pwd.Location = new System.Drawing.Point(377, 230);
            this.checkbox_pwd.Name = "checkbox_pwd";
            this.checkbox_pwd.Size = new System.Drawing.Size(15, 14);
            this.checkbox_pwd.TabIndex = 39;
            this.checkbox_pwd.UseVisualStyleBackColor = true;
            this.checkbox_pwd.CheckedChanged += new System.EventHandler(this.Checkbox_pwd_CheckedChanged);
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 402);
            this.Controls.Add(this.checkbox_pwd);
            this.Controls.Add(this.label_verify_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textbox_verify_password);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.combobox_role);
            this.Controls.Add(this.textbox_surname);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Name = "UserAddForm";
            this.Text = "UserAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_role;
        private System.Windows.Forms.TextBox textbox_surname;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_verify_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_verify_password;
        private System.Windows.Forms.CheckBox checkbox_pwd;
    }
}