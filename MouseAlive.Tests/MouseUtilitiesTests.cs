using NUnit.Framework;
using System.Drawing;

namespace MouseAlive.Tests {

    [TestFixture]
    class MouseUtilitiesTests {

        private Point point;

        [SetUp]
        public void SetUp() {
            point = MouseUtilities.GetMousePosition();
        }

        [Test]
        public void CurrentMousePositionIsNotNull() {
            Assert.IsNotNull(point);
        }

        [Test]
        public void CurrentMousePositionCoordinatesAreNotNegative() {
            Assert.IsTrue(point.X > 0);
            Assert.IsTrue(point.Y > 0);
        }

        [Test]
        public void NewMousePositionDoesNotEqualOldMousePositionAfterMouseMove() {
            var oldPoint = point;
            MouseUtilities.MoveMouse();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreNotEqual(oldPoint, newPoint);
        }

        [Test]
        public void NewMouseXPositionIsOneGreaterThanOldMouseXPosition() {
            var oldPoint = point;
            MouseUtilities.MoveMouse();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreEqual(oldPoint.X + 1, newPoint.X);
        }

        [Test]
        public void NewMouseYPositionIsEqualToTheOldMouseYPosition() {
            var oldPoint = point;
            MouseUtilities.MoveMouse();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreEqual(oldPoint.Y, newPoint.Y);
        }

        [Test]
        public void NewMouseCoordinatesAreEqualToTheOldMouseCoordinatesOnMoveBack() {
            var oldPoint = point;
            MouseUtilities.MoveMouse();
            MouseUtilities.MoveMouseBack();
            var newPoint = MouseUtilities.GetMousePosition();
            Assert.AreEqual(oldPoint, newPoint);
        }
    }
}
