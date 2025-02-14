let mutable x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d %d" x y //Prints 10 11

//To modify x directly, we need to use a mutable reference:

let addOneInPlace (x:byref<int>) = x <- x + 1

let mutable z = 10

let () = addOneInPlace &z

printfn "%d" z //Prints 11

//or pass a mutable reference as the parameter and modify the argument directly:

let addOneInPlaceRef (x:byref<int>) = x <- x + 1

let mutable a = 10

addOneInPlaceRef &a

printfn "%d" a