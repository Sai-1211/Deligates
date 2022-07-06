using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    internal class Predefined_deligates
    {
        public int Add()
        {
            int a=10,b=20;
            return a + b;
            //Console.WriteLine($"{c=a+b}");
        }

        public void Mul()
        {
            
            int a = 10, b = 20;
            //return c = a + b;
            Console.WriteLine($"{ a * b}");
        }

        public bool oddnumber(int x)
        {
            //int a = 34;
            if (x%2 != 0)
            {
                return true; // odd number
            }
            else
            {
                return false;// even number
            }
        }

        public void Func_Deligate()
        {
            //Func() deligate Normal Method
            Func<int> a1 = Add;
            Console.WriteLine($"{a1()}"); 

            //Func() deligate Asynch Method
            Func<int> a2 = delegate ()
            {
                int a = 10, b = 40;
                return a + b;
            };
            Console.WriteLine($"{a2()}");
        }

        public void Action_deligate()
        {
            //Normal Method
            Action b1 = Mul;
            b1();

            //Action deligate Async Method
            Action b2 = delegate ()
            {
                int a = 20, b = 30;
                Console.WriteLine($"{a*b}");
            };
            b2();
        }

        public void Predicate_Deligate()
        {
            //Normal Method
            Predicate<int> c1 = oddnumber;
            Console.WriteLine(c1(4));

            // Predicate Async Method 
            Predicate<int> c2 = delegate (int z)
            {
                if (z % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };
            Console.WriteLine($"{c2(10)}");
        }
       
        
    }
}
