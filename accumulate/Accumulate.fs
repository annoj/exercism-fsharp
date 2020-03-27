module Accumulate

let rec accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec _accumulate cont = function
        | [] -> cont []
        | h :: t -> _accumulate (fun acc -> cont (func h :: acc)) t
    _accumulate id input