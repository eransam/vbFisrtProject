Imports System
Imports System.Collections


Module queuesMod
    Sub queuesMain(args As String())
        Dim myQueue As Queue
        myQueue.Enqueue("a")
        myQueue.Enqueue("b")
        myQueue.Enqueue("c")
        myQueue.Enqueue("d")
        myQueue.Enqueue("e")
        Console.WriteLine(myQueue.Dequeue())
        Console.WriteLine(myQueue.Peek())
        Console.WriteLine(myQueue.Dequeue())
        myQueue.Enqueue("f")
        For Each obj As Object In myQueue
            Console.WriteLine("in my Queue there is a {0}", obj)

        Next

        If myQueue.Contains("b") Then

            Console.WriteLine("yes, there is a b.")
        End If




    End Sub
End Module

