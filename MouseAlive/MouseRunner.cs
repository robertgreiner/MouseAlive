using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MouseAlive {
    public class MouseRunner {

        public void Start() {
            TimerCallback tcb = MoveMouse;
            Timer stateTimer = new Timer(tcb, null, TimeSpan.Zero, TimeSpan.FromMinutes(5));
        }

        public void MoveMouse(Object state) {
            MouseUtilities.MoveMouse();
            MouseUtilities.MoveMouseBack();
        }
    }
}
