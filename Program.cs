using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r = float.Parse(Console.ReadLine());
            Cerchio c= new Cerchio(r);
            Cerchio c1 = Cerchio.Parse(c.ToString());
            Console.WriteLine(c1.Area());
            Console.WriteLine(c1.Perimetro());
            Console.WriteLine(c1);
            Console.ReadLine();
        }
    }
}
