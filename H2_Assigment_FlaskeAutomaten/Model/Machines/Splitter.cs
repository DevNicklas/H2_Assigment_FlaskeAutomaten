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

		internal Splitter(Conveyor inputConveyor, Conveyor[] outputConveyors, MachineBuffer buffer) : base(buffer)
        {
            _inputConveyor = inputConveyor;
            _outputConveyor = outputConveyors;
        }

		internal void Start()
        {
            while (true)
            {
                lock (_lockObject) // This is needed if there is more than 1 thread running the Splitter
                {
                    if (_inputConveyor.Inventory.Count > 0)
                    {
                        Beverage newBeverage = _inputConveyor.RemoveFromInventory(_inputConveyor.GetNextBeverage());
						if (newBeverage != null)
                        {
							this.AddToInventory(newBeverage);
						}
							
                    }
                    Thread.Sleep(500);
                    Beverage beverage = this.GetNextBeverage();
                    if (beverage != null)
                    {
						Sort(beverage);
					}
                    Thread.Sleep(500);
                }
            }
        }
        private void Sort(Beverage beverage)
        {
            switch (beverage)
            {
                case Soda soda:
                    AddSplit(_outputConveyor[0], soda);
                    break;
                case Beer beer:
					AddSplit(_outputConveyor[1], beer);
                    break;
                default:
                    this.AddToInventory(beverage); // unknown beverage back to inventory
                    break;
            }
        }
        private void AddSplit(Conveyor output, Beverage beverage)
        {
            if (output == null) return;
            if (output.Inventory.Count < 10)
            {
                output.AddToInventory(beverage);
			}
		}
    }
}
