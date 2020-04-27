namespace VIPVideoAnalysisTools
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.comboBoxInterface = new System.Windows.Forms.ComboBox();
            this.groupBoxSelInterface = new System.Windows.Forms.GroupBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBoxLink = new System.Windows.Forms.GroupBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.statusStripAbout = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.版本v10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.开发者热血码农ZLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qQ2213407066ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxVideoLink = new System.Windows.Forms.GroupBox();
            this.textBoxVideoLink = new System.Windows.Forms.TextBox();
            this.comboBoxVideoLink = new System.Windows.Forms.ComboBox();
            this.buttonOpenVideoLink = new System.Windows.Forms.Button();
            this.声明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelMe = new System.Windows.Forms.Label();
            this.groupBoxSelInterface.SuspendLayout();
            this.groupBoxLink.SuspendLayout();
            this.groupBoxHelp.SuspendLayout();
            this.statusStripAbout.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxVideoLink.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxInterface
            // 
            this.comboBoxInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterface.FormattingEnabled = true;
            this.comboBoxInterface.Location = new System.Drawing.Point(5, 17);
            this.comboBoxInterface.Name = "comboBoxInterface";
            this.comboBoxInterface.Size = new System.Drawing.Size(516, 20);
            this.comboBoxInterface.TabIndex = 2;
            // 
            // groupBoxSelInterface
            // 
            this.groupBoxSelInterface.Controls.Add(this.comboBoxInterface);
            this.groupBoxSelInterface.Location = new System.Drawing.Point(12, 130);
            this.groupBoxSelInterface.Name = "groupBoxSelInterface";
            this.groupBoxSelInterface.Size = new System.Drawing.Size(526, 45);
            this.groupBoxSelInterface.TabIndex = 2;
            this.groupBoxSelInterface.TabStop = false;
            this.groupBoxSelInterface.Text = "解析接口选择(如无法播放请尝试更换线路)";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 181);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(526, 30);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "解析并使用默认浏览器播放此视频";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // groupBoxLink
            // 
            this.groupBoxLink.Controls.Add(this.textBoxLink);
            this.groupBoxLink.Location = new System.Drawing.Point(12, 79);
            this.groupBoxLink.Name = "groupBoxLink";
            this.groupBoxLink.Size = new System.Drawing.Size(526, 45);
            this.groupBoxLink.TabIndex = 4;
            this.groupBoxLink.TabStop = false;
            this.groupBoxLink.Text = "视频链接地址";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Location = new System.Drawing.Point(6, 16);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(514, 21);
            this.textBoxLink.TabIndex = 1;
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxHelp.Controls.Add(this.richTextBoxHelp);
            this.groupBoxHelp.Location = new System.Drawing.Point(12, 217);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(526, 120);
            this.groupBoxHelp.TabIndex = 5;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "使用方法";
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.BackColor = System.Drawing.Color.Snow;
            this.richTextBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHelp.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.ReadOnly = true;
            this.richTextBoxHelp.Size = new System.Drawing.Size(520, 100);
            this.richTextBoxHelp.TabIndex = 0;
            this.richTextBoxHelp.Text = "1.用浏览器访问相应的视频网站并搜索您想观看的视频。\n2.在视频详情页中选择您想要观看的剧集并进入。\n3.复制浏览器顶部网站地址栏中的所有文本粘贴到此工具的视频链" +
    "接地址文本框中。\n4.在此工具选择视频接口后点击播放此视频的按钮即可观看此视频。";
            // 
            // statusStripAbout
            // 
            this.statusStripAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripAbout.Location = new System.Drawing.Point(0, 368);
            this.statusStripAbout.Name = "statusStripAbout";
            this.statusStripAbout.Size = new System.Drawing.Size(550, 22);
            this.statusStripAbout.TabIndex = 6;
            this.statusStripAbout.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButtonTop,
            this.toolStripSeparator2,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(550, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(315, 17);
            this.toolStripStatusLabel1.Text = "欢迎使用本程序!! 本程序完全免费, 视频接口均来自网络。";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本v10ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.开发者热血码农ZLToolStripMenuItem,
            this.qQ2213407066ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.声明ToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton1.Text = "关于程序(&A)";
            // 
            // 版本v10ToolStripMenuItem
            // 
            this.版本v10ToolStripMenuItem.Name = "版本v10ToolStripMenuItem";
            this.版本v10ToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.版本v10ToolStripMenuItem.Text = "版本：v1.0";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(320, 6);
            // 
            // 开发者热血码农ZLToolStripMenuItem
            // 
            this.开发者热血码农ZLToolStripMenuItem.Name = "开发者热血码农ZLToolStripMenuItem";
            this.开发者热血码农ZLToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.开发者热血码农ZLToolStripMenuItem.Text = "开发者：热血码农ZL";
            // 
            // qQ2213407066ToolStripMenuItem
            // 
            this.qQ2213407066ToolStripMenuItem.Name = "qQ2213407066ToolStripMenuItem";
            this.qQ2213407066ToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.qQ2213407066ToolStripMenuItem.Text = "QQ：2213407066";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTextBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.toolStripTextBox1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTextBox1.Image")));
            this.toolStripTextBox1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(84, 22);
            this.toolStripTextBox1.Text = "程序功能(&T)";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripButtonTop
            // 
            this.toolStripButtonTop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTop.Image")));
            this.toolStripButtonTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTop.Name = "toolStripButtonTop";
            this.toolStripButtonTop.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonTop.Text = "窗口置顶";
            this.toolStripButtonTop.Click += new System.EventHandler(this.ToolStripButtonTop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBoxVideoLink
            // 
            this.groupBoxVideoLink.Controls.Add(this.buttonOpenVideoLink);
            this.groupBoxVideoLink.Controls.Add(this.comboBoxVideoLink);
            this.groupBoxVideoLink.Controls.Add(this.textBoxVideoLink);
            this.groupBoxVideoLink.Location = new System.Drawing.Point(12, 28);
            this.groupBoxVideoLink.Name = "groupBoxVideoLink";
            this.groupBoxVideoLink.Size = new System.Drawing.Size(526, 45);
            this.groupBoxVideoLink.TabIndex = 8;
            this.groupBoxVideoLink.TabStop = false;
            this.groupBoxVideoLink.Text = "快速访问视频网站";
            // 
            // textBoxVideoLink
            // 
            this.textBoxVideoLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVideoLink.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVideoLink.Location = new System.Drawing.Point(154, 16);
            this.textBoxVideoLink.Name = "textBoxVideoLink";
            this.textBoxVideoLink.ReadOnly = true;
            this.textBoxVideoLink.Size = new System.Drawing.Size(220, 21);
            this.textBoxVideoLink.TabIndex = 1;
            this.textBoxVideoLink.Text = "视频网站地址";
            // 
            // comboBoxVideoLink
            // 
            this.comboBoxVideoLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVideoLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoLink.FormattingEnabled = true;
            this.comboBoxVideoLink.Location = new System.Drawing.Point(6, 16);
            this.comboBoxVideoLink.Name = "comboBoxVideoLink";
            this.comboBoxVideoLink.Size = new System.Drawing.Size(142, 20);
            this.comboBoxVideoLink.TabIndex = 3;
            this.comboBoxVideoLink.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVideoLink_SelectedIndexChanged);
            // 
            // buttonOpenVideoLink
            // 
            this.buttonOpenVideoLink.Location = new System.Drawing.Point(380, 16);
            this.buttonOpenVideoLink.Name = "buttonOpenVideoLink";
            this.buttonOpenVideoLink.Size = new System.Drawing.Size(140, 21);
            this.buttonOpenVideoLink.TabIndex = 9;
            this.buttonOpenVideoLink.Text = "用浏览器打开此网站";
            this.buttonOpenVideoLink.UseVisualStyleBackColor = true;
            this.buttonOpenVideoLink.Click += new System.EventHandler(this.ButtonOpenVideoLink_Click);
            // 
            // 声明ToolStripMenuItem
            // 
            this.声明ToolStripMenuItem.Name = "声明ToolStripMenuItem";
            this.声明ToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.声明ToolStripMenuItem.Text = "声明：本程序完全免费, 视频接口均来自网络。";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(320, 6);
            // 
            // labelMe
            // 
            this.labelMe.Location = new System.Drawing.Point(10, 337);
            this.labelMe.Name = "labelMe";
            this.labelMe.Size = new System.Drawing.Size(528, 30);
            this.labelMe.TabIndex = 9;
            this.labelMe.Text = "使用过程中遇到任何问题请联系开发者获取帮助。| 开发者：热血码农ZL  联系QQ:2213407066";
            this.labelMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 390);
            this.Controls.Add(this.labelMe);
            this.Controls.Add(this.groupBoxVideoLink);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStripAbout);
            this.Controls.Add(this.groupBoxHelp);
            this.Controls.Add(this.groupBoxLink);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.groupBoxSelInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "全网VIP视频解析播放工具 ---- 版本：v1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxSelInterface.ResumeLayout(false);
            this.groupBoxLink.ResumeLayout(false);
            this.groupBoxLink.PerformLayout();
            this.groupBoxHelp.ResumeLayout(false);
            this.statusStripAbout.ResumeLayout(false);
            this.statusStripAbout.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxVideoLink.ResumeLayout(false);
            this.groupBoxVideoLink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxInterface;
        private System.Windows.Forms.GroupBox groupBoxSelInterface;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.GroupBox groupBoxLink;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.StatusStrip statusStripAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem 版本v10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 开发者热血码农ZLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qQ2213407066ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBoxVideoLink;
        private System.Windows.Forms.Button buttonOpenVideoLink;
        private System.Windows.Forms.ComboBox comboBoxVideoLink;
        private System.Windows.Forms.TextBox textBoxVideoLink;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 声明ToolStripMenuItem;
        private System.Windows.Forms.Label labelMe;
    }
}

