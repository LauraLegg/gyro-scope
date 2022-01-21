using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Class representing a Scorpio Spicy Gyro
    /// </summary>
    public class ScorpioSpicyGyro
    {
        /// <summary>
        /// Property indicating what kind of meat this Gyro is prepared with. It is default to chicken.
        /// </summary>
        public DonerMeat Meat { get; set; } = DonerMeat.Chicken;

        /// <summary>
        /// Property indicating if this gyro should be served with a pita bread wrap. It should default to true.
        /// </summary>
        public bool Pita { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with peppers. It should default to true.
        /// </summary>
        public bool Peppers { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with onion. It should default to true.
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Property indicating if this gyro should be served with lettuce. It should default to true.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Property indicating this gyro should be served with wing sauce. It should default to true.
        /// </summary>
        public bool WingSauce { get; set; } = true;

        //---------------------------------------------------------------------------------------------------
        /// <summary>
        /// Property  indicating this gyro should be served with tomato. It should default to false.
        /// </summary>
        public bool Tomato { get; set; } = false;

        /// <summary>
        /// Property indicating this gyro should be served with tzatziki sauce. It should default to false.
        /// </summary>
        public bool Tzatziki { get; set; } = false;

        /// <summary>
        /// Property indicating this gyro should be served with eggplant. It should default to false.
        /// </summary>
        public bool Eggplant { get; set; } = false;

        /// <summary>
        /// Property indicating this gyro should be served with mint chutney. It should default to false.
        /// </summary>
        public bool MintChutney { get; set; } = false;
        //---------------------------------------------------------------------------------------------------

        /// <summary>
        /// Read-only property that returns the price of the scorpio spicy gyro
        /// </summary>
        public decimal Price => 6.20m;

        /// <summary>
        /// Read-only property that returns the total calories of the scorpio spicy gyro
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
                if (Peppers) _cal += 33;
                if (Onion) _cal += 30;
                if (Lettuce) _cal += 54;
                if (WingSauce) _cal += 15;

                if (Tomato) _cal += 30;
                if (Tzatziki) _cal += 30;
                if (Eggplant) _cal += 47;
                if (MintChutney) _cal += 10;

                return _cal;
            }
        }

        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<string> instr = default;

                // If meat is anything other than Chicken, add "Use [meat]"
                switch (Meat)
                {
                    case (DonerMeat.Beef):
                        instr.Add("Use Beef");
                        break;
                    case (DonerMeat.Lamb):
                        instr.Add("Use Lamb");
                        break;
                    case (DonerMeat.Pork):
                        instr.Add("Use Pork");
                        break;
                }

                // If any ingredient is not true, add "Hold [ingredient]"
                if (!Pita) instr.Add("Hold Pita");
                if (!Peppers) instr.Add("Hold Peppers");
                if (!Onion) instr.Add("Hold Onion");
                if (!Lettuce) instr.Add("Hold Lettuce");
                if (!WingSauce) instr.Add("Hold Wing Sauce");

                // If any ingredient are added, add "Add [ingredient]"
                if (Tomato) instr.Add("Add Tomato");
                if (Tzatziki) instr.Add("Add Tzatziki");
                if (Eggplant) instr.Add("Add Eggplant");
                if (MintChutney) instr.Add("Add Mint Chutney");

                return instr;
            }
        }

    }
}
