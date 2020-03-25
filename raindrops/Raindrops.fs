module Raindrops

let convert (number: int): string =
    let pling = if number % 3 = 0 then "Pling" else ""
    let plang = if number % 5 = 0 then "Plang" else ""
    let plong = if number % 7 = 0 then "Plong" else ""
    let plingPlangPlong = pling + plang + plong
  
    match plingPlangPlong with
    | "" -> number.ToString()
    | s -> s