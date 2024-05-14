using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Beverages
{
    internal class Beer : Beverage
    {
        private float _alchohol;

        public Beer(float alchohol) : base("Jack & Beer")
        {
            _alchohol = alchohol;
        }

        public float Alchohol
        {
            get
            {
                return _alchohol;
            }
        }
    }
}
