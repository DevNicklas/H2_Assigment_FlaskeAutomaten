using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using H2_Assigment_FlaskeAutomaten.Model;
using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using H2_Assigment_FlaskeAutomaten.Model.Machines;
using H2_Assigment_FlaskeAutomaten.View;

namespace H2_Assigment_FlaskeAutomaten.Controller
{
    internal class Main
    {
        public static Conveyor inputConveyor;
        public static Conveyor[] outputConveyors;


		public static void Setup()
        {

			inputConveyor = SetupNewConveyor(FlaskeautomatenForm.bufferproducer);
			outputConveyors = new Conveyor[] { SetupNewConveyor(FlaskeautomatenForm.bufferBeer), SetupNewConveyor(FlaskeautomatenForm.bufferSoda) };
			Splitter splitter = SetupNewSplitter(FlaskeautomatenForm.bufferSplitter);
			Thread splitterThread = new Thread(splitter.Start);
			splitterThread.Start();
        }
		


		private static Splitter SetupNewSplitter(MachineBuffer buffer)
		{
			return new Splitter(inputConveyor, outputConveyors, buffer);
		}
		private static Conveyor SetupNewConveyor(MachineBuffer buffer)
		{
			return new Conveyor(buffer);
		}

	}
}
