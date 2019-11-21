namespace TradingCompany.FormsUI.Login
{
    partial class LoginForm
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_sign_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_create_account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(254, 266);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_sing_up_Click);
            // 
            // button_sign_in
            // 
            this.button_sign_in.Location = new System.Drawing.Point(367, 266);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Size = new System.Drawing.Size(75, 23);
            this.button_sign_in.TabIndex = 1;
            this.button_sign_in.Text = "Sign In";
            this.button_sign_in.UseVisualStyleBackColor = true;
            this.button_sign_in.Click += new System.EventHandler(this.Button_sign_in_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(303, 131);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(127, 20);
            this.textbox_email.TabIndex = 4;
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(303, 190);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(127, 20);
            this.textbox_password.TabIndex = 5;
            // 
            // button_create_account
            // 
            this.button_create_account.FlatAppearance.BorderSize = 0;
            this.button_create_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_account.ForeColor = System.Drawing.Color.MediumBlue;
            this.button_create_account.Location = new System.Drawing.Point(303, 295);
            this.button_create_account.Name = "button_create_account";
            this.button_create_account.Size = new System.Drawing.Size(92, 25);
            this.button_create_account.TabIndex = 12;
            this.button_create_account.Text = "Create Account]";
            this.button_create_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_account.UseVisualStyleBackColor = false;
            this.button_create_account.Click += new System.EventHandler(this.Button_create_account_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 417);
            this.Controls.Add(this.button_create_account);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sign_in);
            this.Controls.Add(this.button_exit);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_sign_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Button button_create_account;
    }
}

