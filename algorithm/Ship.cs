using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class Ship
    {
        private readonly List<Column> columns = new List<Column>();
        public int Horizon { get; set; }
        public int Vertical { get; set; }
        public IReadOnlyCollection<Column> Columns
        {
            get => columns;
        }
        public Ship(int horizon, int vertical)
        {
            Horizon = horizon;
            Vertical = vertical;
            LoadColumns();
        }

        private void LoadColumns()
        {
            for (int b = 0; b < Vertical; b++)
            {
                for (int l = 0; l < Horizon; l++)
                {
                    columns.Add(new Column() { Horizontal = (b + 1), Vertical = (l + 1), ColumnWeight = 0 });
                }
            }
        }
        public void PlaceAllContainers(List<IContainer> containers)
        {
            foreach (IContainer container in containers.OrderBy(x => x.Type).ThenByDescending(x => x.ContainerWeight))
            {
                PlaceContainer(container);
            }
        }

        private void PlaceContainer(IContainer container)
        {
            try
            {
                Column column = container.SearchSpace(ColumnLightestSide());
                column.PlaceContinaer(container);
            }
            catch (Exception)
            {
                Console.WriteLine("Schip is niet groot genoeg");
            }
        }

        public bool Balance()
        {
            bool ShipBalanced = (columns.Sum(x => x.ColumnWeight) >= (columns.Count * 150000) / 2);
            bool ColumnBalanced = ((ColumnLightestSide().Sum(x => x.ColumnWeight) * 100) / columns.Sum(x => x.ColumnWeight) >= 40);

            if (!ColumnBalanced || !ShipBalanced)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<Column> ColumnLightestSide()
        {
            if (Lightside() == Side.left)
            {
                return columns.Where(x => x.Horizontal <= (Vertical / 2)).ToList();

            }
            else
            {
                return columns.Where(x => x.Horizontal > (Vertical / 2)).ToList();
            }
        }

        private Side Lightside()
        {

            int LeftWeight = columns.Where(x => x.Horizontal <= (Vertical / 2)).Sum(x => x.ColumnWeight);
            int RightWeight = columns.Where(x => x.Horizontal > (Vertical / 2)).Sum(x => x.ColumnWeight);

            if (LeftWeight > RightWeight)
            {
                return Side.right;
            }
            else
            {
                return Side.left;
            }
        }

        public enum Side
        {
            left,
            right
        }
    }
}
  



