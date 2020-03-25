module Grains

let square (n: int): Result<uint64,string> = 
    match n with
    | n when n > 0 && n < 65 -> Ok (1UL <<< (n - 1))
    | _ -> Error "square must be between 1 and 64"

let total: Result<uint64,string> =
    Ok 18446744073709551615UL