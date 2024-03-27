namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberDateTypes();
            //TextBasedDataTypes();
            ConvertingTypes();
            
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

            Console.ReadLine();
        }

        static void TextBasedDataTypes()
        {
            string name = "Aba";
            char letter = 'A';

            Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.WriteLine($"Your name is {name}, it starts with the letter {letter}.");

            Console.ReadLine();
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
    }
}