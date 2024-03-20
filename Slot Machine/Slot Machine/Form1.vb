Public Class Form1
    Public Property itemValue As Integer
    Public Property spinTime As Integer = 2000
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Public Sub spin()
        'generate a random number
        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        Label1.Text = r


        ' show a picture from picture list
        PictureBox1.Image = ImageList1.Images(r)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spin()
    End Sub
End Class
