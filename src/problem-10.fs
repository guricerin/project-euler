open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

    let sieveToUpper upper =
        seq {
            yield 2
            let knownComposites = new System.Collections.Generic.HashSet<int>()
            for i in 3 .. 2 .. upper do
                let found = knownComposites.Contains(i)
                if not found then yield i
                for j in i .. i .. upper do
                    knownComposites.Add(j) |> ignore
        }

let solve() =
    Util.sieveToUpper (int 1e6 * 2)
    |> Seq.sumBy int64
    |> printfn "%d"

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 3248msec おせえ
    0 // return an integer exit code
