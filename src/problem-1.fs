open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let solve() =
    seq {
        for i in 1 .. 1000 - 1 do
            if i % 3 = 0 || i % 5 = 0 then yield i
    }
    |> Seq.sum
    |> printfn "%d"

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    0 // return an integer exit code
