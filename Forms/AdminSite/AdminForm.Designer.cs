namespace ManagmentApplication.Forms
{
    partial class AdminForm
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
            this.productDgv = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EkleButonu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.SilButonu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdateProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.acceptedOrdersByUser = new System.Windows.Forms.DataGridView();
            this.onaylamaButonu = new System.Windows.Forms.Button();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedOrdersByUser)).BeginInit();
            this.SuspendLayout();
            // 
            // productDgv
            // 
            this.productDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDgv.Location = new System.Drawing.Point(12, 39);
            this.productDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDgv.Name = "productDgv";
            this.productDgv.ReadOnly = true;
            this.productDgv.RowHeadersWidth = 51;
            this.productDgv.RowTemplate.Height = 24;
            this.productDgv.Size = new System.Drawing.Size(606, 293);
            this.productDgv.TabIndex = 0;
            this.productDgv.SelectionChanged += new System.EventHandler(this.productDataGridView_SelectionChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(695, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Ürün Ekle";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(699, 90);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(699, 130);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok";
            // 
            // EkleButonu
            // 
            this.EkleButonu.Depth = 0;
            this.EkleButonu.Location = new System.Drawing.Point(830, 90);
            this.EkleButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EkleButonu.MouseState = MaterialSkin.MouseState.HOVER;
            this.EkleButonu.Name = "EkleButonu";
            this.EkleButonu.Primary = true;
            this.EkleButonu.Size = new System.Drawing.Size(116, 23);
            this.EkleButonu.TabIndex = 8;
            this.EkleButonu.Text = "Ekle";
            this.EkleButonu.UseVisualStyleBackColor = true;
            this.EkleButonu.Click += new System.EventHandler(this.EkleButonu_Click);
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(699, 168);
            this.nudStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(100, 22);
            this.nudStock.TabIndex = 9;
            // 
            // SilButonu
            // 
            this.SilButonu.Depth = 0;
            this.SilButonu.Location = new System.Drawing.Point(830, 168);
            this.SilButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SilButonu.MouseState = MaterialSkin.MouseState.HOVER;
            this.SilButonu.Name = "SilButonu";
            this.SilButonu.Primary = true;
            this.SilButonu.Size = new System.Drawing.Size(116, 23);
            this.SilButonu.TabIndex = 10;
            this.SilButonu.Text = "Sil";
            this.SilButonu.UseVisualStyleBackColor = true;
            this.SilButonu.Click += new System.EventHandler(this.SilButonu_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Depth = 0;
            this.btnUpdateProduct.Location = new System.Drawing.Point(830, 126);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Primary = true;
            this.btnUpdateProduct.Size = new System.Drawing.Size(116, 23);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Güncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // acceptedOrdersByUser
            // 
            this.acceptedOrdersByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acceptedOrdersByUser.Location = new System.Drawing.Point(12, 374);
            this.acceptedOrdersByUser.Margin = new System.Windows.Forms.Padding(4);
            this.acceptedOrdersByUser.Name = "acceptedOrdersByUser";
            this.acceptedOrdersByUser.RowHeadersWidth = 51;
            this.acceptedOrdersByUser.Size = new System.Drawing.Size(1056, 334);
            this.acceptedOrdersByUser.TabIndex = 12;
            // 
            // onaylamaButonu
            // 
            this.onaylamaButonu.Location = new System.Drawing.Point(1105, 374);
            this.onaylamaButonu.Margin = new System.Windows.Forms.Padding(4);
            this.onaylamaButonu.Name = "onaylamaButonu";
            this.onaylamaButonu.Size = new System.Drawing.Size(177, 44);
            this.onaylamaButonu.TabIndex = 13;
            this.onaylamaButonu.Text = "Onayla";
            this.onaylamaButonu.UseVisualStyleBackColor = true;
            this.onaylamaButonu.Click += new System.EventHandler(this.onaylamaButonu_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(1119, 439);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(163, 36);
            this.materialFlatButton1.TabIndex = 14;
            this.materialFlatButton1.Text = "İşlem Yapıyorum";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 343);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(197, 24);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Onay Bekleyen Ürünler";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 9);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(136, 24);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Mevcut Ürünler";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1348, 772);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.onaylamaButonu);
            this.Controls.Add(this.acceptedOrdersByUser);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.SilButonu);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.EkleButonu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.productDgv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedOrdersByUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDgv;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRaisedButton EkleButonu;
        private System.Windows.Forms.NumericUpDown nudStock;
        private MaterialSkin.Controls.MaterialRaisedButton SilButonu;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdateProduct;
        private System.Windows.Forms.DataGridView acceptedOrdersByUser;
        private System.Windows.Forms.Button onaylamaButonu;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}