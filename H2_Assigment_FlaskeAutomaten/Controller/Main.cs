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
		// Declare private fields for input and output conveyors
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
			// Set up input conveyor with bufferproducer
			_inputConveyor = SetupNewConveyor(FlaskeautomatenForm.bufferproducer);

			// Set up output conveyors with bufferSoda and bufferBeer
			_outputConveyors = new Conveyor[] { SetupNewConveyor(FlaskeautomatenForm.bufferSoda), SetupNewConveyor(FlaskeautomatenForm.bufferBeer) };

			// Set up splitter with bufferSplitter
			Splitter splitter = SetupNewSplitter(FlaskeautomatenForm.bufferSplitter);
            Thread splitterThread = new Thread(splitter.Start);
            splitterThread.Start();


			// Set up consumer threads for each output conveyor
			Consumer consumer = new Consumer();
            Thread consumeThread1 = new Thread(() => consumer.Consume(_outputConveyors[0]));
            consumeThread1.Start();

            Thread consumeThread2 = new Thread(() => consumer.Consume(_outputConveyors[1]));
            consumeThread2.Start();
        }


		// Method to create a new splitter instance
		private static Splitter SetupNewSplitter(MachineBuffer buffer)
		{
			return new Splitter(_inputConveyor, _outputConveyors, buffer);
		}

		// Method to create a new conveyor instance
		private static Conveyor SetupNewConveyor(MachineBuffer buffer)
		{
			return new Conveyor(buffer);
		}
	}
}
