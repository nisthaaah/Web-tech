using System;

namespace overriding{
    class Animal{
        public virtual void sound(){
            Console.WriteLine("Animal sound");
        }
    }
    class Dog : Animal{
        public override void sound(){
            Console.WriteLine("The dog is barking");
        }
    }
    class Q2{
        public static void Main(String[] args){
            Animal a= new Animal();
            a.sound();
            Dog d= new Dog();
            d.sound();
            Console.ReadLine();
        }
    }



}