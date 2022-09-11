using System.Collections.Generic;

namespace BowlingBall.ICalculations
{
    /// <summary>
    /// The <see cref="IGame"/> interface.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// This method get total score for the balling frames.
        /// </summary>
        /// <param name="frames">The frames.</param>
        /// <returns>Calculated score as integer.</returns>
        int GetScore(IList<IFrame> frames);
    }
}
