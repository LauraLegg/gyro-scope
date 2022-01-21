using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Class representing a Leo Lamb Gyro
    /// </summary>
    public class LeoLambGyro
    {
        /// <summary>
        /// Property indicating what kind of meat this Gyro is prepared with. It is default to Lamb.
        /// </summary>
        public DonerMeat Meat { get; set; } = DonerMeat.Lamb;

        /// <summary>
        /// Property indicating if this gyro should be served with a pita bread wrap. It should default to true.
        /// </summary>
        public bool Pita { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with tomato. It should default to true.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with onion. It should default to true.
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with eggplant. It should default to true.
        /// </summary>
        public bool Eggplant { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with lettuce. It should default to true.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with mint chutney. It should default to true.
        /// </summary>
        public bool MintChutney { get; set; } = true;

        //---------------------------------------------------------------------------------------------------
        /// <summary>
        /// Property indicating this gyro should be served with tzatziki sauce. It should default to false.
        /// </summary>
        public bool Tzatziki { get; set; } = false;

        /// <summary>
        /// Property  indicating this gyro should be served with peppers. It should default to false.
        /// </summary>
        public bool Peppers { get; set; } = false;

        /// <summary>
        /// Property indicating this gyro should be served with wing sauce. It should default to false.
        /// </summary>
        public bool WingSauce { get; set; } = false;
        //---------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read-only property that returns the price of the leo lamb gyro
        /// </summary>
        public decimal Price => 5.75m;

        /// <summary>
        /// Read-only property that returns the total calories of the leo lamb gyro
        /// </summary>
        public uint Calories
        {
            get
            {
                // Total calories
                uint _cal = 0;

                // Adds appropriate calories for the selected meat
                _cal += Meat switch
                {
                    (DonerMeat.Beef) => 181,
                    (DonerMeat.Chicken) => 113,
                    (DonerMeat.Lamb) => 151,
                    (DonerMeat.Pork) => 187,
                    _ => 151,
                };

                // If an item is included, then it's calories are added to _cal
                if (Pita) _cal += 262;
                if (Tomato) _cal += 30;
                if (Onion) _cal += 30;
                if (Lettuce) _cal += 54;
                if (Eggplant) _cal += 47;
                if (MintChutney) _cal += 10;

                if (Tzatziki) _cal += 30;
                if (Peppers) _cal += 33;
                if (WingSauce) _cal += 15;

                return _cal;
            }
        }

        /// <summary>
        /// Read-only property that returns the special instruction of the leo lamb gyro
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<string> instr = default;

                // If meat is anything other than Lamb, add "Use [meat]"
                switch (Meat)
                {
                    case (DonerMeat.Beef): instr.Add("Use Beef");
                        break;
                    case (DonerMeat.Chicken): instr.Add("Use Chicken");
                        break;
                    case (DonerMeat.Pork): instr.Add("Use Pork");
                        break;
                }

                // If any ingredient is not true, add "Hold [ingredient]"
                if (!Pita) instr.Add("Hold Pita");
                if (!Tomato) instr.Add("Hold Tomato");
                if (!Onion) instr.Add("Hold Onion");
                if (!Lettuce) instr.Add("Hold Lettuce");
                if (!Eggplant) instr.Add("Hold Eggplant");
                if (!MintChutney) instr.Add("Hold Mint Chuntney");

                // If any ingredient are added, add "Add [ingredient]"
                if (Tzatziki) instr.Add("Add Tzatziki");
                if (Peppers) instr.Add("Add Peppers");
                if (WingSauce) instr.Add("Add Wing Sauce");

                return instr;
            }
        }

    }
}
