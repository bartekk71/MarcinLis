using System;

namespace TrainingMarcinLisExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. My first app
            Console.WriteLine("Hello World! My first C# application!");
            Console.ReadKey();

            //2. My second app
            Console.WriteLine("Hahahahaha!");
            Console.ReadKey();

            //3. Deklarowanie zmiennych
            int number;

            number = 8;

            Console.WriteLine(number);

            Console.WriteLine("Number is: " + number);

            //Console.WriteLine("zm1 {0}, zm2 {1}, zm1, zm2);

            //4.
            int firstNumber;
            int secondNumber;

            firstNumber = 125;
            secondNumber = 350;

            Console.WriteLine("First number is: " + firstNumber);
            Console.WriteLine("Second number is: " + secondNumber);

            //5.Jednoczesna deklaracja i inicjaliacja zmiennych.
            int thirdNumber = 10;
            int fourthNumber = 40;
            int i, j, k;

            i = 0;
            j = 0;
            k = 1;

            int sum;

            sum = thirdNumber + fourthNumber;

            Console.WriteLine("Third number is: " + thirdNumber);
            Console.WriteLine("Fourth number is: " + fourthNumber);
            Console.WriteLine("i: " + i);
            Console.WriteLine("j: " + j);
            Console.WriteLine("k: " + k);
            Console.WriteLine("Sum is: " + sum);

            //6. Proste operacje arytmetyczne
            int a, b, c;

            a = 10;
            b = 25;
            c = b - a;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("b - a = " + c);
            c = a * b;
            Console.WriteLine("a * b = " + c);

            //7. Dzielenie modulo
            int d, e, f;
            d = 10;
            e = 25;
            f = d % e;
            Console.WriteLine("e % d = " + f);
            Console.WriteLine("11 % 3 = " + 11 % 3);
            f = d * e;
            Console.WriteLine("(d * e) % 120 = " + f % 120);

            //8. Operator inkrementacji
            int x = 1, y;
            Console.WriteLine(++x);
            Console.WriteLine(x++);
            Console.WriteLine(x);
            y = x++;
            Console.WriteLine(y);
            y = ++x;
            Console.WriteLine(++y);
        }
    }
}
