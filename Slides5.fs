module Slides5
// Create a discriminated union type
open System

type Student =
    | FullTime of int
    | PartTime of int
    | Remote

module exercise01 = 
    let run () = 
        // Create a function that takes a student and prints the type of student
        let PrintStudent student =
            match student with
            | FullTime x -> printfn "Full time student with %d hrs of lectures" x
            | PartTime x -> printfn "Part time student with %d hrs of lectures" x
            | Remote -> printfn "A Remote student"

        // Create some students
        // Create a Student called fred and assign it the value FullTime(12)
        let fred = FullTime(12) 
        let mary = PartTime(6)
        let james = Remote
        
        // Call the function PrintStudent with each student
        PrintStudent fred
        PrintStudent mary
        PrintStudent james
        Console.WriteLine("  ")
        0

