namespace AnyCAD.Basic
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadeWithEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeWithPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.orbitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.stdViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::AnyCAD.Basic.Properties.Resources.alone_back_view_beautiful_674268;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1198, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.fileToolStripMenuItem.Text = "导入导出文件";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTLToolStripMenuItem,
            this.sTEPToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.loadToolStripMenuItem.Text = "导入";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // sTLToolStripMenuItem
            // 
            this.sTLToolStripMenuItem.Name = "sTLToolStripMenuItem";
            this.sTLToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.sTLToolStripMenuItem.Text = "STL";
            this.sTLToolStripMenuItem.Click += new System.EventHandler(this.sTLToolStripMenuItem_Click);
            // 
            // sTEPToolStripMenuItem
            // 
            this.sTEPToolStripMenuItem.Name = "sTEPToolStripMenuItem";
            this.sTEPToolStripMenuItem.Size = new System.Drawing.Size(133, 30);
            this.sTEPToolStripMenuItem.Text = "STEP";
            this.sTEPToolStripMenuItem.Click += new System.EventHandler(this.sTEPToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.exportToolStripMenuItem.Text = "导出";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shadeToolStripMenuItem,
            this.shadeWithEdgeToolStripMenuItem,
            this.edgeWithPointsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.orbitToolStripMenuItem,
            this.panToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showGridToolStripMenuItem,
            this.toolStripMenuItem9,
            this.stdViewToolStripMenuItem,
            this.清除视图ToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.viewToolStripMenuItem.Text = "视图选择";
            // 
            // shadeToolStripMenuItem
            // 
            this.shadeToolStripMenuItem.Name = "shadeToolStripMenuItem";
            this.shadeToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.shadeToolStripMenuItem.Text = "形状视图";
            this.shadeToolStripMenuItem.Click += new System.EventHandler(this.shadeToolStripMenuItem_Click);
            // 
            // shadeWithEdgeToolStripMenuItem
            // 
            this.shadeWithEdgeToolStripMenuItem.Name = "shadeWithEdgeToolStripMenuItem";
            this.shadeWithEdgeToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.shadeWithEdgeToolStripMenuItem.Text = "线框视图";
            this.shadeWithEdgeToolStripMenuItem.Click += new System.EventHandler(this.shadeWithEdgeToolStripMenuItem_Click);
            // 
            // edgeWithPointsToolStripMenuItem
            // 
            this.edgeWithPointsToolStripMenuItem.Name = "edgeWithPointsToolStripMenuItem";
            this.edgeWithPointsToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.edgeWithPointsToolStripMenuItem.Text = "渲染视图";
            this.edgeWithPointsToolStripMenuItem.Click += new System.EventHandler(this.edgeWithPointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(207, 6);
            // 
            // orbitToolStripMenuItem
            // 
            this.orbitToolStripMenuItem.Name = "orbitToolStripMenuItem";
            this.orbitToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.orbitToolStripMenuItem.Text = "旋转操作";
            this.orbitToolStripMenuItem.Click += new System.EventHandler(this.orbitToolStripMenuItem_Click);
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.panToolStripMenuItem.Text = "平移操作";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(207, 6);
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.showGridToolStripMenuItem.Text = "基准线显示";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(207, 6);
            // 
            // stdViewToolStripMenuItem
            // 
            this.stdViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.frontToolStripMenuItem});
            this.stdViewToolStripMenuItem.Name = "stdViewToolStripMenuItem";
            this.stdViewToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.stdViewToolStripMenuItem.Text = "视角转换";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.topToolStripMenuItem.Text = "俯视图";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // frontToolStripMenuItem
            // 
            this.frontToolStripMenuItem.Name = "frontToolStripMenuItem";
            this.frontToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.frontToolStripMenuItem.Text = "正视图";
            this.frontToolStripMenuItem.Click += new System.EventHandler(this.frontToolStripMenuItem_Click);
            // 
            // 清除视图ToolStripMenuItem
            // 
            this.清除视图ToolStripMenuItem.Name = "清除视图ToolStripMenuItem";
            this.清除视图ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.清除视图ToolStripMenuItem.Text = "清除视图";
            this.清除视图ToolStripMenuItem.Click += new System.EventHandler(this.清除视图ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 522);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::AnyCAD.Basic.Properties.Resources.alone_back_view_beautiful_674268;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1198, 522);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.Text = "LIUHAO.3D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadeWithEdgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeWithPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem orbitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stdViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTEPToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 清除视图ToolStripMenuItem;
    }
}

