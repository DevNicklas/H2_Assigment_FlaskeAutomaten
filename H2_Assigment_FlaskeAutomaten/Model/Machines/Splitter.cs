using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using H2_Assigment_FlaskeAutomaten.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using H2_Assigment_FlaskeAutomaten.View;

namespace H2_Assigment_FlaskeAutomaten.Model.Machines
{
    internal class Splitter : Machine
    {
		private Conveyor _inputConveyor;
        private Conveyor[] _outputConveyor = new Conveyor[2];
        private readonly object _lockObject = new object(); // Lock object for thread safety
		private int sortingInterval = 500;

		internal Splitter(Conveyor inputConveyor, Conveyor[] outputConveyors, MachineBuffer buffer) : base(buffer)
        {
            _inputConveyor = inputConveyor;
            _outputConveyor = outputConveyors;
        }

		internal void Start() // Method to start the Splitter
		{
			while (true)
			{
				lock (_lockObject) // This is needed if there is more than 1 thread running the Splitter
				{
					GetInput();
					Thread.Sleep(sortingInterval);
					Sort();
					Thread.Sleep(sortingInterval);
				}
			}
		}

		private void GetInput() // Method to get input from the input conveyor
		{
			if (_inputConveyor.Inventory.Count > 0 && this.Inventory.Count < 10)
			{
				Beverage newBeverage = _inputConveyor.RemoveFromInventory(_inputConveyor.GetNextBeverage());
				if (newBeverage != null)
				{
					this.AddToInventory(newBeverage);
				}
			}
		}

		private void Sort() // Method to sort the beverages
		{
			Beverage beverage = GetNextBeverage();
			if (beverage != null)
			{
				switch (beverage)
				{
					case Soda soda:
						AddToOutputConveyor(soda, _outputConveyor[0]);
						break;
					case Beer beer:
						AddToOutputConveyor(beer, _outputConveyor[1]);
						break;
					default:
						AddToInventory(beverage); // unknown beverage back to inventory
						break;
				}
			}
		}
		private void AddToOutputConveyor(Beverage beverage, Conveyor output) // Method to add beverage to output conveyor
		{
			if (output == null) return;
			if (output.Inventory.Count < 10)
			{
				beverage = RemoveFromInventory(beverage);
				if (beverage != null)
				{
					output.AddToInventory(beverage);
				}
			}
		}
	}
}