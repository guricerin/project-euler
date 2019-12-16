open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let solve() =
    let ls = [ 1 .. 100 ]
    let lhs = List.sumBy (fun n -> float n ** 2.0 |> int) ls
    let rhs = List.sum ls |> fun n -> float n ** 2.0 |> int
    rhs - lhs |> printfn "%d"

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 87msec
    0 // return an integer exit code
