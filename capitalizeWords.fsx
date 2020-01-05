open System

let rec capitalizeWords (arr: List<string>) =
    let upper (c: string) = String.map Char.ToUpper c

    match arr with
    | [] -> []
    | x :: xs -> (upper x) :: (capitalizeWords xs)


capitalizeWords [ "hello"; "there" ]
