using System;
namespace simple_arithmetic_Andrew_Creswick
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Operation: Addition");
            Console.Write("What is the 1st number? ");
            int num1Add = int.Parse(Console.ReadLine());
            Console.Write("What is the 2nd number? ");
            int num2Add = int.Parse(Console.ReadLine());
            Console.WriteLine("The answer is: " + (num1Add + num2Add));

            Console.WriteLine("Operation: Subtraction");
            Console.Write("What is the 1st number? ");
            int num1Sub = int.Parse(Console.ReadLine());
            Console.Write("What is the 2nd number? ");
            int num2Sub = int.Parse(Console.ReadLine());
            Console.WriteLine("The answer is: " + (num1Sub - num1Sub));

            Console.WriteLine("Operation: Multiplication");
            Console.Write("What is the 1st number? ");
            int num1Mult = int.Parse(Console.ReadLine());
            Console.Write("What is the 2nd number? ");
            int num2Mult = int.Parse(Console.ReadLine());
            Console.WriteLine("The answer is: " + (num1Mult * num1Mult));

            Console.WriteLine("Operation: Integer Division");
            Console.Write("What is the 1st number? ");
            int num1Div = int.Parse(Console.ReadLine());
            Console.Write("What is the 2nd number? ");
            int num2Div = int.Parse(Console.ReadLine());
            Console.WriteLine("The answer is: " + (num1Div / num2Div));
            Console.WriteLine("Operation: Floating Point/Decimal Division");
            Console.Write("What is the 1st number? ");
            float num1Float = float.Parse(Console.ReadLine());
            Console.Write("What is the 2nd number? ");
            float num2Float = float.Parse(Console.ReadLine());
            Console.WriteLine("The answer is: " + (num1Float / num2Float));


            Console.WriteLine("Operation: Modulus");
            Console.Write("What is the 1st number? ");
            int num1Mod = int.Parse(Console.ReadLine());
            Console.Write("What is the 2nd number? ");
            int num2Mod = int.Parse(Console.ReadLine());
            Console.WriteLine("The answer is: " + (num1Mod % num2Mod));
        }
    }
}
