using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using H2_Assigment_FlaskeAutomaten.Model;
using H2_Assigment_FlaskeAutomaten.Model.Machines;

namespace H2_Assigment_FlaskeAutomaten.Controller
{
    internal class Main
    {
        public void Setup()
        {
			Splitter splitter = SetupNewSplitter();

		}


        private Splitter SetupNewSplitter()
		{
			Conveyor inputConveyor = new Conveyor();
			Conveyor[] outputConveyors = { new Conveyor(), new Conveyor() };
			return new Splitter(inputConveyor, outputConveyors);
		}

	}
}
