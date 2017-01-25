open System.Drawing

let bitmap = new Bitmap(16,16)

let path = __SOURCE_DIRECTORY__ + "/"

bitmap.SetPixel(6,2,Color.DarkOrange)
bitmap.SetPixel(6,2,Color.BlanchedAlmond)

bitmap.SetPixel(7,4,Color.Pink)

bitmap.SetPixel(5,5,Color.Red)
bitmap.SetPixel(6,6,Color.Red)
bitmap.SetPixel(7,6,Color.Red)
bitmap.SetPixel(8,6,Color.Red)

bitmap.SetPixel(9,5,Color.Red)

bitmap.Save(path + "smiley.png")
