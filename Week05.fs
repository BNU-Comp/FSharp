module Week05

// Your code here
open System

module exercise01 = 
    let run () = 
        type Qualification =
            | Degree of int * int
            | ShortCourse of bool
            | ALevel of char


        let DisplayQualification student =
            match student with
                | Degree(x,y)->Console.Write("Classification is ")
                    Console.Write(x)
                    Console.Write(":")
                    Console.WriteLine(y)
                | ShortCourse(pass)->if pass then
                                        Console.WriteLine("You passed your course")
                                    else
                                        Console.WriteLine("You failed your course")
                | ALevel(grade)->Console.Write("Grade : ")
                     Console.WriteLine(grade)
                     

