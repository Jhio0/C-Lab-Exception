using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                Circle c1 = new Circle();
                c1.SetRadius(3.5);
                Console.WriteLine(c1.ToString());

                Circle c2 = new Circle();
                c2.SetRadius(-2.0);
                Console.WriteLine(c2.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle c3 = new Circle();
                c3.SetRadius(0);
                Console.WriteLine(c3.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        
    }
}
