using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Beverages
{
    internal class Soda : Beverage
    {
        private float _sugar;

        public Soda(float sugar) : base("Faxe kondi")
        {
            _sugar = sugar;
        }

        public float Sugar
        {
            get
            {
                return _sugar;
            }
        }
    }
}
