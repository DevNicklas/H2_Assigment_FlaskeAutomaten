using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Machines
{
    public abstract class Machine
    {
        private Beverage[] _inventory;

        public Beverage[] Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public void AddToInventory(Beverage beverage)
        {

        }

        public void RemoveFromInventory(Beverage beverage)
        {

        }
    }
}
