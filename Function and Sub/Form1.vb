Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Lbl1.Text = "Data tersebut"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim strText As String
        strText = TxtBox1.Text
        Lbl2.Text = strText
    End Sub

    Private Function Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Lbl3.Text = "Data tersebut"
        Return Lbl3
    End Function

    Private Function Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Dim strText2 As String
        strText2 = TxtBox2.Text
        Lbl4.Text = strText2
        Return Lbl4
    End Function
End Class
