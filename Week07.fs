module Week07

open System

module patterns =
    let run() =
        let feedback grade =
            match  grade with
            | 'A' -> "Excellent"
            | 'B' -> "Very good"
            | 'C' -> "Good"
            | _ -> "Fail"

        Console.Write("  Your grade is ")
        Console.WriteLine(feedback 'B')
        Console.WriteLine("  ")
