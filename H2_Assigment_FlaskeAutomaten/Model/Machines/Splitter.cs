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

        public Splitter(Conveyor inputConveyor, Conveyor[] outputConveyors)
        {
            _inputConveyor = inputConveyor;
            _outputConveyor = outputConveyors;
        }

        public void Sort()
        {
            while (true)
            {
                if (_inputConveyor.Inventory.Count > 0 && this.Inventory.Count < 10)
                {
                    Beverage beverageToRemove = _inputConveyor.RemoveFromInventory();
                    this.AddToInventory(beverageToRemove);
                }
				Thread.Sleep(1000);
                Beverage beverageToSort = this.RemoveFromInventory();
                if (beverageToSort != null)
                {
                    switch (beverageToSort)
                    {
                        case Soda soda:
                            // Handle Soda type
                            _outputConveyor[0].AddToInventory(soda);
                            break;
                        case Beer beer:
                            // Handle Beer type
                            _outputConveyor[1].AddToInventory(beer);
                            break;
                        default:
                            // Handle other types or log an error
                            break;
                    }
                }

            }
        }
    }
}
