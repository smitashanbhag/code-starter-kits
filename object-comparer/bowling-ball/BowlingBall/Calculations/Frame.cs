using BowlingBall.Helpers;
using BowlingBall.ICalculations;
using System.Linq;
using static BowlingBall.Helpers.Enumerations;

namespace BowlingBall.Calculations
{
    /// <summary>
    /// The <see cref="Frame"/> class.
    /// </summary>
    public class Frame : IFrame
    {
        // </inheritdoc>
        public int[] Pins { get; set; }

        // </inheritdoc>
        public int FrameScore { get { return Pins.Sum(); } }

        // </inheritdoc>
        public State FrameState
        {
            get
            {
                if (this.Pins.Length == Constants.StrikeTurns && this.Pins[0] == Constants.MaxScore)
                    return State.Strike;
                else if (this.Pins.Length == Constants.SpareTurns && FrameScore == Constants.MaxScore)
                    return State.Spare;
                else
                    return State.None;
            }
        }
    }
}
