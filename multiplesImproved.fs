let maxN = 1000;
let floorSum n = 
    let nMax = float( (maxN-1) / n )
    (float n)*0.5*nMax*(nMax + 1.0)

let sumMultiples a b = (floorSum a) + (floorSum b) - (floorSum (a*b))

printfn "Sum: %f" (sumMultiples 3 5)