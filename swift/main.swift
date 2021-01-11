func addition(a: Double, b: Double) {
    print("a + b =", a + b)
}

func subtraction(a: Double, b: Double) {
    print("a - b =", a - b)
}

func multiplication(a: Double, b: Double) {
    print("a x b =", a * b)
}

func division(a: Double, b: Double) {
    if b == 0 {
        print("Oops, you cannot divide by 0!")
    } else {
        print("a / b =", a / b)
    }
}

print("Four arithmetic operations on a and b\nEnter values")
print("Which calculations do you want to output?")
print("0. addition")
print("1. subtraction")
print("2. multiplication")
print("3. division")
print("Except 0 to 3. All")
print("Enter a number: ", terminator: "")
var outputFormat = Int(readLine()!)!
print("a = ", terminator: "")
var a = Double(readLine()!)!
print("b = ", terminator: "")
var b = Double(readLine()!)!
print("a =", a, ", b =", b)

switch outputFormat {
    case 0:
        addition(a: a, b: b)
    case 1:
        subtraction(a: a, b: b)
    case 2:
        multiplication(a: a, b: b)
    case 3:
        division(a: a, b: b)
    default:
        addition(a: a, b: b)
        subtraction(a: a, b: b)
        multiplication(a: a, b: b)
        division(a: a, b: b)
}