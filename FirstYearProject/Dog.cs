using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYearProject
{
    public class Dog : Animal
    {
        public static int Counter = 0;

        public Dog()
        {
            Counter++;
        }
        public static string DoSomthing()
        {
            return "Static method ready!";
        }
        public override string SayHelllo()
        {
            return $"Woof! I am a dog named {Name}.";
        }
        
    }

    public class Cat : Animal
    {
        public override string SayHelllo()
        {
            return $"myau! I am a cat named {Name}.";
        }
    }

    public class Dragon : Animal
    {
        public override string SayHelllo()
        {
            return $"Raghhhhhhhh! I am a dragon named {Name}.";
        }
    }

    public class Horse : Animal
    {
        public void Jump()
        {
            Console.WriteLine($"{Name}: Jump");
        }

        public override string SayHelllo()
        {
            return $"{Name}: Igo-go!";
        }
    }
}
