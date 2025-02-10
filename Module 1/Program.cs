using System;

namespace Module_1
{
    class Module1
    {
        public static void Main(string[] args)
        {
            // Task 2
            
            // Q1 :- Create programs using all type of Variables (Variables, Constants, Display Variables, Multiple Variables, Identifiers).

            // Variables -> Containers to contain variable values which can be re assigned
            int age = 12;
            float decNum = 1.2f;
            double doubleNum = 2.3;
            char ch = '$';
            bool isFun = true;
            string name = "Osama Bin Laden";

            string str1 = "Abhishek";
            string str2 = "Abhishek";

            Console.WriteLine($"{age}, {decNum}, {doubleNum}, {ch}, {isFun}, {name}, {str1 == str2}, {str1.Equals(str2)}");

            // Constants -> Containers to contain values which cannot be reassigned
            //              const keyword -> used to declare a variable as constant (i.e. it's value cannot be reassigned
            //              const cannot be declared without assigning the value
            const int val = 12;
            const string str = "Constant String";
            Console.WriteLine($"{val}, {str}");

            // Display Variables -> Used to display variables to the console window
            Console.WriteLine("This is Display Variable");

            // Multiple Variables -> Declaring more than One variable in a single line
            int a, b, c;
            a = b = c = 12;

            // Identifiers -> Unique names of Variables
            string countryName = "Australia";  // Here, variable name clearly indicates that it's used to store name of Country.
            int empAge = 33;  // It indicates Employee's age

            // Q.2 :- Create programs using all type of Data Types (int, long, float, double, bool, char, string)

            string studentName = "Elma batter";
            int studentAge = 19;
            float weight = 55.25f;
            bool isIntelligent = true;
            char grade = 'A';
            long rollNo = 23645978;

            Console.WriteLine($"{a}, {b}, {c}, {countryName}, {empAge}, {studentAge}, {studentName}, {weight}, {isIntelligent}, {grade}, {rollNo}");

            // Q.3 :- Create programs for showing Type casting (Implicit & Explicit)

            // 1. Implicit Type Casting -> Automatically converts smaller datatype to larger datatype.
            //                             No Data loss occur
            //                             char -> int -> long -> float -> double
            int num1 = 123;
            double num2 = num1;
            //int num3 = num2;   -> This line will give error  => Bcoz we're trying to convert large datatype to small

            Console.WriteLine($"{num1} {num1.GetType()}");
            Console.WriteLine($"{num2} {num2.GetType()}");

            // 2. Explicit Type Casting -> It converts larger datatypes to smaller datatype and needs to be done manually
            //                             Data loss Occurs in this type casting
            //                             double -> float -> long -> int -> char
            int num3 = (int)num2;  // This will convert double to int

            Console.WriteLine($"{num3} {num3.GetType().Name}");
            Console.WriteLine($"{num2} {num2.GetType().Name}");

            // 3. Convert Class -> Type casting using built in methods of Convert class
            char letter = 'A';  // Char cannot be converted to double or boolean
            Console.WriteLine($"{Convert.ToInt32(letter)}, {Convert.ToString(letter)}");
            int number = 23;
            Console.WriteLine($"{(char)(number)},{Convert.ToString(number)}, {Convert.ToBoolean(number)}, {Convert.ToDouble(number)}, {Convert.ToByte(number)}, {Convert.ToDecimal(number)}");

            // 4. Parse and TryParse -> Convert the string ("123") to number
            // i) Parse throws error if string contains anything other than Numbers
            // In order to avoid errors we use safer version i.e. TryParse
            // TryParse first check if it can be parsed or not and then it parse it

            string numString = "12345";
            string numString2 = "123abc";  // It will give error when converted to int as it     is not in the correct format
            Console.WriteLine($"{Convert.ToInt32(numString)}, {Convert.ToDouble(numString)}, {int.Parse(numString)}");
            if(int.TryParse(numString2, out var res))
            {
                Console.WriteLine(res);
            } else
            {
                Console.WriteLine("The String is not in required format");
            }


            // ------------------> TASK 3 <-------------------

            // Q.1 :- Basic Calculator – Take two numbers as input and perform addition, subtraction, multiplication, division, and modulus operations.

            Console.Write("Enter the first Number : ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second Number : ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operation number you want to perform : \n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Modulus");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine($"{"Addition : "} {number1 + number2}");
                    break;
                case 2:
                    Console.WriteLine($"{"Subtraction : "} {number1 - number2}");
                    break;
                case 3:
                    Console.WriteLine($"{"Multiplication : "} {number1 * number2}");
                    break;
                case 4:
                    if (number2 != 0)
                    {
                        Console.WriteLine($"{"Division : "} {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation");
                    }
                    break;
                case 5:
                    if (number2 != 0)
                    {
                        Console.WriteLine($"{"Remainder : "} {number1 % number2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation");
                    }
                    break;
                default:
                    Console.WriteLine("Enter valid operation number!!");
                    break;
            }

            //// Q.2 -> Voting Eligibility Checker – Ask the user for their age and citizenship status (Y/N) and determine if they are eligible to vote (Age ≥ 18 and must be a citizen).

            Console.Write("Enter your age : ");
            int ageOfVoter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you a Citizen of this country (Y/N) : ");
            char citizenStatus = Convert.ToChar(Console.ReadLine());
            if (ageOfVoter >= 18 && (citizenStatus == 'Y' || citizenStatus == 'y'))
            {
                Console.WriteLine("Yes, You are eligible to cast your vote!!!");
            }
            else
            {
                Console.WriteLine("You are not eligible to cast your vote");
            }

            // Q.3 -> Find the Largest Number – Take three numbers as input and determine the largest using comparison operators.
            Console.Write("Enter first number : ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum >= secondNum)
            {
                if(firstNum >= thirdNum)
                {
                    Console.WriteLine($"{firstNum} {"is the largest one!!"}");
                } else
                {
                    Console.WriteLine($"{thirdNum} {"is the largest one!!"}");
                }
            }
            else if (secondNum >= thirdNum)
            {
                Console.WriteLine($"{secondNum} {"is the largest one!!"}");
            } else
            {
                Console.WriteLine($"{thirdNum} {"is the largest one!!"}");
            }

            // ---------------> TASK : 4 <------------------

            // Q.1 :- Full Name Generator – Take first name and last name as input and display the full name using concatenation (+) and string interpolation ($"").

            Console.Write("Enter your first name : ");
            string fName = Console.ReadLine() ?? "";
            Console.Write("Enter your last name : ");
            string lName = Console.ReadLine() ?? "";
            Console.WriteLine("Using Concatenation : " + fName + " " + lName);
            Console.WriteLine($"{"Using String Interpolation :"} {fName} {lName}");

            // Q.2 :- Character Extractor – Take a string as input and print the first, last, and middle character (if the length is odd) using indexing.
            Console.Write("Enter the string : ");
            string inputString = Console.ReadLine() ?? "";
            Console.WriteLine($"{"First Character : "}{inputString[0]}");
            Console.WriteLine($"{"Last Character : "}{inputString[inputString.Length - 1]}");
            Console.WriteLine($"{"Middle Character : "}{inputString[inputString.Length / 2]}");

            // Q.3 :- Escape Sequence Formatter – Print a multi-line formatted string using special characters (\n, \t, \", \\) to display a structured output.
            Console.WriteLine("This line will terminate using New Line Character\n\tThis Line is having some gap in beginning due to the tab space.\nNow, for Inverted commas -> \"We Use Backslash\"\nAnd finally the backslash can be printed using double backslash i.e. \\");

            // Q.4 :- Even or Odd Checker – Take a number as input and use a boolean expression to check if it is even (true) or odd (false).
            Console.Write("Enter the number to be checked : ");
            int numToCheck = Convert.ToInt32(Console.ReadLine());
            if(numToCheck % 2 == 0)
            {
                Console.WriteLine("True, the number is Even!!");
            } else
            {
                Console.WriteLine("False, the number is Odd");
            }

            // Q.5 :- Login Authentication – Take a username and password as input, compare them with predefined values, and return true if they match, otherwise false.
            string definedUsername = "Mr_Abhishek001";
            string definedPassword = "Password";

            Console.Write("Enter your Username : ");
            string userName = Console.ReadLine() ?? "";
            Console.Write("Enter your password : ");
            string password = Console.ReadLine() ?? "";

            if (userName.Equals(definedUsername) && password.Equals(definedPassword)) {
                Console.WriteLine("True, Your credential matches with defined ones!!");
            } else
            {
                Console.WriteLine("False, Wronog Credentials.");
            }

            // Q.6 :- Leap Year Validator – Take a year as input and check if it is a leap year using boolean conditions (true for leap year, false otherwise).
            Console.Write("Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("True, This is a leap year");
            } else
            {
                Console.WriteLine("False, This is not a leap year");
            }

            // --------------------> TASK 5 <--------------------

            // Q.1 (a) : Grade Calculator – Take a student's score as input and determine the grade (A, B, C, D, or F) using an if-else statement.
            Console.Write("Enter the marks of student out of 100 : ");
            int studentMarks = Convert.ToInt32(Console.ReadLine());
            if(studentMarks >= 90)
            {
                Console.WriteLine("Grade : A");
            } else if(studentMarks >= 80)
            {
                Console.WriteLine("Grade : B");
            } else if (studentMarks >= 70)
            {
                Console.WriteLine("Grade : C");
            } else if (studentMarks >= 60)
            {
                Console.WriteLine("Grade : D");
            } else if(studentMarks >= 40)
            {
                Console.WriteLine("Grade : E");
            }
            else
            {
                Console.WriteLine("Grade : F");
            }

            // Q.1 (b) :- Day of the Week – Take a number (1-7) as input and display the corresponding day of the week using a switch statement.
            Console.Write("Enter a Number between 1 - 7");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            switch(dayNum)
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
                default:
                    Console.WriteLine("Wrong input!!!");
                    break;
            }

            // Q.1 (c) :- Even or Odd (Switch Expression) – Use a switch expression to check if a number is even or odd.
            Console.Write("Enter the number to be checked : ");
            int numCheck = Convert.ToInt32(Console.ReadLine());
            switch (numCheck % 2) {
                case 0:
                    Console.WriteLine($"{numCheck} {"is Even Number"}");
                        break;
                case 1:
                    Console.WriteLine($"{numCheck} {"is Odd Number"}");
                    break;
            }

            // Q.2 (a) :- Multiplication Table – Take a number as input and print its multiplication table using a for loop.
            Console.Write("Enter the number for which table needs to be generated : ");
            int tableNum = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(tableNum * i);
            }

            // Q.2 (b) :- Sum of Array Elements – Given an array of numbers, use a foreach loop to calculate and display the sum.
            int[] nums = { 23, 34, 46, 57, 21 };
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine("Sum of all elements in array Nums is : {0}", sum);

            // Q.2 (c) :- Number Guessing Game – Generate a random number (1-100) and let the user guess it using a while loop until they get it right.
            Random random = new Random();
            int randomNum = random.Next(1, 101);
            Console.WriteLine("Random Number : {0}", randomNum);
            Console.Write("Guess the Number (1 - 100) : ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            while(true)
            {
                if(randomNum == userGuess)
                {
                    Console.WriteLine("You Win, You guessed it right!!");
                    break;
                }
                Console.Write("Wrong Guess!! Guess again : ");
                userGuess = Convert.ToInt32(Console.ReadLine());
            }

            // Q.3 (a) :- Find First Divisible Number – Use a for loop to find the first number divisible by both 3 and 5 in a given range. Use break to exit the loop when found.

            Console.Write("Enter the start of the range : ");
            int startRange = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range : ");
            int endRange = Convert.ToInt32(Console.ReadLine());

            for (int i = startRange; i <= endRange; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("First Number divisible by both 3 and 5 is : {0}", i);
                    break;
                }
            }

            // Q.3 (b) :- Skip Even Numbers – Print numbers from 1 to 10 using a for loop but skip even numbers using continue.
            Console.WriteLine("Numbers between 1 - 10 skipping Even Numbers : ");
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }

            // Q.3 (c) :- User Login Attempts – Allow the user to enter a password with a maximum of 3 attempts using a while loop and break if successful.
            int attempts = 0;
            Console.Write("Enter the Password : ");
            while (true)
            {
                string userPass = Console.ReadLine() ?? "";
                if (userPass == definedPassword)
                {
                    Console.WriteLine("Correct Password!!");
                    break;
                }
                else
                {
                    attempts++;
                }
                if (attempts == 3)
                {
                    Console.WriteLine("You have attempted 3 times. Try again after 15 minutes!!");
                    break;
                }
                Console.Write("Wrong Password!! Try again : ");
            }
        }
    }
}