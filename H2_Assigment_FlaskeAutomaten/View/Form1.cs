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
		public static MachineBuffer bufferproducer;
		public static MachineBuffer bufferBeer;
		public static MachineBuffer bufferSoda;

		public static MachineBuffer bufferSplitter;
		public FlaskeautomatenForm()
        {
            InitializeComponent();

			bufferproducer = new MachineBuffer(producerBuffer, producerProgressBar);
			bufferBeer = new MachineBuffer(beerBuffer, beerProgressBar);
			bufferSoda = new MachineBuffer(sodaBuffer, sodaProgressBar);

			bufferSplitter = new MachineBuffer(SplitterBuffer, SpiltterProgressBar);

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
