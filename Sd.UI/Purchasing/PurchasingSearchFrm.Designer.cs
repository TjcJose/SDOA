namespace Sd.UI.Purchasing
{
    partial class PurchasingSearchFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasingSearchFrm));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXsdmx = new System.Windows.Forms.DataGridView();
            this.dgvXsd = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKhid = new System.Windows.Forms.Label();
            this.combKhid = new System.Windows.Forms.ComboBox();
            this.lblSgddh = new System.Windows.Forms.Label();
            this.txtTyphcc = new System.Windows.Forms.TextBox();
            this.dtpXsrqFrom = new System.Windows.Forms.DateTimePicker();
            this.lblEjkh = new System.Windows.Forms.Label();
            this.txtEjkh = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkXsrq = new System.Windows.Forms.CheckBox();
            this.dtpXsrqTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdmx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(578, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 42;
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
            this.dgvXsdmx.Location = new System.Drawing.Point(11, 495);
            this.dgvXsdmx.MultiSelect = false;
            this.dgvXsdmx.Name = "dgvXsdmx";
            this.dgvXsdmx.ReadOnly = true;
            this.dgvXsdmx.RowHeadersWidth = 20;
            this.dgvXsdmx.RowTemplate.Height = 23;
            this.dgvXsdmx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsdmx.Size = new System.Drawing.Size(1262, 327);
            this.dgvXsdmx.TabIndex = 41;
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
            this.dgvXsd.Location = new System.Drawing.Point(11, 126);
            this.dgvXsd.MultiSelect = false;
            this.dgvXsd.Name = "dgvXsd";
            this.dgvXsd.ReadOnly = true;
            this.dgvXsd.RowHeadersWidth = 20;
            this.dgvXsd.RowTemplate.Height = 23;
            this.dgvXsd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXsd.Size = new System.Drawing.Size(1262, 343);
            this.dgvXsd.TabIndex = 40;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(893, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 23);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "仅查未审单据";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(649, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "种 类";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Location = new System.Drawing.Point(320, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 27);
            this.comboBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(236, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "考核部门";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox2.Location = new System.Drawing.Point(707, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 27);
            this.comboBox2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(424, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "商品编码";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(509, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 29);
            this.textBox1.TabIndex = 22;
            // 
            // lblKhid
            // 
            this.lblKhid.AutoSize = true;
            this.lblKhid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblKhid.Location = new System.Drawing.Point(431, 73);
            this.lblKhid.Name = "lblKhid";
            this.lblKhid.Size = new System.Drawing.Size(66, 19);
            this.lblKhid.TabIndex = 17;
            this.lblKhid.Text = "供货商";
            // 
            // combKhid
            // 
            this.combKhid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combKhid.FormattingEnabled = true;
            this.combKhid.ImeMode = System.Windows.Forms.ImeMode.On;
            this.combKhid.Location = new System.Drawing.Point(509, 70);
            this.combKhid.Name = "combKhid";
            this.combKhid.Size = new System.Drawing.Size(128, 27);
            this.combKhid.TabIndex = 16;
            // 
            // lblSgddh
            // 
            this.lblSgddh.AutoSize = true;
            this.lblSgddh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSgddh.Location = new System.Drawing.Point(11, 13);
            this.lblSgddh.Name = "lblSgddh";
            this.lblSgddh.Size = new System.Drawing.Size(104, 19);
            this.lblSgddh.TabIndex = 19;
            this.lblSgddh.Text = "进货单编号";
            // 
            // txtTyphcc
            // 
            this.txtTyphcc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTyphcc.Location = new System.Drawing.Point(115, 9);
            this.txtTyphcc.Name = "txtTyphcc";
            this.txtTyphcc.Size = new System.Drawing.Size(120, 29);
            this.txtTyphcc.TabIndex = 18;
            // 
            // dtpXsrqFrom
            // 
            this.dtpXsrqFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpXsrqFrom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpXsrqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXsrqFrom.Location = new System.Drawing.Point(952, 69);
            this.dtpXsrqFrom.Name = "dtpXsrqFrom";
            this.dtpXsrqFrom.Size = new System.Drawing.Size(136, 29);
            this.dtpXsrqFrom.TabIndex = 21;
            // 
            // lblEjkh
            // 
            this.lblEjkh.AutoSize = true;
            this.lblEjkh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEjkh.Location = new System.Drawing.Point(11, 73);
            this.lblEjkh.Name = "lblEjkh";
            this.lblEjkh.Size = new System.Drawing.Size(104, 19);
            this.lblEjkh.TabIndex = 24;
            this.lblEjkh.Text = "运输单编号";
            // 
            // txtEjkh
            // 
            this.txtEjkh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEjkh.Location = new System.Drawing.Point(115, 69);
            this.txtEjkh.Name = "txtEjkh";
            this.txtEjkh.Size = new System.Drawing.Size(120, 29);
            this.txtEjkh.TabIndex = 22;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTel.Location = new System.Drawing.Point(637, 13);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(104, 19);
            this.lblTel.TabIndex = 25;
            this.lblTel.Text = "厂家订单号";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(320, 9);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(104, 29);
            this.txtTel.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(1042, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 43);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(1167, 1);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(91, 43);
            this.btnQuit.TabIndex = 31;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // chkXsrq
            // 
            this.chkXsrq.AutoSize = true;
            this.chkXsrq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkXsrq.Location = new System.Drawing.Point(848, 71);
            this.chkXsrq.Name = "chkXsrq";
            this.chkXsrq.Size = new System.Drawing.Size(104, 23);
            this.chkXsrq.TabIndex = 32;
            this.chkXsrq.Text = "入库日期";
            this.chkXsrq.UseVisualStyleBackColor = true;
            // 
            // dtpXsrqTo
            // 
            this.dtpXsrqTo.CustomFormat = "yyyy-MM-dd";
            this.dtpXsrqTo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpXsrqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXsrqTo.Location = new System.Drawing.Point(1116, 69);
            this.dtpXsrqTo.Name = "dtpXsrqTo";
            this.dtpXsrqTo.Size = new System.Drawing.Size(140, 29);
            this.dtpXsrqTo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1088, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "至";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpXsrqTo);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.chkXsrq);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.txtEjkh);
            this.panel1.Controls.Add(this.lblEjkh);
            this.panel1.Controls.Add(this.dtpXsrqFrom);
            this.panel1.Controls.Add(this.txtTyphcc);
            this.panel1.Controls.Add(this.lblSgddh);
            this.panel1.Controls.Add(this.combKhid);
            this.panel1.Controls.Add(this.lblKhid);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 121);
            this.panel1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(741, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 29);
            this.textBox2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(235, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "销售单号";
            // 
            // PurchasingSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 834);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvXsdmx);
            this.Controls.Add(this.dgvXsd);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchasingSearchFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "入库单查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsdmx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXsd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvXsdmx;
        private System.Windows.Forms.DataGridView dgvXsd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKhid;
        private System.Windows.Forms.ComboBox combKhid;
        private System.Windows.Forms.Label lblSgddh;
        public System.Windows.Forms.TextBox txtTyphcc;
        private System.Windows.Forms.DateTimePicker dtpXsrqFrom;
        private System.Windows.Forms.Label lblEjkh;
        private System.Windows.Forms.TextBox txtEjkh;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkXsrq;
        private System.Windows.Forms.DateTimePicker dtpXsrqTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}