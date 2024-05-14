﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H2_Assigment_FlaskeAutomaten.Model.Machines
{
    internal class Splitter : Machine
    {
        private Conveyor _inputConveyor;
        private Conveyor[] _outputConveyor = new Conveyor[2];

        public Splitter(Conveyor inputConveyor, Conveyor[] outputConveyors)
        {
            _inputConveyor = inputConveyor;
            _outputConveyor = outputConveyors;
        }

        protected void Sort()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                if (_inputConveyor.Inventory.Count > 0)
                {

                }

				Thread.Sleep(1000);
			}
        }
    }
}
