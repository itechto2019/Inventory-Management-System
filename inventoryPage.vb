Public Class inventoryPage
    Private Sub inventoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getProducts(25)
        recentlyProducts()
        getTotalOut()

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = 13 Then
            searchProducts(txtSearch.Text)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        getProducts(25)
    End Sub

    Private Sub btnAddProducts_Click(sender As Object, e As EventArgs) Handles btnAddProducts.Click
        addProduct.Show()
    End Sub

    Private Sub dataLimiter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dataLimiter.SelectedIndexChanged
        getProducts(dataLimiter.Text)
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id = productsTable.CurrentRow.Cells(0).Value
        If id Then
            deleteForm(id)
            deleteProduct.ShowDialog()
        Else
            MessageBox.Show("No selected Data")
        End If

    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id = productsTable.CurrentRow.Cells(0).Value
        showProduct(id)
        updateProduct.Show()
    End Sub

    Private Sub timeInterval_Tick(sender As Object, e As EventArgs) Handles timeInterval.Tick
        currentDate.Text = Date.Now().ToString("MMM / dd / yyyy")
        currentTime.Text = Date.Now().ToString("hh:mm tt")
        getTotalOut()
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Dim id = productsTable.CurrentRow.Cells(0).Value
        outProductCheck(id)
        outProduct.Show()
    End Sub

End Class