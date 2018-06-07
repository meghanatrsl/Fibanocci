using System;
using System.Collections.Generic;
using System.Text;

namespace fibnocci
{
    class fibnoccirecursive
    {
        static void main(String[] args)
        {
            int range = int.Parse(Console.ReadLine());
            long fib = 0;
            for(int iterator = 0; iterator < range; iterator++)
            {
                Console.WriteLine(fibnocci(iterator));
            }
            
        }
        static int fibnocci(int number)
        {
            if(number == 0)
            {
                return(0);
            }
            if(number == 1)
            {
                return (int.Parse((0+" "+1)));
            }
            else
            {
                int fib = fibnocci(number - 1) + fibnocci(number - 2);
                return(fib);
            }
            Console.ReadKey();
        }
    }
}
