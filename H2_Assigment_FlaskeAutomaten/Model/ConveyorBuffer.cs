using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2_Assigment_FlaskeAutomaten.Model
{
    public class ConveyorBuffer
    {
        private ListBox _listBoxBeverages;
        private ProgressBar _beverageListProgress;
        private readonly uint _maxBeverages;

        internal ConveyorBuffer(ListBox listBoxBeverages, ProgressBar beverageListProgress, uint maxBeverages)
        {
            _listBoxBeverages = listBoxBeverages;
            _beverageListProgress = beverageListProgress;
            _maxBeverages = maxBeverages;
        }

        public void AddBeverage(Beverage beverage)
        {
            if(_listBoxBeverages.Items.Count >= _maxBeverages)
            {
                throw new NotImplementedException();
            }
            else
            {
                _listBoxBeverages.Items.Add(beverage.Name);
            }
        }

        public void RemoveBeverage(Beverage beverage)
        {
            if (_listBoxBeverages.Items.Contains(beverage.Name))
            {
                _listBoxBeverages.Items.Remove(beverage.Name);
            }
        }
    }
}
