Imports System

Module Program


    'מקבל גם מספרים לא שלמים double'
    ' Dim val1 As double = 2.5'
    ' Dim val2 As double = 3.5'


    'כך מגדירים משתנים'
    Dim val1 As Integer = 2
    Dim val2 As Integer = 3
    Dim bolVal As Boolean = True
    Dim strVal As String = "this is my string"
    Dim oneCharVal As Char = "y"

    Dim dateVal As Date = #2023/12/1#
    Dim firstName As String = "jhon"
    Dim lastName As String = "smith"
    Dim prograNum As Integer = 1

    '+= כמו  &='
    'strVal &= "and this is also my string"'

    'sub כל פונק צריכה להיות תחומה ב   '
    Sub Main(args As String())
        'if not , >= , '
        'if val1 =2  and val2=3 then'
        'if val1=1 or val2=2 then'

        'modolo:'
        'Console.WriteLine("val1 mod val2")'

        'המרה למספר:'
        'Console.WriteLine("int(val1) \ int(val2)")'

        If val1 = 2 Then
            Console.WriteLine("we are in the if")

            'סיום התנאי'
        ElseIf val1 = 3 Then
            Console.WriteLine("we are in the else")
        Else
            Console.WriteLine("we are in the else2")
        End If






        'שווה ערך לפלוס &' 
        'Console.WriteLine(" my numbers are " & val1 & " and " & val2 & "." & vbCrLf & "the total is: " & val1 + val2)'
        Console.WriteLine(" my numbers are " & val1 & " and " & val2 & "." & vbCrLf & "the total is: " & val1 + val2)
    End Sub
End Module
