let rec gcd a b = 
  match b with
  | b when (b = 0) -> a
  | _ -> gcd b (a % b)

let lcm a b =
  (a * b)/(gcd a b)

let myLCM = List.reduce(lcm) [1..19]

printfn "Lowest common multiple of 1..20: %A" myLCM