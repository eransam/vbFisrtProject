Imports System

Module Constractors

    Sub Constractors()

        Dim item = New Constractors1("DeskTop")
        item.typing()
    End Sub
End Module

Class Constractors1
    Private _TypeOfComputer As String
    Public Property TypeOfComputer() As String
        Get
            Select Case _TypeOfComputer
                Case "LapTop"
                    Return "pretty good laptop"
                Case "Dasktop"
                    Return "nice desktop"
                Case Else
                    Return _TypeOfComputer

            End Select

        End Get
        Set(ByVal value As String)
            Select Case value
                Case "LapTop", "DeskTop"
                    _TypeOfComputer = value
                Case Else
                    _TypeOfComputer = "unknown"


            End Select
            _TypeOfComputer = value
        End Set
    End Property

    'this is the constractor: '
    Public Sub New(strTypeOfComputer As String)
        TypeOfComputer = strTypeOfComputer
    End Sub

    Function typing() As String
        Console.WriteLine("i im typing in a " & TypeOfComputer)
        Return "type type type "
    End Function

    Sub sound()
        Console.WriteLine("i am creating a sound")
    End Sub




End Class


