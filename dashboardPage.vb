Public Class dashboardPage
    Private Sub dashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getHistory()
        getProductsCount()
        getTotalAmount()
        getDailyAmount()
        getMonthlyAmount()
        getYearlyAmount()
        getTotalOut()
    End Sub

End Class