open System
open System.Collections.Generic

let multiplesOf3And5 num =
    let isMultiple x = x % 3 = 0 || x % 5 = 0

    [ 1 .. num ]
    |> List.sumBy (fun x ->
        match x with
        | _ when isMultiple x -> x
        | _ -> 0)
