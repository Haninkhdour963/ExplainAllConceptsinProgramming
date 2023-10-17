using System.Net.Security;


namespace HelloProgrammerExam
{


    internal class Program
    {
        //Creating MyMethod() method in c#
        static void MyMethod()
        {
            Console.WriteLine("the method is:MyMethod()");
        }
        //Creating MyMethod() with paramaeters
        static void MyMethod(string fName, int yAge, string country = "Palestine")
        {
            Console.WriteLine(fName + "your Age" + yAge + "Your Country is:" + country);
        }
        //Creating MyMethod() with parameters and return parameters 
        static int MyMethod(int xxx, int yyy)
        {

            return xxx + yyy;

        }

        //Creating C# Named Arguments
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("the youngest child is:" + child3);
        }

        /*An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma:*/

         enum Level

        {
            Low,
            Medium,
            High
        }
        enum Country
        {
            Palestine,
            Jordan,
            Syria,
            Lebanon


        }
        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }
        /*By default, the first item of an enum has the value 0. The second has the value 1, and so on.

To get the integer value from an item, you must explicitly convert the item to an int:*/
        int myNum = (int)Months.April;

      

        static void Main(string[] args)
        {

            int myInt = 99;
            //Implicit Casting
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            //Explicit Casting
            myDouble = 9.78;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            //Explicit type using Convert methods
            myInt = 10;
            myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToUInt64(myDouble));
            Console.WriteLine(Convert.ToString(myBool));

            //Write a program to read and write name of user
            Console.WriteLine("Please Enter Your UserName");
            string UserName = Console.ReadLine();
            Console.WriteLine("User Name is:" + UserName);

            //Write a program to enter your age
            Console.WriteLine("Enter Your Age Pleasw");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is:" + yourAge);

            //Write a program to enter two numbers and sum both of them
            Console.WriteLine("Enter The First Number Please");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Scond Number");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            int sum = FirstNum + SecondNum;
            int sub = FirstNum - SecondNum;
            int modNum = FirstNum % SecondNum;
            int multiply = FirstNum * SecondNum;
            int divNum = FirstNum / SecondNum;
            int inct = FirstNum++;
            int decrt = FirstNum--;
            Console.WriteLine("The Summation of two numbers are:" + sum);
            Console.WriteLine("The Sub of two numbers are:" + sub);
            Console.WriteLine("The Modof two numbers are:" + modNum);
            Console.WriteLine("The Multply two numbers are:" + multiply);
            Console.WriteLine("The Devides of two numbers are:" + divNum);
            Console.WriteLine("The Incremnent of  number is:" + inct);
            Console.WriteLine("The Decrement of  number is:" + decrt);

            //Add Operator Assinment
            int x = 20, y = 10, z = 10, h = 10, f = 10, g = 10, i = 10, j = 10, m = 10, n = 10;
            double xx = 20.7;
            x += 5;
            y -= 5;
            z *= 5;
            h /= 5;
            f %= 5;
            g &= 5;
            i |= 5;
            j ^= 5;
            m >>= 5;
            n <<= 5;

            Console.WriteLine("The New X Value is:" + x);
            Console.WriteLine("The New y Value is:" + y);
            Console.WriteLine("The New z Value is:" + z);
            Console.WriteLine("The New h Value is:" + h);
            Console.WriteLine("The New f Value is:" + f);
            Console.WriteLine("The New g Value is:" + g);
            Console.WriteLine("The New i Value is:" + i);
            Console.WriteLine("The New j Value is:" + j);
            Console.WriteLine("The New m Value is:" + m);
            Console.WriteLine("The New n Value is:" + n);


            //Logical Operators
            Console.WriteLine("The Results of logical operator is:" + (x < y && y == 10));
            Console.WriteLine("The Result of logical operator is:" + (x > y && y == 10));
            Console.WriteLine("The Result of logical operator is:" + (x > y || y == 10));
            Console.WriteLine("The Result of logical operator is:" + !(x > y || y == 10));
            Console.WriteLine("The Result of logical operator is:" + (x < y || y == 10));

            //C# Math Class: has many methods that allows you to perform mathmatical tasks on numbers
            Console.WriteLine("The result of Math.Max is:" + (Math.Max(x, y)));
            Console.WriteLine("The result of Math.Min is:" + (Math.Min(x, y)));
            Console.WriteLine("The result of Math.Sqrt is:" + (Math.Sqrt(x)));
            Console.WriteLine("The result of Math.Abs is:" + (Math.Abs(-x)));
            Console.WriteLine("The result of Math.Round is:" + (Math.Round(xx)));



            // C# Strings

            string greeting = "Hello Heno Faminum Queen";
            string greeting1 = "Hello Heno Faminum Queen";
            string greeting2 = "Heno You are the best fuminum in the world";
            string greeting3 = "Heno You are the best fuminum in the world";
            Console.WriteLine("My Huge Universe please listem to me:" + greeting);
            Console.WriteLine("My Huge Universe please listem to me:" + greeting2);

            //C# String Concatenation + Operator

            Console.WriteLine("My Huge Universe please listem to me:" + greeting + greeting2);
            Console.WriteLine("To my Universe plese be listener and focus:" + string.Concat(greeting, greeting2));
            Console.WriteLine("Please listen to me and focus:" + string.Concat(greeting1, greeting2));



            //String Length: method to find the length of text 

            Console.WriteLine("The length of the text in greeting dtring is:" + greeting.Length);

            //String ToUpper(),ToLower(): return a copy of the string converted to uppercase or lowercase

            Console.WriteLine("The ToLowerCase() method is:" + greeting.ToLower() + greeting2.ToLower());
            Console.WriteLine("The ToUpperCase() method is:" + greeting.ToUpper() + greeting2.ToUpper());


            //String Interpoation $"{} {}"

            string FirstName = "Heno The Fuminum Queen";
            string FirstName2 = "Heno Kh";
            string LastName = "The Best Ever Feminine in the World";
            Console.WriteLine($"The Interpolation Strings are:{FirstName} {LastName}");
            Console.WriteLine($"The Interpolation Strings for three strings are: {FirstName} {FirstName2} {LastName}");


            // C# Access Strings use [] or IndexOf(), or Using IndexOf() with Substring()

            string FullName = "Henno Feminume Queen Is The Best In The World";
            int HFllName = FullName.IndexOf("F");
            string LastFullNameH = FullName.Substring(HFllName);
            string MyCountry = " My Country Palestine Free";
            int NCountry = MyCountry.IndexOf("P");
            string LastCountry = MyCountry.Substring(NCountry);

            Console.WriteLine("AccessString Using Index:" + FullName[0]);
            Console.WriteLine("Access Index of Strings Using IndexOf() method:" + FullName.IndexOf("e"));
            Console.WriteLine("Access The string Statement position using Substring() method:" + LastFullNameH);
            Console.WriteLine("Access The String Statement Postition using Substring(0 Method:" + LastCountry);

            //C# Boolean
            bool isItYourName = true;
            bool isItYouraddress = false;
            int xy = 20, yz = 30;

            Console.WriteLine("the result of boolean value is:" + isItYourName);
            Console.WriteLine("the result of boolean value is:" + isItYouraddress);
            Console.WriteLine("The result of expression is boolean:" + (xy >= yz));
            Console.WriteLine("The result of expression is boolean:" + (xy == yz));
            Console.WriteLine("The result of expression is boolean:" + (xy != yz));
            Console.WriteLine("The result of expression is boolean:" + (xy <= yz));

            //if....else  Conditions
            if (xy >= yz)
            {
                Console.WriteLine("The Result is:" + xy);


            }
            else
            { Console.WriteLine("The result else is:" + yz); }


            if (xy == yz)
            {
                Console.WriteLine("the result if is:" + "true");
            }
            else if (xy <= yz)
            {
                Console.WriteLine("the result of else if is:" + "true");
            }
            else
                Console.WriteLine("the else is:" + "true");

            string FFNameTernaryOperand = (xy >= yz) ? "the Condition is true" : "the Condition is false";
            string MyTernaryIfoperand = (xy != yz) ? "the Condition is true" + xy : "The condition is false";

            Console.WriteLine(FFNameTernaryOperand);
            Console.WriteLine(MyTernaryIfoperand);



            //C# switch

            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("This is day=6");
                    break;
                case 7:
                    Console.WriteLine("This is day=7 ");
                    break;
                default:
                    Console.WriteLine("This is the defult statement");
                    break;


            }

            //While Loop
            int xyz = 0;
            while (xyz < 20)
            {
                Console.WriteLine("The result is:" + xyz);
                xyz++;
            }

            // do... While
            do
            {
                Console.WriteLine("the result do is:" + xyz);
                xyz++;
            }
            while (xyz < 20);

            //C# For loop we use it when we know how many times want to loop 
            for (int ii = 0; ii < 10; ii++)
            {
                Console.WriteLine("Print all results in array using for loop is:" + ii);
            }

            //Nested For Loop in C#
            for (int ij = 1; ij <= 2; ij++)
            {
                //outer ==2
                Console.WriteLine("The Outer For Loop Result is:" + ij);
                for (int jj = 1; jj <= 3; jj++)
                {
                    //inner 2*3=6
                    Console.WriteLine("The inner For Loop Result is:" + jj);
                }
            }

            //Foreach Loop in C# used exclusively to loop elements in an array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string item in cars)
            {
                Console.WriteLine("Print all elements in the array using foreach are:" + item);
            }

            //break; used in switch and for loop to jump out loop
            for (int iii = 0; iii < 10; iii++)
            {
                if (iii == 4)
                {
                    break;
                }
                Console.WriteLine("print all results using break keyword:" + iii);
            }

            //continue; used to iteration loop to continue 
            for (int iij = 0; iij < 10; iij++)
            {
                if (iij == 4)
                {
                    continue;
                }
                Console.WriteLine("print all results using continue keyword:" + iij);
            }



            //We need Array for creating set of values in one variable
            int[] myNum = { 10, 20, 30, 40 };

            //Access element in array
            Console.WriteLine("To access the element in the array is :" + myNum[0]);

            //Change any element in array
            cars[0] = "Opel";
            Console.WriteLine("the first value in the car array is:" + cars[0]);


            //To find the length of array we are using Length() method
            Console.WriteLine("the length of array is:" + cars.Length);

            //To Sort Array ascending we use Sort() method 
            Array.Sort(cars);
            foreach (string icar in cars)
            {
                Console.WriteLine("the sort() of car array is:" + icar);
            }

            //SystemLinq Namespace other useful array methods such as:Min,Max,and Sum
            int[] myNumbers = { 5, 1, 9, 8 };
            Console.WriteLine("the Min value in array is:" + myNumbers.Min());
            Console.WriteLine("the Max value in array is:" + myNumbers.Max());
            Console.WriteLine("the Sum value in array is:" + myNumbers.Sum());


            /*Multidimensional Arrays:if you want to store data as a tabular form,
             * like a table with rows and columns, you need to get familiar with multidimensional arrays.*/
        int[,] numbers2D = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine("print 2D element in array:" + numbers2D[0, 2]);
            //Loop for 2D array
            foreach (int num2D in numbers2D)
            {
                Console.WriteLine("the print all values in 2D array is:" + num2D);
            }
            // int[,,] numbers3D = { {2,2,3 }, {4,5,6 },{7,8,9 } };

            //Change Elements of a 2D Array
            numbers2D[0, 0] = 5;
            foreach (int num2D in numbers2D)
            {
                Console.WriteLine("the print all values in 2D array is:" + num2D);
            }
            //We can use for loop too but use, GetLength() instead of Length to specify how many times the loop


            for (int i2d = 0; i2d < numbers2D.GetLength(0); i2d++)
            {
                for (int j2d = 0; j2d < numbers2D.GetLength(1); j2d++)
                {
                    Console.WriteLine("print items in array 2d using for with GetLength():" + numbers2D[i2d, j2d]);
                }
            }

            MyMethod();
            MyMethod("Heno", 32, "Free Palestine");
            MyMethod(20, 30);
            MyMethod(child3: "Heno", child2: "Mezo", child1: "Shosho");

            //Instance my object from Car class in C#,cant accessible the field in the main methos without put public for field public string color="red"
            Car car = new Car();
            Console.WriteLine("the object of Car class is:" + car.color);
            car.color = "blue";
            Console.WriteLine("the object of Car class is:" + car.color);
            Console.WriteLine("the method called from object of car class is:" + car.fullThrottle);
            Console.WriteLine("the method called from object of car class is:" + car.maxSpeed);
            car.maxSpeed = 300;
            Console.WriteLine("the method called from object of car class is:" + car.maxSpeed);

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.year = 1969;
            Ford.color = "red";

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.year = 2005;
            Opel.color = "White";




            Console.WriteLine("Ford.model\t" + Ford.model);
            Console.WriteLine("Opel.model\t" + Opel.model);
            Console.WriteLine("car.model\t" + car.model);


            //Create instance for AccessmodifierKeyWord class
            AccessmodifierKeyWord myaccessmodifier = new AccessmodifierKeyWord();
            Console.WriteLine("the output of AccessmodifierKeyWord" + myaccessmodifier.myAccessString);

            //Create instance object from PropertiesandEncapsulation with set and get methods for properties
            PropertiesandEncapsulation propertiesandEncapsulation = new PropertiesandEncapsulation();
            propertiesandEncapsulation.Name = "Heno Queen";
            Console.WriteLine("the get method for Name property is:\t" + propertiesandEncapsulation.Name);

            //C# Inheritance 
            Car mycar = new Car();
            mycar.honk();//// Call the honk() method (From the Vehicle class) on the myCar object

            Console.WriteLine("Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class" + mycar.model + " \t brand is:\t" + mycar.brand);

            mycar.honk();

            //Now we can create Pig and Dog objects and call the animalSound() method on both of them
            Animal myanimal = new Animal();  // Create a Animal object
            myanimal.animalSound();

            Animal myDog = new Dog();   // Create a Dog object
            myDog.animalSound();

            Animal myPig = new Pig();   // Create a Pig object
            myPig.animalSound();

            /*Note :The output from the example above was probably not what you expected.
             * That is because the base class method overrides the derived class method,
             * when they share the same name.
            However, C# provides an option to override the base class method,
            by adding the virtual keyword to the method inside the base class,
            and by using the override keyword for each derived class methods:*/


            Palestine mycountry = new Palestine();
            mycountry.CitySound();// Call the abstract method
            mycountry.CapitalCountry();// Call the regular method

            //Create a MyBook object
            IBook myBook = new MyBook();
            myBook.BookName();
            myBook.BookDescription();

            //You can access enum items with the dot syntax:
            Level myLevel = Level.Low;
            Country myCountry = Country.Palestine;
         
            Console.WriteLine(myNum);

            //Files in C#
            string sourceFilePath = "source.txt";       // Path to the source file
            string destinationFilePath = "destination.txt"; // Path to the destination file

            try
            {
                // Reading from a file
                string contentToWrite = File.ReadAllText(sourceFilePath);

                // Writing to a file
                File.WriteAllText(destinationFilePath, contentToWrite);

                Console.WriteLine("File read and written successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

        }
     
        }




    }
