Imports System.Runtime.InteropServices

Public Class Form1
    Dim WithEvents CS As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.insertDollar()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertQuarter()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDime()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertNickle()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.CoinReturn()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles CS.CoinReturnEvent
        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If

        If q > 0 Then
            QuarterPictureBox.Visible = True
        Else
            QuarterPictureBox.Visible = False
        End If

        If dm > 0 Then
            DimePictureBox.Visible = True
        Else
            DimePictureBox.Visible = False
        End If

        If n > 0 Then
            NickelPictureBox.Visible = True
        Else
            NickelPictureBox.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextBox.Text
            Case ProductControlvb1.ProductID
                CS.buy(ProductControlvb1)

            Case ProductControlvb2.ProductID
                CS.buy(ProductControlvb2)

            Case ProductControlvb3.ProductID
                CS.buy(ProductControlvb3)

            Case ProductControlvb4.ProductID
                CS.buy(ProductControlvb4)

            Case ProductControlvb5.ProductID
                CS.buy(ProductControlvb5)

            Case ProductControlvb6.ProductID
                CS.buy(ProductControlvb6)

            Case ProductControlvb7.ProductID
                CS.buy(ProductControlvb7)

            Case ProductControlvb8.ProductID
                CS.buy(ProductControlvb8)

            Case ProductControlvb9.ProductID
                CS.buy(ProductControlvb9)

            Case ProductControlvb10.ProductID
                CS.buy(ProductControlvb10)

            Case ProductControlvb11.ProductID
                CS.buy(ProductControlvb11)

            Case ProductControlvb12.ProductID
                CS.buy(ProductControlvb12)

            Case ProductControlvb13.ProductID
                CS.buy(ProductControlvb13)

            Case ProductControlvb14.ProductID
                CS.buy(ProductControlvb14)

            Case ProductControlvb15.ProductID
                CS.buy(ProductControlvb15)

            Case Else
        End Select
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CS_Dispense(P As Image) Handles CS.Dispense
        ProductPictureBox.Image = P
    End Sub
End Class
