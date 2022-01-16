Imports System.Text.RegularExpressions
Public Class Form1
    Public Sub verificar()
        Try
            If Regex.IsMatch(txtCadena.Text, txtRegex.Text) = True Then
                lblResultado.Text = "Resultado: La cadena coincide con la expresión regular √"
                lblResultado.ForeColor = Color.ForestGreen
            Else
                lblResultado.Text = "Resultado: La cadena NO coincide con la expresión regular X"
                lblResultado.ForeColor = Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtRegex_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRegex.KeyUp
        verificar()
    End Sub

    Private Sub txtCadena_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCadena.KeyUp
        verificar()
    End Sub

    
   
End Class
