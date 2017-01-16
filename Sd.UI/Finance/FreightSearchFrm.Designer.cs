namespace Sd.UI.Finance
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
            this.dtpRqTo = new System.Windows.Forms.DateTimePicker();
            this.chkXsrq = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSjsid = new System.Windows.Forms.Label();
            this.lblEjkh = new System.Windows.Forms.Label();
            this.dtpRqFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.combKhid = new System.Windows.Forms.ComboBox();
            this.chkWs = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvJhyfmx = new System.Windows.Forms.DataGridView();
            this.dgvJhyfd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJhyfmx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJhyfd)).BeginInit();
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
            // dtpRqTo
            // 
            this.dtpRqTo.CustomFormat = "yyyy-MM-dd";
            this.dtpRqTo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRqTo.Location = new System.Drawing.Point(417, 67);
            this.dtpRqTo.Name = "dtpRqTo";
            this.dtpRqTo.Size = new System.Drawing.Size(196, 29);
            this.dtpRqTo.TabIndex = 85;
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
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
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
            // dtpRqFrom
            // 
            this.dtpRqFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpRqFrom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRqFrom.Location = new System.Drawing.Point(143, 66);
            this.dtpRqFrom.Name = "dtpRqFrom";
            this.dtpRqFrom.Size = new System.Drawing.Size(187, 29);
            this.dtpRqFrom.TabIndex = 79;
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
            // chkWs
            // 
            this.chkWs.AutoSize = true;
            this.chkWs.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkWs.Location = new System.Drawing.Point(653, 45);
            this.chkWs.Name = "chkWs";
            this.chkWs.Size = new System.Drawing.Size(142, 23);
            this.chkWs.TabIndex = 87;
            this.chkWs.Text = "仅查未审单据";
            this.chkWs.UseVisualStyleBackColor = true;
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
            // dgvJhyfmx
            // 
            this.dgvJhyfmx.AllowUserToAddRows = false;
            this.dgvJhyfmx.AllowUserToDeleteRows = false;
            this.dgvJhyfmx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJhyfmx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJhyfmx.ColumnHeadersHeight = 30;
            this.dgvJhyfmx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJhyfmx.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJhyfmx.Location = new System.Drawing.Point(39, 478);
            this.dgvJhyfmx.MultiSelect = false;
            this.dgvJhyfmx.Name = "dgvJhyfmx";
            this.dgvJhyfmx.ReadOnly = true;
            this.dgvJhyfmx.RowHeadersWidth = 20;
            this.dgvJhyfmx.RowTemplate.Height = 23;
            this.dgvJhyfmx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJhyfmx.Size = new System.Drawing.Size(1014, 302);
            this.dgvJhyfmx.TabIndex = 89;
            // 
            // dgvJhyfd
            // 
            this.dgvJhyfd.AllowUserToAddRows = false;
            this.dgvJhyfd.AllowUserToDeleteRows = false;
            this.dgvJhyfd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJhyfd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJhyfd.ColumnHeadersHeight = 30;
            this.dgvJhyfd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJhyfd.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJhyfd.Location = new System.Drawing.Point(39, 113);
            this.dgvJhyfd.MultiSelect = false;
            this.dgvJhyfd.Name = "dgvJhyfd";
            this.dgvJhyfd.ReadOnly = true;
            this.dgvJhyfd.RowHeadersWidth = 20;
            this.dgvJhyfd.RowTemplate.Height = 23;
            this.dgvJhyfd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJhyfd.Size = new System.Drawing.Size(1014, 336);
            this.dgvJhyfd.TabIndex = 88;
            this.dgvJhyfd.SelectionChanged += new System.EventHandler(this.dgvJhyfd_SelectionChanged);
            // 
            // FreightSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 792);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvJhyfmx);
            this.Controls.Add(this.dgvJhyfd);
            this.Controls.Add(this.chkWs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpRqTo);
            this.Controls.Add(this.chkXsrq);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSjsid);
            this.Controls.Add(this.lblEjkh);
            this.Controls.Add(this.dtpRqFrom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.combKhid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FreightSearchFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "在途运费付款查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJhyfmx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJhyfd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRqTo;
        private System.Windows.Forms.CheckBox chkXsrq;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSjsid;
        private System.Windows.Forms.Label lblEjkh;
        private System.Windows.Forms.DateTimePicker dtpRqFrom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox combKhid;
        private System.Windows.Forms.CheckBox chkWs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvJhyfmx;
        private System.Windows.Forms.DataGridView dgvJhyfd;
    }
}