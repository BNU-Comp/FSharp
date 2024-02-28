module Week05

// Your code here
open System

type Qualification =
    | Degree of int * int
    | ShortCourse of bool
    | ALevel of char

// A display function that takes a qualification and displays it 
module exercise01 = 
 
    let run () = 
        let Display q = 
            match q with
            | Degree (y, m) -> printfn "  Degree: %d years %d months" y m
            | ShortCourse b -> printfn "  Short Course: %b" b
            | ALevel c -> printfn "  A Level: %c" c

        let q1 = Degree (3, 6)
        let q2 = ShortCourse true
        let q3 = ALevel 'A'

        Display q1
        Display q2
        Display q3
        Console.WriteLine("  ") 


