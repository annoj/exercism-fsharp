module Isogram

let isIsogram (str: string) =
    let letters =
        str.ToLower()
        |> Seq.filter System.Char.IsLetter
    letters
    |> Seq.distinct
    |> Seq.length
    |> (=) (Seq.length letters)