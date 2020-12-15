using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Data.DataSet dataSet;
      System.Net.Http.HttpClient client;

      foreach (var referencedAssembly in Assembly.GetEntryAssembly().GetReferencedAssemblies())
      {
        var assembly = Assembly.Load(referencedAssembly.FullName);

        var methodCount = 0;

        foreach (var type in assembly.DefinedTypes)
        {
          methodCount += type.GetMethods().Count();
        }

        Console.WriteLine("{0:N0} types with {1:N0} methods in the {2} assembly", arg0: assembly.DefinedTypes.Count(), arg1: methodCount, arg2: referencedAssembly.Name);
      }
    }
  }
}
