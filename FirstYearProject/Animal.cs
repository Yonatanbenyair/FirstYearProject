using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYearProject
{
    public class Animal
    {
        public double Weight { get; set; }
        public string? Name { get; set; }
        public string? description { get; set; }


        public virtual string SayHelllo()
        {
            return $"hello, I am {Name}, and i weigh {Weight}, i am a{description}";
        }
    }
}
