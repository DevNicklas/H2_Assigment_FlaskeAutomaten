using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using H2_Assigment_FlaskeAutomaten.Model.Machines;
using H2_Assigment_FlaskeAutomaten.View;

namespace H2_Assigment_FlaskeAutomaten.Controller
{
    internal class Main
    {
        private static Conveyor _inputConveyor;
        private static Conveyor[] _outputConveyors;

		internal static Conveyor InputConveyor
		{
			get
			{
				return _inputConveyor;
			}
		}

		internal static Conveyor[] OutputConveyors
		{
			get
			{
				return _outputConveyors;
			}
		}

        internal static void Setup()
        {
			_inputConveyor = SetupNewConveyor(FlaskeautomatenForm.bufferproducer);
			_outputConveyors = new Conveyor[] { SetupNewConveyor(FlaskeautomatenForm.bufferBeer), SetupNewConveyor(FlaskeautomatenForm.bufferSoda) };
			Splitter splitter = SetupNewSplitter(FlaskeautomatenForm.bufferSplitter);
			Thread splitterThread = new Thread(splitter.Start);
			splitterThread.Start();
        }

		private static Splitter SetupNewSplitter(MachineBuffer buffer)
		{
			return new Splitter(_inputConveyor, _outputConveyors, buffer);
		}

		private static Conveyor SetupNewConveyor(MachineBuffer buffer)
		{
			return new Conveyor(buffer);
		}
	}
}
