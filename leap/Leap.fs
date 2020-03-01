module Leap

let leapYear (year: int): bool =
    if year % 4 = 0 then
        if year % 100 = 0 then 
            year % 400 = 0
        else
            true
    else
        false