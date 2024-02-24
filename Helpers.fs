module Helpers
open System

let rec getInteger (message: string) (minValue: int) (maxValue: int) : int =
    Console.Write(message)
    let mutable userInput = 0

    try
        userInput <- Int32.Parse(Console.ReadLine())
        if userInput < minValue || userInput > maxValue then
            printfn "Error: The number must be between %d and %d" minValue maxValue
            getInteger message minValue maxValue
        else
            userInput
    with
    | :? FormatException ->
        printfn "Error: Invalid input. Please enter a valid integer."
        getInteger message minValue maxValue
    | :? OverflowException ->
        printfn "Error: The number you entered is too large or too small."
        getInteger message minValue maxValue
