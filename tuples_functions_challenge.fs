let birthday = 18,1,1986

let reverse birth =
    let dd,mm,yy = birth
    yy,mm,dd

printfn "%A" (reverse birthday)
;;
 (1986, 1, 18)
 val birthday : int * int * int = (18, 1, 1986)
 val reverse : 'a * 'b * 'c -> 'c * 'b * 'a
 val it : unit = ()
