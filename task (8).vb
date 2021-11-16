Module module1
    Sub main()

        Dim str1 As String
        Dim firstcharacter As String
        Dim char1 As String
        Dim char2 As String
        Dim nstr As String


        char1 = ""
        char2 = ""
        str1 = ""
        nstr = ""
        firstcharacter = ""

        Console.Write("Enter string: ")
        str1 = Console.ReadLine()
        firstcharacter = str1(0)
        nstr = firstcharacter
        For count = 1 To Len(str1) - 1
            If str1(count) <> firstcharacter Then
                nstr = nstr & str1(count)
            Else : nstr = nstr & char1

            End If
        Next
        Console.WriteLine("Altered String: " & nstr)
        Console.ReadKey()
    End Sub
End Module
