let location  = 77.51,166.40,21
;;
 val location : float * float * int = (77.51, 166.4, 21)

let location  = (77.51,166.40,21)
;;
 val location : float * float * int = (77.51, 166.4, 21)

let longAlt location =
    let long,_,alt = location
    (alt, long)

printfn "%A" (longAlt location);;
 (21, 77.51)
 val longAlt : 'a * 'b * 'c -> 'c * 'a
 val it : unit = ()
printfn "%A" (fst(longAlt location));;
 21
 val it : unit = ()
printfn "%A" (lst(longAlt location));;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'lst' is not defined at 3,14
printfn "%A" (snd(longAlt location));;
 77.51
 val it : unit = ()
