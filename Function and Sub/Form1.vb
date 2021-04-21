Public Class Form1

    Private Sub X1()
        Lbl1.Text = "Data tersebut"
    End Sub


    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        X1()
    End Sub


    Private Sub X2(ByRef strText As String)
        strText = " Hello " & strText
    End Sub


    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim strText As String = TxtBox1.Text
        X2(strText)
        Lbl2.Text = strText
    End Sub


    Private Function X3()
        Return Lbl3
    End Function


    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Lbl3.Text = "Data tersebut"
    End Sub


    Private Function X4(ByVal strText2 As String)
        Return strText2
    End Function


    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Lbl4.Text = X4(TxtBox2.Text)
    End Sub
End Class
