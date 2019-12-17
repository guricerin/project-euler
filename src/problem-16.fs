open System
open System.Collections.Generic

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let solve() =
    let mutable a = 2I ** 1000
    let mutable ans = 0I
    while a > 0I do
        ans <- ans + (a % 10I)
        a <- a / 10I
    printfn "%A" ans

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 139msec
    0 // return an integer exit code
