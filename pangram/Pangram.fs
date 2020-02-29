module Pangram

let isPangram (input: string): bool = 
    let isLetter (c: char) =
        0x40 < (int c) && (int c) < 0x5b || // A - Z
        0x60 < (int c) && (int c) < 0x7b    // a - z
    
    input
    |> Seq.filter isLetter
    |> Seq.distinctBy (fun c -> if int c > 0x5b then int c - 0x20 else int c) // to lowercase
    |> Seq.length = 26