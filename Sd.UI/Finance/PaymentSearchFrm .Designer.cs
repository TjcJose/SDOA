namespace Sd.UI.Finance
{
    partial class PaymentSearchFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSearchFrm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRqTo = new System.Windows.Forms.DateTimePicker();
            this.dtpRqFrom = new System.Windows.Forms.DateTimePicker();
            this.btnHkjsd = new System.Windows.Forms.Button();
            this.btnFkjsd = new System.Windows.Forms.Button();
            this.chkWs = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRq = new System.Windows.Forms.CheckBox();
            this.dgvHkjsd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHkjsd)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 27);
            this.comboBox1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "供货商";
            // 
            // dtpRqTo
            // 
            this.dtpRqTo.CustomFormat = "yyyy-MM-dd";
            this.dtpRqTo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRqTo.Location = new System.Drawing.Point(689, 20);
            this.dtpRqTo.Name = "dtpRqTo";
            this.dtpRqTo.Size = new System.Drawing.Size(144, 30);
            this.dtpRqTo.TabIndex = 31;
            // 
            // dtpRqFrom
            // 
            this.dtpRqFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpRqFrom.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRqFrom.Location = new System.Drawing.Point(510, 20);
            this.dtpRqFrom.Name = "dtpRqFrom";
            this.dtpRqFrom.Size = new System.Drawing.Size(144, 30);
            this.dtpRqFrom.TabIndex = 32;
            // 
            // btnHkjsd
            // 
            this.btnHkjsd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHkjsd.Location = new System.Drawing.Point(938, 15);
            this.btnHkjsd.Name = "btnHkjsd";
            this.btnHkjsd.Size = new System.Drawing.Size(85, 39);
            this.btnHkjsd.TabIndex = 30;
            this.btnHkjsd.Text = "退出";
            this.btnHkjsd.UseVisualStyleBackColor = true;
            this.btnHkjsd.Click += new System.EventHandler(this.btnHkjsd_Click);
            // 
            // btnFkjsd
            // 
            this.btnFkjsd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFkjsd.Location = new System.Drawing.Point(839, 15);
            this.btnFkjsd.Name = "btnFkjsd";
            this.btnFkjsd.Size = new System.Drawing.Size(85, 39);
            this.btnFkjsd.TabIndex = 29;
            this.btnFkjsd.Text = "查询";
            this.btnFkjsd.UseVisualStyleBackColor = true;
            // 
            // chkWs
            // 
            this.chkWs.AutoSize = true;
            this.chkWs.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkWs.Location = new System.Drawing.Point(235, 26);
            this.chkWs.Name = "chkWs";
            this.chkWs.Size = new System.Drawing.Size(161, 23);
            this.chkWs.TabIndex = 28;
            this.chkWs.Text = "仅查询未审单据";
            this.chkWs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(659, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "至";
            // 
            // chkRq
            // 
            this.chkRq.AutoSize = true;
            this.chkRq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRq.Location = new System.Drawing.Point(403, 24);
            this.chkRq.Name = "chkRq";
            this.chkRq.Size = new System.Drawing.Size(104, 23);
            this.chkRq.TabIndex = 26;
            this.chkRq.Text = "付款日期";
            this.chkRq.UseVisualStyleBackColor = true;
            // 
            // dgvHkjsd
            // 
            this.dgvHkjsd.AllowUserToOrderColumns = true;
            this.dgvHkjsd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHkjsd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHkjsd.ColumnHeadersHeight = 28;
            this.dgvHkjsd.Location = new System.Drawing.Point(24, 80);
            this.dgvHkjsd.Name = "dgvHkjsd";
            this.dgvHkjsd.RowHeadersWidth = 20;
            this.dgvHkjsd.RowTemplate.Height = 23;
            this.dgvHkjsd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHkjsd.Size = new System.Drawing.Size(999, 571);
            this.dgvHkjsd.TabIndex = 37;
            // 
            // PaymentSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 675);
            this.Controls.Add(this.dgvHkjsd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpRqTo);
            this.Controls.Add(this.dtpRqFrom);
            this.Controls.Add(this.btnHkjsd);
            this.Controls.Add(this.btnFkjsd);
            this.Controls.Add(this.chkWs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkRq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentSearchFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "贷款结算单";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHkjsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRqTo;
        private System.Windows.Forms.DateTimePicker dtpRqFrom;
        private System.Windows.Forms.Button btnHkjsd;
        private System.Windows.Forms.Button btnFkjsd;
        private System.Windows.Forms.CheckBox chkWs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRq;
        private System.Windows.Forms.DataGridView dgvHkjsd;
    }
}