Public Class Form1

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.Panel1.Controls.Count > 0 Then
            Me.Panel1.Controls.Item(0).Dispose()
        End If
        Dim a As New Converter
        Me.Panel1.Controls.Add(a)
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.Panel1.Controls.Count > 0 Then
            Me.Panel1.Controls.Item(0).Dispose()
        End If
        Dim a As New Summer
        Me.Panel1.Controls.Add(a)
    End Sub
End Class
