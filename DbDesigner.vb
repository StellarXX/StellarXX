Imports System.Data.SqlClient
Public Class DbDesigner

    Public Shared Function LogoPicDes()
        'Show picture in the log in frame as new logo
    End Function

    Public Shared Function LoginIndex()
        'log in
        'manipulate the database have category and department
        Dim conDB As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\source\repos\JobDescriptionSystem\JDescDB.mdf")
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
            MessageBox.Show("Account and Password does not exist")
        Finally
            If conDB.State = ConnectionState.Open Then
                conDB.Close()
            End If
        End Try
    End Function

    Public Shared Function AdminUpdate()
        'Add/Save, Update
        'Restriction: If the username is exist, change the username
        'Indicator: Emp_ID (Also for Search: ...)
        'can selected row, to update
    End Function

    Public Shared Function SharedAdminInfo()
        'Get the information from the database {The Complete name: CONCAT, the position, the department}
        'Auto Search: Username -> Emp_ID -> Find -> Get -> Show at the AdminIndex. {Use the Emp_ID}
    End Function

    Public Shared Function AdminSearch()
        'use enter key // General Search, auto show at the data table
    End Function

    Public Shared Function AdminDelete()
        'Selected Row. to delete
    End Function

    Public Shared Function AddAdminUsers()
        'When selected row in AddAdmin as user, there is a pop up message or options to create new users to the systems depends on the respective category
    End Function

End Class
