namespace HelloProgrammerExam
{
    abstract class Country
    {
        /*Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces      
The abstract keyword is used for classes and methods:
Abstract class: is a restricted class that cannot be used to create objects
        (to access it, it must be inherited from another class).
Abstract method: can only be used in an abstract class, 
        and it does not have a body. The body is provided by the derived class (inherited from).*/

        public abstract void CitySound();  // Abstract method (does not have a body)
        public void CapitalCountry()
        {

            Console.WriteLine("the Capital of country");
        }



        /*Why And When To Use Abstract Classes and Methods?
To achieve security - hide certain details 
        and only show the important details of an object.
Note: Abstraction can also be achieved with Interfaces,*/
    }
}