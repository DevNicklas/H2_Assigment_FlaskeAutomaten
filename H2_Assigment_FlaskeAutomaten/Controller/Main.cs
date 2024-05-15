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
        public static Conveyor inputConveyor;
        public static Conveyor[] outputConveyors;


		public void Setup()
        {

			inputConveyor = SetupNewConveyor(FlaskeautomatenForm.bufferproducer);
			outputConveyors = new Conveyor[] { SetupNewConveyor(FlaskeautomatenForm.bufferBeer), SetupNewConveyor(FlaskeautomatenForm.bufferSoda) };
			Splitter splitter = SetupNewSplitter(FlaskeautomatenForm.bufferSplitter);
			Thread splitterThread = new Thread(splitter.Start);
			splitterThread.Start();
        }
		


		private Splitter SetupNewSplitter(ConveyorBuffer buffer)
		{
			return new Splitter(inputConveyor, outputConveyors, buffer);
		}
		private Conveyor SetupNewConveyor(ConveyorBuffer buffer)
		{
			return new Conveyor(buffer);
		}

	}
}
