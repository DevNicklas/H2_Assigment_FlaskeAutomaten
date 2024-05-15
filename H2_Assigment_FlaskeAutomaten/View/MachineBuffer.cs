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

        /// <summary>
        /// Represents a buffer used for managing beverages in a ListBox and ProgressBar.
        /// </summary>
        /// <param name="listBoxBeverages">The ListBox control for displaying beverages.</param>
        /// <param name="beverageListProgress">The ProgressBar control for visualizing beverage list progress.</param>
        internal MachineBuffer(ListBox listBoxBeverages, ProgressBar beverageListProgress)
        {
            _listBoxBeverages = listBoxBeverages;
            _beverageListProgress = beverageListProgress;
        }

        /// <summary>
        /// Adds a beverage to the ListBox and updates the ProgressBar if space is available.
        /// </summary>
        /// <param name="beverage">The beverage to add.</param>
        internal void AddBeverage(Beverage beverage)
        {
            if (_listBoxBeverages.Items.Count < _beverageListProgress.Maximum)
            {
                // If invoking is required (cross-thread operation), invoke adding beverage again,
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

        /// <summary>
        /// Removes a beverage from the ListBox and updates the ProgressBar
        /// </summary>
        /// <param name="beverage">The beverage to remove</param>
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
