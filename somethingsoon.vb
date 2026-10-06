Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'to do list

        'add stuff to list

        addtolist()


    End Sub

    Private Sub addtolist()
        Dim answer As String = InputBox("enter whatever to add it to the list (auto false): ")

        Dim newIndex As Integer = CheckedListBox1.Items.Add(answer)

        MessageBox.Show($"'{answer}' was added at index {newIndex}")
    End Sub

    Private Sub appendcheck(ByRef index As Integer, ByVal done As Boolean)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
