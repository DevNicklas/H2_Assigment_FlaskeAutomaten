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
    internal class Main
    {
        public static Conveyor inputConveyor = new Conveyor();
        public static Conveyor[] outputConveyors = { new Conveyor(), new Conveyor() };
        public void Setup()
        {
            inputConveyor.AddToInventory(new Soda(100));
            inputConveyor.AddToInventory(new Soda(100));
            inputConveyor.AddToInventory(new Soda(100));
            inputConveyor.AddToInventory(new Beer(10));
            inputConveyor.AddToInventory(new Beer(10));
            Splitter splitter = SetupNewSplitter();
			Thread thread = new Thread(splitter.Start);
            thread.Start();

//			Console.WriteLine(splitter.Inventory[0].Name);
        }


        private Splitter SetupNewSplitter()
		{

			return new Splitter(inputConveyor, outputConveyors);
		}

	}
}
