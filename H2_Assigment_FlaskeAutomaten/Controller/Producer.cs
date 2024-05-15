using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2_Assigment_FlaskeAutomaten.Controller
{
    /// <summary>
    /// Represents a component responsible for adding beer and soda items to the inventory
    /// </summary>
    internal class Producer
    {

        private Button _addBeerBtn;
        private Button _addSodaBtn;

        /// <summary>
        /// Initializes the Producer class with add beer and add soda buttons
        /// </summary>
        /// <param name="addBeerBtn">The button to add beer</param>
        /// <param name="addSodaBtn">The button to add soda</param>
        internal Producer(Button addBeerBtn, Button addSodaBtn)
        {
            _addBeerBtn = addBeerBtn;
            _addSodaBtn = addSodaBtn;

            // Attach event handlers for button clicks
            _addBeerBtn.Click += OnAddBeerBtnClick;
            _addSodaBtn.Click += OnAddSodaBtnClick;
        }

        /// <summary>
        /// Event handler for the add beer button click. Adds beer to the inventory
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void OnAddBeerBtnClick(object sender, EventArgs e)
        {
            Main.InputConveyor.AddToInventory(new Beer(10));
        }

        /// <summary>
        /// Event handler for the add soda button click. Adds soda to the inventory
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event arguments</param>
        private void OnAddSodaBtnClick(object sender, EventArgs e)
        {
            Main.InputConveyor.AddToInventory(new Soda(100));
        }
    }
}
