let childAges = 2,4;;

let addChildAges ages =
    let bob,sam = ages
    bob + sam

addChildAges childAges;;

let addAges bob sam =
    bob + sam

let fnChildAges bob =
    let addSamsAgeToBobs sam =
        bob + sam
    addSamsAgeToBobs

let triArea width height =
  (width*height)/2

triArea 12 16;;

(/* F# interactive */)
addChildAges childAges;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'addChildAges' is not defined at 3,0

let childAges = 2,4

let addChildAges ages =
    let bob,sam = ages
    bob + sam

addChildAges childAges;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'addChildAges' is not defined at 3,0

 val childAges : int * int = (2, 4)

 val addChildAges : int * int -> int
 val it : int = 6

 val childAges : int * int = (2, 4)

 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'child' is not defined at 7,13

 val childAges : int * int = (2, 4)

 val addChildAges : int * int -> int
 val it : int = 6

 val addAges : bob:int -> sam:int -> int

addAges 2;;
 val it : (int -> int) = <fun:it@2>

let awaitingSamsAge = addAges 2;;
 val awaitingSamsAge : (int -> int)

awaitingSamsAge 4;;
 val it : int = 6

 val fnChildAges : bob:int -> (int -> int)

fnChildAges 2;;
 val it : (int -> int) = <fun:fnChildAges@4>

let samsFn = awaitingSamsAge 4;;
 val samsFn : int = 6

sams

;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'sams' is not defined at 3,0

samsFn 4;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 This value is not a function and cannot be applied at 3,0

;;
let samsFn = awaitingSamsAge 4;;
 val samsFn : int = 6

samsFn 4;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 This value is not a function and cannot be applied at 3,0

fnChildAges 2 4
;;
 val it : int = 6

 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 TABs are not allowed in F# code unless the #indent "off" option is used at 3,0

 val triArea : width:int -> height:int -> int

 val triArea : width:int -> height:int -> int
 val it : int = 96

