Imports System
Module Recursion

    Sub Recursion1()


        Console.WriteLine(GrandTotal(9))


    End Sub


    Function GrandTotal(Addnumber As Integer, Optional RunningTotal As Integer = 0)
        RunningTotal += Addnumber
        If Addnumber <= 0 Then
            Return RunningTotal
        End If

        Return GrandTotal(Addnumber - 1, RunningTotal)

    End Function

End Module

Class RecursionClass

End Class