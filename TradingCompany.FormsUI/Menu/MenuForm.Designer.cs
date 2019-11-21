namespace TradingCompany.FormsUI.Menu
{
    partial class MenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_profile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_clock = new System.Windows.Forms.Label();
            this.button_sign_out = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.datagrid_recent_orders = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_recent_orders = new System.Windows.Forms.Label();
            this.button_view_all = new System.Windows.Forms.Button();
            this.Label_menu = new System.Windows.Forms.Label();
            this.buttutton_orders = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.button_suppliers = new System.Windows.Forms.Button();
            this.button_customers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_profile
            // 
            this.button_profile.FlatAppearance.BorderSize = 0;
            this.button_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.ForeColor = System.Drawing.Color.MediumBlue;
            this.button_profile.Location = new System.Drawing.Point(829, 15);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(75, 23);
            this.button_profile.TabIndex = 8;
            this.button_profile.Text = "Profile";
            this.button_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_profile.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clock.ForeColor = System.Drawing.Color.Black;
            this.label_clock.Location = new System.Drawing.Point(11, 13);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(58, 26);
            this.label_clock.TabIndex = 10;
            this.label_clock.Text = "Clock";
            // 
            // button_sign_out
            // 
            this.button_sign_out.FlatAppearance.BorderSize = 0;
            this.button_sign_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sign_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sign_out.ForeColor = System.Drawing.Color.MediumBlue;
            this.button_sign_out.Location = new System.Drawing.Point(920, 13);
            this.button_sign_out.Name = "button_sign_out";
            this.button_sign_out.Size = new System.Drawing.Size(58, 25);
            this.button_sign_out.TabIndex = 11;
            this.button_sign_out.Text = "Sign Out";
            this.button_sign_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sign_out.UseVisualStyleBackColor = false;
            this.button_sign_out.Click += new System.EventHandler(this.Button_sign_out_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Black;
            this.label_date.Location = new System.Drawing.Point(13, 41);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(41, 19);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "Date";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Black;
            this.label_name.Location = new System.Drawing.Point(834, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(131, 23);
            this.label_name.TabIndex = 13;
            this.label_name.Text = "Name Surname";
            // 
            // datagrid_recent_orders
            // 
            this.datagrid_recent_orders.AutoGenerateColumns = false;
            this.datagrid_recent_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid_recent_orders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_recent_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_recent_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.datagrid_recent_orders.DataSource = this.ordersDTOBindingSource;
            this.datagrid_recent_orders.Location = new System.Drawing.Point(320, 169);
            this.datagrid_recent_orders.Name = "datagrid_recent_orders";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_recent_orders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_recent_orders.Size = new System.Drawing.Size(660, 381);
            this.datagrid_recent_orders.TabIndex = 14;
            this.datagrid_recent_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_recent_orders_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 54;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 85;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 81;
            // 
            // ordersDTOBindingSource
            // 
            this.ordersDTOBindingSource.DataSource = typeof(TradingCompany.BLL.DTO.OrderDTO);
            // 
            // label_recent_orders
            // 
            this.label_recent_orders.AutoSize = true;
            this.label_recent_orders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recent_orders.ForeColor = System.Drawing.Color.Black;
            this.label_recent_orders.Location = new System.Drawing.Point(316, 147);
            this.label_recent_orders.Name = "label_recent_orders";
            this.label_recent_orders.Size = new System.Drawing.Size(102, 19);
            this.label_recent_orders.TabIndex = 15;
            this.label_recent_orders.Text = "Recent Orders";
            // 
            // button_view_all
            // 
            this.button_view_all.FlatAppearance.BorderSize = 0;
            this.button_view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_view_all.ForeColor = System.Drawing.Color.Black;
            this.button_view_all.Location = new System.Drawing.Point(423, 146);
            this.button_view_all.Name = "button_view_all";
            this.button_view_all.Size = new System.Drawing.Size(75, 23);
            this.button_view_all.TabIndex = 16;
            this.button_view_all.Text = "view all";
            this.button_view_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_view_all.UseVisualStyleBackColor = false;
            this.button_view_all.Click += new System.EventHandler(this.Button_view_all_Click);
            // 
            // Label_menu
            // 
            this.Label_menu.AutoSize = true;
            this.Label_menu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_menu.ForeColor = System.Drawing.Color.Black;
            this.Label_menu.Location = new System.Drawing.Point(12, 146);
            this.Label_menu.Name = "Label_menu";
            this.Label_menu.Size = new System.Drawing.Size(46, 19);
            this.Label_menu.TabIndex = 17;
            this.Label_menu.Text = "Menu";
            // 
            // buttutton_orders
            // 
            this.buttutton_orders.Location = new System.Drawing.Point(16, 169);
            this.buttutton_orders.Name = "buttutton_orders";
            this.buttutton_orders.Size = new System.Drawing.Size(135, 52);
            this.buttutton_orders.TabIndex = 18;
            this.buttutton_orders.Text = "Orders";
            this.buttutton_orders.UseVisualStyleBackColor = true;
            // 
            // button_products
            // 
            this.button_products.Location = new System.Drawing.Point(17, 242);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(134, 52);
            this.button_products.TabIndex = 19;
            this.button_products.Text = "Products";
            this.button_products.UseVisualStyleBackColor = true;
            // 
            // button_suppliers
            // 
            this.button_suppliers.Location = new System.Drawing.Point(16, 396);
            this.button_suppliers.Name = "button_suppliers";
            this.button_suppliers.Size = new System.Drawing.Size(131, 52);
            this.button_suppliers.TabIndex = 20;
            this.button_suppliers.Text = "Suppliers";
            this.button_suppliers.UseVisualStyleBackColor = true;
            // 
            // button_customers
            // 
            this.button_customers.Location = new System.Drawing.Point(17, 320);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(130, 52);
            this.button_customers.TabIndex = 21;
            this.button_customers.Text = "Customers";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.Button_customers_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 592);
            this.Controls.Add(this.button_customers);
            this.Controls.Add(this.button_suppliers);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.buttutton_orders);
            this.Controls.Add(this.Label_menu);
            this.Controls.Add(this.button_view_all);
            this.Controls.Add(this.label_recent_orders);
            this.Controls.Add(this.datagrid_recent_orders);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.button_sign_out);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.button_profile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_recent_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Button button_sign_out;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.DataGridView datagrid_recent_orders;
        private System.Windows.Forms.Label label_recent_orders;
        private System.Windows.Forms.Button button_view_all;
        private System.Windows.Forms.Label Label_menu;
        private System.Windows.Forms.Button buttutton_orders;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Button button_suppliers;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.BindingSource ordersDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
    }
}