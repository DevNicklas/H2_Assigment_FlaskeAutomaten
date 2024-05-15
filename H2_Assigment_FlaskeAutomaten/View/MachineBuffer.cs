using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2_Assigment_FlaskeAutomaten.View
{
	/// <summary>
	/// Represents a buffer for holding beverages in a beverage vending machine.
	/// </summary>
	internal class MachineBuffer
    {
        private ListBox _listBoxBeverages;
        private ProgressBar _beverageListProgress;

        internal MachineBuffer(ListBox listBoxBeverages, ProgressBar beverageListProgress)
        {
            _listBoxBeverages = listBoxBeverages;
            _beverageListProgress = beverageListProgress;
        }
		// Method to add a beverage to the list box and update the progress bar
		internal void AddBeverage(Beverage beverage)
		{
			if (_listBoxBeverages.Items.Count < _beverageListProgress.Maximum)
			{
				// If invoking is required (cross-thread operation), invoke adding beverage again
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

		// Method to remove a beverage from the list box and update the progress bar
		internal void RemoveBeverage(Beverage beverage)
		{
			if (_listBoxBeverages.InvokeRequired)
			{
				_listBoxBeverages.Invoke(new Action(() => RemoveBeverage(beverage)));
			}
			else
			{
				// If the beverage is not found in the list box, throw an exception
				if (!_listBoxBeverages.Items.Contains(beverage.Name))
				{
					throw new NotImplementedException();
				}
				else
				{
					// Remove the beverage from the list box and update the progress bar
					_listBoxBeverages.Items.Remove(beverage.Name);
					_beverageListProgress.Value--;
				}
			}
		}
	}
}
