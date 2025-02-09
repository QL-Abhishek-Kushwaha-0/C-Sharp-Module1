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

            Console.WriteLine($"{age}, {decNum}, {doubleNum}, {ch}, {isFun}, {name}");

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
        }
    }
}