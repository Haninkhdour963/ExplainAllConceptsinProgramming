namespace HelloProgrammerExam
{
    public class Vehicle
    {
        //If you don't want other classes to inherit from a class, use the sealed keyword:
        
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");

        }


        /*Why And When To Use "Inheritance"?
- It is useful for code reusability: 
        reuse fields and methods of an existing class when you create a new class.

:  We Use a Polymorphism,
        which uses inherited methods to perform different tasks.*/


    }
}