Module Module1


        Sub Main()

        Dim str1, str2, str3, str4 As String
            Dim notposition, badposition, counter, counter2 As Integer
            str1 = ""
            notposition = 0
            badposition = 0
            counter = 0
            counter2 = 0


            Console.Write("Input string: ")
            str1 = UCase(Console.ReadLine)
        str4 = str1




            For counter = 1 To Len(str1)
                If Mid(str1, counter, 3) = "NOT" Then
                    notposition = counter
                ElseIf Mid(str1, counter, 3) = "BAD" Then
                    badposition = counter
                End If


        Next
        If notposition = 0 Then
            Console.WriteLine(LCase(str4))
            Console.ReadKey()
        End If
        If badposition = 0 Then
            Console.WriteLine(LCase(str4))
            Console.ReadKey()

        End If
        str2 = LCase(Mid(str1, 1, notposition - 1))
        str3 = LCase(Mid(str1, badposition + 3))
        str1 = LCase(str1)



            If badposition > notposition Then
            Console.WriteLine("Altered string: " & str2 & "good" & str3)
                Console.ReadKey()

        End If

    End Sub

End Module
