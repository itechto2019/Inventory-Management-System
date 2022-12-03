Imports MySql.Data.MySqlClient
Module productsModule
    Private mysqlCommand As MySqlCommand
    Private dataAdapter As MySqlDataAdapter
    Private mysqlDataReader As MySqlDataReader
    Private dataTable As DataTable
    Private productsCount As Integer
    Private sql As String

    'Get history
    Public Sub getHistory()
        Try
            DbConnect()
            sql = "Select * from historys where date(created_at)=@date order By id desc"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now().ToString("yyyy-MM-dd")
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalar

            If result Then
                dataAdapter.Fill(dataTable)
                dashboardPage.historyTable.DataSource = dataTable
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Get products overall
    Public Async Sub getProducts(limit)
        Try
            DbConnect()
            sql = "Select * from products limit @limit"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.AddWithValue("@limit", limit)
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalarAsync

            If Await result Then
                dataAdapter.Fill(dataTable)
                inventoryPage.productsTable.DataSource = dataTable
            Else
                MessageBox.Show("No records found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Counts of product in overall
    Public Sub getProductsCount()
        Try
            DbConnect()
            sql = "select count(*) from products"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalar
            If result Then
                dashboardPage.totalProducts.Text = result
            Else
                dashboardPage.totalProducts.Text = 0
            End If

        Catch ex As Exception
            dashboardPage.totalProducts.Text = 0
        End Try
    End Sub
    'Counts of product daily
    Public Async Sub getDailyAmount()
        Try
            DbConnect()
            sql = "select count(*) from products where Date(date) BETWEEN @today AND @today"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@today", MySqlDbType.Date).Value = DateTime.Now().ToString("yyyy-MM-dd")
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalarAsync()
            dashboardPage.dailyAmount.Text = Convert.ToDecimal(Await result).ToString("N0")
        Catch ex As Exception
            dashboardPage.dailyAmount.Text = 0
        End Try
    End Sub
    'Counts of product outs overall
    Public Async Sub getTotalOut()
        Try
            DbConnect()
            sql = "select count(*) from solds"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@today", MySqlDbType.Date).Value = DateTime.Now().ToString("yyyy-MM-dd")
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalarAsync()
            inventoryPage.productOut.Text = Convert.ToDecimal(Await result).ToString("N0")
            dashboardPage.productOut.Text = Convert.ToDecimal(Await result).ToString("N0")
        Catch ex As Exception
            dashboardPage.productOut.Text = 0
            inventoryPage.productOut.Text = 0
        End Try
    End Sub
    'Get the total of products yearly
    Public Async Sub getDailyProducts()
        Try
            DbConnect()
            dailyView.productsTable.DataSource = ""
            sql = "select * from products where Date(date) BETWEEN @today AND @today"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@today", MySqlDbType.Date).Value = DateTime.Now().ToString("yyyy-MM-dd")
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalarAsync()
            If Await result Then
                dataAdapter.Fill(dataTable)
                dailyView.productsTable.DataSource = dataTable
                dailyView.lblStatus.Text = "PRODUCTS IN"
            Else
                MessageBox.Show("No records found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Get the total of products out daily
    Public Async Sub getDailyProductsOut()
        Try
            DbConnect()
            dailyView.productsTable.DataSource = ""
            sql = "select * from solds where Date(date) BETWEEN @today AND @today"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@today", MySqlDbType.Date).Value = DateTime.Now().ToString("yyyy-MM-dd")
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalarAsync()
            If Await result Then
                dataAdapter.Fill(dataTable)
                dailyView.productsTable.DataSource = dataTable
                dailyView.lblStatus.Text = "PRODUCTS OUT"
            Else
                MessageBox.Show("No records found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Counts the products monthly
    Public Async Sub getMonthlyAmount()
        Try
            DbConnect()
            sql = "select count(*) from products where MONTH(date) = MONTH(CURRENT_DATE()) AND YEAR(date) = YEAR(CURRENT_DATE())"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalarAsync()
            dashboardPage.monthlyAmount.Text = Convert.ToDecimal(Await result).ToString("N0")
        Catch ex As Exception
            dashboardPage.monthlyAmount.Text = 0
        End Try
    End Sub
    'Get the total of products monthly
    Public Async Sub getMonthlyProducts()
        Try
            DbConnect()
            sql = "select * from products where MONTH(date) = MONTH(CURRENT_DATE()) AND YEAR(date) = YEAR(CURRENT_DATE())"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalarAsync()
            If Await result Then
                dataAdapter.Fill(dataTable)
                monthlyView.productsTable.DataSource = dataTable
                monthlyView.lblStatus.Text = "PRODUCTS IN"
            Else
                MessageBox.Show("No records found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Get the total of products out monthly
    Public Async Sub getMonthlyProductsOut()
        Try
            DbConnect()
            dailyView.productsTable.DataSource = ""
            sql = "select * from solds where MONTH(date) = MONTH(CURRENT_DATE()) AND YEAR(date) = YEAR(CURRENT_DATE())"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalarAsync()
            If Await result Then
                dataAdapter.Fill(dataTable)
                monthlyView.productsTable.DataSource = dataTable
                monthlyView.lblStatus.Text = "PRODUCTS OUT"
            Else
                MessageBox.Show("No records found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Counts of product yearly
    Public Async Sub getYearlyAmount()
        Try
            DbConnect()
            sql = "select count(*) as yearly_in from products where YEAR(date) = YEAR(CURRENT_DATE())"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalarAsync()

            dashboardPage.yearlyAmount.Text = Convert.ToDecimal(Await result).ToString("N0")
        Catch ex As Exception
            dashboardPage.yearlyAmount.Text = 0
        End Try
    End Sub
    'Get the total of products yearly
    Public Async Sub getYearlyProducts()
        Try
            DbConnect()
            sql = "select * from products where YEAR(date) = YEAR(CURRENT_DATE())"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalarAsync()
            If Await result Then
                dataAdapter.Fill(dataTable)
                yearlyView.productsTable.DataSource = dataTable
                yearlyView.lblStatus.Text = "PRODUCTS IN"
            Else
                MessageBox.Show("No records found!")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Get total of products out yearly
    Public Async Sub getYearlyProductsOut()
        Try
            DbConnect()
            dailyView.productsTable.DataSource = ""
            sql = "select * from solds where YEAR(date) = YEAR(CURRENT_DATE())"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalarAsync()
            If Await result Then
                dataAdapter.Fill(dataTable)
                yearlyView.productsTable.DataSource = dataTable
                yearlyView.lblStatus.Text = "PRODUCTS OUT"
            Else
                MessageBox.Show("No records found!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Recently added products
    Public Sub recentlyProducts()
        Try
            DbConnect()
            sql = "select count(*) from products"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@today", MySqlDbType.Date).Value = DateTime.Now().ToString("yyyy-MM-dd")
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalar
            inventoryPage.productIn.Text = result
        Catch ex As Exception
            inventoryPage.productIn.Text = 0
        End Try
    End Sub
    'Get the total Amount
    Public Sub getTotalAmount()
        Try
            DbConnect()
            sql = "SELECT sum(unit * price) as Amount FROM products"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalar
            dashboardPage.totalAmount.Text = "$" + Convert.ToDecimal(result).ToString("N2")
        Catch ex As Exception
            dashboardPage.totalAmount.Text = "$" + 0.ToString()
        End Try
    End Sub
    'To filter-out the data
    Public Sub searchProducts(query)
        Try
            DbConnect()
            sql = "Select * from products where product LIKE '%" & query & "%'"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Prepare()
            End With
            dataAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            dataAdapter.SelectCommand = mysqlCommand
            Dim result = mysqlCommand.ExecuteScalar

            If result Then
                dataAdapter.Fill(dataTable)
                inventoryPage.productsTable.DataSource = dataTable
            Else
                MessageBox.Show("No match found!")
                inventoryPage.txtSearch.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    'To insert a product
    Public Sub addProducts(product, unit, price, remarks, personnel)
        Try
            sql = "INSERT INTO products (product, unit, price, remarks, date,personnel) values(@product, @unit, @price, @remarks, @date, @personnel)"
            mysqlCommand = New MySqlCommand

            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@product", MySqlDbType.VarChar).Value = product
                .Parameters.Add("@price", MySqlDbType.Decimal).Value = price.ToString().Replace("$", "").Replace(",", "").Trim()
                .Parameters.Add("@unit", MySqlDbType.Int64).Value = unit.ToString().Replace(",", "").Trim()
                .Parameters.Add("@remarks", MySqlDbType.VarChar).Value = remarks
                .Parameters.Add("@personnel", MySqlDbType.VarChar).Value = personnel
                .Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now().ToString("yyyy-MM-dd")
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteNonQuery
            If result Then
                recentlyProducts()
            End If
            If result Then
                addProduct.Close()
                MessageBox.Show("Product added.", "Product")
            End If
        Catch ex As Exception
            MessageBox.Show("Please specify the correct values.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    'Show specific product by id
    Public Sub showProduct(id)
        Try
            DbConnect()
            sql = "select * from products where id=@id"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.AddWithValue("@id", id)
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalar
            Dim data = mysqlCommand.ExecuteReader
            If result Then
                While data.Read()
                    updateProduct.product_id.Text = data("id")
                    updateProduct.txtProduct.Text = data("product").ToString()
                    updateProduct.txtPrice.Text = "$" + Convert.ToDecimal(data("price")).ToString("N2")
                    updateProduct.txtUnit.Text = Convert.ToDecimal(data("unit")).ToString("N2")
                    updateProduct.txtRemarks.Text = data("remarks").ToString()
                    updateProduct.txtPersonnel.Text = data("personnel").ToString()
                End While

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'To check the product to be deleted
    Public Sub deleteForm(id)
        Try
            DbConnect()
            sql = "select * from products where id=@id"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.AddWithValue("@id", id)
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalar
            Dim data = mysqlCommand.ExecuteReader
            If result Then
                While data.Read()
                    deleteProduct.product_id.Text = data("id")
                    deleteProduct.txtProduct.Text = data("product").ToString()
                    deleteProduct.txtPrice.Text = "$" + Convert.ToDecimal(data("price")).ToString("N2")
                    deleteProduct.txtUnit.Text = Convert.ToDecimal(data("unit")).ToString("N2")
                    deleteProduct.txtRemarks.Text = data("remarks").ToString()
                    deleteProduct.txtPersonnel.Text = data("personnel").ToString()
                End While

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'To commit an update
    Public Sub updateCurrentProduct(id, product, unit, price, remarks, personnel)
        Try
            DbConnect()
            sql = "UPDATE products set product=@product, unit=@unit,price=@price,remarks=@remarks,personnel=@personnel where id=@id"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.AddWithValue("@id", id)
                .Parameters.AddWithValue("@product", product)
                .Parameters.AddWithValue("@unit", unit.ToString().Replace(",", "").Trim())
                .Parameters.AddWithValue("@price", price.ToString().Replace("$", "").Replace(",", "").Trim())
                .Parameters.AddWithValue("@remarks", remarks)
                .Parameters.AddWithValue("@personnel", personnel)
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteNonQuery
            If result Then
                updateProduct.Close()
                MessageBox.Show("Products updated.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'commit delete product
    Public Sub deleteCurrentProduct(id)
        Try
            DbConnect()
            sql = "Delete from products where id=@id"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.AddWithValue("@id", id)
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteNonQuery()
            If result Then
                deleteProduct.Close()
                MessageBox.Show("Product deleted.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'To check products to be out
    Public Sub outProductCheck(id)
        Try
            DbConnect()

            Dim sql = "Select * from products where id=@id"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.AddWithValue("@id", id)
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteScalar
            Dim data = mysqlCommand.ExecuteReader
            If result Then
                While data.Read()
                    outProduct.txtProduct.Tag = data("id")
                    outProduct.txtProduct.Text = data("product").ToString()
                    outProduct.txtPrice.Text = "$" + Convert.ToDecimal(data("price")).ToString("N2")
                    outProduct.totalUnit = Convert.ToDecimal(data("unit")).ToString("N2")
                    outProduct.txtUnit.Text = data("unit")
                    outProduct.txtRemarks.Text = data("remarks").ToString()
                    outProduct.txtPersonnel.Text = data("personnel").ToString()
                End While

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'To out products
    Public Sub outProducts(id, product, unit, price, personnel, client, remarks)
        Try
            DbConnect()
            sql = "INSERT INTO solds (product, unit,price, personnel, client,remarks,date) values(@product,@unit,@price,@personnel,@client,@remarks,@date)"
            mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.AddWithValue("@product", product)
                .Parameters.AddWithValue("@unit", unit.ToString().Replace(",", "").Trim())
                .Parameters.AddWithValue("@price", unit * price.ToString().Replace("$", "").Replace(",", "").Trim())
                .Parameters.AddWithValue("@personnel", personnel)
                .Parameters.AddWithValue("@client", client)
                .Parameters.AddWithValue("@remarks", remarks)
                .Parameters.AddWithValue("@date", Date.Now().ToString("yyyy-MM-dd"))
                .Prepare()
            End With
            Dim result = mysqlCommand.ExecuteNonQuery
            If result Then
                sql = "update products as a join(select sum(unit - @unit) as result from products where id=@id) as b
                       set unit = b.result where id=@id"
                mysqlCommand = New MySqlCommand
                With mysqlCommand
                    .CommandText = sql
                    .Connection = connection
                    .Parameters.AddWithValue("@unit", unit)
                    .Parameters.AddWithValue("@id", id)
                    .Prepare()
                End With
                mysqlCommand.ExecuteNonQuery()
                outProduct.Close()
                MessageBox.Show("Product successfully out")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
