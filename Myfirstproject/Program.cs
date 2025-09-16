using System;

class Animal
{
   public virtual void sound()
   {
      Console.WriteLine("Animal makes a sound");
    }

}
class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("Dog barks");
    }
}
class cat : Animal
{
    public override void sound()
    {
        Console.WriteLine("cat meow");
    }
}
class Program
{
    static void Main()
    {
        Animal a = new Dog();
        a.sound();
        Console.WriteLine("hello");
    }
}

