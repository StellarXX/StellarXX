Public Class AddAdmin
    Private Sub AddAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListforCB.AdminSuffix()
        ListforCB.AdminPosition()
        ListforCB.AdminDepartment()
    End Sub
End Class