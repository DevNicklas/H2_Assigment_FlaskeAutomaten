using H2_Assigment_FlaskeAutomaten.Model.Beverages;
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

            _addBeerBtn.Click += OnAddBeerBtnClick;
            _addSodaBtn.Click += OnAddSodaBtnClick;
        }

        private void OnAddBeerBtnClick(object sender, EventArgs e)
        {
            Main.inputConveyor.AddToInventory(new Beer(10));
        }

        private void OnAddSodaBtnClick(object sender, EventArgs e)
        {
            Main.inputConveyor.AddToInventory(new Soda(100));
        }
    }
}
