using System;

namespace abs{
    abstract class Animal{
        public abstract void Walk();
        public abstract void Run();
        
    }
    class Lion : Animal{
        public override void Walk(){
            Console.WriteLine("The Lion is walking");
        }
        public override void Run(){
            Console.WriteLine("The Lion is running");
        }
    }
    class Tiger : Animal{
        public override void Walk(){
            Console.WriteLine("The Tiger is walking");
        }
        public override void Run(){
            Console.WriteLine("The Tiger is running");
        }
    }
    class Q3{
        public static void Main(String[] args){
            Animal lion = new Lion();
            lion.Walk();
            lion.Run();
            Animal tiger = new Tiger();
            tiger.Walk();
            tiger.Run();
            Console.ReadLine();

        }
    }


}