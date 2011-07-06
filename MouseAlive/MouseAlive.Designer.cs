namespace MouseAlive {
    partial class MouseAlive {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseAlive));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLabelBlog = new System.Windows.Forms.LinkLabel();
            this.IconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.IconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipTitle = "MouseAlive";
            this.NotifyIcon.ContextMenuStrip = this.IconContextMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Mouse Alive";
            this.NotifyIcon.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MouseAlive v 1.0 by Robert Greiner";
            // 
            // LinkLabelBlog
            // 
            this.LinkLabelBlog.AutoSize = true;
            this.LinkLabelBlog.Location = new System.Drawing.Point(36, 42);
            this.LinkLabelBlog.Name = "LinkLabelBlog";
            this.LinkLabelBlog.Size = new System.Drawing.Size(123, 13);
            this.LinkLabelBlog.TabIndex = 1;
            this.LinkLabelBlog.TabStop = true;
            this.LinkLabelBlog.Text = "http://creatingcode.com";
            // 
            // IconContextMenu
            // 
            this.IconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExit});
            this.IconContextMenu.Name = "IconContextMenu";
            this.IconContextMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(152, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MouseAlive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 77);
            this.Controls.Add(this.LinkLabelBlog);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MouseAlive";
            this.Text = "MouseAlive";
            this.Load += new System.EventHandler(this.MouseAlive_Load);
            this.SizeChanged += new System.EventHandler(this.MouseAlive_SizeChanged);
            this.IconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkLabelBlog;
        private System.Windows.Forms.ContextMenuStrip IconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
    }
}

