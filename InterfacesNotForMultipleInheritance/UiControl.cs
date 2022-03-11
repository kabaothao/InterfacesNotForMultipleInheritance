using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNotForMultipleInheritance
{
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }  

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
          
    }
}


/*
 One of the common misconceptions about interfaces is that they're used to implement multiple inheritance

in C-sharp and I have seen books videos and blog posts that make such a claim but unfortunately that

claim is fundamentally wrong.

Interface's got nothing to do with inheritance.

 */