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
			while (true) { 
				foreach (Conveyor Conveyor in Main.outputConveyors)
				{
					Beverage beverage = Conveyor.GetNextBeverage();
					if (beverage != null)
					{
						Conveyor.RemoveFromInventory(beverage);
						Thread.Sleep(2000);
					}
				}
				Thread.Sleep(250);
			}
		}
	}
}
