using System;
namespace ques4{

public class Overloading
{
    public void Display()
    {
        Console.WriteLine("No parameters");
    }

    public void Display(int a)
    {
        Console.WriteLine("One parameter: {0}", a);
    }

    public void Display(string a)
    {
        Console.WriteLine("One parameter: {0}", a);
    }

    public void Display(int a, string b)
    {
        Console.WriteLine("Two parameters: {0}, {1}", a, b);
    }

    public static void Main(string[] args)
    {
        Overloading obj = new Overloading();
        obj.Display();
        obj.Display(10);
        obj.Display("Hello");
        obj.Display(10, "World");
    }
}
}
