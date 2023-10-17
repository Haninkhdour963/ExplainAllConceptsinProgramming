namespace HelloProgrammerExam
{
    class Animal   // Base class (parent) 
    {

        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }


        /*Like we specified in the previous chapter;
         * Inheritance lets us inherit fields and methods from another class. 
         * Polymorphism uses those methods to perform different tasks. 
         * This allows us to perform a single action in different ways.*/

    }
}