namespace Sd.UI.SystemAdmin
{
    partial class AuthorityFrm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.combUser = new System.Windows.Forms.ComboBox();
            this.gbAuthority = new System.Windows.Forms.GroupBox();
            this.tvCompetence = new TreeViewEnhanced();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbAuthority.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(41, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(65, 12);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "用户工号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "所属权限组：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 21);
            this.textBox2.TabIndex = 3;
            // 
            // combUser
            // 
            this.combUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combUser.FormattingEnabled = true;
            this.combUser.Location = new System.Drawing.Point(128, 40);
            this.combUser.Name = "combUser";
            this.combUser.Size = new System.Drawing.Size(141, 20);
            this.combUser.TabIndex = 4;
            this.combUser.SelectedIndexChanged += new System.EventHandler(this.combUser_SelectedIndexChanged);
            // 
            // gbAuthority
            // 
            this.gbAuthority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAuthority.Controls.Add(this.tvCompetence);
            this.gbAuthority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAuthority.Location = new System.Drawing.Point(31, 123);
            this.gbAuthority.Name = "gbAuthority";
            this.gbAuthority.Size = new System.Drawing.Size(547, 501);
            this.gbAuthority.TabIndex = 5;
            this.gbAuthority.TabStop = false;
            this.gbAuthority.Text = "权限";
            // 
            // tvCompetence
            // 
            this.tvCompetence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tvCompetence.CheckBoxes = true;
            this.tvCompetence.Indent = 28;
            this.tvCompetence.ItemHeight = 20;
            this.tvCompetence.Location = new System.Drawing.Point(3, 17);
            this.tvCompetence.Name = "tvCompetence";
            this.tvCompetence.Size = new System.Drawing.Size(541, 481);
            this.tvCompetence.TabIndex = 0;
            this.tvCompetence.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCompetence_AfterCheck);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(310, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 49);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "提交权限";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(455, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AuthorityFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 637);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbAuthority);
            this.Controls.Add(this.combUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Name = "AuthorityFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "权限画面";
            this.Load += new System.EventHandler(this.AuthorityFrm_Load);
            this.gbAuthority.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox combUser;
        private System.Windows.Forms.GroupBox gbAuthority;
        private System.Windows.Forms.TreeView tvCompetence;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}