Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblSalary.Text = Val(txt1.Text) * 12
        lblTax.Text = Val(lblSalary.Text) * 0.5
        lblTotal.Text = Val(lblSalary.Text) - Val(lblTax.Text)

    End Sub


End Class
