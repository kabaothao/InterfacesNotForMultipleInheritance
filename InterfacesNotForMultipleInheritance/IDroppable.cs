using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNotForMultipleInheritance
{
    public class IDroppable
    {
        void Drop();
    }
}

/*
 
It's fundamentally wrong to say a class inherits from an interface, a class implements an interface because

an interface as you see here is simply a contract. It's saying that any class that implements this interface should have a method that is public void and called drop.

And that's what we type here. So that's the truth about interfaces and inheritance.
 */