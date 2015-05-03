let sumToN n = n*(n+1)/2
let sumSqToN n = n*(n+1)*(2*n+1)/6
let diffSumSq n= (pown (sumToN n) 2) - (sumSqToN n)

printfn "Difference in sum of squares and square of sum for n = 100: %A" (diffSumSq 100)