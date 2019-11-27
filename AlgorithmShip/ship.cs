using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmShip
{
    public class Ship
    {
        private List<Column> columns = new List<Column>();
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
                PlaatsContainer(container);
            }
        }

       private void PlaceContainer(IContainer container)
        {
            try
            {
                Column column = container.SearchSpace(KolommenLichtsteKant());
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
            bool ColumnBalanced = ((ColumnLightestSide().Sum(x => x.GewichtKolom) * 100) / columns.Sum(x => x.ColumnWeight) >= 40);

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
            if (LichtsteKant() == Side.left)
            {
                return columns.Where(x => x.Horizontal <= (Vertical / 2)).ToList();

            }
            else
            {
                return columns.Where(x => x.Horizontal > (Vertical / 2)).ToList();
            }
        }
    }

    private Side LichtsteKant()
    {
        int LeftWeight = Columns.Where(x => x.Horizontal <= (Vertical / 2)).Sum(x => x.GewichtKolom);
        int RightWeight = Columns.Where(x => x.Horizontal > (Vertical / 2)).Sum(x => x.GewichtKolom);

        if (LeftWeight > RightWeight)
        {
            return Side.right;
        }
        else
        {
            return Side.left;
        }
    }
}
public enum Side
    {
        left,
        right
    }
}
}
