Imports System.Text.RegularExpressions
Public Class Summer

    Private Sub Summer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label3.Text = ""
        Label6.Text = ""
        Label8.Text = ""
        Label2.Text = ""
        Label7.Text = ""
        Label9.Text = ""
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim Decimalpattern As String = "[09]"
        Dim Binarypattern As String = "[01]"
        Dim Octalpattern As String = "[0-7]"
        Dim Num1 As Integer = 0
        Dim Num2 As Integer = 0
        If ComboBox1.Text <> "Select the base" Then
            If (IsNumeric(TextBox1.Text) And TextBox1.Text <> "") Then
                'Number1
                If ComboBox1.Text = "Decimal (Base 10)" Then
                    Dim data As Integer = CInt(TextBox1.Text)
                    Dim regex As Regex = New Regex(Decimalpattern)
                    Dim match As Match = regex.Match(TextBox1.Text)
                    If match.Success Then
                        'here we test the range [0-9]
                        Num1 = Val(TextBox1.Text)
                    Else : MessageBox.Show("Only digits from 0 to 9 are allowed")
                        TextBox1.Text = ""
                        TextBox1.Focus()
                    End If

                ElseIf ComboBox1.Text = "Binary (Base 2)" Then
                    'here we test the range [01]
                    Dim regex As Regex = New Regex(Binarypattern)
                    Dim match As Match = regex.Match(TextBox1.Text)
                    If match.Success Then
                        'here we convert to decimal
                        Num1 = Convert.ToInt32(TextBox1.Text, 2)
                    Else : MessageBox.Show("Only digits from 0 to 1 are allowed")
                        TextBox1.Text = ""
                        TextBox1.Focus()
                    End If

                ElseIf ComboBox1.Text = "Octal (Base 8)" Then
                    'here we test the range [0-7]
                    Dim regex As Regex = New Regex(Octalpattern)
                    Dim match As Match = regex.Match(TextBox1.Text)
                    If match.Success Then
                        'here we convert to decimal
                        Num1 = Convert.ToInt32(TextBox2.Text, 8)
                    Else : MessageBox.Show("Only digits from 0 to 7 are allowed")
                        TextBox1.Text = ""
                        TextBox1.Focus()
                    End If
                End If
            Else : MessageBox.Show("Please enter the first number.")

            End If
        Else : MessageBox.Show("Please select a base for the first number.")
        End If

        If ComboBox2.Text <> "Select the base" Then
            'Number2
            If (IsNumeric(TextBox2.Text) And TextBox2.Text <> "") Then
                If ComboBox2.Text = "Decimal (Base 10)" Then
                    Dim data As Integer = CInt(TextBox2.Text)
                    Dim regex As Regex = New Regex(Decimalpattern)
                    Dim match As Match = regex.Match(TextBox2.Text)
                    If match.Success Then
                        'here we test the range [0-9]
                        Num2 = Val(TextBox2.Text)
                    Else : MessageBox.Show("Only digits from 0 to 9 are allowed")
                        TextBox2.Text = ""
                        TextBox2.Focus()
                    End If

                ElseIf ComboBox2.Text = "Binary (Base 2)" Then
                    'here we test the range [01]
                    Dim data As Integer = CInt(TextBox2.Text)
                    Dim regex As Regex = New Regex(Binarypattern)
                    Dim match As Match = regex.Match(TextBox2.Text)
                    If match.Success Then
                        'here we convert to decimal
                        Num2 = Convert.ToInt32(TextBox2.Text, 2)
                    Else : MessageBox.Show("Only digits from 0 to 1 are allowed")
                        TextBox2.Text = ""
                        TextBox2.Focus()
                    End If

                ElseIf ComboBox2.Text = "Octal (Base 8)" Then
                    'here we test the range [0-7]
                    Dim data As Integer = CInt(TextBox2.Text)
                    Dim regex As Regex = New Regex(Octalpattern)
                    Dim match As Match = regex.Match(TextBox1.Text)
                    If match.Success Then
                        'here we convert to decimal
                        Num2 = Convert.ToInt32(TextBox2.Text, 8)
                    Else : MessageBox.Show("Only digits from 0 to 7 are allowed")
                        TextBox2.Text = ""
                        TextBox2.Focus()
                    End If
                End If
            Else : MessageBox.Show("Please enter the second number.")
            End If
        Else : MessageBox.Show("Please select a base for the second number.")
            End If
        'here we sum them
        If ComboBox3.Text <> "Select the base" Then
            Dim decsum As Integer = Num1 + Num2
            If ComboBox3.Text = "Decimal (Base 10)" Then
                Label9.Text = decsum
            ElseIf ComboBox3.Text = "Binary (Base 2)" Then
                Label9.Text = Convert.ToString(decsum, 2)
            ElseIf ComboBox3.Text = "Octal (Base 8)" Then
                Label9.Text = Convert.ToString(decsum, 8)
            End If
            Label3.Text = "The sum is:"
            Label6.Text = TextBox1.Text
            Label2.Text = TextBox2.Text
            Label8.Text = "+"
            Label7.Text = "="
        Else : MessageBox.Show("Please select a base for the summed number.")

        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ComboBox2.Text = "Select the base"
        ComboBox1.Text = "Select the base"
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        Label6.Text = ""
        Label8.Text = ""
        Label2.Text = ""
        Label7.Text = ""
        Label9.Text = ""
        TextBox1.Focus()
    End Sub
    Public Shared Function DecimalToBinary(dec As Integer) As String
        If dec < 1 Then Return "0"

        Dim binStr As String = String.Empty

        While dec > 0
            binStr = binStr.Insert(0, (dec Mod 2).ToString())
            dec = Int(dec / 2)
        End While
        Return binStr
    End Function
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim A As String = ComboBox2.Text
        ComboBox2.Text = ComboBox1.Text
        ComboBox1.Text = A
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        Label6.Text = ""
        Label8.Text = ""
        Label2.Text = ""
        Label7.Text = ""
        Label9.Text = ""
        TextBox1.Focus()
    End Sub
End Class
