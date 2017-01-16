namespace Sd.UI.Finance
{
    partial class InComeSearchFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InComeSearchFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.chkSrrq = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkWs = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvQtsrd = new System.Windows.Forms.DataGridView();
            this.dgvQtsrmx = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRqFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpRqTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtsrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtsrmx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "收入单号";
            // 
            // chkSrrq
            // 
            this.chkSrrq.AutoSize = true;
            this.chkSrrq.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSrrq.Location = new System.Drawing.Point(28, 74);
            this.chkSrrq.Name = "chkSrrq";
            this.chkSrrq.Size = new System.Drawing.Size(104, 23);
            this.chkSrrq.TabIndex = 1;
            this.chkSrrq.Text = "收入日期";
            this.chkSrrq.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(127, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 29);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(337, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "至";
            // 
            // chkWs
            // 
            this.chkWs.AutoSize = true;
            this.chkWs.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkWs.Location = new System.Drawing.Point(596, 74);
            this.chkWs.Name = "chkWs";
            this.chkWs.Size = new System.Drawing.Size(161, 23);
            this.chkWs.TabIndex = 7;
            this.chkWs.Text = "仅查询未审单据";
            this.chkWs.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(863, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 38);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(863, 66);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvQtsrd
            // 
            this.dgvQtsrd.AllowUserToOrderColumns = true;
            this.dgvQtsrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQtsrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQtsrd.ColumnHeadersHeight = 28;
            this.dgvQtsrd.Location = new System.Drawing.Point(28, 118);
            this.dgvQtsrd.Name = "dgvQtsrd";
            this.dgvQtsrd.RowHeadersWidth = 20;
            this.dgvQtsrd.RowTemplate.Height = 23;
            this.dgvQtsrd.Size = new System.Drawing.Size(933, 285);
            this.dgvQtsrd.TabIndex = 10;
            this.dgvQtsrd.SelectionChanged += new System.EventHandler(this.dgvQtsrd_SelectionChanged);
            // 
            // dgvQtsrmx
            // 
            this.dgvQtsrmx.AllowUserToOrderColumns = true;
            this.dgvQtsrmx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQtsrmx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQtsrmx.ColumnHeadersHeight = 28;
            this.dgvQtsrmx.Location = new System.Drawing.Point(28, 429);
            this.dgvQtsrmx.Name = "dgvQtsrmx";
            this.dgvQtsrmx.RowHeadersWidth = 20;
            this.dgvQtsrmx.RowTemplate.Height = 23;
            this.dgvQtsrmx.Size = new System.Drawing.Size(933, 348);
            this.dgvQtsrmx.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(393, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "明     细     内     容";
            // 
            // dtpRqFrom
            // 
            this.dtpRqFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpRqFrom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRqFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRqFrom.Location = new System.Drawing.Point(127, 71);
            this.dtpRqFrom.Name = "dtpRqFrom";
            this.dtpRqFrom.Size = new System.Drawing.Size(193, 29);
            this.dtpRqFrom.TabIndex = 22;
            // 
            // dtpRqTo
            // 
            this.dtpRqTo.CustomFormat = "yyyy-MM-dd";
            this.dtpRqTo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRqTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRqTo.Location = new System.Drawing.Point(380, 71);
            this.dtpRqTo.Name = "dtpRqTo";
            this.dtpRqTo.Size = new System.Drawing.Size(189, 29);
            this.dtpRqTo.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(592, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "收入类别";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(415, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 29);
            this.textBox2.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(679, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 27);
            this.comboBox1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(329, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "摘要名称";
            // 
            // InComeSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 801);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpRqTo);
            this.Controls.Add(this.dtpRqFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvQtsrmx);
            this.Controls.Add(this.dgvQtsrd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkWs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkSrrq);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InComeSearchFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " 收入进账单查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtsrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtsrmx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSrrq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkWs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvQtsrd;
        private System.Windows.Forms.DataGridView dgvQtsrmx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRqFrom;
        private System.Windows.Forms.DateTimePicker dtpRqTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}