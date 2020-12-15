using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // unsigned integer means positive whole numbers including 0.
      uint naturalNumber = 23;
      // integer means positive or negative whole numbers including 0.
      int integerNumber = -23;
      // float means single precision floating point.
      // F suffix makes it a floating point literal.
      float realNumber = 2.3F;
      // double means double precision floating point.
      double anotherRealNumber = 2.3;

      // Three representations of the number 2 million.
      int decimalNotation = 2_000_000;
      int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
      int hexadecimalNotation = 0x_001E_8480;
      // Check if the variables have same values.
      // Output of both the following statements should be true.
      Console.WriteLine($"{decimalNotation == binaryNotation}");
      Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

      Console.WriteLine($"byte uses {sizeof(byte)} byte and can store numbers in the range {byte.MinValue} and {byte.MaxValue}");
      Console.WriteLine($"sbyte uses {sizeof(sbyte)} byte and can store numbers in the range {sbyte.MinValue} and {sbyte.MaxValue}");
      Console.WriteLine($"short uses {sizeof(short)} bytes and can store numbers in the range {short.MinValue} and {short.MaxValue}");
      Console.WriteLine($"ushort uses {sizeof(ushort)} bytes and can store numbers in the range {ushort.MinValue} and {ushort.MaxValue}");
      Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue} and {int.MaxValue}");
      Console.WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in the range {uint.MinValue} and {uint.MaxValue}");
      Console.WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range {long.MinValue} and {long.MaxValue}");
      Console.WriteLine($"ulong uses {sizeof(ulong)} bytes and can store numbers in the range {ulong.MinValue} and {ulong.MaxValue}");
      Console.WriteLine($"char uses {sizeof(char)} bytes and can store numbers in the range {char.MinValue} and {char.MaxValue}");
      Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range {float.MinValue} and {float.MaxValue}");
      Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue} and {double.MaxValue}");
      Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue} and {decimal.MaxValue}");

      Console.WriteLine("Using Doubles:");
      double a = 0.1;
      double b = 0.2;
      if (a + b == 0.3)
      {
        Console.WriteLine($"{a} + {b} equals 0.3");
      }
      else
      {
        Console.WriteLine($"{a} + {b} DOES NOT equal 0.3");
      }

      Console.WriteLine("Using Decimals:");
      decimal c = 0.1M;
      decimal d = 0.2M;
      if (c + d == 0.3M)
      {
        Console.WriteLine($"{c} + {d} equals 0.3");
      }
      else
      {
        Console.WriteLine($"{c} + {d} DOES NOT equal 0.3");
      }
    }
  }
}