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
		private MachineBuffer _buffer;
		private const int MAX_BEVERAGE = 10;

		internal List<Beverage> Inventory
		{
			get { return _inventory; }
		}

		internal Machine(MachineBuffer buffer)
		{
			_buffer = buffer;
			_inventory = new List<Beverage>();
		}

		internal bool AddToInventory(Beverage beverage)
		{
			if (_inventory.Count < MAX_BEVERAGE)
			{
				_inventory.Add(beverage);
				_buffer.AddBeverage(beverage);
				return true;
			}
			return false;

		}

		internal Beverage GetNextBeverage() => _inventory.FirstOrDefault();

		internal Beverage RemoveFromInventory(Beverage beverage)
        {
            if (beverage != null)
			{
				_inventory.Remove(beverage);
				_buffer.RemoveBeverage(beverage);
				return beverage;
			} 
			return null;
        }
    }
}
