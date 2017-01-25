open System.Drawing
open System.IO
open System

let bitmap = new Bitmap(16,16)

let pathAndFileName = Path.Combine(__SOURCE_DIRECTORY__ + "square.png")

let naiveLine (x0,y0) (x1,y1) color (bitmap:Bitmap)
    let xLen = float (x1-x0)
    let yLen = float (y1-y0)

    if xLen <> 0.0 then
        for x in x0.x1 do
            let proportion = float (x-x0) / xLen
            let y = (int (Math.Round(proportion * yLen))) + y0
            printfn "%i" y
            bitmap.SetPixel(x,y,color)
    
	if yLen <> 0.0 then
     for y in y0.y1 do
         let proportion = float (y-y0) / xLen
         let x = (int (Math.Round(proportion * xLen))) + x0
         printfn "%i" x
         bitmap.SetPixel(x,y,color)

bitmap.Save(pathAndFileName)

naiveLine (7,10) (5,19) Color.Red bitmap
