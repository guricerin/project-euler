open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let solve() =
    let f n =
        let a = n |> string
        let b = a |> Util.strRev
        a = b
    seq {
        for i in 900 .. 999 do
            for j in 900 .. 999 do
                let k = i * j
                if f k then yield k
    }
    |> Seq.max
    |> printfn "%d"

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 270msec いや、見苦しいコードやな
    0 // return an integer exit code
