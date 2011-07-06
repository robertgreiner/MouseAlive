using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace MouseAlive {
    public class MouseUtilities {
        public static System.Drawing.Point GetMousePosition() {
            return System.Windows.Forms.Control.MousePosition;
        }

        public static void MoveMouse() {
            Cursor.Position = new System.Drawing.Point(Cursor.Position.X + 1, Cursor.Position.Y);
        }

        public static void MoveMouseBack() {
            Cursor.Position = new System.Drawing.Point(Cursor.Position.X - 1, Cursor.Position.Y);
        }
    }
}
