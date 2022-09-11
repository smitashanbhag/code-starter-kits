using BowlingBall.Calculations;
using BowlingBall.ICalculations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static BowlingBall.Helpers.Enumerations;

namespace BowlingBall.Tests
{
    /// <summary>
    /// The <see cref="FrameTests"/> class
    /// </summary>
    [TestClass]
    public class FrameTests
    {
        /// <summary>
        /// The <see cref="IFrame"/>.
        /// </summary>
        private IFrame frame;

        /// <summary>
        /// The <see cref="Initialize"/> method to initialize <see cref="Frame"/> object.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            frame = new Frame();
        }

        /// <summary>
        /// The <see cref="SetStrikeFramePinsTest"/> test method to check whether the strike pins are set.
        /// </summary>
        [TestMethod]
        public void SetStrikeFramePinsTest()
        {
            frame.Pins = new int[] { 10 };
            Assert.AreEqual(1, frame.Pins.Length);
        }

        /// <summary>
        /// The <see cref="SetSpareFramePinsTest"/> test method to check whether the spare pins are set.
        /// </summary>
        [TestMethod]
        public void SetSpareFramePinsTest()
        {
            frame.Pins = new int[] { 9, 1 };
            Assert.AreEqual(2, frame.Pins.Length);
        }

        /// <summary>
        /// The <see cref="SetNormalFramePinsTest"/> test method to check whether the normal pins are set.
        /// </summary>
        [TestMethod]
        public void SetNormalFramePinsTest()
        {
            frame.Pins = new int[] { 7, 1 };
            Assert.AreEqual(2, frame.Pins.Length);
        }

        /// <summary>
        /// The <see cref="StrikeStateFrameTest"/> test method to check the strike state.
        /// </summary>
        [TestMethod]
        public void StrikeStateFrameTest()
        {
            frame.Pins = new int[] { 10 };
            Assert.AreEqual(State.Strike, frame.FrameState);
        }

        /// <summary>
        /// The <see cref="SpareStateFrameTest"/> test method to check the spare state.
        /// </summary>
        [TestMethod]
        public void SpareStateFrameTest()
        {
            frame.Pins = new int[] { 9, 1 };
            Assert.AreEqual(State.Spare, frame.FrameState);
        }

        /// <summary>
        /// The <see cref="NormalStateFrameTest"/> test method to check the normal state.
        /// </summary>
        [TestMethod]
        public void NormalStateFrameTest()
        {
            frame.Pins = new int[] { 1, 1 };
            Assert.AreEqual(State.None, frame.FrameState);
        }

        /// <summary>
        /// The <see cref="NormalStateScoreFrameTest"/> test method to check the normal state score.
        /// </summary>
        [TestMethod]
        public void NormalStateScoreFrameTest()
        {
            frame.Pins = new int[] { 1, 1 };
            Assert.AreEqual(2, frame.FrameScore);
        }

        /// <summary>
        /// The <see cref="StrikeStateScoreFrameTest"/> test method to check the strike state score.
        /// </summary>
        [TestMethod]
        public void StrikeStateScoreFrameTest()
        {
            frame.Pins = new int[] { 10 };
            Assert.AreEqual(10, frame.FrameScore);
        }

        /// <summary>
        /// The <see cref="SpareStateScoreFrameTest"/> test method to check the spare state score.
        /// </summary>
        [TestMethod]
        public void SpareStateScoreFrameTest()
        {
            frame.Pins = new int[] { 9, 1 };
            Assert.AreEqual(10, frame.FrameScore);
        }
    }
}
