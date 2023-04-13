Imports System
Imports System.Security.Cryptography.X509Certificates

Module Evants

    Sub Evants()



        Dim soundOfTyping As String

        'ואנו מכניסים לו פרופרטי מסויים ComputerEvants כאן אנו יוצרים משתנה שהוא מופע של הקלאס 
        Dim item2 = New ComputerEvants("Desktop")

        'כאן אנו מפעילים את הפונקציה מהקלאס שלנו ומכניסים את הערך המוחזר למשתנה שלנו
        soundOfTyping = item2.Typing()

        Console.WriteLine(soundOfTyping & " goes the " & item2.TypeOfComputer & ".")
        item2.sound()

        Dim item3 = New ComputerEvants("Motorbike")
        soundOfTyping = item3.Typing()
        Console.WriteLine(soundOfTyping & " goes the " & item3.TypeOfComputer & ".")
        item3.sound()
    End Sub


    'כך שכל פעם שיקראו לאיבנט זה אז הפונקציה הזו תופעל IamTyping אנו יוצרים פונקציה המשוייכת לאיבנט שיצרנו בשם 
    Sub IamTyping_EventHandler()
        Console.WriteLine("i am typing in a evant")
    End Sub


End Module

'כאן אנו יוצרים קלאס
Class ComputerEvants
    'IamTyping כאן אנו מצהירים שאנו יוצרים איבנט בשם 
    Public Event IamTyping()

    'כאן אנו יוצרים קונסטרקטור שזה אומר שכל מופע חדש של הקלאס שלנו השורה הזו תרשם בקונסול
    Public Sub New()
        Console.WriteLine("i am creating a new ComputerEvants")

    End Sub

    'כאן אנו יוצרים עוד קונסטרקטור אשר מקבל ערך מהמשתמש
    Public Sub New(strTypeOfComputer As String)

        'Me.New() משמש במחלקה ComputerEvants כדי לקרוא לבנאי ברירת המחדל ולוודא שהאובייקט מאותחל במלואו לפני ביצוע הגדרה נוספת כלשהי.
        Me.New()

        'כאן אנו מכניסים את הערך מהמשתמש למשתנה שלנו
        TypeOfComputer = strTypeOfComputer

    End Sub

    'כאן אנו יוצרים משתנה פרייבט מסוג סטרינג
    Private _TypeOfComputer As String

    'כאן אנו יוצרים פונקציה בתוך הקלאס
    Function Typing() As String
        ' IamTyping כך אנו קוראים לאיבנט בשם
        'זאת אומרת שבכל פעם שמישו יקרא לאיבנט זה אז הפונקציה המקושרת אליו תפעל IamTyping_EventHandler() אינבט זה הוא מצביע של הפונקציה שיצרנו במיוחד לאיבנט זה בשם
        RaiseEvent IamTyping()
        'ולאחר מכן אנו מחזירים את הסטרינג הזה:
        Return "type type type"

    End Function

    ': ומגדירים לו גט וסט בתבנית הזו TypeOfComputer כאן אנו יוצרים משתנה בשם 
    Public Property TypeOfComputer() As String
        '_TypeOfComputer את הגט שלו אנו מתנים בתנאי סלקט בהתאם להערך של המשתנה 
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

        'יקבע הערך היוחזר בגט שלנו _TypeOfComputer וכך בהתאם לערך של משתנה  _TypeOfComputer בהגדרת הערך שלו בעזרת הסט אנו מגדירים את הערך למשתנה 
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


    Sub sound()
        Console.WriteLine("i am creating a sound")

    End Sub



End Class


