using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //w3resource.com/csharp-exercises/basic/index.php

            //1
            Console.Write("Hello:");
            Console.Write(" Nick Wise\n");

            //2
            int a = 5;
            int b = 6;
            int sum = (a + b);

            Console.WriteLine(sum);

            //OR

            int sums = (5 + 6);

            Console.WriteLine(sums);

            //3
            int c = 18;
            int d = 2;
            int div = (c / d);

            Console.WriteLine(div);

            //OR

            int divs = (18 / 2);

            Console.WriteLine(divs);

            //4
            Console.WriteLine((4*6) -1);
            Console.WriteLine((35+5) % 7);
            Console.WriteLine(((4*6) / 11) + 14 - 4);
            Console.WriteLine(2+15/6*1-7%2);

            //5
            //N/A
            //6
            Console.WriteLine("Enter three numbers");
            Console.WriteLine("First number: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Third number: ");
            int numThree = int.Parse(Console.ReadLine());
            Console.WriteLine(numOne + " x " + numTwo + " x " + numThree + " = ");
            Console.WriteLine("Press ENTER to multiply");
            Console.ReadKey();
            Console.WriteLine(numOne * numTwo * numThree);

            //7
            Console.WriteLine("Enter the first number");
            int unoNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int dosNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Press enter to see the math: ");
            Console.ReadKey();
            Console.WriteLine(unoNum + "+" + dosNum + "=" +(unoNum + dosNum));
            Console.WriteLine(unoNum + "-" + dosNum + "=" +(unoNum - dosNum));
            Console.WriteLine(unoNum + "x" + dosNum + "=" +(unoNum * dosNum));
            Console.WriteLine(unoNum + "/" + dosNum + "=" + (unoNum / dosNum));
            Console.WriteLine(unoNum + "%" + dosNum + "=" + (unoNum % dosNum));

            //8



        }
    }
}
