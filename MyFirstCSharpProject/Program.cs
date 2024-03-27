namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberDateTypes();
            TextBasedDataTypes();
            ConvertingTypes();
            BooleanType();
            Operators();
            Remainder();
            VarKeyword();
            
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
    }
}