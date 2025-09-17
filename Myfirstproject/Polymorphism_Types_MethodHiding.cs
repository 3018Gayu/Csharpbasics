using System;
namespace Myfirstproject
{
    class Company
    {
        public void Show()
        {
            Console.WriteLine("Company Show Method");
        }
        public virtual void Display()  // Method Overriding
        {
            Console.WriteLine("Company Display Method");
        }
    }
    class Employee : Company
    {
        public new void Show()  // Method Hiding
        {
            Console.WriteLine("Employee Show Method");
        }
        public override void Display()  // Method Overriding
        {
            Console.WriteLine("Employee Display Method");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Polymorphism Types in C#");
            Company c=new Employee();
            c.Show(); // Method Hiding
            c.Display(); // Method Overriding
        }
    }
}
