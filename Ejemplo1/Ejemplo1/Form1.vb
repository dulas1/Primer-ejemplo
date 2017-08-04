Public Class Form1

    Dim primer As String = "Hola Mundo"
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'esto es un comentario
        MessageBox.Show("Esto es una prueba", "Mensage")
        MessageBox.Show(primer, "¡Hola a todos!")
    End Sub
End Class
