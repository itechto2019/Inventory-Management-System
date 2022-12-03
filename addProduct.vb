Imports System.Text.RegularExpressions
Public Class addProduct
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call addProducts(txtProduct.Text, txtUnit.Text, txtPrice.Text, txtRemarks.Text, txtPersonnel.Text)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub


End Class