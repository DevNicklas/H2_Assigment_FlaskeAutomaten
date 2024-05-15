using H2_Assigment_FlaskeAutomaten.View;
using H2_Assigment_FlaskeAutomaten.Model.Beverages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using H2_Assigment_FlaskeAutomaten.Controller;

namespace H2_Assigment_FlaskeAutomaten
{
    public partial class FlaskeautomatenForm : Form
    {
		public static ConveyorBuffer bufferproducer;
		public static ConveyorBuffer bufferBeer;
		public static ConveyorBuffer bufferSoda;

		public static ConveyorBuffer bufferSplitter;
		public FlaskeautomatenForm()
        {
            InitializeComponent();

			bufferproducer = new ConveyorBuffer(producerBuffer, producerProgressBar, 10);
			bufferBeer = new ConveyorBuffer(beerBuffer, beerProgressBar, 10);
			bufferSoda = new ConveyorBuffer(sodaBuffer, sodaProgressBar, 10);

			bufferSplitter = new ConveyorBuffer(SplitterBuffer, SpiltterProgressBar, 10);

		}

		private void beerBtn_Click(object sender, EventArgs e)
		{
			Main.inputConveyor.AddToInventory(new Beer(10));
		}

		private void sodaBtn_Click(object sender, EventArgs e)
		{
			Main.inputConveyor.AddToInventory(new Soda(100));
		}
	}
}
