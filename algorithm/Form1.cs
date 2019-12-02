using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShipMakerBtn.Enabled = true;
            BtnPlaceAll.Enabled = false;
            BtnCreateContainer.Enabled = false;
            foreach (ContainerType type in Enum.GetValues(typeof(ContainerType)))
            {
                TypeofContainerComboBox.Items.Add(type);
            }
        }

        private void ShipMakerBtn_Click(object sender, EventArgs e)
        {
            ShipMakerBtn.Enabled = false;
          
            btnPlaats.Enabled = true;
            btnToevoegen.Enabled = true;
            int x = (int)HorizontalUpDown.Value;
            int y = (int)VerticalNumericUpDown.Value;
            Ship ship = new Ship(x, y );
        }
    }
}
