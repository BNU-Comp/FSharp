module week01

open System

// Exercise 01

module exercise01 = 
    
    let run () = 
        let name = "Kate Ibom"
        let age = 21
        let height = 1.8
    
        printfn "%s" name
        printfn "%i" age
        printfn "%f" height

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
