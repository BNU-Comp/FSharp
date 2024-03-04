module Week05

// Your code here
open System

type Qualification =
    | Degree of int * int
    | ShortCourse of bool
    | ALevel of char

let mary = Degree (2, 1)
let jane = ShortCourse true
let sally = ALevel 'A'
let students = [mary;jane;sally]

// A display function that takes a qualification and displays it 
module exercise01 = 
 
    let run () = 
        let Display q = 
            match q with
            | Degree (y, m) -> printfn "  Degree: %d years %d months" y m
            | ShortCourse b -> printfn "  Short Course: %b" b
            | ALevel c -> printfn "  A Level: %c" c

        Display mary
        Display jane
        Display sally
        Console.WriteLine("  ") 

module exercise02 =
    let run() =
        let DisplayQualifications v =
            do
                for s in v do
                    match s with
                    | Degree(x, y) ->
                        Console.Write("  Degree Classification is ")
                        Console.Write(x)
                        Console.Write(":")
                        Console.WriteLine(y)
                    | ShortCourse(pass) ->
                        if pass then
                            Console.WriteLine("  You passed your short course")
                        else
                            Console.WriteLine("  You failed your short course")
                    | ALevel(grade) ->
                        Console.Write("  A'Level Grade is ")
                        Console.WriteLine(grade)
        Console.WriteLine("  ")
        DisplayQualifications students

//DisplayQualifications students




