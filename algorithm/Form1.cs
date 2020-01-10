using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ContainerShip
{
    public partial class Form1 : Form
    {
        private readonly List<IContainer> _containers = new List<IContainer>();
        private Ship _ship;

        public Form1()
        {
            InitializeComponent();
            ShipMakerBtn.Enabled = true;
            BtnPlaceAll.Enabled = false;
            BtnCreateContainer.Enabled = false;
            foreach (ContainerType Type in Enum.GetValues(typeof(ContainerType)))
                TypeofContainerComboBox.Items.Add(Type);
        }

        private void ShipMakerBtn_Click(object sender, EventArgs e)
        {
            ShipMakerBtn.Enabled = false;
            BtnPlaceAll.Enabled = true;
            BtnCreateContainer.Enabled = true;

            _ship = new Ship((int) HorizontalUpDown.Value, (int) VerticalNumericUpDown.Value);
            FillCombobox();
        }

        public void FillCombobox()
        {
            for (var i = 0; i < _ship.Vertical; i++) cbVertical.Items.Add(i);

            for (var i = 0; i < _ship.Horizon; i++) cbHorizontal.Items.Add(i);
        }

        private void BtnPlaceAll_Click(object sender, EventArgs e)
        {
            _ship.PlaceAllContainers(_containers);
            Console.WriteLine("testing");
            if (!_ship.Balance()) MessageBox.Show("_ship is not in balance");
        }

        private void cbHorizontal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbHorizontal.SelectedText != null && cbVertical.SelectedText != null)
            {
                var RowContainers = new List<IContainer>();
                foreach (var column in _ship.Columns.Where(x =>
                    x.Vertical == cbVertical.SelectedIndex + 1 && x.Horizontal == cbHorizontal.SelectedIndex + 1))
                foreach (Container container in column.Containers)
                {
                    lbColumn.Items.Clear();
                    lbColumn.Items.Add(container);
                }
            }
        }

        private void BtnCreateContainer_Click(object sender, EventArgs e)
        {
            if ((ContainerType) TypeofContainerComboBox.SelectedItem == ContainerType.Cooled)
                _containers.Add(new Cooled
                    {ContainerWeight = (int) WeightContainer.Value, Type = ContainerType.Cooled});

            if ((ContainerType) TypeofContainerComboBox.SelectedItem == ContainerType.Normal)
                _containers.Add(new Standard
                    {ContainerWeight = (int) WeightContainer.Value, Type = ContainerType.Normal});

            if ((ContainerType) TypeofContainerComboBox.SelectedItem == ContainerType.Valuable)
                _containers.Add(new Valuable
                    {ContainerWeight = (int) WeightContainer.Value, Type = ContainerType.Valuable});

            ContainerList.Items.Clear();
            foreach (var container in _containers) ContainerList.Items.Add(container.ToString());
        }
    }
}