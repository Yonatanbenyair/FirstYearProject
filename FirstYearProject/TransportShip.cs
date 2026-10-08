using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYearProject
{
    public class TransportShip : BaseShip
    {
        public TransportShip(int i) : base(5)
        {
            Console.WriteLine("Transportship constructor");
        }

        public override string Move(int distance)
        {
            return $"transportship covered distance {distance}";
        }

        public override string ToString()
        {
            return "trans";
        }
    }
}
