using System;

namespace Enum{
    class ques3{
        enum Days{
            Sun, Mon, Tues, Wed, Thur, Fri, Sat
        };
        static void Main(String[] args){
            Console.WriteLine("Sunday: " + (int)Days.Sun);
            Console.WriteLine("Friday: " + (int)Days.Fri);

        }
    }
}