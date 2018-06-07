using System;

namespace fibnocci
{
    class fibnocciloop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the range of the numbers");
            int range = int.Parse(Console.ReadLine());
            try
            {
                bool myval = range.
                if(range)
            }
            
            int first_no = 0, second_no = 1;
            Console.WriteLine(first_no);
            Console.WriteLine(second_no);
            for(int iterator = 0; iterator < range; iterator++)
            {
                int third_no = first_no + second_no;
                Console.WriteLine(third_no);
                first_no = second_no;
                second_no = third_no;
            }
            Console.ReadKey();
        }
        
    }
}
