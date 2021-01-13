using System;

#pragma warning disable 0219

class MainClass {
  public static void addition(float a, float b) {
    Console.WriteLine ("a + b = {0}", a + b);
  }

  public static void subtraction(float a, float b) {
    Console.WriteLine ("a - b = {0}", a - b);
  }

  public static void multiplication(float a, float b) {
    Console.WriteLine ("a x b = {0}", a * b);
  }

  public static void division(float a, float b) {
    if (b == 0) {
      Console.WriteLine ("Oops, you cannot divide by 0!");
    } else {
      Console.WriteLine ("a / b = {0}", a / b);
    }
  }

  public static void Main (string[] args) {
    Console.WriteLine ("Four arithmetic operations on a and b\nEnter values");
    Console.WriteLine ("Which calculations do you want to output?");
    Console.WriteLine ("0. addition");
    Console.WriteLine ("1. subtraction");
    Console.WriteLine ("2. multiplication");
    Console.WriteLine ("3. division");
    Console.WriteLine ("Except 0 to 3. All");
    Console.Write ("Enter a number: ");
    var outputFormat = int.Parse(Console.ReadLine());
    Console.Write ("a = ");
    var a = float.Parse(Console.ReadLine());
    Console.Write ("b = ");
    var b = float.Parse(Console.ReadLine());

    switch (outputFormat) {
      case 0:
        addition(a, b);
        break;
      case 1:
        subtraction(a, b);
        break;
      case 2:
        multiplication(a, b);
        break;
      case 3:
        division(a, b);
        break;
      default:
        addition(a, b);
        subtraction(a, b);
        multiplication(a, b);
        division(a, b);
        break;
    }
  }
}