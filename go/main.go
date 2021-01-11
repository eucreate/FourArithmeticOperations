package main

import "fmt"

func addition(a float32, b float32) {
	fmt.Printf("a + b = %v\n", a+b)
}

func subtraction(a float32, b float32) {
	fmt.Printf("a - b = %v\n", a-b)
}

func multiplication(a float32, b float32) {
	fmt.Printf("a x b = %v\n", a*b)
}

func division(a float32, b float32) {
	if b == 0 {
		fmt.Println("Oops, you cannot divide by 0!")
	} else {
		fmt.Printf("a / b = %v\n", a/b)
	}
}

func main() {
	var(
		a	float32
		b	float32
		outputFormat	int
	)
	fmt.Println("Four arithmetic operations on a and b\nEnter values")
	fmt.Println("Which calculations do you want to output?")
	fmt.Println("0. addition")
	fmt.Println("1. subtraction")
	fmt.Println("2. multiplication")
	fmt.Println("3. division")
	fmt.Println("Except 0 to 3. All")
	fmt.Printf("Enter a number: ")
	fmt.Scan(&outputFormat)
	fmt.Print("a = ")
	fmt.Scan(&a)
	fmt.Print("b = ")
	fmt.Scan(&b)

	switch outputFormat {
		case 0:
			addition(a, b)
		case 1:
			subtraction(a, b)
		case 2:
			multiplication(a, b)
		case 3:
			division(a, b)
		default:
			addition(a, b)
			subtraction(a, b)
			multiplication(a, b)
			division(a, b)
	}
}