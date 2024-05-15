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
	/// <summary>
	/// Represents a consumer that continuously consumes beverages from a conveyor.
	/// </summary>
	internal class Consumer
    {
		internal void Consume(Conveyor conveyor)
        {
            // Continuously consume beverages
            while (true)
            {
                // Lock the conveyor to ensure thread safety
                lock (conveyor)
                {
                    Beverage beverage = conveyor.GetNextBeverage();
                    if (beverage != null)
                    {
                        // Remove the beverage from the inventory
                        conveyor.RemoveFromInventory(beverage);
                    }
                }
                // Wait for 3000 milliseconds (3 sec) before processing the next conveyor
                Thread.Sleep(3000);

            }
        }
    }
}
