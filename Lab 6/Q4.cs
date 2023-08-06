using System;

namespace overloading{
  class Calc
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Q4
{
    static void Main(string[] args)
    {
        Calc c = new Calc();

        int sum1 = c.Add(7, 5);
        Console.WriteLine("Sum 1: " + sum1);

        double sum2 = c.Add(2.8, 4.7);
        Console.WriteLine("Sum 2: " + sum2);

        int sum3 = c.Add(7, 2, 9);
        Console.WriteLine("Sum 3: " + sum3);

        Console.ReadLine();
    }
}

}