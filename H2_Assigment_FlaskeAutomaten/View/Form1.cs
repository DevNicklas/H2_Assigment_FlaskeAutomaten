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

namespace H2_Assigment_FlaskeAutomaten
{
    public partial class FlaskeautomatenForm : Form
    {
        public FlaskeautomatenForm()
        {
            InitializeComponent();

            ConveyorBuffer buffer = new ConveyorBuffer(producerBuffer, producerProgressBar);

            Soda soda = new Soda(20);

            buffer.AddBeverage(soda);
        }
    }
}
