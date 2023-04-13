Imports System
Module multi
    Sub multiMain(args As String())
        Dim names(3) As String
        names(0) = "joun smith"
        names(1) = "joun smith"
        names(2) = "pilliph berton"
        names(3) = "fred bloggs"
        For x As Byte = 0 To names.Length - 1
            Console.WriteLine(names(x))


        Next

        Dim Mnames(3, 1) As String
        Mnames(0, 0) = "joun"
        Mnames(0, 1) = "smith"
        Mnames(1, 0) = "joun"
        Mnames(1, 1) = "smith"
        Mnames(2, 0) = "pilipe"
        Mnames(2, 1) = "berton"
        Mnames(3, 0) = "fred"
        Mnames(3, 1) = "bloggs"

        For Each nme As String In Mnames
            Console.WriteLine(nme)

        Next





    End Sub
End Module

Class multiClass

End Class