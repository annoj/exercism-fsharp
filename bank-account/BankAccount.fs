module BankAccount

type OpenAccount =
    {mutable balance: decimal}

type Account = 
    | Closed
    | Open of OpenAccount

let mkBankAccount() =
    Closed

let openAccount account =
    match account with 
    | Closed -> Open {balance = 0.0m}
    | Open _ -> failwith "Account already opened."

let closeAccount account =
    match account with
    | Closed -> failwith "Account already closed."
    | Open _ -> Closed

let getBalance account =
    match account with
    | Closed -> None
    | Open account -> Some account.balance

let updateBalance change account =
    match account with
    | Closed -> failwith "Account closed."
    | Open account ->
        lock account (fun _ ->
            account.balance <- account.balance + change
            Open account)