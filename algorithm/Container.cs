using System.Linq;
namespace ContainerShip
{
    public class Container
    {
        public int ContainerWeight { get; set; }
        public ContainerType Type { get; set; }

        public override string ToString()
        {
            return "Type: " + Type + " Weight: " + ContainerWeight;
        }

        public bool ContainerFitsInColumn(Stack stack)
        {
            if (stack.Containers.Count != 0)
            {
                var WeightColumn = stack.Containers.Sum(x => x.ContainerWeight) -
                                   stack.Containers.First().ContainerWeight;
                return WeightColumn + ContainerWeight <= 120000;
            }

            return true;
        }
    }
}