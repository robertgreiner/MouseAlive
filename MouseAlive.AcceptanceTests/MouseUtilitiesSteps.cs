using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Drawing;

namespace MouseAlive.AcceptanceTests {
    [Binding]
    public class MouseUtilitiesSteps {
        
        private Point point;

        [Given("I am working on a machine with MouseAlive")]
        public void GivenIAmWorkingOnAMachineWithMouseAlive() {
            point = MouseUtilities.GetMousePosition();
        }

        [When("a certain amount of time has elapsed")]
        public void WhenIAmAwayFromMyDesk() {
            var oldPoint = point;
            MouseUtilities.MoveMouse();
           
        }

        [Then("the mouse should move automatically")]
        public void ThenTheMouseShouldMoveAutomaticallyOverATimeInterval() {
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreNotEqual(point, newPoint);
        }
    }
}
