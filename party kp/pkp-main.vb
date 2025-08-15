Public Class pkp_main
    Dim randomgen As New System.Random()
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MoveKP()
    End Sub
    Function MoveKP() As Boolean
        Dim mHeight As Integer = My.Computer.Screen.Bounds.Height - 917
        Dim mWidth As Integer = My.Computer.Screen.Bounds.Width - 1137
        Dim xPos As Integer = randomgen.Next(mWidth)
        Dim yPos As Integer = randomgen.Next(mHeight)
        Me.Location = New Point(xPos, yPos)
        Return True
    End Function
End Class