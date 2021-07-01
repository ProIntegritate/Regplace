Module Module1

    Sub Main()

        Dim sArg() As String = Environment.GetCommandLineArgs

        If UBound(sArg) = 0 Then
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("Regplace, written in 2021 by Glenn Larsson. Parameters:")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("1. file to process (text)")
            Console.WriteLine("2. 'regular expression'".Replace("'", Chr(34)))
            Console.WriteLine("3. 'replacement value'".Replace("'", Chr(34)))
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Example: Regplace filename 'averylongstring' 'x'".Replace("'", Chr(34)))
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Above exampel would replace all occurences of averylongstring with x")
            Console.ForegroundColor = ConsoleColor.White
            Exit Sub
        End If

        Dim sFN As String = ""
        Dim sRegExp As String = ""
        Dim sReplace As String = ""

        Try
            sFN = sArg(1)
            sRegExp = sArg(2)
            sReplace = sArg(3)
        Catch ex As Exception
        End Try

        If sFN = "" Or sRegExp = "" Then
            Console.WriteLine("Need a filename and parameters.")
            Exit Sub
        End If

        If System.IO.File.Exists(sFN) = False Then
            Console.WriteLine("File " & sFN & " does not exist.")
            Exit Sub
        End If

        Dim fl As New System.IO.FileInfo(sFN)
        If fl.Length = 0 Then
            Console.WriteLine("File " & sFN & " is 0 length - or locked. Cant continue.")
            Exit Sub
        End If
        fl = Nothing

        Dim sStuff As String = ""

        Try
            sStuff = System.IO.File.ReadAllText(sFN)
        Catch ex As Exception
        End Try

        Dim rx As System.Text.RegularExpressions.Regex
        sStuff = rx.Replace(sStuff, sRegExp, sReplace)
        rx = Nothing

        Try
            System.IO.File.WriteAllText(sFN, sStuff)
        Catch ex As Exception
        End Try

    End Sub

End Module
