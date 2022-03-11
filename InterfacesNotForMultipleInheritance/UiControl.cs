using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNotForMultipleInheritance
{
    public class UiControl
    {   
        public class Textbox : UiControl, Idraggable, IDroppable
        {
            /*
            If you add Size to line 11
            our class cannot have multiple basic classes. But what we can do here is to have this text box implement multiple interfaces so we can say it implements.

            So when we go and implement that interface in a class like a text box we have to type that method declaration again and then actually implement it. So there is no code to inherit.
            There is no reusability. And that's the reason that I explain interfaces got nothing to do with inheritance.

            */

            public void Drag()
            {
                throw new NotImplementedException();
            }

            public void Drop()
            {
                throw new NotImplementedException();

            }


        }



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


It's fundamentally wrong to say a class inherits from an interface a class implements an interface because

an interface as you see here is simply a contract. It's saying that any class that implements this interface should have a method that is public void and called drop.

And that's what we type here. So that's the truth about interfaces and inheritance.

 */