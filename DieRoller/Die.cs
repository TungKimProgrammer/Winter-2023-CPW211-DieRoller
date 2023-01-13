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
        /// Creates the die and rools it to start with a random number
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The Current Face up value of die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rools the die and set the <see cref="FaceValue"/> to the new number
        /// </summary>
        /// <returns> Returns the new random number</returns>
        public byte Roll() {
            // Generate random number
            Random random = new ();
            byte newValue = (byte)random.Next(1, 7);

            // Set to FaceValue
            FaceValue = newValue;

            return FaceValue;
        }
    }
}
