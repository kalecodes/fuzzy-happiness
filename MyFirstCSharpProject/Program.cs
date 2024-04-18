namespace MyFirstCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberDateTypes();
            //TextBasedDataTypes();
            //ConvertingTypes();
            //BooleanType();
            //Operators();
            //Remainder();
            //VarKeyword();
            //ConstKeyword();
            //Exercise1();
            //Exercise2();
            //ConsoleInputOutput();
            //IfStatements();
            //SwitchStatements();
            Loops();

        }

        static void NumberDateTypes()
        {
            //int x;
            //int y;
            //int z;

            int x, y, z;
            int a = 5, b = 10, c = 20;


            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long bigNumber = 8948498L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float precision = 5.00001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            //Console.ReadLine();
        }

        static void TextBasedDataTypes()
        {
            string name = "Aba";
            char letter = 'A';

            Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.WriteLine($"Your name is {name}, it starts with the letter {letter}.");

            //Console.ReadLine();
        }

        static void ConvertingTypes()
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());

            string textBigNumber = "90000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);
            Console.WriteLine(bigNumber.GetType());

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
            Console.WriteLine(negative.GetType());

            string textPrecision = "5.0000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
            Console.WriteLine(precision.GetType());

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
            Console.WriteLine(money.GetType());
        }

        static void BooleanType()
        {
            bool value = false;
            bool isMale = true;
            Console.WriteLine(value);
            Console.WriteLine(isMale);
        }

        static void Operators()
        {
            // + - * /

            int age = 23;
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            age = age + 1;
            Console.WriteLine(age);
            age += 1;
            Console.WriteLine(age);
            age += 10;
            Console.WriteLine(age);

            int year = 2024;
            year /= 2;
            Console.WriteLine(year);

            string name = "Abe";
            name += " is programming";
            Console.WriteLine(name);

            // this does not work correctly because it is trying to add the unicode values together
            char letter = 'a';
            letter += 'b';
            Console.WriteLine(letter);

            // the ++ before the variable tells the compiler to execute the operation first, then return the value
            // the ++ after returns the value first, and then executes the operation
            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(++i);

        }

        static void Remainder()
        {
            int firstNum = 10;
            int secondNum = 3;
            // This will truncate the result to another integer (3)
            Console.WriteLine(firstNum / secondNum); // 3.333
            // This is called the 'modulus operator', which gives us the remainder
            Console.WriteLine(firstNum % secondNum); // 3r1

            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);
        }

        static void VarKeyword()
        {
            // the compiler will figure out what type it needs to be based on the value it is initialized with
            // best practive to only use var when it is very obvious what the type is going to be (to improve read time)
            var age = 23;
            Console.WriteLine(age.GetType());
            var bigNumber = 90000L;
            Console.WriteLine(bigNumber.GetType());
            var negative = -55.2D;
            Console.WriteLine(negative.GetType());
        }

        static void ConstKeyword()
        {

            int vat = 20;
            vat = 22;
            Console.WriteLine(vat);

            const int sales = 6;
            //sales = 8;
            // reassinging this constant will throw a compile error
            Console.WriteLine(sales);
        }

        static void Exercise1()
        {
            var firstName = "Kalen";
            var phone = "1234567891";
            var age = 27;

            Console.WriteLine(firstName);
            Console.WriteLine(phone);
            Console.WriteLine(age);

            Console.WriteLine($"Hi, my name is {firstName}. I am currently {age} years old. My phone number is {phone}");
        }

        static void Exercise2()
        {
            /*
             * Create & intialize two ints
             * Make a variable to work out the remainder
             * Output remainder to the screen
             * Change the first int variable to another number
                * and recalculate the remainder
                * output new remainder to the screen
            */
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            num1 = 11;
            remainder = num1 % num2;
            Console.WriteLine(remainder);
        }

        static void ConsoleInputOutput()
        {
            // Console WriteLine has a terminator at the end, Console Write will output the next function on the same line.
            Console.WriteLine("Hello my name is Aba!");
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Your name is ");
            Console.WriteLine(name);
            Console.Write("Your age is ");
            Console.WriteLine(age);
            Console.WriteLine("Your name is " + name + " and your age is " + age + ".");
            Console.WriteLine($"Your name is {name} and your age is {age}");
        }

        static void IfStatements()
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Your name is " + name + " and your age is " + age);

            //if (age < 0 || age > 150)
            //{
            //    Console.WriteLine("Invalid Age");
            //}
            //else
            //{
            //    if (age >= 18 && age < 21)
            //    {
            //        Console.WriteLine("You are an adult.");
            //    }
            //    else if (age >= 21)
            //    {
            //        Console.WriteLine("You are and adult old enough to drink.");
            //    }
            //    else if (age >= 13)
            //    {
            //        Console.WriteLine("Your are a teenager.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are a child.");
            //    }
            //}

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int actualAnswer = numberA * numberB;

            Console.Write($"Value of {numberA} x {numberB}: ");
            int answerInput = Convert.ToInt32(Console.ReadLine());

            if  (answerInput ==  actualAnswer)
            {
                Console.WriteLine("Correct. Well Done!");
            }
            else
            {
                Console.WriteLine("Sorry, that is incorrect.");
            }
        }

        static void SwitchStatements()
        {
            Console.WriteLine("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            string weekday;
            switch (day)
            {
                case 1: weekday = "Monday";
                    break;
                case 2: weekday = "Tuesday";
                    break;
                case 3: weekday = "Wednesday";
                    break;
                case 4: weekday = "Thursday";
                    break;
                case 5: weekday = "Friday";
                    break;
                case 6: weekday = "Saturday";
                    break;
                case 7: weekday = "Sunday";
                    break;
                default: weekday = "Invalid. Please enter a number between 1 and 7.";
                    break;
            }

            Console.WriteLine(weekday);
        }

        static void Loops()
        {
            // for loops
            //Console.WriteLine("What message do you want to repeat?");
            //string message = Console.ReadLine();
            //Console.WriteLine("How many times do you want to say hi?");
            //int loopCounter = Convert.ToInt32(Console.ReadLine());
            //if (loopCounter <= 0)
            //{
            //    Console.WriteLine("Please enter a number greater than 0");
            //} else
            //{
            //    for (int i = 0; i < loopCounter; i++)
            //    {
            //        Console.WriteLine(message);
            //    }
            //}

            // while loops

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int actualAnswer = numberA * numberB;
            int answerInput = 0;

            Console.WriteLine($"What is the value of {numberA} x {numberB}?");

            //while (answerInput != actualAnswer)
            //{
            //    // checks the condition first, then executes
            //    answerInput = Convert.ToInt32(Console.ReadLine());
            //    if (answerInput != actualAnswer)
            //    {
            //        Console.WriteLine("Sorry, that is incorrect. Please try again.");
            //        Console.WriteLine();
            //    }
            //}

            do
            {
                // completes the action first, then checks the condition
                answerInput = Convert.ToInt32(Console.ReadLine());
                if (answerInput != actualAnswer)
                {
                    Console.WriteLine("Sorry, that is incorrect. Please try again.");
                    Console.WriteLine();
                }
            } while (answerInput != actualAnswer);

            Console.WriteLine("Correct, well done!");
        }
    }
}