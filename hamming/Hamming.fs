module Hamming

let distance (strand1: string) (strand2: string): int option = 
    if strand1.Length <> strand2.Length then None
    else 
        let dist = Array.zip (strand1.ToCharArray()) (strand2.ToCharArray())
                |> Array.fold (fun acc (x, y) -> acc + (if x = y then 0 else 1)) 0
        Some dist