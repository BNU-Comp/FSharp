module Program

open week01

[<EntryPoint>]
let main argv =
    printfn "\n  Hello from F#"
    printfn "  Calling Week 01 Exercise 3"
    

    let result = week01.exercise3.run()
    0

