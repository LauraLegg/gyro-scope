using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Class representing a Pisces Fish Dish
    /// </summary>
    public class PiscesFishDish
    {
        /// <summary>
        /// Read-only property that returns the price of the pisces fish dish
        /// </summary>
        public decimal Price => 5.99m;

        /// <summary>
        /// Read-only property that returns the total calories of the pisces fish dish
        /// </summary>
        public uint Calories => 726;

        /// <summary>
        /// Read-only property that returns the special instruction of the pisces fish dish
        /// </summary>
        public IEnumerable<string> SpecialInstructions => null;
    }
}
