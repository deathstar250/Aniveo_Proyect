Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Useresq.Text = user


    End Sub


    Private Sub CerrarAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicacionToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPeliculaToolStripMenuItem.Click
        addmovie.ShowDialog()
    End Sub

    Private Sub EliminarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPeliculaToolStripMenuItem.Click
        delmovie.ShowDialog()
    End Sub

    Private Sub ModificarPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarPeliculaToolStripMenuItem.Click
        modmovie.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        addser.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        modser.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        delser.ShowDialog()
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        adduser.ShowDialog()
    End Sub

    Private Sub BorrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarUsuarioToolStripMenuItem.Click
        deluser.ShowDialog()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        moduser.ShowDialog()
    End Sub
End Class
