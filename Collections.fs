
module Collections

open System


let printMeanScore (row : string) = 
    let elements = row.Split('\t')
    let name = elements.[0]
    let id =  elements.[1]
    
    let score = 
        elements
        |> Array.skip 2
        |> Array.map float
        |> Array.average
    
    printfn "  %s\t%s\t%0.1f" name id score
let readData filePath = 
    let rows = System.IO.File.ReadAllLines(filePath)
    // let data = 
    //     rows
    //     |> Array.map (fun row -> row.Split('\t'))
    //     |> Array.map (fun cols -> (cols.[0], cols.[1], int cols.[2]))
    
    // printfn "  Read %d rows from file\n" rows.Length
    
    rows
        |> Array.skip 1 
        |> Array.iter printMeanScore
    
    printfn "  \nFile Read Complete\n"



module ReadFile = 
    let run() = 
        Console.WriteLine("  Collections with file data")
        let filePath = "data/StudentScores.txt"
        Console.WriteLine("  Reading data from file\n")
        readData filePath
        0
