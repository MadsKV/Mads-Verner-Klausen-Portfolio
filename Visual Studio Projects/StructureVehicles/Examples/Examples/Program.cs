using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            test2 t2 = new test2();
            test t1 = new test();

            Console.WriteLine( t1.overloadStuff(20));
            Console.WriteLine( t1.overloadStuff("String"));
            t2.method1();
        }
    }
}
