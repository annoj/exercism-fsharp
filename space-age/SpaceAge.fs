module SpaceAge

type Planet =
    | Mercury
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let age (planet: Planet) (seconds: int64): float =
    match planet with
    | Mercury -> (float) seconds / 7600543.81992
    | Venus -> (float) seconds / 19414149.052176
    | Earth -> (float) seconds / 31557600.0
    | Mars -> (float) seconds / 59354032.690079994
    | Jupiter -> (float) seconds / 374355659.124
    | Saturn -> (float) seconds / 929292362.8848
    | Uranus -> (float) seconds / 2651370019.3296
    | Neptune -> (float) seconds / 5200418560.032001