using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;  // using for dll import
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

    public class CheckAccessModifier
    {
        int i;                                         //No Access specifier means private
        public int j;                                        // Public
        protected int k;                             //Protected data
        internal int m;                        // Internal means visible inside assembly
        protected internal int n;                   //inside assembly as well as to derived classes outside assembly
        static int x;                                 // This is also private
        public static int y;                       //Static means shared across objects
        [DllImport("MyDll.dll")]
        public static extern int MyFoo();       //extern means declared in this assembly defined in some other assembly

        public void CheckAccessModifierMethod()
        {
            CheckAccessModifier obj = new CheckAccessModifier();
            obj.i = 10;   //Error can’t access private data through object.But here it is accessible.:)
            obj.j = 10;
            obj.k = 10;
            obj.m = 10;
            obj.n = 10;
            //     obj.s =10;  //Errror Static data can be accessed by class names only
            CheckAccessModifier.x = 10;
            //   obj.y = 10; //Errror Static data can be accessed by class names only
            CheckAccessModifier.y = 10;
        }


    }

    public class CheckAccessModifier2 : CheckAccessModifier
    {
        public static void Main()
        {
            CheckAccessModifier2 obj2 = new CheckAccessModifier2();
            obj2.CheckAccessModifierMethod();   // using inheritance

               //Access specifiers comes into picture only when you create object of class outside the class
               CheckAccessModifier obj = new CheckAccessModifier();
            
            //    obj.i =10; //Error can’t access private data through object.
            obj.j = 10;
            //      obj.k=10;     //Error can’t access protected data through object.
            obj.m = 10;
            obj.n = 10;
            //     obj.s =10;  //Errror Static data can be accessed by class names only
           // CheckAccessModifier.x = 10;  //Error can’t access private data outside class
                                         //   obj.y = 10; //Errror Static data can be accessed by class names only
            CheckAccessModifier.y = 10;

        }
    }

}
    