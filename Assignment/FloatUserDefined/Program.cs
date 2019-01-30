using System;

namespace FloatUserDefined
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter first float number: ");
            FloatUser input1=new FloatUser(Console.ReadLine());
            Console.WriteLine("Enter second float number: ");
            FloatUser input2=new FloatUser(Console.ReadLine());
            FloatUser result=new FloatUser();
            result=result.floatAddition(input1,input2);
            input1.displayIEEE();
            input2.displayIEEE();
            Console.WriteLine("\n\nAddition of given float numbers is ");
            result.displayIEEE();
            Console.ReadKey();
        }
    }
}