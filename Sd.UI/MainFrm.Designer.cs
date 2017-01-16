namespace Sd.UI
{
    sealed partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.在途系统 = new System.Windows.Forms.ToolStripMenuItem();
            this.库房管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.销售单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.财务管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.综合报表 = new System.Windows.Forms.ToolStripMenuItem();
            this.综合查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.客户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCzy = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngine
            // 
            this.skinEngine.@__DrawButtonFocusRectangle = true;
            this.skinEngine.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine.SerialNumber = "";
            this.skinEngine.SkinFile = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.在途系统,
            this.库房管理,
            this.销售管理,
            this.财务管理,
            this.综合报表,
            this.信息管理,
            this.系统管理,
            this.退出});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 在途系统
            // 
            this.在途系统.Image = global::Sd.UI.Properties.Resources.lorry_go;
            this.在途系统.Name = "在途系统";
            this.在途系统.ShortcutKeyDisplayString = "L";
            this.在途系统.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.在途系统.Size = new System.Drawing.Size(126, 36);
            this.在途系统.Text = "在途管理(&L)";
            // 
            // 库房管理
            // 
            this.库房管理.Image = global::Sd.UI.Properties.Resources.database_yellow;
            this.库房管理.Name = "库房管理";
            this.库房管理.Size = new System.Drawing.Size(130, 36);
            this.库房管理.Text = "库存管理(&O)";
            // 
            // 销售管理
            // 
            this.销售管理.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售单ToolStripMenuItem});
            this.销售管理.Image = global::Sd.UI.Properties.Resources.cart_add;
            this.销售管理.Name = "销售管理";
            this.销售管理.Size = new System.Drawing.Size(130, 36);
            this.销售管理.Text = "销售管理(&N)";
            // 
            // 销售单ToolStripMenuItem
            // 
            this.销售单ToolStripMenuItem.Image = global::Sd.UI.Properties.Resources.resultset_next;
            this.销售单ToolStripMenuItem.Name = "销售单ToolStripMenuItem";
            this.销售单ToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.销售单ToolStripMenuItem.Text = "销售单(&N)";
            this.销售单ToolStripMenuItem.Click += new System.EventHandler(this.销售单ToolStripMenuItem_Click);
            // 
            // 财务管理
            // 
            this.财务管理.Image = global::Sd.UI.Properties.Resources.table_money;
            this.财务管理.Name = "财务管理";
            this.财务管理.Size = new System.Drawing.Size(130, 36);
            this.财务管理.Text = "财务管理(&Q)";
            // 
            // 综合报表
            // 
            this.综合报表.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.综合查询ToolStripMenuItem});
            this.综合报表.Image = global::Sd.UI.Properties.Resources.report_stack;
            this.综合报表.Name = "综合报表";
            this.综合报表.Size = new System.Drawing.Size(127, 36);
            this.综合报表.Text = "综合报表(&S)";
            // 
            // 综合查询ToolStripMenuItem
            // 
            this.综合查询ToolStripMenuItem.Image = global::Sd.UI.Properties.Resources.resultset_next;
            this.综合查询ToolStripMenuItem.Name = "综合查询ToolStripMenuItem";
            this.综合查询ToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
            this.综合查询ToolStripMenuItem.Text = "综合查询(&Z)";
            this.综合查询ToolStripMenuItem.Click += new System.EventHandler(this.综合查询ToolStripMenuItem_Click);
            // 
            // 信息管理
            // 
            this.信息管理.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户ToolStripMenuItem,
            this.部门ToolStripMenuItem,
            this.商品ToolStripMenuItem});
            this.信息管理.Image = global::Sd.UI.Properties.Resources.visual_basic;
            this.信息管理.Name = "信息管理";
            this.信息管理.Size = new System.Drawing.Size(127, 36);
            this.信息管理.Text = "信息管理(&T)";
            // 
            // 客户ToolStripMenuItem
            // 
            this.客户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户信息ToolStripMenuItem});
            this.客户ToolStripMenuItem.Image = global::Sd.UI.Properties.Resources.resultset_next;
            this.客户ToolStripMenuItem.Name = "客户ToolStripMenuItem";
            this.客户ToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.客户ToolStripMenuItem.Text = "客户(&T)";
            // 
            // 客户信息ToolStripMenuItem
            // 
            this.客户信息ToolStripMenuItem.Name = "客户信息ToolStripMenuItem";
            this.客户信息ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.客户信息ToolStripMenuItem.Text = "客户信息(&R)";
            this.客户信息ToolStripMenuItem.Click += new System.EventHandler(this.客户信息ToolStripMenuItem_Click);
            // 
            // 部门ToolStripMenuItem
            // 
            this.部门ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大部门ToolStripMenuItem});
            this.部门ToolStripMenuItem.Image = global::Sd.UI.Properties.Resources.resultset_next;
            this.部门ToolStripMenuItem.Name = "部门ToolStripMenuItem";
            this.部门ToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.部门ToolStripMenuItem.Text = "部门(&U)";
            // 
            // 大部门ToolStripMenuItem
            // 
            this.大部门ToolStripMenuItem.Name = "大部门ToolStripMenuItem";
            this.大部门ToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.大部门ToolStripMenuItem.Text = "大部门信息(&V)";
            this.大部门ToolStripMenuItem.Click += new System.EventHandler(this.大部门ToolStripMenuItem_Click);
            // 
            // 商品ToolStripMenuItem
            // 
            this.商品ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品信息ToolStripMenuItem});
            this.商品ToolStripMenuItem.Image = global::Sd.UI.Properties.Resources.resultset_next;
            this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            this.商品ToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.商品ToolStripMenuItem.Text = "商品(&S)";
            // 
            // 商品信息ToolStripMenuItem
            // 
            this.商品信息ToolStripMenuItem.Name = "商品信息ToolStripMenuItem";
            this.商品信息ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.商品信息ToolStripMenuItem.Text = "商品信息(&P)";
            this.商品信息ToolStripMenuItem.Click += new System.EventHandler(this.商品信息ToolStripMenuItem_Click);
            // 
            // 系统管理
            // 
            this.系统管理.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.权限管理ToolStripMenuItem});
            this.系统管理.Image = global::Sd.UI.Properties.Resources.cog_edit;
            this.系统管理.Name = "系统管理";
            this.系统管理.Size = new System.Drawing.Size(133, 36);
            this.系统管理.Text = "系统管理(&W)";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Image = global::Sd.UI.Properties.Resources.resultset_next;
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
            this.用户管理ToolStripMenuItem.Text = "用户管理(&U)";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Image = global::Sd.UI.Properties.Resources.resultset_next;
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
            this.权限管理ToolStripMenuItem.Text = "权限管理(&Q)";
            this.权限管理ToolStripMenuItem.Click += new System.EventHandler(this.权限管理ToolStripMenuItem_Click);
            // 
            // 退出
            // 
            this.退出.Image = global::Sd.UI.Properties.Resources.cancel;
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(100, 36);
            this.退出.Text = "退出(&Z)";
            this.退出.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel11,
            this.tsslCzy});
            this.statusStrip1.Location = new System.Drawing.Point(0, 933);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1584, 29);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 24);
            this.toolStripStatusLabel3.Text = " ";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 24);
            this.toolStripStatusLabel1.Text = "开发者：";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(55, 24);
            this.toolStripStatusLabel2.Text = "网络部";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel10.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel10.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(11, 24);
            this.toolStripStatusLabel10.Text = " ";
            this.toolStripStatusLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(83, 24);
            this.toolStripStatusLabel4.Text = "联系电话：";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(101, 24);
            this.toolStripStatusLabel5.Text = "18844157106";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel6.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(11, 24);
            this.toolStripStatusLabel6.Text = " ";
            this.toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(55, 24);
            this.toolStripStatusLabel7.Text = "微信：";
            this.toolStripStatusLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel8.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(55, 24);
            this.toolStripStatusLabel8.Text = "tjcgao";
            this.toolStripStatusLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel9.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel9.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(11, 24);
            this.toolStripStatusLabel9.Text = " ";
            this.toolStripStatusLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel11.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(97, 24);
            this.toolStripStatusLabel11.Text = "当前操作者：";
            this.toolStripStatusLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tsslCzy
            // 
            this.tsslCzy.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslCzy.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslCzy.Name = "tsslCzy";
            this.tsslCzy.Size = new System.Drawing.Size(45, 24);
            this.tsslCzy.Text = "        ";
            this.tsslCzy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Sd.UI.Properties.Resources.主画面02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 962);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 在途系统;
        private System.Windows.Forms.ToolStripMenuItem 销售管理;
        private System.Windows.Forms.ToolStripMenuItem 财务管理;
        private System.Windows.Forms.ToolStripMenuItem 信息管理;
        private System.Windows.Forms.ToolStripMenuItem 综合报表;
        private System.Windows.Forms.ToolStripMenuItem 系统管理;
        private System.Windows.Forms.ToolStripMenuItem 库房管理;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        public System.Windows.Forms.ToolStripStatusLabel tsslCzy;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售单ToolStripMenuItem;
        public Sunisoft.IrisSkin.SkinEngine skinEngine;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.ToolStripMenuItem 综合查询ToolStripMenuItem;
    }
}