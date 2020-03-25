module Darts

let score (x: double) (y: double): int = 
    let radius = sqrt (x ** 2.0 + y ** 2.0)
    match radius with
    | r when r <= 1.0 -> 10
    | r when r <= 5.0 -> 5
    | r when r <= 10.0 -> 1
    | _ -> 0