Public Class yearlyView

    Private Sub btnProductsIn_Click(sender As Object, e As EventArgs) Handles btnProductsIn.Click
        getYearlyProducts()
    End Sub

    Private Sub btnProductsOut_Click(sender As Object, e As EventArgs) Handles btnProductsOut.Click
        getYearlyProductsOut()
    End Sub

    Private Sub yearlyView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class