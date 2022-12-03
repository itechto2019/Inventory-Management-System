Public Class dashboard
    Public productState = False
    Public activeButton = Color.FromArgb(59, 68, 246)
    Public defaultColor = Color.FromArgb(49, 53, 82)
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productsMenu.VerticalScroll.Visible = False
        setActivePanel(dashboardPage)
        setActiveButton(btnDashboard)
        pageTitle.Text = btnDashboard.Text
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        isLoggedIn = False
        loggedOut()
        loginForm.Show()
        Me.Dispose()
    End Sub

    Private Sub productsManager_Click(sender As Object, e As EventArgs) Handles productsManager.Click
        If productState = False Then
            productsMenu.Visible = True
            productState = True
        Else
            productsMenu.Visible = False
            productState = False
        End If
    End Sub


    Public Sub setActiveButton(button As Button)
        pageTitle.Text = button.Text
    End Sub
    Public Sub setActivePanel(panel As Form)
        activePanel.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        activePanel.Controls.Add(panel)
        panel.Show()
        panel.Activate()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        setActivePanel(dashboardPage)
        setActiveButton(btnDashboard)

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        setActivePanel(inventoryPage)
        setActiveButton(btnInventory)

    End Sub
    Private Sub btnReturns_Click(sender As Object, e As EventArgs) Handles btnSold.Click
        setActiveButton(btnSold)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        setActiveButton(btnReports)
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        setActivePanel(dailyView)
        setActiveButton(btnDaily)
        getDailyProducts()

    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        setActivePanel(monthlyView)
        setActiveButton(btnMonthly)
        getMonthlyProducts()

    End Sub

    Private Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click
        setActivePanel(yearlyView)
        setActiveButton(btnYearly)
        getYearlyProducts()

    End Sub
End Class