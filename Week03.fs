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