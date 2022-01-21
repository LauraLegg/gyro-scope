using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// Class representing a Sagittarius Greek Salad
    /// </summary>
    public class SagittariusGreekSalad
    {
        /// <summary>
        /// Property indicating how large the serving of greek salad is.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Read-only property that returns the price of greek salad based on size.
        /// </summary>
        public decimal Price
        {
            get
            {
                return Size switch
                {
                    (Size.Small) => 2.00m,
                    (Size.Medium) => 2.50m,
                    (Size.Large) => 3.00m,
                    _ => throw new NotImplementedException(),
                };
            }
        }

        /// <summary>
        /// Read-only property that returns the calories of greek salad based on size.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Size switch
                {
                    (Size.Small) => 180,
                    (Size.Medium) => 270,
                    (Size.Large) => 360,
                    _ => throw new NotImplementedException(),
                };
            }
        }
    }
}
