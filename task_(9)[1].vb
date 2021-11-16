Module Module1

    Sub Main()
        Dim fword As String
        Dim sword As String
        Dim str1 As String
        Dim str2 As String
        Dim str3 As String
        Dim str4 As String
        Dim space As Char
        fword = ""
        sword = ""
        space = ""
        str1 = ""
        str3 = ""
        str4 = ""


        Console.Write("Input first word ")
        fword = Console.ReadLine

        Console.Write("Input second word: ")
        sword = Console.ReadLine
        str1 = Left(sword, 2) & Mid(fword, 3, Len(fword) - 2)
        str3 = Left(fword, 2)
        str4 = Mid(sword, 3, Len(sword) - 2)


        str2 = ""


        str2 = (str3 & str4)
        Console.WriteLine(str1 & space & str2)



        Console.ReadKey()
    End Sub

End Module