module SumOfMultiples

let listOfMultiples (upperBound: int) (n: int) =
    if n = 0 then [0] else [n .. n .. (upperBound - 1)]

let sum (numbers: int list) (upperBound: int): int =
    numbers
    |> List.collect (listOfMultiples upperBound)
    |> List.distinct
    |> List.sum