using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double min, max;

            SuperList spList = new SuperList { 1.0, 3.5, 2.7, 60.4, 17.4, 0.8 };

            spList.GetMinMax(out min, out max);

            Console.WriteLine($"min is {min}, max is {max}");
            Console.ReadKey();
        }
    }
}
