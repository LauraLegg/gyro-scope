using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// Class representing a Gemini Stuffed Grape Leaf
    /// </summary>
    public class GeminiStuffedGrapeLeaves
    {
        /// <summary>
        /// Property indicating how large the serving of stuffed graped leaves is.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Read-only property that returns the price of stuffed grape leaves based on size.
        /// </summary>
        public decimal Price
        {
            get
            {
                return Size switch
                {
                    (Size.Small) => 1.50m,
                    (Size.Medium) => 2.00m,
                    (Size.Large) => 2.50m,
                    _ => throw new NotImplementedException(),
                };
            }
        }

        /// <summary>
        /// Read-only property that returns the calories of stuffed grape leaves based on size.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Size switch
                {
                    (Size.Small) => 360,
                    (Size.Medium) => 540,
                    (Size.Large) => 720,
                    _ => throw new NotImplementedException(),
                };
            }
        }
    }
}
