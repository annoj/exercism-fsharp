module Leap

let isDivisible dividend divisor = dividend % divisor = 0

let leapYear (year: int): bool =
    isDivisible year 4
    && not (isDivisible year 100)
    || isDivisible year 400