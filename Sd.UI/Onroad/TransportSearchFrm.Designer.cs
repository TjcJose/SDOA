namespace Sd.UI.Onroad
{
    partial class TransportSearchFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportSearchFrm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXsdmx = new System.Windows.Forms.DataGridView();
            this.dgvXsd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpYsrqTo = new System.Windows.Forms.DateTimePicker();
            this.chkYsrq = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSjsid = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEjkh = new System.Windows.Forms.Label();
            this.dtpYsrqFrom = new System.Windows.Forms.DateTimePicker();
            this.combKhid = new System.Windows.Forms.ComboBox();
            this.lblKhid = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdmx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsd)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(934, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 23);
            this.checkBox1.TabIndex = 76;
            this.checkBox1.Text = "仅查未审单据";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(472, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "明  细  内  容";
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
            this.dgvXsdmx.Location = new System.Drawing.Point(21, 441);
            this.dgvXsdmx.MultiSelect = false;
            this.dgvXsdmx.Name = "dgvXsdmx";
            this.dgvXsdmx.ReadOnly = true;
            this.dgvXsdmx.RowHeadersWidth = 20;
            this.dgvXsdmx.RowTemplate.Height = 23;
            this.dgvXsdmx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsdmx.Size = new System.Drawing.Size(1057, 340);
            this.dgvXsdmx.TabIndex = 74;
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
            this.dgvXsd.Location = new System.Drawing.Point(21, 104);
            this.dgvXsd.MultiSelect = false;
            this.dgvXsd.Name = "dgvXsd";
            this.dgvXsd.ReadOnly = true;
            this.dgvXsd.RowHeadersWidth = 20;
            this.dgvXsd.RowTemplate.Height = 23;
            this.dgvXsd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsd.Size = new System.Drawing.Size(1057, 310);
            this.dgvXsd.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(629, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "至";
            // 
            // dtpYsrqTo
            // 
            this.dtpYsrqTo.CustomFormat = "yyyy-MM-dd";
            this.dtpYsrqTo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpYsrqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYsrqTo.Location = new System.Drawing.Point(681, 69);
            this.dtpYsrqTo.Name = "dtpYsrqTo";
            this.dtpYsrqTo.Size = new System.Drawing.Size(184, 29);
            this.dtpYsrqTo.TabIndex = 71;
            // 
            // chkYsrq
            // 
            this.chkYsrq.AutoSize = true;
            this.chkYsrq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkYsrq.Location = new System.Drawing.Point(319, 72);
            this.chkYsrq.Name = "chkYsrq";
            this.chkYsrq.Size = new System.Drawing.Size(104, 23);
            this.chkYsrq.TabIndex = 70;
            this.chkYsrq.Text = "运输日期";
            this.chkYsrq.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(988, 13);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(88, 34);
            this.btnQuit.TabIndex = 69;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(892, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 34);
            this.btnSearch.TabIndex = 68;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(106, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 29);
            this.textBox1.TabIndex = 66;
            // 
            // lblSjsid
            // 
            this.lblSjsid.AutoSize = true;
            this.lblSjsid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSjsid.Location = new System.Drawing.Point(21, 21);
            this.lblSjsid.Name = "lblSjsid";
            this.lblSjsid.Size = new System.Drawing.Size(85, 19);
            this.lblSjsid.TabIndex = 64;
            this.lblSjsid.Text = "商品编码";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(399, 16);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(208, 29);
            this.txtTel.TabIndex = 61;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTel.Location = new System.Drawing.Point(314, 21);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(85, 19);
            this.lblTel.TabIndex = 63;
            this.lblTel.Text = "运输单号";
            // 
            // lblEjkh
            // 
            this.lblEjkh.AutoSize = true;
            this.lblEjkh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEjkh.Location = new System.Drawing.Point(21, 74);
            this.lblEjkh.Name = "lblEjkh";
            this.lblEjkh.Size = new System.Drawing.Size(85, 19);
            this.lblEjkh.TabIndex = 62;
            this.lblEjkh.Text = "核算部门";
            // 
            // dtpYsrqFrom
            // 
            this.dtpYsrqFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpYsrqFrom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpYsrqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYsrqFrom.Location = new System.Drawing.Point(423, 69);
            this.dtpYsrqFrom.Name = "dtpYsrqFrom";
            this.dtpYsrqFrom.Size = new System.Drawing.Size(184, 29);
            this.dtpYsrqFrom.TabIndex = 59;
            // 
            // combKhid
            // 
            this.combKhid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combKhid.FormattingEnabled = true;
            this.combKhid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.combKhid.Location = new System.Drawing.Point(681, 18);
            this.combKhid.Name = "combKhid";
            this.combKhid.Size = new System.Drawing.Size(184, 27);
            this.combKhid.TabIndex = 57;
            // 
            // lblKhid
            // 
            this.lblKhid.AutoSize = true;
            this.lblKhid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblKhid.Location = new System.Drawing.Point(615, 21);
            this.lblKhid.Name = "lblKhid";
            this.lblKhid.Size = new System.Drawing.Size(66, 19);
            this.lblKhid.TabIndex = 58;
            this.lblKhid.Text = "运输商";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Location = new System.Drawing.Point(106, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 27);
            this.comboBox1.TabIndex = 57;
            // 
            // TransportSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 792);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvXsdmx);
            this.Controls.Add(this.dgvXsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpYsrqTo);
            this.Controls.Add(this.chkYsrq);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSjsid);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEjkh);
            this.Controls.Add(this.dtpYsrqFrom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.combKhid);
            this.Controls.Add(this.lblKhid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransportSearchFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "在途运输单查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdmx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvXsdmx;
        private System.Windows.Forms.DataGridView dgvXsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpYsrqTo;
        private System.Windows.Forms.CheckBox chkYsrq;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSjsid;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEjkh;
        private System.Windows.Forms.DateTimePicker dtpYsrqFrom;
        private System.Windows.Forms.ComboBox combKhid;
        private System.Windows.Forms.Label lblKhid;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}