
Public Class CoinSlot
    Public Event Dispense(P As Image)
    Public Event CoinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property Dollar As Integer
    Public Property Quarter As Integer
    Public Property Dime As Integer
    Public Property Nickle As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal

        Get
            _Total = Dollar + Quarter * 0.25 + Dime * 0.1 + Nickle * 0.05
            Return _Total
        End Get
    End Property
    Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollar, Quarter, Dime, Nickle)
        Dollar = 0
        Quarter = 0
        Dime = 0
        Nickle = 0
    End Sub

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
    Public Sub spin()
        If Total >= 1 Then
            _Total = Total - 1
            Dollar = 0
            Quarter = 0
            Dime = 0
            Nickle = _Total / 0.05
        End If
    End Sub
End Class
