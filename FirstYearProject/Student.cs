using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYearProject
{
    internal class Student : IComparable
    {
        public string? Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age;
        }
        
        public int CompareTo(object? obj)
        {
            Student? student = obj as Student;
            if(this.Age > student.Age) return 1;
            if(this.Age < student.Age) return -1;
            return 0;
        }
    }
}