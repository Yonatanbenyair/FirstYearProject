using FirstYearProject;
using System.Numerics;
using System.Runtime.InteropServices;
internal class Program
{
    private static void Main(string[] args)
    {
        #region yonatan   
        //Student std1 = new Student() { Name = "John", Age = 22 };
        //Student std2 = new Student() { Name = "Arthur", Age = 42 };

        //Student[] students = {std1, std2};

        //foreach (Student student in students)
        //{
        //    Console.WriteLine(student);
        //}















        //Dog dog = new Dog() { Weight = 3.5, Name = "Dog Buddy"};
        //Cat cat = new Cat() { Weight = 1.5, Name = "BLACK! cat" };
        //Dragon dragon = new Dragon() { Weight = 17600, Name = "poopy dragon" };
        //Animal[] animals = new Animal[] {dog, cat, dragon};
        //foreach (Animal animal in animals)
        //{
        //    Console.WriteLine(animal.Name);
        //}
        //Dog dog1 = new Dog();
        //Console.WriteLine(Dog.Counter);
        //Console.WriteLine(Dog.DoSomthing());
        #endregion
        try
        {
            Console.WriteLine("Enter the number plesae: ");
            int num = int.Parse(Console.ReadLine());
            num = num + 3;
            Console.WriteLine("Result is:" + num);
            Test();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block excuted");
        }

        static void Test()
        {
            Console.WriteLine("enter your name");
            string? name = Console.ReadLine();
            if (name == "yonatan")
                Console.WriteLine("hello" + name);
            else
            {
                throw new Exception("Your name isnt yonatan");
            }
            Console.ReadLine();
        }
    }
}
