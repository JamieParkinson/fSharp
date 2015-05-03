// Palindromes which are a product of 2 3-digit numbers have 5-6 digits; assume the largest has 6

let reverse n = ((n / 100) % 10) + 10*((n / 10) % 10) + 100*(n % 10)

let palindromes = [999..-1..0] |> List.map(fun n -> n + 1000*(reverse n))

let areThreeDigits (f, s) =
  let first = f >= 100 && f < 1000
  let second = s >= 100 && s < 1000
  if first && second then
    Some (f, s)
  else
    None

let isProduct (n : int) =
  let factors = [110..11..990] |> List.choose(fun d ->
    match (n % d) with
      | 0 -> areThreeDigits (d, (n/d))
      |  _-> None)
  not (factors = [])

let productsPalindromes = List.filter(isProduct) palindromes
printfn "Largest palindrome which is a product of 2 3-digit numbers: %A" (List.max productsPalindromes)