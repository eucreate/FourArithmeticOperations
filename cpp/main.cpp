#include <iostream>

void addition(float a, float b) {
  std::cout << "a + b = " << a + b << std::endl;
}

void subtraction(float a, float b) {
  std::cout << "a - b = " << a - b << std::endl;
}

void multiplecation(float a, float b) {
  std::cout << "a x b = " << a * b << std::endl;
}

void division(float a, float b) {
  if (b == 0) {
    std::cout << "Oops, you cannot divide by 0!\n";
  } else {
    std::cout << "a / b = " << a / b << std::endl;
  }
}

int main() {
  float a, b;
  int outputFormat;
  std::cout << "Four arithmetic operations on a and b\nEnter values\n";
  std::cout << "Which calculations do you want to output?\n";
  std::cout << "0. addition\n";
  std::cout << "1. subtraction\n";
  std::cout << "2. multiplication\n";
  std::cout << "3. division\n";
  std::cout << "Except 0 to 3. All\n";
  std::cout << "Enter a number: ";
  std::cin >> outputFormat;
  std::cout << "a = ";
  std::cin >> a;
  std::cout << "b = ";
  std::cin >> b;

  switch (outputFormat) {
    case 0:
      addition(a, b);
			break;
    case 1:
      subtraction(a, b);
			break;
    case 2:
      multiplecation(a, b);
			break;
    case 3:
      division(a, b);
			break;
    default:
      addition(a, b);
      subtraction(a, b);
      multiplecation(a, b);
      division(a, b);
  }
}