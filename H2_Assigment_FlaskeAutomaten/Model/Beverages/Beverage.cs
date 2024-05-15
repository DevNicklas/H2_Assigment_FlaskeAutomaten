using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Beverages
{
    /// <summary>
    /// Represents an beverage
    /// </summary>
    internal abstract class Beverage
    {
        private string _name;

        /// <summary>
        /// Initializes a new instance of the Beverage class with the specified name
        /// </summary>
        /// <param name="name">The name of the beverage</param>
        protected Beverage(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets the name of the beverage
        /// </summary>
        internal string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
