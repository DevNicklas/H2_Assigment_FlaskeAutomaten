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
        private Conveyor _inputConveyor = new Conveyor();
        private Conveyor[] _outputConveyors = { new Conveyor(), new Conveyor() };
        public void Setup()
        {
            _inputConveyor.AddToInventory(new Soda(100));
            Splitter splitter = SetupNewSplitter();
			Thread thread = new Thread(splitter.Sort);
            thread.Start();

//			Console.WriteLine(splitter.Inventory[0].Name);
        }


        private Splitter SetupNewSplitter()
		{

			return new Splitter(_inputConveyor, _outputConveyors);
		}

	}
}
