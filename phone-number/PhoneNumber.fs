module PhoneNumber

let debug a = 
    a |> Seq.iter (fun x -> printf "%s" (string x)); printfn ""
    printfn "%s" (a.GetType().ToString())
    a

open System.Text.RegularExpressions
let (|Regex|_|) (pattern:seq<char>) (input: seq<char>) =
    let m = Regex.Match(input.ToString(), pattern.ToString())
    if m.Success then Some (m.Groups.[0]) else None

let clean input : uint64 option =
    let onlyDigits = input |> Seq.filter System.Char.IsDigit
    debug onlyDigits |> ignore
    match onlyDigits with
    | Regex @"^[2-9]\d{2}[2-9]\d{2}\d{4}$" number -> Some (uint64 (string onlyDigits))
    | Regex @"^1[2-9]\d{2}[2-9]\d{2}\d{4}$" number -> Some (uint64 (string onlyDigits).[1..])
    | _ -> None