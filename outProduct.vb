Public Class outProduct
    Public totalUnit = 0
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub outProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalUnit = txtUnit.Text
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Call outProducts(txtProduct.Tag, txtProduct.Text, txtUnit.Text, txtPrice.Text, txtPersonnel.Text, txtClient.Text, txtRemarks.Text)
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Try

            Dim total As Double
            If Not txtUnit.Text.ToString() = "" Then
                If CInt(txtUnit.Text) > totalUnit Then
                    txtUnit.Text = totalUnit
                    MessageBox.Show("The max unit reach.")
                    txtUnit.Focus()
                Else
                    total = txtPrice.Text * txtUnit.Text
                    lblTotal.Text = "Total: " + Convert.ToDecimal(total.ToString()).ToString("N2")
                End If

            Else
                lblTotal.Text = "Total: " + 0.ToString()
            End If

        Catch ex As Exception
            If Not txtUnit.Text.ToString() = "" Then
                MessageBox.Show("Please specify the correct value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUnit.Text = txtUnit.Text.Length().ToString() - 1
            End If
        End Try
    End Sub
End Class