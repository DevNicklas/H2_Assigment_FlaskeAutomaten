using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2_Assigment_FlaskeAutomaten.View;

namespace H2_Assigment_FlaskeAutomaten.Model.Machines
{
	public abstract class Machine
	{
		private List<Beverage> _inventory;
		private ConveyorBuffer _buffer;


		public List<Beverage> Inventory
		{
			get { return _inventory; }
		}

		public Machine(ConveyorBuffer buffer)
		{
			buffer = _buffer;
			_inventory = new List<Beverage>();
		}

		public void AddToInventory(Beverage beverage)
		{
			_inventory.Add(beverage);
			_buffer.AddBeverage(beverage);
		}

        public Beverage RemoveFromInventory()
        {
            Beverage beverage = _inventory.FirstOrDefault();
            if (beverage != null)
			{
				_inventory.Remove(beverage);
				_buffer.RemoveBeverage(beverage);
			} 
            return beverage;
        }
    }
}
