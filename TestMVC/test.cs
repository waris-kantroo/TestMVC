using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC
{
    public abstract class Test
    {
        public abstract void Area();   // abstarct can reside only in abstract class
    }
    public class Rectangle : Test
    {
        public override void Area()
        {
            Console.WriteLine("Rectangle class area :");

        }
    }


    public class testInterface : Itest, Itest2
    {
        void Itest2.Display()  // no access modifier observe.... explicit interface
        {

        }
       public  void Display()
        {

        }
    }

    public interface Itest
    {
        void Display();
    }
    public interface Itest2
    {
        void Display();
    }
}
    