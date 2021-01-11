import java.util.Scanner;

class Main {

  public static void addition(double a, double b) {
    System.out.printf("a + b = %f\n", a + b);
  }

  public static void subtraction(double a, double b) {
    System.out.printf("a - b = %f\n", a - b);
  }

  public static void multiplication(double a, double b) {
    System.out.printf("a x b = %f\n", a * b);
  }

  public static void division(double a, double b) {
    if (b == 0) {
      System.out.printf("Oops, you cannot divide by 0!\n");
    } else {
      System.out.printf("a / b = %f\n", a / b);
    }
  }

  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    System.out.println("Four arithmetic operations on a and b\nEnter values");
    System.out.println("Which calculations do you want to output?");
    System.out.println("0. addition");
    System.out.println("1. subtraction");
    System.out.println("2. multiplication");
    System.out.println("3. division");
    System.out.println("Except 0 to 3. All");
    System.out.print("Enter a number: ");
    int outputFormat = scan.nextInt();
    System.out.print("a = ");
    double a = scan.nextDouble();
    System.out.print("b = ");
    double b = scan.nextDouble();

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