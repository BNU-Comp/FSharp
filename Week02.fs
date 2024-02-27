module Week02

open System

module exercise01 = 
    let run () = 
        let TimesTwo x = x * 2
        Console.Write("\n  Two Times is: ")
        Console.WriteLine(TimesTwo 5)

module exercise02 = 
    let run () = 
        let Remainder a b = a % b
        Console.Write("  Remainder is: ")        
        Console.WriteLine(Remainder 8 5)

module exercise03 = 
    let run () = 
        let CubeVolume h w d = h * w * d
        Console.Write($"  The volume of a cube is: ")
        Console.WriteLine(CubeVolume 3 4 5)

module exercise04 = 
    let run () = 
        let LargerOfTwo a b = if a > b then a else b
        Console.Write($"  The larger is: ")
        Console.WriteLine(LargerOfTwo 5 7)
        Console.WriteLine()

module exercise05 = 
    let run () = 
        let Digits = [4;8;12;16;20]
        Console.Write("  List of int is: ")
        printfn $"%A{Digits}"
        Console.WriteLine()

// Add numbers from 4 by 4 to 20        
module exercise06 = 
    let run () = 
        let Digits = [4..4..20]
        Console.Write("  List of int is: ")
        printfn $"%A{Digits}"
        Console.WriteLine()
  
  // Add numbers from 0 to 9 then add -1 to the list        
module exercise07 = 
    let run () = 
        let Digits = [0..9]
        let updateDigits = -1::Digits
        Console.Write("  List of int is: ")
        printfn $"%A{Digits}"
        Console.Write("  List of updates is: ")
        printfn $"%A{updateDigits}"        
        Console.WriteLine()

module exercise08 = 
    let run () =
        let squares x = 
            [
                yield (x-1) * (x-1)
                yield x * x
                yield (x+1) * (x+1)
            ]
        let result = squares 5
        Console.Write("  List of squares is: ")
        printf $"%A{result}"
        Console.WriteLine()