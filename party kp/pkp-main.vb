Public Class pkp_main
    Dim randomgen As New System.Random()
    Dim xPos As Integer
    Dim yPos As Integer
    Function MoveKP() As Boolean
        My.Computer.Audio.Play(My.Resources.honk, AudioPlayMode.Background)
        Dim mHeight As Integer = My.Computer.Screen.Bounds.Height - Me.Height
        Dim mWidth As Integer = My.Computer.Screen.Bounds.Width - Me.Width
        xPos = randomgen.Next(mWidth)
        yPos = randomgen.Next(mHeight)
        Dim kpWidth As Integer = randomgen.Next(1000) + 100
        Dim kpHeight As Integer = randomgen.Next(800) + 100
        Me.Width = kpWidth
        Me.Height = kpHeight
        Me.kp.Width = Me.Width
        Me.kp.Height = Me.Height
        'Me.kp.Location = New Point(0, 0)
        Me.Location = New Point(xPos, yPos)
        Return True
    End Function

    Private Sub kpMovementInterval_Tick(sender As Object, e As EventArgs) Handles kpMovementInterval.Tick
        MoveKP()
    End Sub

    Private Sub kpShakeInterval_Tick(sender As Object, e As EventArgs) Handles kpShakeInterval.Tick
        Dim xShake As Integer = randomgen.Next(40)
        Dim yShake As Integer = randomgen.Next(40)
        Me.Location = New Point(xPos + xShake, yPos + yShake)
    End Sub

    Private Sub pkp_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.honk, AudioPlayMode.Background)
    End Sub
End Class