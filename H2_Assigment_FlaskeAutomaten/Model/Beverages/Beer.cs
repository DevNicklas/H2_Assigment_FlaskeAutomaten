using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Beverages
{
    /// <summary>
    /// Represents a beer beverage
    /// </summary>
    internal class Beer : Beverage
    {
        private float _alchohol;

        /// <summary>
        /// Initializes a new instance of the Beer class with the specified alcohol content
        /// </summary>
        /// <param name="alchohol">The alcohol content of the beer</param>
        internal Beer(float alchohol) : base("Jack & Beer")
        {
            _alchohol = alchohol;
        }

        /// <summary>
        /// Gets the alcohol content of the beer
        /// </summary>
        internal float Alchohol
        {
            get
            {
                return _alchohol;
            }
        }
    }
}
