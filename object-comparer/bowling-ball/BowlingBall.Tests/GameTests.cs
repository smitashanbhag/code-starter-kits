using BowlingBall.Calculations;
using BowlingBall.ICalculations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BowlingBall.Tests
{
    /// <summary>
    /// The <see cref="GameTests"/> class
    /// </summary>
    [TestClass]
    public class GameTests
    {
        /// <summary>
        /// The <see cref="IGame"/>.
        /// </summary>
        IGame game;

        /// <summary>
        /// The <see cref="Initialize"/> method to initialize <see cref="Game"/> object.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            game = new Game();
        }

        /// <summary>
        /// The <see cref="GameScoreForMixFrames"/> test method.
        /// </summary>
        [TestMethod]
        public void GameScoreForMixFrames()
        {
            var frames = GetMixFrames();
            Assert.AreEqual(187, game.GetScore(frames));
        }

        /// <summary>
        /// The <see cref="GameScoreForAllStrikeFrames"/> test method.
        /// </summary>
        [TestMethod]
        public void GameScoreForAllStrikeFrames()
        {
            var frames = GetStrikeFrames();
            Assert.AreEqual(290, game.GetScore(frames));
        }

        /// <summary>
        /// The <see cref="GameScoreForAllSpareFrames"/> test method.
        /// </summary>
        [TestMethod]
        public void GameScoreForAllSpareFrames()
        {
            var frames = GetSpareFrames();
            Assert.AreEqual(162, game.GetScore(frames));
        }

        /// <summary>
        /// The <see cref="GameScoreForNonStrikeAndNonSpareFrames"/> test method.
        /// </summary>
        [TestMethod]
        public void GameScoreForNonStrikeAndNonSpareFrames()
        {
            var frames = GetNonStrikeAndNonSpareFrames();
            Assert.AreEqual(20, game.GetScore(frames));
        }

        /// <summary>
        /// The <see cref="GetNonStrikeAndNonSpareFrames"/> method to get mock frames.
        /// </summary>
        /// <returns>The <see cref="IFrame"/> list.</returns>
        private IList<IFrame> GetNonStrikeAndNonSpareFrames()
        {
            var frames = new List<IFrame>
            {
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } },
                new Frame() { Pins = new int[] { 1 } }
            };
            return frames;
        }

        /// <summary>
        /// The <see cref="GetStrikeFrames"/> method to get mock frames.
        /// </summary>
        /// <returns>The <see cref="IFrame"/> list.</returns>
        private IList<IFrame> GetStrikeFrames()
        {
            var frames = new List<IFrame>
            {
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10, 10 } }
            };
            return frames;
        }

        /// <summary>
        /// The <see cref="GetSpareFrames"/> method to get mock frames.
        /// </summary>
        /// <returns>The <see cref="IFrame"/> list.</returns>
        private IList<IFrame> GetSpareFrames()
        {
            var frames = new List<IFrame>
            {
                new Frame() { Pins = new int[] { 9, 1 } },
                new Frame() { Pins = new int[] { 5, 5 } },
                new Frame() { Pins = new int[] { 9, 1 } },
                new Frame() { Pins = new int[] { 1, 9 } },
                new Frame() { Pins = new int[] { 7, 3 } },
                new Frame() { Pins = new int[] { 8, 2 } },
                new Frame() { Pins = new int[] { 4, 6 } },
                new Frame() { Pins = new int[] { 9, 1 } },
                new Frame() { Pins = new int[] { 9, 1 } },
                new Frame() { Pins = new int[] { 5, 5, 5 } }
            };
            return frames;
        }

        /// <summary>
        /// The <see cref="GetMixFrames"/> method to get mock frames.
        /// </summary>
        /// <returns>The <see cref="IFrame"/> list.</returns>
        private IList<IFrame> GetMixFrames()
        {
            var frames = new List<IFrame>
            {
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 9, 1 } },
                new Frame() { Pins = new int[] { 5, 5 } },
                new Frame() { Pins = new int[] { 7, 2 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 10 } },
                new Frame() { Pins = new int[] { 9, 0 } },
                new Frame() { Pins = new int[] { 8, 2 } },
                new Frame() { Pins = new int[] { 9, 1, 10 } }
            };
            return frames;
        }
    }
}
