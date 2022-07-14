Module Module1

    Sub Main()
        Dim choice As String
        choice = ""
        Do
            Console.WriteLine("1. CREATE ACCOUNT" & vbNewLine & "2. DISPLAY ACCOUNT" & vbNewLine & vbNewLine & "CHOOSE OPTION")
            choice = Console.ReadLine()
            Select Case choice
                Case "1"
                    CreateAccounts()
                Case "2"
                    DisplayAccounts()
                Case Else
                    Console.WriteLine("INVALID CHOICE")
            End Select

        Loop While choice <> ""
        Console.ReadLine()
    End Sub
    Dim ACCLIST As List(Of Bank) = New List(Of Bank)
    Sub CreateAccounts()
        Dim AccNo, Name, Addr, Email As String
        Dim balance As Decimal
        AccNo = ""
        Do
            Console.WriteLine("ENTER ACCOUNT NUMBER")
            AccNo = Console.ReadLine()
            If AccNo = "" Then
                Exit Do
            End If
            Console.WriteLine("ENTER  NAME")
            Name = Console.ReadLine()
            Console.WriteLine("ENTER  ADDRESS")
            Addr = Console.ReadLine()
            Console.WriteLine("ENTER EMAIL")
            Email = Console.ReadLine()
            Console.WriteLine("ENTER BALANCE")
            balance = Console.ReadLine()
            ACCLIST.Add(New Bank(AccNo, Name, Addr, Email, balance))
        Loop While AccNo <> ""

    End Sub
    Sub DisplayAccounts()
        For Each account In ACCLIST
            Console.WriteLine(account)
        Next
        Console.ReadLine()
    End Sub

End Module
