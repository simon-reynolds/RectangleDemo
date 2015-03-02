namespace RectangleDemoFs

open System
open RectangleDemoFs.Interfaces

type Rectangle(length: decimal, width: decimal) =
    
    do
        if length <= 0m then raise (ArgumentOutOfRangeException("length"))
        if width <= 0m then raise (ArgumentOutOfRangeException("width"))


    member this.IsSquare() =
        length.Equals width

    member val Length =
        length

    member val Width =
        width

    interface IShape with
        member val Area =
            length * width

        member val Perimeter =
            (length * 2m) + (width * 2m)

    