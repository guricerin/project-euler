open System
open System.Collections.Generic

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""


let rec fact (x: bigint) =
    if x = 0I then 1I
    else x * fact (x - 1I)

let solve() =
    let numer = fact (20I * 2I)
    let denom = fact 20I
    numer / (denom * denom) |> printfn "%A"

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 159msec
    0 // return an integer exit code
