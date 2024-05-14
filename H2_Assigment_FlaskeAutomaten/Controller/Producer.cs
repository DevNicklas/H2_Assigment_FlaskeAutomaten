using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2_Assigment_FlaskeAutomaten.Controller
{
    internal class Producer
    {
        private Button _addBeerBtn;
        private Button _addSodaBtn;

        internal Producer(Button addBeerBtn, Button addSodaBtn)
        {
            _addBeerBtn = addBeerBtn;
            _addSodaBtn = addSodaBtn;
        }


    }
}
