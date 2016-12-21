namespace Sd.UI.Selling
{
    partial class SellingInfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingInfoFrm));
            this.dgvXsdInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXsdInfo
            // 
            this.dgvXsdInfo.AllowUserToAddRows = false;
            this.dgvXsdInfo.AllowUserToDeleteRows = false;
            this.dgvXsdInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXsdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXsdInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvXsdInfo.Name = "dgvXsdInfo";
            this.dgvXsdInfo.ReadOnly = true;
            this.dgvXsdInfo.RowTemplate.Height = 23;
            this.dgvXsdInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsdInfo.Size = new System.Drawing.Size(1002, 580);
            this.dgvXsdInfo.TabIndex = 0;
            this.dgvXsdInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvXsdInfo_CellMouseDoubleClick);
            this.dgvXsdInfo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvXsdInfo_PreviewKeyDown);
            // 
            // SellingInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 580);
            this.Controls.Add(this.dgvXsdInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellingInfoFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "销售单信息";
            this.Load += new System.EventHandler(this.SellingInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXsdInfo;
    }
}