module QueenAttack

let isInBound (value: int) = 
    [0 .. 7] |> List.contains value

let create (position: int * int) = 
    isInBound (fst(position)) && isInBound (snd(position))

let shareRow (pos1: int, _) (pos2: int, _) =
    pos1 = pos2

let shareColumn (_, pos1: int) (_, pos2: int) =
    pos1 = pos2

let shareDiagonal (pos1: int * int) (pos2: int * int) = 
    abs ((snd(pos2) - snd(pos1)) / (fst(pos2) - fst(pos1))) = 1

let canAttack (queen1: int * int) (queen2: int * int) = 
    shareRow queen1 queen2
    || shareColumn queen1 queen2
    || shareDiagonal queen1 queen2