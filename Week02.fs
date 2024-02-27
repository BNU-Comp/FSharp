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

// Exercise 9 and exercise 10 are two parts of the same topic
// Create a list of numbers, then divide each number by 2
module exercise09 = 
    let run () =
        let intDivList  = 
            [
                let intDivide x = x / 2
                for i in 1..10 do
                    yield intDivide i
            ]
        Console.Write("  intDivList is: ")
        printfn $"%A{intDivList}"
        Console.Write("  Length of intDivList is: ")
        Console.WriteLine(List.length intDivList)
        Console.Write("  Head of intDivList is: ")
        Console.WriteLine(List.head intDivList)

        let tail = List.tail intDivList
        Console.Write("  Tail of intDivList is: ")
        for i in tail do
            Console.Write($"{i} ")
        
        Console.WriteLine()

// Create a list of cars, then check if a car is in the list
module exercise11 =
    let run () =
        let cars = ["Toyota";"Vauxhall";"Ford";"Honda"]
        let found = List.exists(fun c->c="Honda") cars
        if found then
            Console.WriteLine("  \nHonda is in list\n")
        else
            Console.WriteLine("  \nHonda is not in list\n")

// Create a list of names, then delete one of the names
module exercise12 =
    let run () =
        let mutable nameList = []

        for n in 1..3 do
            Console.Write("Enter Name :")
        
            let element = Console.ReadLine()    
            nameList<-element::nameList

        for n in nameList do
            Console.WriteLine(n)

        Console.Write("Enter Name to Delete :")
        let delElement = Console.ReadLine()
        nameList<-List.filter(fun n->n <> delElement) nameList

        for n in nameList do
            Console.WriteLine(n)

// Excercise 13 
// Create a list of grades and a list of marks, then zip the two lists together
// Find the mark for a given grade C
module exercise14 =
    let run () =
        let grades = ['A';'B';'C';'D']
        let marks = [70;60;50;40]

        let gradeMarks = List.zip grades marks

        let gm = List.find(fun m-> fst m = 'C') gradeMarks
        Console.Write("  \nGrade C has mark: ")
        Console.WriteLine(snd gm)
        Console.WriteLine()


// End of Week02.fs
