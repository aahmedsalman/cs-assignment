Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim count As Integer = 0
        Dim ing As String = ""
        Dim ly As String = ""
        Dim ingly As String = ""
        Dim pos As String = ""

        Console.Write("Enter string: ")
        str1 = LCase(Console.ReadLine)


        If Len(str1) <= 3 Then
            ing = "ing"
            ingly = ""
        End If
        If Right(str1, 3) = "ing" Then
            ing = ""
            ingly = "ly"

        End If
        If Len(str1) < 3 Then
            ing = ""
            ingly = ""

        End If
        Console.WriteLine("Output: " & str1 & ing & ingly)
        Console.ReadKey()
    End Sub

End Module
