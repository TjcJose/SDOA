namespace Sd.UI.Onroad
{
    partial class FreightSearchFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreightSearchFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpXsrqTo = new System.Windows.Forms.DateTimePicker();
            this.chkXsrq = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSjsid = new System.Windows.Forms.Label();
            this.lblEjkh = new System.Windows.Forms.Label();
            this.dtpXsrqFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.combKhid = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXsdmx = new System.Windows.Forms.DataGridView();
            this.dgvXsd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdmx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(360, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 86;
            this.label1.Text = "至";
            // 
            // dtpXsrqTo
            // 
            this.dtpXsrqTo.CustomFormat = "yyyy-MM-dd";
            this.dtpXsrqTo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpXsrqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXsrqTo.Location = new System.Drawing.Point(417, 67);
            this.dtpXsrqTo.Name = "dtpXsrqTo";
            this.dtpXsrqTo.Size = new System.Drawing.Size(196, 29);
            this.dtpXsrqTo.TabIndex = 85;
            // 
            // chkXsrq
            // 
            this.chkXsrq.AutoSize = true;
            this.chkXsrq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkXsrq.Location = new System.Drawing.Point(39, 70);
            this.chkXsrq.Name = "chkXsrq";
            this.chkXsrq.Size = new System.Drawing.Size(104, 23);
            this.chkXsrq.TabIndex = 84;
            this.chkXsrq.Text = "结算日期";
            this.chkXsrq.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(954, 33);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(99, 47);
            this.btnQuit.TabIndex = 83;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(824, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 47);
            this.btnSearch.TabIndex = 82;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSjsid
            // 
            this.lblSjsid.AutoSize = true;
            this.lblSjsid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSjsid.Location = new System.Drawing.Point(39, 24);
            this.lblSjsid.Name = "lblSjsid";
            this.lblSjsid.Size = new System.Drawing.Size(66, 19);
            this.lblSjsid.TabIndex = 81;
            this.lblSjsid.Text = "运输商";
            // 
            // lblEjkh
            // 
            this.lblEjkh.AutoSize = true;
            this.lblEjkh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEjkh.Location = new System.Drawing.Point(344, 24);
            this.lblEjkh.Name = "lblEjkh";
            this.lblEjkh.Size = new System.Drawing.Size(85, 19);
            this.lblEjkh.TabIndex = 80;
            this.lblEjkh.Text = "考核部门";
            // 
            // dtpXsrqFrom
            // 
            this.dtpXsrqFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpXsrqFrom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpXsrqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXsrqFrom.Location = new System.Drawing.Point(143, 66);
            this.dtpXsrqFrom.Name = "dtpXsrqFrom";
            this.dtpXsrqFrom.Size = new System.Drawing.Size(187, 29);
            this.dtpXsrqFrom.TabIndex = 79;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Location = new System.Drawing.Point(429, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 27);
            this.comboBox1.TabIndex = 77;
            // 
            // combKhid
            // 
            this.combKhid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combKhid.FormattingEnabled = true;
            this.combKhid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.combKhid.Location = new System.Drawing.Point(111, 20);
            this.combKhid.Name = "combKhid";
            this.combKhid.Size = new System.Drawing.Size(219, 27);
            this.combKhid.TabIndex = 78;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(653, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 23);
            this.checkBox1.TabIndex = 87;
            this.checkBox1.Text = "仅查未审单据";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(466, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 90;
            this.label2.Text = " 明  细  内  容";
             // 
            // dgvXsdmx
            // 
            this.dgvXsdmx.AllowUserToAddRows = false;
            this.dgvXsdmx.AllowUserToDeleteRows = false;
            this.dgvXsdmx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXsdmx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXsdmx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXsdmx.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXsdmx.Location = new System.Drawing.Point(39, 478);
            this.dgvXsdmx.MultiSelect = false;
            this.dgvXsdmx.Name = "dgvXsdmx";
            this.dgvXsdmx.ReadOnly = true;
            this.dgvXsdmx.RowHeadersWidth = 20;
            this.dgvXsdmx.RowTemplate.Height = 23;
            this.dgvXsdmx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsdmx.Size = new System.Drawing.Size(1014, 302);
            this.dgvXsdmx.TabIndex = 89;
            // 
            // dgvXsd
            // 
            this.dgvXsd.AllowUserToAddRows = false;
            this.dgvXsd.AllowUserToDeleteRows = false;
            this.dgvXsd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXsd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXsd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXsd.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvXsd.Location = new System.Drawing.Point(39, 113);
            this.dgvXsd.MultiSelect = false;
            this.dgvXsd.Name = "dgvXsd";
            this.dgvXsd.ReadOnly = true;
            this.dgvXsd.RowHeadersWidth = 20;
            this.dgvXsd.RowTemplate.Height = 23;
            this.dgvXsd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsd.Size = new System.Drawing.Size(1014, 336);
            this.dgvXsd.TabIndex = 88;
            // 
            // FreightSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 792);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvXsdmx);
            this.Controls.Add(this.dgvXsd);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpXsrqTo);
            this.Controls.Add(this.chkXsrq);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSjsid);
            this.Controls.Add(this.lblEjkh);
            this.Controls.Add(this.dtpXsrqFrom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.combKhid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FreightSearchFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "在途运费付款查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdmx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpXsrqTo;
        private System.Windows.Forms.CheckBox chkXsrq;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSjsid;
        private System.Windows.Forms.Label lblEjkh;
        private System.Windows.Forms.DateTimePicker dtpXsrqFrom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox combKhid;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvXsdmx;
        private System.Windows.Forms.DataGridView dgvXsd;
    }
}