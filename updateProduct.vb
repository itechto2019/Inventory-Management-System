Public Class updateProduct
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateCurrentProduct(product_id.Text, txtProduct.Text, txtUnit.Text, txtPrice.Text, txtRemarks.Text, txtPersonnel.Text)
    End Sub

End Class