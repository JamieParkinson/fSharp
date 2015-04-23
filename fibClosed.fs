let maxN = 4e6;
let phi = (1.0 + (sqrt 5.0))*0.5

let NfromF (F : float) = floor (System.Math.Log(F*(sqrt 5.0) + 0.5, phi)) / 3.0
let sumEven max =
    let N = NfromF max
    (1.0/(sqrt 5.0))*((1.0 - phi**(3.0*N + 3.0))/(1.0 - phi**3.0) - (1.0 - (-phi)**(-3.0*N - 3.0))/(1.0 + phi**(-3.0)))

printfn "Sum: %f" (sumEven maxN)