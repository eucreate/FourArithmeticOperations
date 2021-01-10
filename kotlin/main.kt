fun addition(a: Double, b: Double) = println("a + b = ${a + b}")

fun subtraction(a: Double, b: Double) = println("a - b = ${a - b}")

fun multiplication(a: Double, b: Double) = println("a x b = ${a * b}")

fun division(a: Double, b: Double) = println("a / b = ${a / b}")

fun main(args: Array<String>) {
    print("Four arithmetic operations on a and b\nEnter values\na = ")
    val a = readLine()?.toDouble()?:0.0
    print("b = ")
    val b = readLine()?.toDouble()?:0.0
    println("Which calculations do you want to output?")
    println("0. addition")
    println("1. subtraction")
    println("2. multiplication")
    println("3. division")
    println("Except 0 to 3. All")
    print("Enter a number: ")
    val outputFormat = readLine()?.toInt()?:0
    println("a = $a, b = $b")

    when (outputFormat) {
        0 -> addition(a, b)
        1 -> subtraction(a, b)
        2 -> multiplication(a, b)
        3 -> division(a, b)
        else -> {
            addition(a, b)
            subtraction(a, b)
            multiplication(a, b)
            division(a, b)
        }
    }
}