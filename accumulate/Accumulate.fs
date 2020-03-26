﻿module Accumulate

let rec accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec accmlt cont = function
        | [] -> cont []
        | h :: t -> accmlt (fun acc -> cont (func h :: acc)) t
    accmlt id input