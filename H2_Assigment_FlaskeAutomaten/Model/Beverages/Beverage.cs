using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Beverages
{
    internal abstract class Beverage
    {
        private string _name;

        protected Beverage(string name) 
        {
            _name = name;
        }

        internal string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
