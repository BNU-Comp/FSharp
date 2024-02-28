module Week03

open System
let cities = ["London";"New York";"Paris";"Hong Kong"]

module exercise01 = 
    let run () = 

        Console.WriteLine("  Cities: \n")
        let Display c = 
            Console.WriteLine("  " + string(c))

        List.iter Display cities
        Console.WriteLine("  ")

module exercise02 = 
    let run () = 

        Console.WriteLine("  Cities String Length: \n")
        let Len (s:string) = s.Length
        let lenCities  = List.map Len cities

        let Display c = 
            Console.WriteLine($"  Length = {int(c)}")

        List.iter Display lenCities
        
        Console.WriteLine("  ")

// This is a module that contains a list of digits
module lists =
    let digits = [0..9]

// This is a module that takes a list and displays it
module functions = 
    let it lst = 
        List.iter (fun x -> printf "%d " x) lst

// This is a module that takes a list and accumulates the sum of the elements
module exercise04 =
    let run () = 
        Console.WriteLine("  Digits: \n")
        functions.it lists.digits
        Console.WriteLine("  ")
        
        let accumulate acc x = acc + x
        let sum = List.fold accumulate 0 lists.digits
        Console.WriteLine($"  Sum of digits = {sum}\n")
