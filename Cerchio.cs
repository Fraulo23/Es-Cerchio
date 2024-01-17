using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Cerchio
{
    internal class Cerchio
    {
        public float Raggio { get; set; }
        public Cerchio(float raggio)
        {
            Raggio = raggio;
        }
        public float Area()
        {
            return (float)(Math.PI * Raggio * Raggio);
        }
        public float Perimetro()
        {
            return (float)(Math.PI * Raggio*2);
        }
    }
}
