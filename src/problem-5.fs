open System

module Util =
    let strRev s =
        s
        |> Seq.rev
        |> Seq.map string
        |> String.concat ""

module Gcd =

    let inline gcd x y =
        let zero = LanguagePrimitives.GenericZero

        let rec loop x y =
            if y = zero then x
            else loop y (x % y)
        loop x y

    let inline lcm x y =
        let g = gcd x y
        x / g * y

let solve() = List.fold (fun acc x -> Gcd.lcm acc x) 1 [ 1 .. 20 ] |> printfn "%d"


[<EntryPoint>]
let main _ =
    let sw = Diagnostics.Stopwatch()
    sw.Start()
    solve()
    sw.Stop()
    printfn "%d msec" sw.ElapsedMilliseconds
    // 270msec いや、見苦しいコードやな
    0 // return an integer exit code
