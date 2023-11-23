Imports System.Data.SqlClient
Public Class DbDesigner

    Public Shared Function LogoPicDes()
        'Show picture in the log in frame as new logo
    End Function

    Public Shared Function LoginIndex()
        'log in
        'manipulate the database have category and department
        Dim conDB As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CYD\OTHERS MDF\JDescDB.mdf")
        Try
            conDB.Open()
            Dim sqlCom As New SqlCommand("Select Emp_Cat from tbl_Login where [Emp_ID] = @user and [Emp_Pass] = @pass", conDB)
            sqlCom.Parameters.AddWithValue("@user", Form1.TextBox1.Text)
            sqlCom.Parameters.AddWithValue("@pass", Form1.TextBox2.Text)

            Dim rst As String = sqlCom.ExecuteScalar().ToString
            Using getDept As New SqlCommand("select Emp_Dept from tbl_Login where [Emp_ID] = @userfind", conDB)
                getDept.Parameters.AddWithValue("@userfind", Form1.TextBox1.Text)
                Dim EmpDept As String = getDept.ExecuteScalar.ToString
                If rst = "Admin" Then
                    AdminIndex.Show()
                ElseIf rst = "Head" Then
                    MsgBox("Welcome Head of " & EmpDept)
                ElseIf rst = "Regular" Then
                    MsgBox("Welcome the regular from " & EmpDept)
                ElseIf rst = "J.O." Then
                    MsgBox("Welcome job order from " & EmpDept)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conDB.State = ConnectionState.Open Then
                conDB.Close()
            End If
        End Try
    End Function

    Public Shared Function AdminUpdate()

    End Function

    Public Shared Function SharedAdminInfo()

    End Function

End Class
