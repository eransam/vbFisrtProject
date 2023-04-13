Imports System
Imports System.Collections
Imports System.Collections.Generic



Module LinkedListMod
    Sub LinkedListMain(args As String())
        Dim LL As New LinkedList(Of String)
        LL.AddFirst("a")
        LL.AddLast("b")
        LL.AddLast("c")
        LL.AddLast("d")
        LL.AddLast("e")
        LL.RemoveLast()
        LL.Remove(LL.Find("b"))
        LL.AddBefore(LL.Find("c"), "F")
        LL.AddAfter(LL.Find("c"), "G")
        If LL.Contains("B") Then
            Console.WriteLine("the contain is true")

        Else
            Console.WriteLine("the contain is false")
        End If

        For Each word As String In LL
            Console.WriteLine(word)

        Next
        LL.Clear()




    End Sub
End Module

