namespace HelloProgrammerExam
{
  public class Car:Vehicle //is derived from Car Class
    {
        public string color ;
        public int maxSpeed ;
        public string model;
        public  int year;

        /*A constructor is a special method that is used to initialize objects.
         * The advantage of a constructor,
         * is that it is called when an object of a class is created*/
        // Create a class constructor with a parameter
        public Car()
        {
            color= "red";
            maxSpeed = 200;
           

        }
        //Just like other methods, constructors can be overloaded by using different numbers of parameters.

        public Car(string color, int maxSpeed, string model, int year)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
            this.model = model;
            this.year = year;
        }

      
        /*Why did we declare the method as public, and not static, like in the examples from the C# Methods ?

The reason is simple:
        a static method can be accessed without creating an object of the class,
        while public methods can only be accessed by objects.*/

        public int  fullThrottle()
        {
            return maxSpeed;

        }
        
    }
}