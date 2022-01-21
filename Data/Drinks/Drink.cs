using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// A base class for all sides sold at GyroScope
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// The price of the side
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }
    }
}
