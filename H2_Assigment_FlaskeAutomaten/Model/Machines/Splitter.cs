using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Machines
{
    internal class Splitter : Machine
    {
		private Conveyor _inputConveyor;
        private Conveyor[] _outputConveyor = new Conveyor[2];
        private readonly object _lockObject = new object(); // Lock object for thread safety
		private const int MAX_BEVERAGE = 15;

		public Splitter(Conveyor inputConveyor, Conveyor[] outputConveyors, ConveyorBuffer buffer) : base(buffer)
        {
            _inputConveyor = inputConveyor;
            _outputConveyor = outputConveyors;
        }

        public void Start()
        {
            while (true)
            {
                lock (_lockObject) // This is needed if there is more than 1 thread running the Splitter
                {
                    if (_inputConveyor.Inventory.Count > 0 && this.Inventory.Count < MAX_BEVERAGE)
                    {
                        this.AddToInventory(_inputConveyor.RemoveFromInventory());
                    }
                    Thread.Sleep(500);
                    Beverage beverage = this.RemoveFromInventory(); // Retrieve removed beverage
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
                    _outputConveyor[0].AddToInventory(soda);
                    break;
                case Beer beer:
                    _outputConveyor[1].AddToInventory(beer);
                    break;
                default:
                    this.AddToInventory(beverage); // unknown beverage back to inventory
                    break;
            }
        }
    }
}
