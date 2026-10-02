Imports System.Threading.Tasks
Imports System.Threading

Public Class Form1
    ' yes i know ai made this im tryna learn from it okay i know basics but kurwa threading is hard trust

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await Task.WhenAll(CountToMillion(ListBox1, ""),
                           CountToMillion(ListBox2, " is the number"))
        MessageBox.Show("both r done")
    End Sub

    Private Async Function CountToMillion(target As ListBox, suffix As String) As Task
        For i As Integer = 0 To 1000000
            target.Items.Clear()
            target.Items.Add(i & suffix)

            Await Task.Delay(100)
        Next
    End Function

End Class
