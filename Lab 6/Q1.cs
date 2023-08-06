using System;

namespace inheritance{
    class MCA{
        public void course(){
            Console.WriteLine("Master of Computer Application");
        }
    }
    class Semester2 : MCA{
        public void subjects(){
            Console.WriteLine("5"); 
        }   
    }

    class Q1{
        public static void Main(String[] args){
            MCA m= new MCA();
            m.course();
            Semester2 s= new Semester2();
            s.subjects();
            Console.ReadLine();
        }

    }
}
