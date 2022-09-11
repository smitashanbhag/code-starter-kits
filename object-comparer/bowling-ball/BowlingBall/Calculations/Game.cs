using BowlingBall.Helpers;
using BowlingBall.ICalculations;
using System.Collections.Generic;

namespace BowlingBall.Calculations
{
    /// <summary>
    /// The <see cref="Game"/> class.
    /// </summary>
    public class Game : IGame
    {
        // </inheritdoc>
        public int GetScore(IList<IFrame> frames)
        {
            return frames.CalculateFinalFramesScore();
        }
    }
}
