open System
open System.Collections.Generic

let multiplesOf3And5 num =
    let isMultiple x = x % 3 = 0 || x % 5 = 0

    [ 1 .. num ]
    |> List.sumBy (fun x ->
        match x with
        | _ when isMultiple x -> x
        | _ -> 0)

multiplesOf3And5 (49)
// let multiplesOf3And5 num =
//     [ 1 .. num ]
//     |> List.fold (fun acc x ->
//         match x with
//         | 3
//         | 5 -> acc + x
//         | _ when x % 3 = 0 -> acc + x
//         | _ when x % 5 = 0 -> acc + x
//         | _ -> acc)
