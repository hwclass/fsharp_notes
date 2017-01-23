(*Functions Further*)

let squareFunction (input:int) =
  let sq = input * input
  sq
;;
 val squareFunction : input:int -> int

squareFunction 5
;;
 val it : int = 25

(/*speed calculation*/)

;;
 Unexpected identifier in interaction. Expected ')' or other token. at 3,3
 Unmatched '(' at 3,0
 Unexpected symbol ')' in expression at 3,22
 parse error at 3,22

let speed (dist:float) = dist / 2.0;;
 val speed : dist:float -> float

speed 20.0;;
 val it : float = 10.0
