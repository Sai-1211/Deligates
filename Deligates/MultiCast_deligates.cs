using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    public delegate void Arithmetic();
    internal class MultiCast_deligates
    {
        // Methods
        public void Add()
        {
            int a = 10, b = 40;
            Console.WriteLine($"{a+b}");
        }
        public void sub()
        {
            int a = 60, b = 40;
            Console.WriteLine($"{a - b}");
        }
        public void Mul()
        {
            int a = 40, b = 40;
            Console.WriteLine($"{a * b}");
        }
        public void Div()
        {
            int a = 600, b = 40;
            Console.WriteLine($"{a / b}");
        }


        // Delegate calling 
        public void MultiCast()
        {
            Arithmetic ab = new Arithmetic(Add);
            Arithmetic ac = new Arithmetic(sub);
            Arithmetic ad = new Arithmetic(Mul);
            Arithmetic ae = new Arithmetic(Div);

            ab(); //50
            ac += ab; 
            ac();//70
            ad -= ac;
            ad();
            ae += ad;
            ae();
        }
    }
}
