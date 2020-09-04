using TriangleTracker;
using System;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to TriangleTracker");
      Console.WriteLine("Enter three side lengths, and I'll tell you what type of");
      Console.WriteLine("triangle it will make!");
      Console.WriteLine("Enter X:");
      int x = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Y:");
      int y = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Z:");
      int z = int.Parse(Console.ReadLine());
      Triangle triangle = new Triangle(x,y,z);
      Console.WriteLine("You just described a(n) " + triangle.OfType() + " triangle!");
      Console.WriteLine("I'm pretty smart, huh? Want to do it again? [y/n]");
      string start_over = Console.ReadLine();
      if (start_over == "y")
      {
        Main();
      }
    }
  }
}