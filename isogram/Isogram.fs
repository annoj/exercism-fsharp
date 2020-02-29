module Isogram

let isIsogram (str: string) =
    let onlyLetters = Seq.filter (fun (c: char) -> List.contains c ['a' .. 'z']) (str.ToLower())
    let onlyLettersDistinct = onlyLetters |> Seq.distinct
    (onlyLetters |> Seq.length) = (onlyLettersDistinct |> Seq.length)