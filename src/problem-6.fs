open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let solve() =
    seq {
        for x in 1 .. 100 do
            for y in 1 .. 100 do
                if x <> y then yield x * y
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
    // 87msec
    0 // return an integer exit code
