Public Class frmLogin

    '
    Dim intCounter As Integer = 0

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If intCounter >= 3 Then
            MessageBox.Show("Maximum number of attempts exceed")
            Application.Exit()
        End If
        If UsernameTextBox.Text = "admin" Then
            If PasswordTextBox.Text = "admin" Then
                Dim frmParkVale As New frmParkVale
                frmParkVale.Show()
                Me.Close()
            End If
        End If
        intCounter = intCounter + 1
    End Sub

    Private Sub Cancel_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
