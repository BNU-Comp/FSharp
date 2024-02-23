module week01

open System

// Week 1 Exercise 3

let exercise3 =
    Console.Write("Enter your name > ")
    let name = Console.ReadLine()

    Console.Write("Enter your age > ")
    let age = int(Console.ReadLine())

    Console.Write("Enter your height in meters > ")
    let height = float(Console.ReadLine())

    Console.WriteLine($"Your name = {name} aged {age} height {height}")
