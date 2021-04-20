Public Class Form1

    Private Sub X1()
        Lbl1.Text = "Data tersebut"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        X1()
    End Sub

    Private Sub X2()
        Dim strText As String
        strText = TxtBox1.Text
        Lbl2.Text = strText
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        X2()
    End Sub

    Private Function X3()
        Return Lbl3
    End Function

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Lbl3.Text = "Data tersebut"
    End Sub

    Private Function X4()
        Dim strText2 As String
        strText2 = TxtBox2.Text
        Lbl4.Text = strText2
        Return Lbl4
    End Function

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        X4()
    End Sub
End Class
