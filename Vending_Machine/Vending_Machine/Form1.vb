Imports System.Runtime.InteropServices

Public Class Form1
    Dim CS As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.insertDollar()
        Label1.Text = CS.total
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertQuarter()
        Label1.Text = CS.total
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDime()
        Label1.Text = CS.total
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertNickle()
        Label1.Text = CS.total
    End Sub
End Class
