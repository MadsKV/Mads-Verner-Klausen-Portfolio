using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class BaseClass
    {
        public virtual void method1()
        {
            Console.WriteLine("Dichael");
        }

    }
    
    //Overloading
    //Overloading er når man har flere metoder i samme scope, med det samme navn men forskellige parameter.
    public class test
    {
        public int overloadStuff(int id)
        {
            return id;
        }
        public string overloadStuff(string name)
        {
            return name;
        }
    }

    //Overriding
    //Overriding tillader dig at ændrer funtionaliteten af en metode i en "Child class".
    public class test2 : BaseClass
    {
        public override void method1()
        {
            Console.WriteLine("Jackael");
        }
        public virtual void overrideStuff(int id)
        {
            //Get stuff default location
        }
    }

    public class test3 : test2
    {
        public override void overrideStuff(int id)
        {
            base.overrideStuff(id);
            //or - Get stuff new location
        }
    }
}
