1 + 1 ;;
 val it : int = 2

let completed = 'completed';;
 Stopped due to error
 System.Exception: Operation could not be completed due to earlier error
 Unexpected quote symbol in binding at 3,16

let completed = "completed";;
 val completed : string = "completed"

completed;;
 val it : string = "completed"

let uncompleted = "uncompleted"
;;
 val uncompleted : string = "uncompleted"

let hello = "Hello";;
 val hello : string = "Hello"

let name = "Baris";;
 val name : string = "Baris"

hello + name;;
 val it : string = "HelloBaris"

"hello " + "Baris";;
 val it : string = "hello Baris"

"hello, " + "Baris";;
 val it : string = "hello, Baris"

let hello = "hello, ";;
 val hello : string = "hello, "

hello + 'Baris';;
 Unexpected quote symbol in expression at 3,8
 parse error at 3,8

hello + "Baris";;
 val it : string = "hello, Baris"

let name = "Baris";;
 val name : string = "Baris"

hello + name;;
 val it : string = "hello, Baris"

let greeting = hello + name;;
 val greeting : string = "hello, Baris"

greeting;;
 val it : string = "hello, Baris"
