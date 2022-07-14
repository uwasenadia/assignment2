Public Class Bank
    Public AccountNumber As String
    Public OwnerName As String
    Public OwnerAddress As String
    Public OwnerEmail As String
    Public Balance As Decimal
    Public Overrides Function ToString() As String
        Return AccountNumber & vbTab & OwnerName & vbTab & OwnerAddress & vbTab & OwnerEmail & vbTab & Balance
    End Function
    Sub New(ACCOUNT As String, NAME As String, ADDRESS As String, EMAIL As String, BALANCE As Decimal)
        Me.AccountNumber = ACCOUNT
        Me.OwnerName = NAME
        Me.OwnerAddress = ADDRESS
        Me.OwnerEmail = EMAIL
        Me.Balance = BALANCE
    End Sub
    Sub New()

    End Sub
End Class
