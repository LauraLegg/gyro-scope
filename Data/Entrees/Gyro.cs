using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    public abstract class Gyro, Entree
    {

        /// <summary>
        /// Property indicating what kind of meat this Gyro is prepared with.
        /// </summary>
        public DonerMeat Meat { get; set; }

        /// <summary>
        /// Property indicating if this gyro should be served with a pita bread wrap.
        /// </summary>
        public bool Pita { get; set; }

        /// <summary>
        /// Property indicating if this gyro should be served with tomato.
        /// </summary>
        public bool Tomato { get; set; }

        /// <summary>
        /// Property indicating if this gyro should be served with onion.
        /// </summary>
        public bool Onion { get; set; }

        /// <summary>
        /// Property indicating if this gyro should be served with eggplant.
        /// </summary>
        public bool Eggplant { get; set; }

        /// <summary>
        /// Property indicating if this gyro should be served with lettuce.
        /// </summary>
        public bool Lettuce { get; set; }

        /// <summary>
        /// Property indicating if this gyro should be served with mint chutney.
        /// </summary>
        public bool MintChutney { get; set; }

        /// <summary>
        /// Property indicating this gyro should be served with tzatziki sauce.
        /// </summary>
        public bool Tzatziki { get; set; }

        /// <summary>
        /// Property  indicating this gyro should be served with peppers.
        /// </summary>
        public bool Peppers { get; set; }

        /// <summary>
        /// Property indicating this gyro should be served with wing sauce. It should default to false.
        /// </summary>
        public bool WingSauce { get; set; }
    }
}
