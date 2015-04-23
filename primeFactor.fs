let myN = 600851475143I

let g x n = (x*x + 1I) % n

let rec gcd a b = 
    match b with
    | b when (b = 0I) -> a
    | _ -> gcd b (a % b)

let rec pollardRho d xi yi n =
    let x = g xi n
    let y = g (g yi n) n
    let d = gcd (abs (x - y)) n
    match d with
    | d when (d = 1I) -> (pollardRho d x y n)
    | d when (d = n) -> n
    | d -> d

let rec factorsList n list = 
    let fac = pollardRho 1I 2I 2I n
    let currentList = fac :: list
    match fac with
    | fac when (fac = n) -> currentList
    | fac -> factorsList (n/fac) currentList

let maxFactor n = 
    let factors = factorsList n (1I :: [])
    List.max factors

printf "Max factor: %A\n" (maxFactor myN)