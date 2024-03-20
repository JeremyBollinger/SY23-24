Public Class Form1
    Dim Cs As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If Cs.Total >= 1 Then
            ReelControl1.spin()
            ReelControl2.spin()
            ReelControl3.spin()
            Cs.spin()
            TotalLabel.Text = Cs.Total.ToString("c2")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ReelControl1.itemValue
        Label2.Text = ReelControl2.itemValue
        Label3.Text = ReelControl3.itemValue
        Timer1.Enabled = False
        If ReelControl1.itemValue = ReelControl2.itemValue And ReelControl2.itemValue = ReelControl3.itemValue Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Cs.insertDollar()
        TotalLabel.Text = Cs.Total.ToString("c2")
    End Sub

    Private Sub ReelControl1_Load(sender As Object, e As EventArgs) Handles ReelControl1.Load

    End Sub
End Class
