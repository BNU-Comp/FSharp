module week01

open System

// Exercise 01 & 02

module exercise01 = 
    
    let run () = 
        let name = "Kate Ibom"
        let age = 21
        let height = 1.8
    
        printfn "%s" name
        printfn "%i" age
        printfn "%f" height

        Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}")

// Week 1 Exercise 3

module exercise3 =
    let run () =

        Console.Write("\n    Enter your name > ")
        let name = Console.ReadLine()

        Console.Write("    Enter your age > ")
        let age = Helpers.getInteger "Enter your age > " 1 120

        Console.Write("    Enter your height in meters > ")
        let height = float(Console.ReadLine())

        Console.WriteLine($"\n    Your name = {name} aged {age} height {height}\n")

// A function that gets 2 integers from the user and returns the sum 
// of the two integers 
module exercise4 =
    let run () =
        let num1 = Helpers.getInteger "\nEnter first number > " 1 100
        let num2 = Helpers.getInteger "Enter second number > " 1 100
        let sum = num1 + num2
        printfn "The sum of %d and %d is %d\n" num1 num2 sum

// A function that gets 2 integers from the user and returns the 
// result of integer division of the first number by the second number
// and the remainder.
module exercise5 =
    let run () =
        let num1 = Helpers.getInteger "\nEnter first number > " 1 100
        let num2 = Helpers.getInteger "Enter second number > " 1 100
        let div = num1 / num2
        let rem = num1 % num2
        printfn "The result of %d / %d is %d with a remainder of %d\n" num1 num2 div rem

// A function that asks the user to enter two numbers and then choose 
// an operator from +,-,*,/.  The function then returns the result of 
// addition, subtraction, multiplication or division based on the user's choice.
module exercise6 =
    let run () =
        let num1 = Helpers.getInteger "\nEnter first number > " 1 100
        let num2 = Helpers.getInteger "Enter second number > " 1 100
        Console.Write("Enter an operator (+, -, *, /) > ")
        let op = Console.ReadLine()
        let result = 
            match op with
            | "+" -> num1 + num2
            | "-" -> num1 - num2
            | "*" -> num1 * num2
            | "/" -> num1 / num2
            | _ -> 0
        printfn "The result of %d %s %d is %d\n" num1 op num2 result

// A function that asks the user to enter a start number and 
// an finish number as integers and then returns the sum of all
// the numbers between the start and finish numbers.
module exercise7 =
    let run () =
        let start = Helpers.getInteger "\n  Enter start number > " 1 100
        let finish = Helpers.getInteger "  Enter finish number > " 1 100
        let sum = 
            let rec loop i acc =
                if i > finish then acc
                else loop (i + 1) (acc + i)
            loop start 0
        printfn "\n The sum of all numbers between %d and %d is %d\n" start finish sum

// A function that is the same as exercise 6 but uses if-else instead of match
module exercise8 =
    let run () =
        let num1 = Helpers.getInteger "\nEnter first number > " 1 100
        let num2 = Helpers.getInteger "Enter second number > " 1 100
        Console.Write("Enter an operator (+, -, *, /) > ")
        let op = Console.ReadLine()
        let result = 
            if op = "+" then num1 + num2
            elif op = "-" then num1 - num2
            elif op = "*" then num1 * num2
            elif op = "/" then num1 / num2
            else 0
        printfn "The result of %d %s %d is %d\n" num1 op num2 result

