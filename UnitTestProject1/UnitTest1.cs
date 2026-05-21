using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.Drawing;

namespace BallMovementTests
{
    [TestClass]
    public class CoreLogicTests
    {
        [TestMethod]
        public void Test_RadiusReduction_BasedOnWeight()
        {
            Form1 mainForm = new Form1();
            mainForm.weight = 5;
            mainForm.currentRadius = 40f;

            float reduction = (11 - mainForm.weight) * 0.5f;
            mainForm.currentRadius -= reduction;

            Assert.AreEqual(37f, mainForm.currentRadius, 0.001f);
        }

        [TestMethod]
        public void Test_MinimumRadius_StopCondition()
        {
            Form1 mainForm = new Form1();
            mainForm.minRadius = 10f;
            mainForm.currentRadius = 12f;
            mainForm.weight = 7;

            float reduction = (11 - mainForm.weight) * 0.5f;
            mainForm.currentRadius -= reduction;

            bool isMinReached = mainForm.currentRadius <= mainForm.minRadius;
            Assert.IsTrue(isMinReached);
        }

        [TestMethod]
        public void Test_ColorSelection_BasedOnDirection()
        {
            Form1 mainForm = new Form1();
            mainForm.color1 = Color.Red;
            mainForm.color2 = Color.Blue;
            mainForm.isMovingForward = true;

            mainForm.isMovingForward = !mainForm.isMovingForward;

            Color currentColor = mainForm.isMovingForward ? mainForm.color1 : mainForm.color2;

            Assert.AreEqual(Color.Blue, currentColor);
        }
    }
}
