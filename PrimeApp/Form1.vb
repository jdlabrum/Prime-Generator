Public Class Form1

    Dim lBound As Integer
    Dim ubound As Integer
    Dim odds As Integer = 3


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Try
            If lTextbox.Text > uTextbox.Text Then
                Throw New System.Exception("Invalid value error")
            End If

            For i As Integer = lTextbox.Text To uTextbox.Text
                isPrime(i)
            Next

            If ListBox1.Items.Count = 0 Then
                Throw New System.Exception("No value error")
            End If

        Catch ex As InvalidCastException
            ListBox1.Items.Add("Please enter an integer in each field")
        Catch ex As Exception
            ListBox1.Items.Add("No prime numbers within range")
        End Try

    End Sub

    Public Sub isPrime(ByVal input As Integer)
        If input < 2 Then
            Return
        ElseIf input = 2 Then
            ListBox1.Items.Add(input)
            Return
        ElseIf (input Mod 2) = 0 Then
            Return
        Else
            odds = 3
            While odds < input
                If input Mod odds = 0 Then
                    Return
                End If
                odds += 2
            End While
            ListBox1.Items.Add(input)
        End If
        Return
    End Sub

End Class
