open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

let fib n =
    let rec loop i a b acc =
        let c = a + b
        if c > n then
            acc
        else
            let acc =
                if c % 2L = 0L then acc + c
                else acc
            loop (i + 1) b c acc
    loop 1 1L 1L 0L

let solve() = fib (int64 1e6 * 4L) |> printfn "%d"


[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    0 // return an integer exit code
