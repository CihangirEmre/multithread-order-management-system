namespace ManagmentApplication.Forms.UserSite
{
    partial class CartForm
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
            this.cartDgv = new System.Windows.Forms.DataGridView();
            this.ConfirmCartButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RemoveOrderButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.conditionalID = new System.Windows.Forms.TextBox();
            this.staticLabelID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cartDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cartDgv
            // 
            this.cartDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDgv.Location = new System.Drawing.Point(12, 12);
            this.cartDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartDgv.Name = "cartDgv";
            this.cartDgv.RowHeadersWidth = 51;
            this.cartDgv.RowTemplate.Height = 24;
            this.cartDgv.Size = new System.Drawing.Size(432, 194);
            this.cartDgv.TabIndex = 0;
            // 
            // ConfirmCartButton
            // 
            this.ConfirmCartButton.AutoSize = true;
            this.ConfirmCartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmCartButton.Depth = 0;
            this.ConfirmCartButton.Location = new System.Drawing.Point(159, 217);
            this.ConfirmCartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmCartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmCartButton.Name = "ConfirmCartButton";
            this.ConfirmCartButton.Primary = false;
            this.ConfirmCartButton.Size = new System.Drawing.Size(140, 36);
            this.ConfirmCartButton.TabIndex = 1;
            this.ConfirmCartButton.Text = "Sepeti Onayla";
            this.ConfirmCartButton.UseVisualStyleBackColor = true;
            this.ConfirmCartButton.Click += new System.EventHandler(this.ConfirmCartButton_Click);
            // 
            // RemoveOrderButton
            // 
            this.RemoveOrderButton.AutoSize = true;
            this.RemoveOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveOrderButton.Depth = 0;
            this.RemoveOrderButton.Location = new System.Drawing.Point(137, 263);
            this.RemoveOrderButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveOrderButton.Name = "RemoveOrderButton";
            this.RemoveOrderButton.Primary = false;
            this.RemoveOrderButton.Size = new System.Drawing.Size(187, 36);
            this.RemoveOrderButton.TabIndex = 2;
            this.RemoveOrderButton.Text = "Seçili Ürünü Kaldır";
            this.RemoveOrderButton.UseVisualStyleBackColor = true;
            this.RemoveOrderButton.Click += new System.EventHandler(this.RemoveOrderButton_Click);
            // 
            // conditionalID
            // 
            this.conditionalID.Location = new System.Drawing.Point(255, 318);
            this.conditionalID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conditionalID.Name = "conditionalID";
            this.conditionalID.Size = new System.Drawing.Size(132, 22);
            this.conditionalID.TabIndex = 3;
            // 
            // staticLabelID
            // 
            this.staticLabelID.Location = new System.Drawing.Point(92, 318);
            this.staticLabelID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staticLabelID.Name = "staticLabelID";
            this.staticLabelID.Size = new System.Drawing.Size(132, 22);
            this.staticLabelID.TabIndex = 4;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 366);
            this.Controls.Add(this.staticLabelID);
            this.Controls.Add(this.conditionalID);
            this.Controls.Add(this.RemoveOrderButton);
            this.Controls.Add(this.ConfirmCartButton);
            this.Controls.Add(this.cartDgv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartForm";
            this.Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)(this.cartDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartDgv;
        private MaterialSkin.Controls.MaterialFlatButton ConfirmCartButton;
        private MaterialSkin.Controls.MaterialFlatButton RemoveOrderButton;
        private System.Windows.Forms.TextBox conditionalID;
        private System.Windows.Forms.TextBox staticLabelID;
    }
}