Public Class monthlyView


    Private Sub btnProductsIn_Click(sender As Object, e As EventArgs) Handles btnProductsIn.Click
        getMonthlyProducts()
    End Sub

    Private Sub btnProductsOut_Click(sender As Object, e As EventArgs) Handles btnProductsOut.Click
        getMonthlyProductsOut()
    End Sub
End Class