Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (IsNumeric(TextBox3.Text) And TextBox3.Text <> "" And IsNumeric(TextBox4.Text) And TextBox4.Text <> "") Then
            If ((Val(TextBox3.Text) = 2 And Val(TextBox4.Text) = 55) Or (Val(TextBox3.Text) And Val(TextBox4.Text))) Then
                Form1.Show()
                Me.Close()
            Else
                MessageBox.Show("Please enter Section or Bench Number Correctly")
            End If
        Else : MessageBox.Show("Please enter" & Check_inputs() & "as a number.")
        End If
    End Sub
    Private Function Check_inputs() As String
        Dim Wrong_inputs As String
        If (Not (IsNumeric(TextBox3.Text)) Or TextBox3.Text = "") Then
            Wrong_inputs = Wrong_inputs & " Section "
        End If
        If (Not (IsNumeric(TextBox4.Text)) Or TextBox4.Text = "") Then
            Wrong_inputs = Wrong_inputs & " Bench Number "
        End If
        Return Wrong_inputs
    End Function
End Class
