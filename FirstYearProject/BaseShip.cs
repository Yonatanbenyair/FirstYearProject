using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYearProject
{
    public class BaseShip
    {
        private int counter;
        protected int speed;
        public BaseShip(int i)
        {
            Console.WriteLine("BaseShip Constructor " + i);
        }
        public virtual string Move(int distance)
        {
            counter++;
            return $"Base ship covered distance {distance}";
        }
    }
}
