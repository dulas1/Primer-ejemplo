Public Class Form1

    Dim primer As String = "Hola Mundo"
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'este es el otro comentario
        MessageBox.Show("Esto es una prueba", "Mensage")
        MessageBox.Show(primer, "¡Hola a todos!")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        lbox1.Items.Add(txt1.Text)

    End Sub

End Class
