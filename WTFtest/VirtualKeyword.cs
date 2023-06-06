using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTFtest
{
    internal class VirtualKeyword
    {
        class A
        {
            public virtual void Show() { Console.WriteLine("A"); }
        }

        class B : A
        {
            public override void Show() { Console.WriteLine("B"); }
        }

        class Start
        {


            static void Main(string[] args)
            {
                A ab = new A();
                B bc = new B();
                ab.Show();
                bc.Show();

                A ab1 = bc;
                ab1.Show();
            }
        }



    }
}
