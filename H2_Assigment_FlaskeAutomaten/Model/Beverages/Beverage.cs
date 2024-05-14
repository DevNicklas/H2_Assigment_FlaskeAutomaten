using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Beverages
{
    public abstract class Beverage
    {
        private string _name;

        protected Beverage(string name) 
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
