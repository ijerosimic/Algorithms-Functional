open System

let rec capitalizeWords (arr: List<string>) =
    let upper (c: string) = String.map Char.ToUpper arr.[0]

    match arr with
    | [] -> capitalizeWords arr
    | x :: xs -> (upper x) :: (capitalizeWords xs)


capitalizeWords [ "hello"; "there" ]
