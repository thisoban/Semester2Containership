using System.Collections.Generic;
using System.Linq;


namespace ContainerShip
{
    public class Valuable : Container, IContainer
    {

        public Stack SearchSpace(List<Stack> columns)
        {
            if (!columns.OrderBy(x => x.StackWeight).Where(x =>
                ContainerFitsInColumn(x) && x.Containers.All(y => y.Type != ContainerType.Valuable)).Any())
            {
                return null;
            }
            else
            {
                return columns.OrderBy(x => x.StackWeight)
                    .Where(x => ContainerFitsInColumn(x) && !x.Containers.Any(y => y.Type == ContainerType.Valuable))
                    .Where(x => ControlFrontAndBack(columns, x)).First();
            }
        }

        private bool ControlFrontAndBack(List<Stack> columns, Stack column)
        {
            List<Stack> ColumnFrontBack = columns.Where(x => x.Horizontal == column.Horizontal && (column.Vertical == (x.Vertical + 1) || column.Vertical == (x.Vertical - 1))).ToList();
            return (ColumnFrontBack.All(x => BlockColumnSelf(column, x, columns)));
        }

        private bool BlockColumnSelf(Stack columnValuable, Stack blockColumn, List<Stack> columns)
        {
            if (columnValuable.Vertical == 1 || columnValuable.Vertical == columns.Max(x => x.Vertical))
            {
                return true;
            }
            else
            {
                return !(blockColumn.Containers.Count > columnValuable.Containers.Count);
            }
        }
    }
}
