Public Class HomeTab
    'used buttons instead of tab panel layout heheeh
    Sub childform(ByVal panel As Form)
        ContentPanel.Controls.Clear()
        panel.TopLevel = False
        ContentPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub HomeTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PayRoll_Click(sender As Object, e As EventArgs) Handles PayRoll.Click
        childform(Form1)

    End Sub


    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        childform(AboutTab)
    End Sub

    Private Sub Kto12_Click(sender As Object, e As EventArgs) Handles Kto12.Click
        childform(Kto12Tab)
    End Sub


    Private Sub Procurement_Click(sender As Object, e As EventArgs) Handles Procurement.Click
        childform(ProcurementTab)
    End Sub

    Private Sub Contact_Click(sender As Object, e As EventArgs) Handles Contact.Click
        childform(ContactTab)
    End Sub

    Private Sub Regions_Click(sender As Object, e As EventArgs) Handles Regions.Click
        childform(RegionsTab)
    End Sub

    Private Sub Resource_Click(sender As Object, e As EventArgs) Handles Resource.Click
        childform(ResourcesTab)
    End Sub

    Private Sub tab_Click(sender As Object, e As EventArgs) Handles tab.Click
        childform(home)
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
End Class