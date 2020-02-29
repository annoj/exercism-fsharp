module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int =
    let listOfMultiples (n: int) =
        [for k in [0 .. (upperBound - 1) / n] do yield n * k]
    numbers
    |> List.filter (fun n -> n > 0)
    |> List.collect listOfMultiples
    |> List.distinct
    |> List.sum