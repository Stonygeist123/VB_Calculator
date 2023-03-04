Public Class Form1
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Calculate(Txt_Input.Text)
        End If
    End Sub

    Private Sub Calculate(input As String)

    End Sub
End Class
