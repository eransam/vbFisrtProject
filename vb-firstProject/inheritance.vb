Imports System
Module inheritance
    Sub inheritanceMain()
        Console.WriteLine("computer")
        Dim item As New inheritance1()
        item.TypeOfComputer = "a generic computer"
        Console.WriteLine(item.Hardware())

        Console.WriteLine(item.TypeOfComputer)

        Console.WriteLine("Laptop")
        Dim item2 As New inheritance2()
        item2.TypeOfComputer = "a laptop"
        Console.WriteLine(item2.Hardware())
        Console.WriteLine(item2.TypeOfComputer)
        Console.WriteLine(item2.amIMobile())







    End Sub
End Module

Class inheritance1 'the base class'
    Public Property TypeOfComputer As String
    Function Hardware()
        Return "Hardwere"

    End Function
End Class

Class inheritance2
    Inherits inheritance1

    Function amIMobile()
        Console.WriteLine("yes i am mobile")

    End Function


End Class

