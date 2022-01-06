using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
             static void Main(string[] args)
        {
            float number = 1;
            int sum = 0;
            int evens = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + 1;
                    }
                }

                if (sum % 2 == 0)
                {
                    evens++;
                }

                sum = 0;
            }

            Console.WriteLine(evens);
        }
    }
}
