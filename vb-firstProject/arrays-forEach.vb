Module arrays

    Sub arrays()
        Dim items As Integer() = {10, 11, 12, 12, 14, 15, 16, 17}

        'פה שינינו את הערך של תא 4 לערך 14
        items.SetValue(14, 4)
        items(0) = 22
        Console.WriteLine("the first item of the array is: ", items(0))
        For x As Integer = 0 To items.Length - 1
            Console.WriteLine(items(x))
            If items(x) = 13 Then
                Console.WriteLine("the val 13 is in index" & x)
                Exit For
            End If


        Next

        For Each item As Integer In items
            Console.WriteLine(item)
        Next
    End Sub
End Module