using System.Collections.Generic;
using System.Linq;

namespace algorithm
{
    public class Cooled:Container, IContainer
    {
       public ContainerType Type { get; set; }

       public Stack SearchSpace(List<Stack> stack)
       {
           if (stack.OrderBy(x => x.StackWeight).Where(x => ContainerFitsInColumn(x) && x.Vertical == 1).Count() ==
               0) return null;

           return stack.OrderBy(x => x.StackWeight)
               .Where(x => ContainerFitsInColumn(x) && x.Vertical == 1).First();
       }
    }
}
