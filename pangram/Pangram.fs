module Pangram

let isPangram (input: string): bool = 
    let lower = input.ToLower()
    ['a' .. 'z']
    |> List.except lower
    |> List.isEmpty