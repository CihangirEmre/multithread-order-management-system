namespace ManagmentApplication.Forms
{
    partial class UserForm
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
            this.userDgw = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSpentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.esZamanliSiparisYonetimiDataSet = new ManagmentApplication.EsZamanliSiparisYonetimiDataSet();
            this.customersTableAdapter = new ManagmentApplication.EsZamanliSiparisYonetimiDataSetTableAdapters.CustomersTableAdapter();
            this.orderStatusDgv = new System.Windows.Forms.DataGridView();
            this.productDgv = new System.Windows.Forms.DataGridView();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addCartButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CartL = new MaterialSkin.Controls.MaterialLabel();
            this.ProductStockLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esZamanliSiparisYonetimiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // userDgw
            // 
            this.userDgw.AllowUserToOrderColumns = true;
            this.userDgw.AutoGenerateColumns = false;
            this.userDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn,
            this.customerTypeDataGridViewTextBoxColumn,
            this.totalSpentDataGridViewTextBoxColumn});
            this.userDgw.DataSource = this.customersBindingSource;
            this.userDgw.Location = new System.Drawing.Point(17, 14);
            this.userDgw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userDgw.Name = "userDgw";
            this.userDgw.RowHeadersWidth = 51;
            this.userDgw.RowTemplate.Height = 24;
            this.userDgw.Size = new System.Drawing.Size(678, 82);
            this.userDgw.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Müşteri ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Müşteri İsmi";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "Budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Toplam Bütçe";
            this.budgetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerTypeDataGridViewTextBoxColumn
            // 
            this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "CustomerType";
            this.customerTypeDataGridViewTextBoxColumn.HeaderText = "Müşteri Tipi";
            this.customerTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
            this.customerTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalSpentDataGridViewTextBoxColumn
            // 
            this.totalSpentDataGridViewTextBoxColumn.DataPropertyName = "TotalSpent";
            this.totalSpentDataGridViewTextBoxColumn.HeaderText = "Toplam Harcama";
            this.totalSpentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalSpentDataGridViewTextBoxColumn.Name = "totalSpentDataGridViewTextBoxColumn";
            this.totalSpentDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSpentDataGridViewTextBoxColumn.Width = 125;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.esZamanliSiparisYonetimiDataSet;
            // 
            // esZamanliSiparisYonetimiDataSet
            // 
            this.esZamanliSiparisYonetimiDataSet.DataSetName = "EsZamanliSiparisYonetimiDataSet";
            this.esZamanliSiparisYonetimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // orderStatusDgv
            // 
            this.orderStatusDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderStatusDgv.Location = new System.Drawing.Point(688, 194);
            this.orderStatusDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderStatusDgv.Name = "orderStatusDgv";
            this.orderStatusDgv.RowHeadersWidth = 51;
            this.orderStatusDgv.RowTemplate.Height = 24;
            this.orderStatusDgv.Size = new System.Drawing.Size(1128, 339);
            this.orderStatusDgv.TabIndex = 1;
            // 
            // productDgv
            // 
            this.productDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDgv.Location = new System.Drawing.Point(12, 194);
            this.productDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDgv.Name = "productDgv";
            this.productDgv.RowHeadersWidth = 51;
            this.productDgv.RowTemplate.Height = 24;
            this.productDgv.Size = new System.Drawing.Size(562, 339);
            this.productDgv.TabIndex = 2;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(12, 551);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.quantityNumericUpDown.TabIndex = 3;
            // 
            // addCartButton
            // 
            this.addCartButton.AutoSize = true;
            this.addCartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCartButton.Depth = 0;
            this.addCartButton.Location = new System.Drawing.Point(320, 546);
            this.addCartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCartButton.Name = "addCartButton";
            this.addCartButton.Primary = false;
            this.addCartButton.Size = new System.Drawing.Size(118, 36);
            this.addCartButton.TabIndex = 4;
            this.addCartButton.Text = "Sepete Ekle";
            this.addCartButton.UseVisualStyleBackColor = true;
            this.addCartButton.Click += new System.EventHandler(this.addCartButton_Click);
            // 
            // CartL
            // 
            this.CartL.AutoSize = true;
            this.CartL.Depth = 0;
            this.CartL.Font = new System.Drawing.Font("Roboto", 11F);
            this.CartL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CartL.Location = new System.Drawing.Point(667, 551);
            this.CartL.MouseState = MaterialSkin.MouseState.HOVER;
            this.CartL.Name = "CartL";
            this.CartL.Size = new System.Drawing.Size(58, 24);
            this.CartL.TabIndex = 6;
            this.CartL.Text = "Sepet";
            this.CartL.Click += new System.EventHandler(this.CartL_Click);
            // 
            // ProductStockLabel
            // 
            this.ProductStockLabel.AutoSize = true;
            this.ProductStockLabel.Depth = 0;
            this.ProductStockLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ProductStockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductStockLabel.Location = new System.Drawing.Point(12, 167);
            this.ProductStockLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductStockLabel.Name = "ProductStockLabel";
            this.ProductStockLabel.Size = new System.Drawing.Size(159, 24);
            this.ProductStockLabel.TabIndex = 7;
            this.ProductStockLabel.Text = "Ürün stok durumu";
            this.ProductStockLabel.Click += new System.EventHandler(this.ProductStockLabel_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1828, 593);
            this.Controls.Add(this.ProductStockLabel);
            this.Controls.Add(this.CartL);
            this.Controls.Add(this.addCartButton);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.productDgv);
            this.Controls.Add(this.orderStatusDgv);
            this.Controls.Add(this.userDgw);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.Text = "Sipariş Yönetimi";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esZamanliSiparisYonetimiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDgw;
        private EsZamanliSiparisYonetimiDataSet esZamanliSiparisYonetimiDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private EsZamanliSiparisYonetimiDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSpentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView orderStatusDgv;
        private System.Windows.Forms.DataGridView productDgv;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private MaterialSkin.Controls.MaterialFlatButton addCartButton;
        private MaterialSkin.Controls.MaterialLabel CartL;
        private MaterialSkin.Controls.MaterialLabel ProductStockLabel;
    }
}