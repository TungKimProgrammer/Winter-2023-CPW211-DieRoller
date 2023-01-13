using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// represents a single six-sided die (1-6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The Current Face up value of die
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rools the die and set the <see cref="FaceValue"/> to the new number
        /// </summary>
        /// <returns> Returns the new random number</returns>
        public byte Roll() {
            throw new NotImplementedException();
        }
    }
}
