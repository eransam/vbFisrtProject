Imports System
Module Program3





    'מקבל גם מספרים לא שלמים double'
    ' Dim val1 As double = 2.5'
    ' Dim val2 As double = 3.5'


    'כך מגדירים משתנים'
    Dim val1 As Integer = 14
    Dim val2 As Integer = 10
    Dim bolVal As Boolean = True
    Dim strVal As String = "this is my string"
    Dim oneCharVal As Char = "y"
    Dim valFor As Integer

    Dim dateVal As Date = #2023/12/1#
    Dim firstName As String = "jhon"
    Dim lastName As String = "smith"
    Dim prograNum As Integer = 1

    '+= כמו  &='
    'strVal &= "and this is also my string"'

    'sub כל פונק צריכה להיות תחומה ב   '
    Sub Main3(args As String())

        'modolo:'
        'Console.WriteLine("val1 mod val2")'

        'המרה למספר:'
        'Console.WriteLine("int(val1) \ int(val2)")'


        'select case:--------------------------------------------------------------------------------------------'

        Select Case val1 Mod val2
            Case 1
                Console.WriteLine("its 1")
            Case 2
                Console.WriteLine("its 2")
            Case 6, 8
                Console.WriteLine("fhfhfghfg")

            Case 3 To 5
                Console.WriteLine("fhfhfggh")
        End Select




        'for loop ---------------------------------------------------------------------------------------------'

        'כך אנו עושים לולאה אשר רצה 21 פעמים זאת אומרת שאנו צריכים לזכור שכאן הלופ רץ גם כאשר מגיע ל20'
        For valFor = 1 To 20
            Console.WriteLine("we r in the for")

        Next
        'כך אנו אומרים ללולאה לרדת בצעדי מינוס 1 Step -1'
        'ירוץ בקפיצות של 2  step 2'
        For valFor = 30 To 20 Step -1
            Console.WriteLine("we r in the for")
            If valFor = 21 Then
                Exit For
            End If

        Next

        'if ---------------------------------------------------------------------------------------------'

        'if not , >= , '
        'if val1 =2  and val2=3 then'
        'if val1=1 or val2=2 then'
        If val1 = 2 Then
            Console.WriteLine("we are in the if")

            'סיום התנאי'
        ElseIf val1 = 3 Then
            Console.WriteLine("we are in the else")
        Else
            Console.WriteLine("we are in the else2")
        End If


        'while ---------------------------------------------------------------------------------------------'
        Dim valWhile As Integer
        While valWhile <= 20
            If valWhile = 10 Then
                Exit While
            End If
            Console.WriteLine("fff")
            valWhile += 1

        End While



        'Do while ---------------------------------------------------------------------------------------------'

        Do
            If valWhile = 100 Then
                Exit Do
            End If
            valWhile = valWhile + 1
            Console.WriteLine("fff")
        Loop While valWhile <= 20




        'ReadLine ---------------------------------------------------------------------------------------------'



        Dim val1ReadLine As Integer = 30
        Dim val2ReadLine As Double
        Dim userInput As String
        Console.Write("please enter a denominator: ")

        'כך אנו נקבל את הערך מהמשתמש:'
        userInput = Console.ReadLine()

        Try
            'לסוג דאבל כך userInput ממירים את '
            val2ReadLine = CDbl(userInput)
            Console.WriteLine(val1ReadLine & " modulus " & val2ReadLine & " is " & (val1ReadLine Mod val2ReadLine) & ".")

            'במידה ותיהיה שגיאה אז המערכת תנתב לקאצ' המתאים'
        Catch ex As FormatException
            Console.Write("there is a format exception")


        Catch ex As Exception
            Console.Write("there is a problem with the input")
            Throw

        Finally
            Console.Write("the end. ")

        End Try


        'for question ---------------------------------------------------------------------------------------------'


        Dim userInput2 As String
        Dim runningTotal As Double = 1
        ' For numberOfTimes As Byte = 1 To 5
        ' Console.Write("please enter your number: ")
        ' userInput = Console.ReadLine()
        ' unningTotal *= userInput
        ' Next
        ' Console.Write("your answer is: ")
        ' Console.Write(runningTotal)
        ' Console.WriteLine("this is the end of the program") 



        'Do While question ---------------------------------------------------------------------------------------------'

        Do
            Console.Write("please enter your number: ")
            userInput = Console.ReadLine()
            runningTotal *= userInput

            'עוד צורה לכתיבה   Loop While userInput <> "0"
        Loop Until userInput = "0"

        Console.Write("your answer is: ")
        Console.Write(runningTotal)




        Console.WriteLine("this is the end of the program")

        Dim item = New Computer3
        Dim soundOfTyping As String
        soundOfTyping = item.typing()
        item.TypeOfComputer = "LapTop"
        Console.WriteLine(soundOfTyping & " goes the " & item.TypeOfComputer)

        Console.WriteLine(soundOfTyping & " goes the computer")
        item.sound()



    End Sub
End Module


'class-----------------------------------------------------------------------------------------------------'

Class Computer3

    'get - set ..........................................................................................'

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




    'fanctions--------------------------------------------------------------------------------------------'


    Function typing() As String
        Console.WriteLine("i im typing")
        Return "type type type "
    End Function

    Sub sound()
        Console.WriteLine("i am creating a sound")
    End Sub
End Class
