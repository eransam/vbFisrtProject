Imports System
Imports System.Collections


Module stackMod
    Sub stackMain(args As String())
        Dim myStack As Stack
        myStack.Push("a")
        myStack.Push("b")
        myStack.Push("c")
        myStack.Push("d")
        myStack.Push("e")
        Console.WriteLine(myStack.Pop())
        Console.WriteLine(myStack.Peek())
        Console.WriteLine(myStack.Pop())
        myStack.Push("f")
        For Each obj As Object In myStack
            Console.WriteLine("in my stack there is a {0}", obj)

        Next

        If myStack.Contains("b") Then

            Console.WriteLine("yes, there is a b.")
        End If




    End Sub
End Module


