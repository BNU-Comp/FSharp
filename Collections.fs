
module Collections

open System

let readData filePath = 
    let rows = System.IO.File.ReadAllLines(filePath)
    let data = 
        rows
        |> Array.map (fun row -> row.Split('\t'))
        |> Array.map (fun cols -> (cols.[0], cols.[1], int cols.[2]))
    
    printfn "  Read %d rows from file" rows.Length


module exercise01 = 
    let run() = 
        Console.WriteLine("Collections with file data")
        let filePath = "data/StudentScores.txt"
        Console.WriteLine("  Reading data from file")
        readData filePath
        0
