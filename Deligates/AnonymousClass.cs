using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    internal class AnonymousClass
    {
        public delegate void Evennumbers();
        public void SingleCast_Delegate() 
        {
            //Synchronous Method
            Evennumbers abc = new Evennumbers(EvennumbersMethod);
            abc();

            //Asynchronous Method
            Evennumbers bbc = () =>
            {
                int n;
                Console.WriteLine("Enter the value for Async:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 != 0)
                {
                    Console.WriteLine("Number is odd");
                }
                else
                    Console.WriteLine("Number is Not odd");
            };
            bbc();
        }

        //Synchronuous Method call function
        public void EvennumbersMethod()
        {
            int n;
            Console.WriteLine("Enter the number");
            n= Convert.ToInt32(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("Number is Even"); 
            }
            else 
            { 
                Console.WriteLine("Number is not Even"); 
            }
            
        }

    }
}
