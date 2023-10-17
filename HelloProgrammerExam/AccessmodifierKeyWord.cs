namespace HelloProgrammerExam
{
    public class AccessmodifierKeyWord
    {
        public string myAccessString = "This class explain the access modifier";

        /*public : The code is accessible for all classes
         * private: The code is only accessible within the same class
         * protected:The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance 
         * internal: 	The code is only accessible within its own assembly, but not from another assembly.
         * There's also two combinations: protected internal and private protected.
         */

        /*Why Access Modifiers?
        To control the visibility of class members (the security level of each individual class and class member).

        To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.
        This is done by declaring fields as private.*/


        public void MyAccessStringMethod()
        {

            Console.WriteLine("the output of AccessmodifierKeyWord class is: " + myAccessString);
        }

    }
}