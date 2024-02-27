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
        

  