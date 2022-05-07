Public Class Form1
    Dim c As New CodigoX0
    Dim ganador As Integer = -1
    Dim tablero(2, 2) As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.ComienzoDelJuego()
        tablero = c.getTablero

    End Sub
    Private Sub checkGanador()
        Dim ub(2) As Integer
        ub = c.getUltimoBoton
        If ub(0) = 0 And ub(1) = 0 Then
            btn1.Text = "0"
        End If
        If ub(0) = 0 And ub(1) = 1 Then
            btn2.Text = "0"
        End If
        If ub(0) = 0 And ub(1) = 2 Then
            btn3.Text = "0"
        End If
        If ub(0) = 1 And ub(1) = 0 Then
            btn4.Text = "0"
        End If
        If ub(0) = 1 And ub(1) = 1 Then
            btn5.Text = "0"
        End If
        If ub(0) = 1 And ub(1) = 2 Then
            btn6.Text = "0"
        End If
        If ub(0) = 2 And ub(1) = 0 Then
            btn7.Text = "0"
        End If
        If ub(0) = 2 And ub(1) = 1 Then
            btn8.Text = "0"
        End If
        If ub(0) = 2 And ub(1) = 2 Then
            btn9.Text = "0"
        End If
        If ganador = 0 Then
            Label2.Text = "Gana X"
        End If
        If ganador = 1 Then
            Label2.Text = "Gana 0"
        End If
        If ganador = -1 Then
            If c.tableroCompleto() = True Then
                Label2.Text = "Empate"
            End If

        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If tablero(0, 0) = -1 Then
            btn1.Text = "X"
            c.pulsarBoton(0, 0)
            ganador = c.ganarPartida
            Call checkGanador()
            btn1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If tablero(0, 1) = -1 Then
            btn2.Text = "X"
            c.pulsarBoton(0, 1)
            ganador = c.ganarPartida
            Call checkGanador()
            btn2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If tablero(0, 2) = -1 Then
            btn3.Text = "X"
            c.pulsarBoton(0, 2)
            ganador = c.ganarPartida
            Call checkGanador()
            btn3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If tablero(1, 0) = -1 Then
            btn4.Text = "X"
            c.pulsarBoton(1, 0)
            ganador = c.ganarPartida
            Call checkGanador()
            btn4.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If tablero(1, 1) = -1 Then
            btn5.Text = "X"
            c.pulsarBoton(1, 1)
            ganador = c.ganarPartida
            Call checkGanador()
            btn5.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If tablero(1, 2) = -1 Then
            btn6.Text = "X"
            c.pulsarBoton(1, 2)
            ganador = c.ganarPartida
            Call checkGanador()
            btn6.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If tablero(2, 0) = -1 Then
            btn7.Text = "X"
            c.pulsarBoton(2, 0)
            ganador = c.ganarPartida
            Call checkGanador()
            btn7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If tablero(2, 1) = -1 Then
            btn8.Text = "X"
            c.pulsarBoton(2, 1)
            ganador = c.ganarPartida
            Call checkGanador()
            btn8.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If tablero(2, 2) = -1 Then
            btn9.Text = "X"
            c.pulsarBoton(2, 2)
            ganador = c.ganarPartida
            Call checkGanador()
            btn9.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        c = New CodigoX0
        c.ComienzoDelJuego()
        tablero = c.getTablero()
        ganador = -1
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btn1.ForeColor = Color.White
        btn2.ForeColor = Color.White
        btn3.ForeColor = Color.White
        btn4.ForeColor = Color.White
        btn5.ForeColor = Color.White
        btn6.ForeColor = Color.White
        btn7.ForeColor = Color.White
        btn8.ForeColor = Color.White
        btn9.ForeColor = Color.White
    End Sub
End Class