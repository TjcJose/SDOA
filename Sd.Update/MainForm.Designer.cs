namespace Sd.Update
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_reconnect = new System.Windows.Forms.Label();
            this.label_progress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "正在分析升级信息......";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.GhostWhite;
            this.progressBar1.Location = new System.Drawing.Point(4, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(385, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label_reconnect
            // 
            this.label_reconnect.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reconnect.ForeColor = System.Drawing.Color.Red;
            this.label_reconnect.Location = new System.Drawing.Point(3, 89);
            this.label_reconnect.Name = "label_reconnect";
            this.label_reconnect.Size = new System.Drawing.Size(208, 23);
            this.label_reconnect.TabIndex = 5;
            this.label_reconnect.Text = "连接断开，正在重连中...";
            this.label_reconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_reconnect.Visible = false;
            // 
            // label_progress
            // 
            this.label_progress.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progress.ForeColor = System.Drawing.Color.Brown;
            this.label_progress.Location = new System.Drawing.Point(247, 89);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(142, 23);
            this.label_progress.TabIndex = 6;
            this.label_progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 23);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 121);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.label_reconnect);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "软件自动更新";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_reconnect;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Label label2;
    }
}