using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sumofn
{
    static void Main()
    {
        int n = 20;
        int i = 1;
        int sum = 0;

        //calculating sum from 1 to n
        while (i <= n)
        {
            sum += i;
            i++;
        }

        Console.WriteLine("Sum is: " + sum);
    }
}