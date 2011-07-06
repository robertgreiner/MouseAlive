using NUnit.Framework;
using System.Drawing;

namespace MouseAlive.Tests {

    [TestFixture]
    class MouseUtilitiesTests {

        [SetUp]
        public void SetUp() {

        }

        [Test]
        public void CurrentMousePositionIsNotNull() {
            var point = MouseUtilities.GetMousePosition();
            Assert.IsNotNull(point);
        }

        [Test]
        public void CurrentMousePositionCoordinatesAreNotNegative() {
            var point = MouseUtilities.GetMousePosition();
            Assert.IsTrue(point.X > 0);
            Assert.IsTrue(point.Y > 0);
        }

        [Test]
        public void NewMousePositionDoesNotEqualOldMousePositionAfterMouseMove() {
            var oldPoint = MouseUtilities.GetMousePosition();
            MouseUtilities.MoveMouse();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreNotEqual(oldPoint, newPoint);
        }

        [Test]
        public void NewMouseXPositionIsOneGreaterThanOldMouseXPosition() {
            var oldPoint = MouseUtilities.GetMousePosition();
            MouseUtilities.MoveMouse();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreEqual(oldPoint.X + 1, newPoint.X);
        }

        [Test]
        public void NewMouseYPositionIsEqualToTheOldMouseYPosition() {
            var oldPoint = MouseUtilities.GetMousePosition();
            MouseUtilities.MoveMouse();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreEqual(oldPoint.Y, newPoint.Y);
        }

        [Test]
        public void NewMouseCoordinatesAreEqualToTheOldMouseCoordinatesOnMoveBack() {
            var oldPoint = MouseUtilities.GetMousePosition();
            MouseUtilities.MoveMouse();
            MouseUtilities.MoveMouseBack();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreEqual(oldPoint, newPoint);
        }
    }
}
