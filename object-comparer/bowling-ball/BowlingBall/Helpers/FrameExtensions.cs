using BowlingBall.ICalculations;
using System.Collections.Generic;
using static BowlingBall.Helpers.Enumerations;

namespace BowlingBall.Helpers
{
    /// <summary>
    /// The <see cref="FrameExtensions"/> class.
    /// </summary>
    public static class FrameExtensions
    {
        /// <summary>
        /// The <see cref="CalculateFinalFramesScore"/> method calculates the total score for all the frames.
        /// </summary>
        /// <param name="frames">The frames.</param>
        /// <returns>The total score.</returns>
        public static int CalculateFinalFramesScore(this IList<IFrame> frames)
        {
            int totalBonus = 0;
            int totalPins = 0;
            for (int i = 0; i < frames.Count; i++)
            {
                if (i != Constants.MaxFrames - 1)
                {
                    totalBonus += CalculateCurrentFrameBonus(i, frames);
                }

                totalPins += frames[i].FrameScore;
            }

            return totalBonus + totalPins;
        }

        /// <summary>
        /// The <see cref="CalculateCurrentFrameBonus"/> method calculates bonuses for a specific frame.
        /// </summary>
        /// <param name="currentFrameIndex">The specific frame index.</param>
        /// <param name="frames">The frames.</param>
        /// <returns>The calculated bonus.</returns>
        private static int CalculateCurrentFrameBonus(int currentFrameIndex, IList<IFrame> frames)
        {
            var currentFrame = frames[currentFrameIndex];
            if (currentFrame.FrameState == State.Strike)
            {
                var nextFrameToCurrent = frames[currentFrameIndex + 1];
                if (nextFrameToCurrent.FrameState == State.Strike)
                {
                    return nextFrameToCurrent.FrameScore + frames[currentFrameIndex + 2].Pins[0];
                }

                return nextFrameToCurrent.FrameScore;
            }
            else if (currentFrame.FrameState == State.Spare)
            {
                return frames[currentFrameIndex + 1].Pins[0];
            }

            return default;
        }
    }
}
