using System;

namespace calculate{

delegate int Calc(int a, int b);
    class Calculator{
        public static int Add(int a, int b){
            return a+b;
        }
        public static int Sub(int a, int b){
            return a-b;
        }

        static void Main(String[] args){
            Calc c = Calculator.Add;
            int result = c(7,3);
            Console.WriteLine("Addition: " + result);

            c = Calculator.Sub;
            result = c(7,3);
            Console.WriteLine("Subtraction: " + result);            

        }
    }
}