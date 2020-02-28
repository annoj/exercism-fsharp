module TwoFer

let twoFer (name : string option) : string =
    name
    |> Option.defaultValue "you"
    |> sprintf "One for %s, one for me." 