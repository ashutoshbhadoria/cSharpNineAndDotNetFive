using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      object height = 1.88;
      object name = "Amir";
      Console.WriteLine($"{name} is {height} meters tall.");
      // int length1 = name.Length; // Compilation error.
      int length2 = ((string)name).Length;
      Console.WriteLine($"{name} has {length2} characters.");

      dynamic anotherName = "Ahmed";
      // this compiles but would throw an exception at run-time if you later store a data type that does not have a property named Length
      int length = anotherName.Length; // Intelisense won't work.
      Console.WriteLine($"{anotherName} has {length} characters.");
    }
  }
}
