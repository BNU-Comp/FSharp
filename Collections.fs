
module Collections

open System

type Student = 
    { 
        Name : string
        Id : string
        Mean : float
        Min : float
        Max : float
    }

(*
    Split the string into its elements
    Extract the name and id from the first two elements
    Extract the scores from the remaining elements
    Calculate the mean, min and max scores
    Print the name, id, mean, min and max scores
*)
module Student =
    let fromString(s:string) =

        let elements = s.Split('\t')
        let name = elements.[0]
        let id =  elements.[1]
        
        let scores = 
            elements
            |> Array.skip 2
            |> Array.map float

        let meanScore = scores |> Array.average
        let minScore = scores |> Array.min
        let maxScore = scores |> Array.max
        { 
            Name = name;
            Id = id; 
            Mean = meanScore; 
            Min = minScore; 
            Max = maxScore 
        }


    let printMeanScore (student : Student) = 

            printfn "  %s\t%s\t%0.1f\t%0.1f\t%0.1f" 
                student.Name student.Id 
                student.Min 
                student.Max
                student.Mean 

(*
    Read all the rows of the file as an array of strings
    Skip the first row (header)
    For each row, print the mean score, min and max scores
*)
let readData filePath = 
    let rows = System.IO.File.ReadAllLines(filePath)
    // let data = 
    //     rows
    //     |> Array.map (fun row -> row.Split('\t'))
    //     |> Array.map (fun cols -> (cols.[0], cols.[1], int cols.[2]))
    
    // printfn "  Read %d rows from file\n" rows.Length
    
    rows
        |> Array.skip 1 
        |> Array.map Student.fromString
        |> Array.iter Student.printMeanScore
    
    printfn "  \nFile Read Complete\n"


(*
    Output a heading, set the filePath to the file to be read
    Read all the rows of the file as an array of strings
    Skip the first row (header)
    For each row, print the mean score, min and max scores
*)
module ReadFile = 
    let run() = 
        Console.WriteLine("  Collections with file data")
        let filePath = "data/StudentScores.txt"
        Console.WriteLine("  Reading data from file\n")
        readData filePath
        0
