namespace purchageIns
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴1ToolStripMenuItem,
            this.통계1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴1ToolStripMenuItem
            // 
            this.메뉴1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴2ToolStripMenuItem,
            this.메뉴3ToolStripMenuItem});
            this.메뉴1ToolStripMenuItem.Name = "메뉴1ToolStripMenuItem";
            this.메뉴1ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.메뉴1ToolStripMenuItem.Text = "메뉴1";
            // 
            // 메뉴2ToolStripMenuItem
            // 
            this.메뉴2ToolStripMenuItem.Name = "메뉴2ToolStripMenuItem";
            this.메뉴2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.메뉴2ToolStripMenuItem.Text = "메뉴2";
            // 
            // 메뉴3ToolStripMenuItem
            // 
            this.메뉴3ToolStripMenuItem.Name = "메뉴3ToolStripMenuItem";
            this.메뉴3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.메뉴3ToolStripMenuItem.Text = "메뉴3";
            // 
            // 통계1ToolStripMenuItem
            // 
            this.통계1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.통계2ToolStripMenuItem});
            this.통계1ToolStripMenuItem.Name = "통계1ToolStripMenuItem";
            this.통계1ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.통계1ToolStripMenuItem.Text = "통계1";
            // 
            // 통계2ToolStripMenuItem
            // 
            this.통계2ToolStripMenuItem.Name = "통계2ToolStripMenuItem";
            this.통계2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.통계2ToolStripMenuItem.Text = "통계2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계2ToolStripMenuItem;
    }
}