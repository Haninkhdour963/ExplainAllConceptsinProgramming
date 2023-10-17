namespace HelloProgrammerExam
{
    interface IBook // interface    
    {

        /*An interface is a completely "abstract class",
         * which can only contain abstract methods and properties 
         * (with empty bodies)
         *By default, members of an interface are abstract and public.
         *Interfaces can contain properties and methods, but not fields.*/

        void BookName();// interface method (does not have a body)
        void BookDescription();// interface method (does not have a body)






        /*Notes on Interfaces:
Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IBook" object in the Program class)
Interface methods do not have a body - the body is provided by the "implement" class
On implementation of an interface, you must override all of its methods
Interfaces can contain properties and methods, but not fields/variables
Interface members are by default abstract and public
An interface cannot contain a constructor (as it cannot be used to create objects)
Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).

2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces. Note: To implement multiple interfaces, separate them with a comma .*/
    }
}