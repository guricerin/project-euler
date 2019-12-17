open System
open System.Collections.Generic

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let rec fact n =
    if n <= 0I then 1I
    else n * fact (n - 1I)

let solve() =
    let mutable n = fact 100I
    let mutable ans = 0I
    while n > 0I do
        ans <- ans + (n % 10I)
        n <- n / 10I
    printfn "%A" ans

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 148msec
    0 // return an integer exit code
