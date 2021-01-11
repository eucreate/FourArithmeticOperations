#include <stdio.h>

void addition(float a, float b) {
  printf("a + b = %f\n", a + b);
}

void subtraction(float a, float b) {
  printf("a - b = %f\n", a - b);
}

void multiplication(float a, float b) {
  printf("a x b = %f\n", a * b);
}

void division(float a, float b) {
  if (b == 0) {
    printf("Oops, you cannot divide by 0!\n");
  } else {
    printf("a / b = %f\n", a / b);
  }
}

int main(void) {
  float a, b;
  int outputFormat;
  printf("Four arithmetic operations on a and b\nEnter values\n");
  printf("Which calculations do you want to output?\n");
  printf("0. addition\n");
  printf("1. subtraction\n");
  printf("2. multiplication\n");
  printf("3. division\n");
  printf("Except 0 to 3. All\n");
  printf("Enter a number: ");
  scanf("%d", &outputFormat);
  printf("a = ");
  scanf("%f", &a);
  printf("b = ");
  scanf("%f", &b);

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

  return 0;
}