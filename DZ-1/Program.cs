using System;

namespace DZ1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("How many nails? ");
            int nails = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //while (0 >= nails || nails > 10)
            //{
            //    Console.WriteLine("Dude.. Wrong input data! We need nails > 0 and <= 10");
            //}

            if (0 < nails && nails <= 10)
            {
                Console.WriteLine("How many hits?");
                int hits = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (0 < hits && hits <= 5)
                {
                    for (int i = 1; i != nails + 1; i++)
                    {
                        Console.WriteLine("Nail #" + i);
                        var n = hits;
                        while (n > 0)
                        {
                            Console.WriteLine("Knock!");
                            n--;
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Dude.. Wrong input data! We need hits > 0 and <= 5");
                }
            }
            else
            {
                Console.WriteLine("Dude.. Wrong input data! We need nails > 0 and <= 10");

            }
        }
    }
}

