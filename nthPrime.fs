open System
open System.Collections

let nthPrimeBound n =
  let nf = float n
  (nf*((log nf) + (log (log nf)))) |> int
  

let nthPrime n =
  let max = nthPrimeBound n
  let arr = new BitArray(max, true)
  let sqrtPrime = Math.Sqrt(float max) |> int

  for p in 2 .. sqrtPrime+1 do
    if arr.Get(p) then
      for pp in p*2 .. p .. max-1 do
        arr.Set(pp, false)
        
  seq { for i in 2 .. max-1 do if arr.Get(i) then yield i } |> (Seq.nth (n-1))

printfn "10001st prime: %A" (nthPrime 10001)

