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
    /// <summary>
    /// Represents the main class responsible for setting up the system
    /// </summary>
    internal class Main
    {
        // Declare private fields for input and output conveyors
        private static Conveyor _inputConveyor;
        private static Conveyor[] _outputConveyors;

        /// <summary>
        /// Gets the input conveyor
        /// </summary>
        internal static Conveyor InputConveyor
        {
            get
            {
                return _inputConveyor;
            }
        }

        /// <summary>
        /// Gets the array of output conveyors
        /// </summary>
        internal static Conveyor[] OutputConveyors
        {
            get
            {
                return _outputConveyors;
            }
        }

        /// <summary>
        /// Sets up the system by initializing conveyors, splitter, and consumer threads
        /// </summary>
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

        /// <summary>
        /// Sets up a new splitter with the specified machine buffer
        /// </summary>
        /// <param name="buffer">The machine buffer for the splitter</param>
        /// <returns>The newly created splitter</returns>
        private static Splitter SetupNewSplitter(MachineBuffer buffer)
        {
            return new Splitter(_inputConveyor, _outputConveyors, buffer);
        }

        /// <summary>
        /// Sets up a new conveyor with the specified machine buffer
        /// </summary>
        /// <param name="buffer">The machine buffer for the conveyor</param>
        /// <returns>The newly created conveyor</returns>
        private static Conveyor SetupNewConveyor(MachineBuffer buffer)
        {
            return new Conveyor(buffer);
        }
    }

}
}
