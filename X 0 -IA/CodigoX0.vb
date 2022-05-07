Public Class CodigoX0
    Private tablero(2, 2) As Integer 'Arreglo que sevira como la cuadricula donde se juega X0'
    Private ganador As Integer = -1 'Variable que contiene el valor del ganador segun la logica del programa es mejor que sea -1'
    Private contador As Integer = 0
    Private ub(2) As Integer 'Arreglo para regresar la ultima posicion que utilice la computadora'

    Public Function getTablero()
        Return tablero
    End Function
    Public Function ComienzoDelJuego() 'Esta funcion relllena la matriz con -1 para indicar que esta vacia y ganador es igual a -1 para decir que no hay ganador'
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                tablero(i, j) = -1
            Next
        Next
        ganador = -1
        Return ""
    End Function
    Public Function pulsarBoton(ByVal n, ByVal m) 'Esta funcion comprueba que la posicion que escogio el usuario sea valida y comprueba si la partida ya se gano y llama la funcion para que juege la computadora'
        If n >= 0 And n < 3 And m < 3 And tablero(n, m) = -1 Then
            If ganador = -1 Then
                tablero(n, m) = 0
                ganador = ganarPartida()
                ponerFichaCompu()
            End If
        End If
    End Function
    Public Function ganarPartida() 'Esta funcion contiene todos los parametros para declarar un ganador retornado el valor que se encuentra en la casilla como el del ganador'
        'victoria en diagonal \'
        If tablero(0, 0) <> -1 And tablero(0, 0) = tablero(1, 1) And tablero(0, 0) = tablero(2, 2) Then
            Return tablero(0, 0)
        End If
        'victoria en diagonal /'
        If tablero(0, 2) <> -1 And tablero(0, 2) = tablero(1, 1) And tablero(0, 2) = tablero(2, 0) Then
            Return tablero(0, 2)
        End If
        'victor en horizontal y diagonal'
        For n As Integer = 0 To 2
            If tablero(n, 0) <> -1 And tablero(n, 0) = tablero(n, 1) And tablero(n, 0) = tablero(n, 2) Then 'horizontal'
                Return tablero(n, 0)
            End If
            If tablero(0, n) <> -1 And tablero(0, n) = tablero(1, n) And tablero(0, n) = tablero(2, n) Then 'vertical'
                Return tablero(0, n)
            End If
        Next
        Return -1
    End Function
    Public Function getGanador()
        Return ganador
    End Function
    Public Function getUltimoBoton()
        Return ub
    End Function
    'ALGORITMO MINI MAX'
    Public Function tableroCompleto() 'Esta funcion reccore todo el tablero para comprobar si esta lleno'
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If tablero(x, y) = -1 Then
                    Return False
                End If

            Next
        Next
    End Function
    Public Function finPartida() 'esta funcion revisa los dos valores booleando 
        Return tableroCompleto() Or ganarPartida() <> -1
    End Function
    Public Function PonerFichaCompu()
        If Not finPartida() Then
            Dim f As Integer = 0
            Dim c As Integer = 0
            Dim v As Integer = Integer.MinValue 'para que funcione el algoritmo se necesita colocar el minimo valor posible en el lenguaje de Visual basics'
            Dim aux As Integer
            For x As Integer = 0 To 2
                For y As Integer = 0 To 2
                    If tablero(x, y) = -1 Then
                        tablero(x, y) = 1
                        aux = min()
                        If aux > v Then
                            v = aux
                            f = x
                            c = y
                        End If
                        tablero(x, y) = -1
                    End If
                Next
            Next
            tablero(f, c) = 1
            ub(0) = f
            ub(1) = c
        End If
    End Function
    Private Function max()
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return -1
            Else Return 0
            End If
        End If
        Dim v As Integer = Integer.MinValue
        Dim aux As Integer
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If tablero(x, y) = -1 Then
                    tablero(x, y) = 1
                    aux = min()
                    If aux > v Then
                        v = aux
                    End If
                    tablero(x, y) = -1
                End If
            Next
        Next
        Return v
    End Function
    Private Function min()
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return 1
            Else Return 0
            End If
        End If
        Dim v As Integer = Integer.MaxValue
        Dim aux As Integer
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                If tablero(x, y) = -1 Then
                    tablero(x, y) = 0
                    aux = max()
                    If aux < v Then
                        v = aux
                    End If
                    tablero(x, y) = -1
                End If
            Next
        Next
        Return v
    End Function
End Class
