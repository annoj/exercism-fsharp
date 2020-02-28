module TwoFer

let twoFer (name : string option) : string =
    match name with
    | None -> "One for you, one for me."
    | Some(name) -> "One for " + name + ", one for me."