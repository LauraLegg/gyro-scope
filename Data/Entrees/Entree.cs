using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A base class for all entrees sold at GyroScope
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions of the entree
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }
    }
}
