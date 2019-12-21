open System
open System.Collections

[<AutoOpen>]
module Cin =
    let read f = stdin.ReadLine() |> f
    let reada f = stdin.ReadLine().Split() |> Array.map f

    let readInts() =
        read string
        |> Seq.toArray
        |> Array.map (fun x -> Convert.ToInt32(x.ToString()))

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

    let divisors (n: int64) =
        let lim =
            n
            |> float
            |> sqrt
            |> int
        seq {
            for i in 1 .. lim do
                let i = int64 i
                if n % i = 0L then
                    yield i
                    if i * i <> n then yield n / i
        }
        |> Array.ofSeq
        |> Array.sort

let solve() =
    seq {
        for a in 2..1000 do
            let a = int64 a
            let da = Util.divisors a |> Array.sum |> fun x -> x - a
            if a < da then
                let db = Util.divisors da |> Array.sum |> fun x -> x - da
                if a = db then yield (a, da)
    }
    |> Seq.sumBy (fun (i, x) -> i + x)
    |> printfn "%d"

[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    // 174msec
    printfn "%d msec" sw.ElapsedMilliseconds
    0 // return an integer exit code
