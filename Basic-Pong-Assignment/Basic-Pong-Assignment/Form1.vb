Public Class frmPong

    'Holds the ball's vertical and horizontal momentum and speed.
    Dim dblVertMomentum, dblHorizMomentum As Double

    Dim intBallPosition, intScore As Integer

    Private Sub frmPong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Position game spite (moving objects) Randomized
        Randomize()
        intBallPosition = Int((650 - 50 + 1) * Rnd() + 1)
        Me.picBall.Left = intBallPosition
        Me.picBall.Top = 170

        Me.picPaddle.Left = Me.Width / 2 - Me.picPaddle.Width / 2
        Me.picPaddle.Top = 495

    End Sub

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        'Move the ball based on the vertical and horizantal momentum.
        Me.picBall.Top = Me.picBall.Top + dblVertMomentum
        Me.picBall.Left = Me.picBall.Left + dblHorizMomentum

        'Detect colisions between the ball and the padel.
        If Me.picBall.Top + Me.picBall.Height > Me.picPaddle.Top Then
            If Me.picPaddle.Left + Me.picPaddle.Width >= Me.picBall.Left And Me.picPaddle.Left <= Me.picBall.Left + Me.picBall.Width Then
                dblVertMomentum = -dblVertMomentum
            End If
        End If

            'Detect colisions between the ball and the wall.

            If Me.picBall.Left + Me.picBall.Width >= Me.Width Then
                'Detect ball colision with right side of screen.
                Me.picBall.Left = Me.Width - Me.picBall.Width
                dblHorizMomentum = -dblHorizMomentum

            ElseIf Me.picBall.Left <= 0 Then
                'Detect ball collision with left side of screen.
                Me.picBall.Left = 0
                dblHorizMomentum = -dblHorizMomentum

            ElseIf Me.picBall.Top <= 0 Then
                'Detect ball colision with top of the screen.
                Me.picBall.Top = 0
                dblVertMomentum = -dblVertMomentum

            ElseIf Me.picBall.Top >= Me.Height Then
                'Detect ball colision with bottom of the screen.
                Me.tmrGame.Enabled = False
                MsgBox("You Have Lost The Game.")
            End If

            'Detect collisions between the ball and specific bricks.

            'Collisions for picBrick1
        If Me.picBrick1.Left + Me.picBrick1.Width > Me.picBall.Left And Me.picBrick1.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick1.Top + Me.picBrick1.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick1.Top = Me.picBrick1.Top - 100
                intScore = intScore + 1
            End If
        End If

            'Collisions for picBrick2
        If Me.picBrick2.Left + Me.picBrick2.Width > Me.picBall.Left And Me.picBrick2.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick2.Top + Me.picBrick2.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick2.Top = Me.picBrick2.Top - 100
                intScore = intScore + 1
            End If
        End If

            'Collisions for picBrick3
        If Me.picBrick3.Left + Me.picBrick3.Width > Me.picBall.Left And Me.picBrick3.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick3.Top + Me.picBrick3.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick3.Top = Me.picBrick3.Top - 100
                intScore = intScore + 1
            End If
        End If

            'Collisions for picBrick4
        If Me.picBrick4.Left + Me.picBrick4.Width > Me.picBall.Left And Me.picBrick4.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick4.Top + Me.picBrick4.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick4.Top = Me.picBrick4.Top - 100
                intScore = intScore + 1
            End If
        End If

            'Collisions for picBrick5
        If Me.picBrick5.Left + Me.picBrick5.Width > Me.picBall.Left And Me.picBrick5.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick5.Top + Me.picBrick5.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick5.Top = Me.picBrick5.Top - 100
                intScore = intScore + 1
            End If
        End If

            'Collisions for picBrick6
        If Me.picBrick6.Left + Me.picBrick6.Width > Me.picBall.Left And Me.picBrick6.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick6.Top + Me.picBrick6.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick6.Top = Me.picBrick6.Top - 100
                intScore = intScore + 1
            End If
        End If

            'Collisions for picBrick7
        If Me.picBrick7.Left + Me.picBrick7.Width > Me.picBall.Left And Me.picBrick7.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick7.Top + Me.picBrick7.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick7.Top = Me.picBrick7.Top - 100
                intScore = intScore + 1
            End If
        End If

            'Collisions for picBrick8
        If Me.picBrick8.Left + Me.picBrick8.Width > Me.picBall.Left And Me.picBrick8.Left < Me.picBall.Left + Me.picBall.Width Then
            If Me.picBall.Top < Me.picBrick8.Top + Me.picBrick8.Height Then
                dblVertMomentum = -dblVertMomentum
                Me.picBrick8.Top = Me.picBrick8.Top - 100
                intScore = intScore + 1
            End If
        End If

            If intScore = 8 Then
                Me.tmrGame.Enabled = False
                MsgBox("Congradulations: You Have Destroyed All Of The Bricks. You have Won!")
            End If
    End Sub

    Private Sub frmPong_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Left
                If Me.picPaddle.Left <= 0 Then
                    Me.picPaddle.Left = Me.picPaddle.Left
                Else
                    Me.picPaddle.Left = Me.picPaddle.Left - 10
                End If
            Case Keys.Right
                If Me.picPaddle.Left + Me.picPaddle.Width >= Me.Width Then
                    Me.picPaddle.Left = Me.picPaddle.Left
                Else
                    Me.picPaddle.Left = Me.picPaddle.Left + 10
                End If
            Case Keys.Enter
                Me.tmrGame.Enabled = False
                MsgBox("The Game Has Been Paused.")
            Case Keys.ShiftKey
                Me.tmrGame.Enabled = True
            Case Keys.P
                MsgBox("The Game Will Be Resumed")
                Me.tmrGame.Enabled = True
            Case Keys.E
                dblHorizMomentum = 1
                dblVertMomentum = 1
            Case Keys.M
                dblHorizMomentum = 2
                dblVertMomentum = 2
            Case Keys.H
                dblHorizMomentum = 3
                dblVertMomentum = 3
        End Select
    End Sub
End Class
