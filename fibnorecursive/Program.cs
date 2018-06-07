using System; 

namespace fibnorecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int iterator = 0; iterator < range; iterator++)
            {
                Console.WriteLine(fibnocci(iterator));
            }
            Console.ReadKey();

        }
        static int fibnocci(int number)
        {
            if (number == 0)
            {
                return (0);
            }
            if (number == 1)
            {
                return  1;
            }
            else
            {
                int fib = fibnocci(number - 1) + fibnocci(number - 2);
                return (fib);
            }
            Console.ReadKey();
        }
    }
}
