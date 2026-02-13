namespace ManagmentApplication.Forms.AdminSite
{
    partial class LogPanel
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
            this.allLogsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allLogsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // allLogsDGV
            // 
            this.allLogsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allLogsDGV.Location = new System.Drawing.Point(56, 41);
            this.allLogsDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allLogsDGV.Name = "allLogsDGV";
            this.allLogsDGV.RowHeadersWidth = 51;
            this.allLogsDGV.Size = new System.Drawing.Size(1145, 297);
            this.allLogsDGV.TabIndex = 0;
            // 
            // LogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1236, 576);
            this.Controls.Add(this.allLogsDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogPanel";
            this.Text = "LogPanel";
            ((System.ComponentModel.ISupportInitialize)(this.allLogsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allLogsDGV;
    }
}