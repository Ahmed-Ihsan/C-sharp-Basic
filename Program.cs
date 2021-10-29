using System;
using System.Linq;
 
namespace C_
{
    class Program
    {
        string color = "red";

        static void MyMethod() {
            Console.WriteLine("I just got executed!");
        }
        
        static void MyMethod_name(string fname = "None") {
            Console.WriteLine(fname + " Refsnes");
        }

        static int sqr(int x) {
            return x*x;
        }

        static void names(string child1 = "------", string child2 = "------" , string child3 = "------") {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            /*
            Data_Type	Size	    Description
            int	        4 bytes	    Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long	    8 bytes	    Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float	    4 bytes	    Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double	    8 bytes	    Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool	    1 bit	    Stores true or false values
            char	    2 bytes	    Stores a single character/letter, surrounded by single quotes
            string	    2 bytes     per character	Stores a sequence of characters, surrounded by double quotes
            */

            int x = 0;
            string myName = "ahmed";
            // int myNum = 5;
            // double myDoubleNum = 5.99D;
            // char myLetter = 'D';
            // bool myBool = true;
            // long myNum_2 = 15000000000L;
            // float myNum3 = 5.75F;

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            while (x <= 4)
            {
                Console.Write("Hello World!. ");
                Console.Write(" i am ");
                Console.WriteLine(myName);
                x ++;
                
            }

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            string name = "John";
            Console.WriteLine("Hello " + name);
            
            /*
            Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char
            */

            double myDouble = 9.78;
            int myInt = (int) myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt); 

            int my_Int = 10;
            double my_Double = 5.25;
            bool my_Bool = true;

            Console.WriteLine(Convert.ToString(my_Int));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(my_Double));  // convert double to int
            Console.WriteLine(Convert.ToString(my_Bool));   // convert bool to string 

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            /*
            Operator	Name	        Description	                            Example	
                +	    Addition	    Adds together two values	            x + y	
                -	    Subtraction	    Subtracts one value from another	    x - y	
                *	    Multiplication	Multiplies two values	                x * y	
                /	    Division	    Divides one value by another	        x / y	
                %	    Modulus	        Returns the division remainder	        x % y	
                ++	    Increment	    Increases the value of a variable by 1	x++	
                --	    Decrement	    Decreases the value of a variable by 1	x--

                Operator	Example	    Same As	
                    =	    x = 5	    x = 5	
                    +=	    x += 3	    x = x + 3	
                    -=	    x -= 3	    x = x - 3	
                    *=	    x *= 3	    x = x * 3	
                    /=	    x /= 3	    x = x / 3	
                    %=	    x %= 3	    x = x % 3	
                    &=	    x &= 3	    x = x & 3	
                    |=	    x |= 3	    x = x | 3	
                    ^=	    x ^= 3	    x = x ^ 3	
                    >>=	    x >>= 3	    x = x >> 3	
                    <<=	    x <<= 3	    x = x << 3

                Operator	Name	                    Example	
                    ==	    Equal to	                x == y	
                    !=	    Not equal	                x != y	
                    >	    Greater than	            x > y	
                    <	    Less than	                x < y	
                    >=	    Greater than or equal to	x >= y	
                    <=	    Less than or equal to	    x <= y

                Operator	Name	        Description	                                                Example
                    && 	    Logical and	    Returns true if both statements are true	                x < 5 &&  x < 10	
                    || 	    Logical or	    Returns true if one of the statements is true	            x < 5 || x < 4	
                    !	    Logical not	    Reverse the result, returns false if the result is true	    !(x < 5 && x < 10)
            */

            double max = Math.Max(5, 10);
            double min = Math.Min(5,10);
            double Sqrt = Math.Sqrt(64);
            double abs = Math.Abs(-4.7);
            double round = Math.Round(9.99);

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(Sqrt);
            Console.WriteLine(abs);
            Console.WriteLine(round);

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt_2 = "Hello World";
            Console.WriteLine(txt_2.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt_2.ToLower());   // Outputs "hello world"

            string first_Name = "John ";
            string last_Name = "Doe";
            string name_ = string.Concat(first_Name, last_Name);
            Console.WriteLine(name_);

            firstName = "John";
            lastName = "Doe";
            name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            // Full name
            name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");
            Console.WriteLine(charPos);

            // Get last name
            lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);

            /*
                Escape character	Result	    Description
                \'	                    '	    Single quote
                \"	                    "	    Double quote
                \\	                    \	    Backslash
            */
            txt = "It\'s alright.";
            txt = "The character \\ is called backslash.";
            txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

            /*
                Code	Result	
                \n	    New Line	
                \t	    Tab	
                \b	    Backspace
            */

            int num = 10;
            int num2 = 20;
            int z = num + num2;  // z will be 30 (an integer/number)
            Console.WriteLine(z);

            string Str  = "10";
            string Str2 = "20";
            string resl = Str + Str2;  // z will be 1020 (a string)
            Console.WriteLine(z);

            num = 10;
            num2 = 9;
            Console.WriteLine(num > num2); // returns True, because 10 is higher than 9
            Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
            Console.WriteLine(num == 10); // returns True, because the value of x is equal to 10
            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

            if (20 > 18) {
                Console.WriteLine("20 is greater than 18");
            }

            num = 20;
            num2 = 18;
            if (num > num2) {
                Console.WriteLine(" num is greater than num2");
            }

            int time = 20;
            if (time < 18) {
                Console.WriteLine("Good day.");
            } else {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            time = 22;
            if (time < 10) {
                Console.WriteLine("Good morning.");
            } else if (time < 20) {
                Console.WriteLine("Good day.");
            } else {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            int day = 4;
            switch (day) 
            {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            }
            // Outputs "Thursday" (day 4)

            day = 4;
            switch (day) 
            {
            case 6:
                Console.WriteLine("Today is Saturday.");
                break;
            case 7:
                Console.WriteLine("Today is Sunday.");
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
            }
            // Outputs "Looking forward to the Weekend."

            int i = 0;
            while (i < 5) {
                Console.WriteLine(i);
                i++;
            }

            i = 0;
            do {
                Console.WriteLine(i);
                i++;
            }while (i < 5);

            for (int j = 0; j < 5; j++) {
                Console.WriteLine(j);
            }

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string car in cars) {
                Console.WriteLine(car);
            }

            for ( i = 0; i < 10; i++) {
                if (i == 4) {
                    break;
                }
                Console.WriteLine(i);
            }

             for ( i = 0; i < 10; i++) {
                if (i == 4) {
                    continue;
                }
                Console.WriteLine(i);
            }

            string[] cars_2 = {"Volvo", "BMW", "Ford", "Mazda"};
            int[] my_Num = {10, 20, 30, 40};
            
            Console.WriteLine(cars[0]);
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            for ( i = 0; i < cars.Length; i++) {
                Console.WriteLine(cars[i]);
            }

            foreach (string car in cars) {
            Console.WriteLine(car);
            }

            Array.Sort(cars);
            foreach (string car in cars){
            Console.WriteLine(car);
            }

            int[] myNumbers = {5, 1, 8, 9};
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            // Create an array of four elements, and add values later
            string[] cars_name = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars_name2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // Create an array of four elements without specifying the size 
            string[] cars_name3 = new  string[] {"Volvo", "BMW", "Ford", "Mazda"};

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars_name4 = {"Volvo", "BMW", "Ford", "Mazda"};


            // Declare an array
            string[] cars2 ;

            // Add values, using new
            cars2 = new string[] {"Volvo", "BMW", "Ford"};

            // Add values without using new (this will cause an error)
            // cars2 = {"Volvo", "BMW", "Ford"};

            MyMethod();
            MyMethod();
            MyMethod();

            MyMethod_name("ahmed");
            MyMethod_name("ali");
            MyMethod_name("Code");
            MyMethod_name();
            MyMethod_name("string");

            Console.WriteLine(sqr(2));
            x = sqr(4);
            Console.WriteLine(x);
            x = sqr(8);
            Console.WriteLine(x);

            names("ahmed","ali","cars");
            names(child2 : "ahmed" , child3: "ali" ,child1: "cars");
            names();

            Program myObj = new Program();
            Program myObj2 = new Program();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj2.color);

            bot MYbot = new bot();
            Console.WriteLine(MYbot.hi);

            MYbot.fullThrottle();

            Console.WriteLine(MYbot.name);
            MYbot.name = "Ahmed"; 
            Console.WriteLine(MYbot.name);
            Console.WriteLine(MYbot.model);

            /*
            Modifier	Description
            public	    The code is accessible for all classes
            private	    The code is only accessible within the same class
            protected	The code is accessible within the same class, or in a class that is inherited from 
                        that class. You will learn more about inheritance in a later chapter
            internal	The code is only accessible within its own assembly, but not from another 
                        assembly. You will learn more about this in a later chapter
            */

            
        }
    }
}
