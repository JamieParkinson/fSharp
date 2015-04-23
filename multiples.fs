let maxN = 1000
let sum = [1..(maxN - 1)] |> List.filter(fun n -> ((n % 3) = 0 || (n % 5) = 0)) |> List.sum
printfn "Sum: %i" sum