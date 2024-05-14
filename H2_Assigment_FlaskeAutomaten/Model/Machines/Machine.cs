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
		private List<Beverage> _inventory;

		public List<Beverage> Inventory
		{
			get { return _inventory; }
		}

		public Machine()
		{
			_inventory = new List<Beverage>();
		}

		public void AddToInventory(Beverage beverage)
		{
			_inventory.Add(beverage);
		}

		public void RemoveFromInventory(Beverage beverage)
		{
			_inventory.Remove(beverage);
		}
	}
}
