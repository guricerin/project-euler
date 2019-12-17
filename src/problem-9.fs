open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let solve() =
    seq {
        for a in 1 .. 1000 do
            for b in a + 1 .. 1000 do
                let c = 1000 - (a + b)
                if a + b + c = 1000 then
                    let f x = float x |> fun x -> x ** 2. |> int
                    if (f a) + (f b) = f c then yield a * b * c
    }
    |> Seq.head
    |> printfn "%d"

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 99msec
    0 // return an integer exit code
