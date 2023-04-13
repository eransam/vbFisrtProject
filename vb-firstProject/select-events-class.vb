Imports System

Module Program2

    Sub Main2()
        Dim firstAnimal As New animal("Lion")
        'זאת אומרת שבמופע הזה בכל פעם שנפעיל מתוך המופע הזה את האיבנט  IHeardASound כך אנו מגדירים למופע הזה שיצרנו תנאי להפעלת האיבנט 
        'ונפעיל אותה IHeardASound_eventHandler אנו נופנה לפונקציה 
        'זאת אומרת שאיבנט זה הוא אישי למופע שיצרנו
        AddHandler firstAnimal.IHeardASound, AddressOf IHeardASound_eventHandler


        Dim secondAnimal As New animal("Fish")
        Console.WriteLine("the first animal is: " & firstAnimal.nameOfAnimal)
        Console.WriteLine("and is noise is: " & firstAnimal.soundOfAnimal)
        Console.WriteLine("the second animal is: " & secondAnimal.nameOfAnimal)
        Console.WriteLine("and is noise is: " & secondAnimal.soundOfAnimal)
    End Sub


    Sub IHeardASound_eventHandler()
        Console.WriteLine("i hear a sound")
    End Sub
End Module

Class animal

    Public Sub New()

    End Sub

    Public Sub New(NameOfAnimal As String)
        ' Property nameOfAnimal וכך בעצם אנו מצביעים על הפרופרטי THIS מקבילה לפקודה  ME הפקודה 
        'אז המערכת הייתה מתייסת למשתנה הזה כאילו משתנה חדש ופוסחת על הפרופרטי הקיים שלו כבר בקלאס ME  במידה ולא היינו רושמים 
        'והייתה ממשיכה בקוד לפי הערך החדש של המשתנה החדש
        Me.nameOfAnimal = NameOfAnimal
    End Sub
    Private _nameOfAnimal As String


    Property nameOfAnimal As String
        Get
            Return _nameOfAnimal

        End Get
        Set(value As String)
            If value = "Fish" Then
                _nameOfAnimal = "not a animal"
            Else
                _nameOfAnimal = value
            End If

        End Set

    End Property

    Public Event IHeardASound()




    Function soundOfAnimal() As String
        RaiseEvent IHeardASound()
        Select Case nameOfAnimal
            Case "lion"
                Return "reeerrr"
            Case "dog"
                Return "bark"
            Case Else
                Return "noise"


        End Select

    End Function


End Class


