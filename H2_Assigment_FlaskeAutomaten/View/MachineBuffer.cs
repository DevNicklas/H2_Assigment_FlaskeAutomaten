using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2_Assigment_FlaskeAutomaten.View
{
    internal class MachineBuffer
    {
        private ListBox _listBoxBeverages;
        private ProgressBar _beverageListProgress;

        internal MachineBuffer(ListBox listBoxBeverages, ProgressBar beverageListProgress)
        {
            _listBoxBeverages = listBoxBeverages;
            _beverageListProgress = beverageListProgress;
        }

        internal void AddBeverage(Beverage beverage)
        {
            if (_listBoxBeverages.Items.Count < _beverageListProgress.Maximum)
            {
                if (_listBoxBeverages.InvokeRequired)
                {
                    _listBoxBeverages.Invoke(new Action(() => AddBeverage(beverage)));
                }
                else
                {
                    _listBoxBeverages.Items.Add(beverage.Name);
                    _beverageListProgress.Value++;
                }
            }
        }

        internal void RemoveBeverage(Beverage beverage)
        {
            if (_listBoxBeverages.InvokeRequired)
            {
                _listBoxBeverages.Invoke(new Action(() => RemoveBeverage(beverage)));
            }
            else
            {
                if (!_listBoxBeverages.Items.Contains(beverage.Name))
                {
                    throw new Exception("Kan ikke fjerne drikkevarer");
                }
                else
                {
                    _listBoxBeverages.Items.Remove(beverage.Name);
                    _beverageListProgress.Value--;
                }
            }
        }
    }
}
