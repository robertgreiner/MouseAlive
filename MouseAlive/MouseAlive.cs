using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseAlive {
    public partial class MouseAlive : Form {
        public MouseAlive() {
            InitializeComponent();
        }

        private void MouseAlive_SizeChanged(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                minimizeToTray();
            }
        }

        private void MouseAlive_Load(object sender, EventArgs e) {
            minimizeToTray();
        }

        private void minimizeToTray() {
            NotifyIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void MenuItemExit_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
