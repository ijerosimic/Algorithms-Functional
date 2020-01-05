open System

let rec capitalizeFirst (arr: List<string>) =
    let upper (c: string) = string (Char.ToUpper c.[0]) + c.[1..]

    match arr with
    | [] -> []
    | x :: xs -> (upper x) :: (capitalizeFirst xs)


capitalizeFirst [ "hello"; "there" ]
