Imports System.Data.OleDb

Public Class CoinSlot
    Public Property Dollar As Integer
    Public Property Quarter As Integer
    Public Property Dime As Integer
    Public Property Nickle As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return Dollar + Quarter * 0.25 + Dime * 0.1 + Nickle * 0.05
        End Get
    End Property
    Public Sub insertDollar()
        Dollar = Dollar + 1
    End Sub
    Public Sub insertQuarter()
        Quarter = Quarter + 1
    End Sub
    Public Sub insertDime()
        Dime = Dime + 1
    End Sub
    Public Sub insertNickle()
        Nickle = Nickle + 1
    End Sub
End Class
