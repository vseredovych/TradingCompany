﻿namespace TradingCompany.FormsUI.Menu
{
    partial class OrderAddForm
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
            this.combobox_user = new System.Windows.Forms.ComboBox();
            this.textbox_destination = new System.Windows.Forms.TextBox();
            this.label_datetime = new System.Windows.Forms.Label();
            this.label_yser = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.datetime_picker_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // combobox_user
            // 
            this.combobox_user.FormattingEnabled = true;
            this.combobox_user.Location = new System.Drawing.Point(233, 137);
            this.combobox_user.Name = "combobox_user";
            this.combobox_user.Size = new System.Drawing.Size(100, 21);
            this.combobox_user.TabIndex = 49;
            this.combobox_user.SelectedIndexChanged += new System.EventHandler(this.Combobox_user_SelectedIndexChanged);
            // 
            // textbox_destination
            // 
            this.textbox_destination.Location = new System.Drawing.Point(233, 104);
            this.textbox_destination.Name = "textbox_destination";
            this.textbox_destination.Size = new System.Drawing.Size(100, 20);
            this.textbox_destination.TabIndex = 42;
            this.textbox_destination.TextChanged += new System.EventHandler(this.Textbox_destination_TextChanged);
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Location = new System.Drawing.Point(97, 170);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(30, 13);
            this.label_datetime.TabIndex = 47;
            this.label_datetime.Text = "Date";
            this.label_datetime.Click += new System.EventHandler(this.Label_datetime_Click);
            // 
            // label_yser
            // 
            this.label_yser.AutoSize = true;
            this.label_yser.Location = new System.Drawing.Point(97, 137);
            this.label_yser.Name = "label_yser";
            this.label_yser.Size = new System.Drawing.Size(29, 13);
            this.label_yser.TabIndex = 45;
            this.label_yser.Text = "User";
            this.label_yser.Click += new System.EventHandler(this.Label_yser_Click);
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Location = new System.Drawing.Point(97, 107);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(60, 13);
            this.label_destination.TabIndex = 43;
            this.label_destination.Text = "Destination";
            this.label_destination.Click += new System.EventHandler(this.Label_destination_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(258, 225);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 46;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(100, 225);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 48;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // datetime_picker_date
            // 
            this.datetime_picker_date.Location = new System.Drawing.Point(233, 170);
            this.datetime_picker_date.Name = "datetime_picker_date";
            this.datetime_picker_date.Size = new System.Drawing.Size(200, 20);
            this.datetime_picker_date.TabIndex = 50;
            this.datetime_picker_date.ValueChanged += new System.EventHandler(this.Datetime_picker_date_ValueChanged);
            // 
            // OrderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 363);
            this.Controls.Add(this.datetime_picker_date);
            this.Controls.Add(this.combobox_user);
            this.Controls.Add(this.textbox_destination);
            this.Controls.Add(this.label_datetime);
            this.Controls.Add(this.label_yser);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Name = "OrderAddForm";
            this.Text = "OrderAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox combobox_user;
        private System.Windows.Forms.TextBox textbox_destination;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label_yser;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DateTimePicker datetime_picker_date;
    }
}