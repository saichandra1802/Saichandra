using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saichandra
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.Add(1, 2, 3); 
              a.Add(1, 2);

        }
    }
 public  class A
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c = 10)
        {
            Console.WriteLine("dev");

            Console.WriteLine("dev1");

            return a + b + c;

        }
      
    }
}
