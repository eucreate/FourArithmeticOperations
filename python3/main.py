def addition(a, b):
    print("a + b = ", a + b)

def subtraction(a, b):
    print("a - b = ", a - b)

def multiplication(a, b):
    print("a x b = ", a * b)

def division(a, b):
    if b == 0:
        print("Oops, you cannot divide by 0!")
    else:
        print("a / b = ", a / b)

print("Four arithmetic operations on a and b\nEnter values")
print("Which calculations do you want to output?")
print("0. addition")
print("1. subtraction")
print("2. multiplication")
print("3. division")
print("Except 0 to 3. All")
outputFormat = int(input("Enter a number: "))
a = float(input("a = "))
b = float(input("b = "))

if outputFormat == 0:
    addition(a, b)
elif outputFormat == 1:
    subtraction(a, b)
elif outputFormat == 2:
    multiplication(a, b)
elif outputFormat == 3:
    division(a, b)
else:
    addition(a, b)
    subtraction(a, b)
    multiplication(a, b)
    division(a, b)