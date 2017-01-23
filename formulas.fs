(*Formulas*)

xyz = "xyz";;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'xyz' is not defined at 2,0

let xyz = "xyz";;
 val xyz : string = "xyz"

"abc";;
 val it : string = "abc"

xvy;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'xvy' is not defined at 3,0

xyz;;
 val it : string = "xyz"

speed * time;;
xvy;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The value or constructor 'xvy' is not defined at 3,0


let speed = 20;;
 val speed : int = 20

let time = 2;;
 val time : int = 2

speed * time;;
 val it : int = 40

val distance = 186;;
 Unexpected keyword 'val' in interaction at 3,0
 parse error at 3,0

let distance = 186;;
 val distance : int = 186

let time = 8;;
 val time : int = 8

speed = distance / time;;
 val it : bool = false

speed
;;
 val it : int = 20

let speed = distance / time;;
 val speed : int = 23

speed
;;
 val it : int = 23

let distance = 186.0;;
 val distance : float = 186.0

let speed = distance / time;;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 The type 'int' does not match the type 'float' at 3,23
 The type 'int' does not match the type 'float' at 3,21

let time = 8.0;;
 val time : float = 8.0

let speed = distance / time;;
 val speed : float = 23.25

speed;;
 val it : float = 23.25
