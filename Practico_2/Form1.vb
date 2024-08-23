Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LNombre.Click

    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        Dim nombreActual As String = TNombre.Text
        Dim caracteresPermitidos As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        For Each c As Char In nombreActual
            If Not caracteresPermitidos.Contains(c) Then
                MessageBox.Show("Solo se permiten letras en el nombre.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TNombre.Text = TNombre.Text.Remove(TNombre.Text.Length - 1)
                TNombre.SelectionStart = TNombre.Text.Length
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged
        Dim apellidoActual As String = TApellido.Text
        Dim caracteresPermitidos As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        For Each c As Char In apellidoActual
            If Not caracteresPermitidos.Contains(c) Then
                MessageBox.Show("Solo se permiten letras en el apellido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TApellido.Text = TApellido.Text.Remove(TApellido.Text.Length - 1)
                TApellido.SelectionStart = TApellido.Text.Length
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged
        Dim dniActual As String = TDni.Text

        For Each c As Char In dniActual
            If Not Char.IsDigit(c) Then
                MessageBox.Show("Solo se permiten números en el DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TDni.Text = TDni.Text.Remove(TDni.Text.Length - 1)
                TDni.SelectionStart = TDni.Text.Length
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TNombre.Text = "" Or TApellido.Text = "" Or TDni.Text = "" Then
            MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ask As MsgBoxResult

            ask = MsgBox("Seguro que desea insertar un nuevo Cliente?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1, "Confirmar Inserción")

            If ask = MsgBoxResult.Yes Then
                LModificar.Text = "Nombre: " & TNombre.Text & " " & TApellido.Text & " | DNI: " & TDni.Text


                MsgBox("El Cliente: " & TNombre.Text & " " & TApellido.Text & " se insertó correctamente", MsgBoxStyle.Information, "Guardar")


            End If
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Está a punto de eliminar el Cliente: " & TNombre.Text & " " & TApellido.Text,
                     MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation, "Confirmar Eliminación")
        If ask = MsgBoxResult.Yes Then
            MsgBox("El Cliente: " & TNombre.Text & " " & TApellido.Text & " se eliminó correctamente",
                   MsgBoxStyle.Information, "Eliminar")

            TNombre.Clear()
            TApellido.Clear()
            TDni.Clear()
            LModificar.Text = ""
        End If
    End Sub

    Private Sub LModificar_Click(sender As Object, e As EventArgs) Handles LModificar.Click

    End Sub
End Class
