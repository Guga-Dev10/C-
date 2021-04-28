using System;

namespace Sistema_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("Error! " + dbze.Message + "\n" 
                    + "Use another type in 'result'");
            }
        }
    }
}
