using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Beverages
{
    /// <summary>
    /// Represents a soda beverage
    /// </summary>
    internal class Soda : Beverage
    {
        private float _sugar;

        /// <summary>
        /// Initializes a new instance of the Soda class with the specified sugar amount
        /// </summary>
        /// <param name="sugar">The sugar amount in the soda</param>
        internal Soda(float sugar) : base("Faxe kondi")
        {
            _sugar = sugar; 
        }

        /// <summary>
        /// Gets the sugar amount of the soda
        /// </summary>
        internal float Sugar
        {
            get
            {
                return _sugar;
            }
        }
    }
}
