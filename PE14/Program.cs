using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            public abstract class MyAbstractClass
        {
            private int xY;

            public int MyProperty
            {
                get { return xY; }
                set { xY = value; }
            }
        }
        // 2
        public interface IMyInterface
        {
            void MyMethod();
        }

        public class MyClass : IMyInterface
        {
            public void MyMethod()
            {

            }
        }

        public class MyClass2 : IMyInterface
        {
            public void MyMethod()
            {

            }
        }
//3
namespace myNamespace
    {
        public interface IMyInterface
        {
            void MyMethod();
        }

        public class MyClass : IMyInterface
        {
            public void MyMethod()
            {
                
            }
        }

        public class MyClass2 : IMyInterface
        {
            public void MyMethod()
            {
      
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
           
                MyClass myClass = new MyClass();
                CallMyMethod(myClass);

                MyClass2 myClass2 = new MyClass2();
                CallMyMethod(myClass2);

                Console.ReadLine();
            }

            public static void CallMyMethod(IMyInterface myObject)
            {
                myObject.MyMethod();
            }
        }
    }


}
}
}
