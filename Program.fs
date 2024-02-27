module Program

open week01
open Week02

[<EntryPoint>]
let main argv =
    printfn "\n  Hello from F#"
    printfn "  Calling Week 02 Exercise 1 - 4"
    
    Week02.exercise01.run()
    Week02.exercise02.run()
    Week02.exercise03.run()
    Week02.exercise04.run()
    0

