Imports System





'פולימורפיזם זה בעצם האפשרות ליצור לדוג את אותה פונקציה מספר פעמים עם פעולות שונות כמו פה בדוגמא
'שאותה אנו שמים לפני הפונ הראשונה בקלאס הבסיס  Overridable ואנו עושים זאת ע''י הפקודות   ImMobile() אני יוצרים 2 פונקציות זהות  
'לפני הפונ Overrides ולאחר מכן וכל קלאס אשר יורש את קלאס הבסיס אנו יכולים ליצור שוב את אותה פונקציה ולשנות לה את הפעולות ע''י הפקודה 
Module polymorphism
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

Class polymorphism1 'the base class'
    Public Property TypeOfComputer As String
    Function Hardware()
        Return "Hardwere"

    End Function

    Overridable Function ImMobile()
        Return "i dont know"

    End Function

End Class

Class polymorphism2
    Inherits polymorphism1

    Overrides Function ImMobile()
        Return "i dont know"

    End Function



    Function amIMobile()
        Console.WriteLine("yes i am mobile")

    End Function


End Class

