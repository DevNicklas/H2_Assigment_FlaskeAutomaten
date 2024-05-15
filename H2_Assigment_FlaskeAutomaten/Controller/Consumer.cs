using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using H2_Assigment_FlaskeAutomaten.Model;
using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using H2_Assigment_FlaskeAutomaten.Model.Machines;

namespace H2_Assigment_FlaskeAutomaten.Controller
{
	internal class Consumer
	{
		public void Consume()
		{
			// Continuously consume beverages
			while (true) { 
				foreach (Conveyor Conveyor in Main.outputConveyors)
				{
					// Lock the conveyor to ensure thread safety
					lock (Conveyor)
					{
						Beverage beverage = Conveyor.GetNextBeverage();
						if (beverage != null)
						{
							// Remove the beverage from the inventory
							Conveyor.RemoveFromInventory(beverage);
						}
					}
					// Wait for 2000 milliseconds (2 sec) before processing the next conveyor
					Thread.Sleep(2000);
				}
					
			}
		}
	}
}
