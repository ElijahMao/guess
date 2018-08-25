Public Class Form1

    Dim guess, count, min, max As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New Random()
        guess = r.Next(1, 1000)
        min = 1
        max = 999
        count = 0
        lblTitle.Text = min.ToString() & " < ? < " & max.ToString()
        lblMsg.Text = "共猜了 " & count.ToString() & "次"
        btnOk.Enabled = True
        txtGuess.Text = ""
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        count += 1
        Dim myguess As Integer = Val(txtGuess.Text)

        If myguess >= min And myguess < max Then
            If myguess = guess Then
                MessageBox.Show("賓果")
                btnOk.Enabled = False
            ElseIf myguess > guess Then
                max = myguess
                MessageBox.Show("再小一點")
            ElseIf myguess < guess Then
                min = myguess
                MessageBox.Show("再大一點")
            End If
        Else
            MessageBox.Show("輸入提示範圍內的數字")
        End If
        lblMsg.Text = "共猜了 " & count.ToString() & "次"
        lblTitle.Text = min.ToString() & " < ? < " & max.ToString()
    End Sub

    Private Sub btnAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgain.Click
        Form1_Load(sender, e)
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MessageBox.Show("請問是否離開游戲嗎?", "猜數字遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Application.Exit()

        End If
    End Sub
End Class
