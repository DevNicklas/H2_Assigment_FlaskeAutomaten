using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2_Assigment_FlaskeAutomaten.View;

namespace H2_Assigment_FlaskeAutomaten.Model.Machines
{
	/// <summary>
	/// Represents an abstract base class
	/// </summary>
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


		/// <summary>
		/// Adds a beverage to the inventory if there is space available.
		/// </summary>
		/// <param name="beverage">The beverage to add.</param>
		/// <returns>True if the beverage was added successfully, false otherwise.</returns>
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

		/// <summary>
		/// Retrieves the next beverage from the inventory.
		/// </summary>
		/// <returns>The next beverage in the inventory, or null if the inventory is empty.</returns>
		internal Beverage GetNextBeverage() => _inventory.FirstOrDefault();

		/// <summary>
		/// Removes a beverage from the inventory and updates the UI buffer.
		/// </summary>
		/// <param name="beverage">The beverage to remove.</param>
		/// <returns>The removed beverage, or null if the specified beverage is null or not found in the inventory.</returns>
		internal Beverage RemoveFromInventory(Beverage beverage)
        {
            if (beverage != null)
			{
				_inventory.Remove(beverage); // Remove the beverage from the inventory
				_buffer.RemoveBeverage(beverage);
				return beverage;
			} 
			return null;
        }
    }
}
