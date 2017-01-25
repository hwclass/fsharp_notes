open System.Drawing

let bitmap = new Bitmap(16,16)

let path = __SOURCE_DIRECTORY__ + "/"

bitmap.Save(path + "bitmap.png")

let large = new Bitmap(32,32)

large.Save(path + "large.png", Imaging.ImageFormat.Png)
