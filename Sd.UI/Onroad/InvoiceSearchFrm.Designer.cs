namespace Sd.UI.Onroad
{
    partial class InvoiceSearchFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpXsrqTo = new System.Windows.Forms.DateTimePicker();
            this.chkXsrq = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSjsid = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.dtpXsrqFrom = new System.Windows.Forms.DateTimePicker();
            this.combKhid = new System.Windows.Forms.ComboBox();
            this.lblKhid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXsdmx = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEjkh = new System.Windows.Forms.TextBox();
            this.lblEjkh = new System.Windows.Forms.Label();
            this.dgvXsd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdmx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(511, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "至";
            // 
            // dtpXsrqTo
            // 
            this.dtpXsrqTo.CustomFormat = "yyyy-MM-dd";
            this.dtpXsrqTo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpXsrqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXsrqTo.Location = new System.Drawing.Point(539, 13);
            this.dtpXsrqTo.Name = "dtpXsrqTo";
            this.dtpXsrqTo.Size = new System.Drawing.Size(143, 29);
            this.dtpXsrqTo.TabIndex = 51;
            // 
            // chkXsrq
            // 
            this.chkXsrq.AutoSize = true;
            this.chkXsrq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkXsrq.Location = new System.Drawing.Point(260, 16);
            this.chkXsrq.Name = "chkXsrq";
            this.chkXsrq.Size = new System.Drawing.Size(104, 23);
            this.chkXsrq.TabIndex = 50;
            this.chkXsrq.Text = "发货日期";
            this.chkXsrq.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(984, 10);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(88, 34);
            this.btnQuit.TabIndex = 49;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(871, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 34);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(632, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 29);
            this.txtAddress.TabIndex = 46;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.Location = new System.Drawing.Point(549, 66);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 19);
            this.lblAddress.TabIndex = 47;
            this.lblAddress.Text = "出厂单号";
            // 
            // lblSjsid
            // 
            this.lblSjsid.AutoSize = true;
            this.lblSjsid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSjsid.Location = new System.Drawing.Point(768, 66);
            this.lblSjsid.Name = "lblSjsid";
            this.lblSjsid.Size = new System.Drawing.Size(85, 19);
            this.lblSjsid.TabIndex = 45;
            this.lblSjsid.Text = "商品编码";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(99, 61);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(129, 29);
            this.txtTel.TabIndex = 41;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTel.Location = new System.Drawing.Point(12, 66);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(85, 19);
            this.lblTel.TabIndex = 43;
            this.lblTel.Text = "发货单号";
            // 
            // dtpXsrqFrom
            // 
            this.dtpXsrqFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpXsrqFrom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpXsrqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXsrqFrom.Location = new System.Drawing.Point(364, 13);
            this.dtpXsrqFrom.Name = "dtpXsrqFrom";
            this.dtpXsrqFrom.Size = new System.Drawing.Size(143, 29);
            this.dtpXsrqFrom.TabIndex = 39;
            // 
            // combKhid
            // 
            this.combKhid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combKhid.FormattingEnabled = true;
            this.combKhid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.combKhid.Location = new System.Drawing.Point(78, 15);
            this.combKhid.Name = "combKhid";
            this.combKhid.Size = new System.Drawing.Size(150, 24);
            this.combKhid.TabIndex = 35;
            // 
            // lblKhid
            // 
            this.lblKhid.AutoSize = true;
            this.lblKhid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblKhid.Location = new System.Drawing.Point(12, 18);
            this.lblKhid.Name = "lblKhid";
            this.lblKhid.Size = new System.Drawing.Size(66, 19);
            this.lblKhid.TabIndex = 36;
            this.lblKhid.Text = "供货商";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(484, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "明  细  内  容";
            // 
            // dgvXsdmx
            // 
            this.dgvXsdmx.AllowUserToAddRows = false;
            this.dgvXsdmx.AllowUserToDeleteRows = false;
            this.dgvXsdmx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXsdmx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvXsdmx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXsdmx.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvXsdmx.Location = new System.Drawing.Point(12, 440);
            this.dgvXsdmx.MultiSelect = false;
            this.dgvXsdmx.Name = "dgvXsdmx";
            this.dgvXsdmx.ReadOnly = true;
            this.dgvXsdmx.RowHeadersWidth = 20;
            this.dgvXsdmx.RowTemplate.Height = 23;
            this.dgvXsdmx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsdmx.Size = new System.Drawing.Size(1057, 340);
            this.dgvXsdmx.TabIndex = 54;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(704, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 23);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.Text = "仅查未审单据";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(857, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 29);
            this.textBox1.TabIndex = 46;
            // 
            // txtEjkh
            // 
            this.txtEjkh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEjkh.Location = new System.Drawing.Point(364, 61);
            this.txtEjkh.Name = "txtEjkh";
            this.txtEjkh.Size = new System.Drawing.Size(181, 29);
            this.txtEjkh.TabIndex = 40;
            this.txtEjkh.TextChanged += new System.EventHandler(this.txtEjkh_TextChanged);
            // 
            // lblEjkh
            // 
            this.lblEjkh.AutoSize = true;
            this.lblEjkh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEjkh.Location = new System.Drawing.Point(256, 66);
            this.lblEjkh.Name = "lblEjkh";
            this.lblEjkh.Size = new System.Drawing.Size(104, 19);
            this.lblEjkh.TabIndex = 42;
            this.lblEjkh.Text = "厂家订单号";
            this.lblEjkh.Click += new System.EventHandler(this.lblEjkh_Click);
            // 
            // dgvXsd
            // 
            this.dgvXsd.AllowUserToAddRows = false;
            this.dgvXsd.AllowUserToDeleteRows = false;
            this.dgvXsd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXsd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvXsd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXsd.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvXsd.Location = new System.Drawing.Point(12, 106);
            this.dgvXsd.MultiSelect = false;
            this.dgvXsd.Name = "dgvXsd";
            this.dgvXsd.ReadOnly = true;
            this.dgvXsd.RowHeadersWidth = 20;
            this.dgvXsd.RowTemplate.Height = 23;
            this.dgvXsd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsd.Size = new System.Drawing.Size(1060, 307);
            this.dgvXsd.TabIndex = 53;
            this.dgvXsd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXsd_CellContentClick);
            // 
            // InvoiceSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 792);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvXsdmx);
            this.Controls.Add(this.dgvXsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpXsrqTo);
            this.Controls.Add(this.chkXsrq);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSjsid);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtEjkh);
            this.Controls.Add(this.lblEjkh);
            this.Controls.Add(this.dtpXsrqFrom);
            this.Controls.Add(this.combKhid);
            this.Controls.Add(this.lblKhid);
            this.Name = "InvoiceSearchFrm";
            this.Text = "厂家发货单查询";
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
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSjsid;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.DateTimePicker dtpXsrqFrom;
        private System.Windows.Forms.ComboBox combKhid;
        private System.Windows.Forms.Label lblKhid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvXsdmx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEjkh;
        private System.Windows.Forms.Label lblEjkh;
        private System.Windows.Forms.DataGridView dgvXsd;
    }
}