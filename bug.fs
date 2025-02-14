let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y //Prints 10 11, not 11 11 as one might expect

let mutable z = 10

let addOneInPlace z = z <- z + 1

let () = addOneInPlace z

printfn "%d" z //Prints 11 as expected