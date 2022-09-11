using static BowlingBall.Helpers.Enumerations;

namespace BowlingBall.ICalculations
{
    /// <summary>
    /// The <see cref="IFrame"/> interface.
    /// </summary>
    public interface IFrame
    {
        /// <summary>
        /// The <see cref="Pins"/>.
        /// </summary>
        int[] Pins { get; set; }

        /// <summary>
        /// The <see cref="FrameScore"/>.
        /// </summary>
        int FrameScore { get; }

        /// <summary>
        /// The <see cref="FrameState"/>.
        /// </summary>
        State FrameState { get; }
    }
}
