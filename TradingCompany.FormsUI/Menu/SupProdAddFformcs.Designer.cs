namespace TradingCompany.FormsUI.Menu
{
    partial class SupProdAddFformcs
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
            this.label_supplier = new System.Windows.Forms.Label();
            this.label_product = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.combobox_product = new System.Windows.Forms.ComboBox();
            this.combobox_supplier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_supplier
            // 
            this.label_supplier.AutoSize = true;
            this.label_supplier.Location = new System.Drawing.Point(81, 114);
            this.label_supplier.Name = "label_supplier";
            this.label_supplier.Size = new System.Drawing.Size(45, 13);
            this.label_supplier.TabIndex = 43;
            this.label_supplier.Text = "Supplier";
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(81, 79);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(44, 13);
            this.label_product.TabIndex = 41;
            this.label_product.Text = "Product";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(242, 210);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 46;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(84, 210);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 48;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // combobox_product
            // 
            this.combobox_product.FormattingEnabled = true;
            this.combobox_product.Location = new System.Drawing.Point(209, 74);
            this.combobox_product.Name = "combobox_product";
            this.combobox_product.Size = new System.Drawing.Size(121, 21);
            this.combobox_product.TabIndex = 49;
            this.combobox_product.SelectedIndexChanged += new System.EventHandler(this.Combobox_product_SelectedIndexChanged);
            // 
            // combobox_supplier
            // 
            this.combobox_supplier.FormattingEnabled = true;
            this.combobox_supplier.Location = new System.Drawing.Point(209, 111);
            this.combobox_supplier.Name = "combobox_supplier";
            this.combobox_supplier.Size = new System.Drawing.Size(121, 21);
            this.combobox_supplier.TabIndex = 50;
            this.combobox_supplier.SelectedIndexChanged += new System.EventHandler(this.Combobox_supplier_SelectedIndexChanged);
            // 
            // SupProdAddFformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 308);
            this.Controls.Add(this.combobox_supplier);
            this.Controls.Add(this.combobox_product);
            this.Controls.Add(this.label_supplier);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Name = "SupProdAddFformcs";
            this.Text = "SupProdAddFformcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_supplier;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ComboBox combobox_product;
        private System.Windows.Forms.ComboBox combobox_supplier;
    }
}