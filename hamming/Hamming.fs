module Hamming

let distance (strand1: string) (strand2: string): int option = 
    if strand1.Length <> strand2.Length then None
    else (strand1, strand2)
        ||> Seq.map2 (=) 
        |> Seq.sumBy (fun b -> if b then 0 else 1)
        |> Some