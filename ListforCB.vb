Public Class ListforCB
    Public Shared Function AdminSuffix()
        AddAdmin.ComboBox1.Items.Clear()
        AddAdmin.ComboBox1.Items.Add("JR")
        AddAdmin.ComboBox1.Items.Add("SR")
        AddAdmin.ComboBox1.Items.Add("I")
        AddAdmin.ComboBox1.Items.Add("II")
        AddAdmin.ComboBox1.Items.Add("III")
        AddAdmin.ComboBox1.Items.Add("IV")
        AddAdmin.ComboBox1.Items.Add("V")
        AddAdmin.ComboBox1.Items.Add("VI")
        AddAdmin.ComboBox1.Items.Add("VII")
        AddAdmin.ComboBox1.Items.Add("VIII")
    End Function

    Public Shared Function AdminPosition()
        AddAdmin.ComboBox2.Items.Clear()
        AddAdmin.ComboBox2.Items.Add("Data Encoder")
        AddAdmin.ComboBox2.Items.Add("Clerk")
        AddAdmin.ComboBox2.Items.Add("Program Assistant")
        AddAdmin.ComboBox2.Items.Add("Administrative Aide I")
        AddAdmin.ComboBox2.Items.Add("Administrative Aide II")
        AddAdmin.ComboBox2.Items.Add("Administrative Aide III")
        AddAdmin.ComboBox2.Items.Add("Administrative Aide IV")
        AddAdmin.ComboBox2.Items.Add("Administrative Aide V")
        AddAdmin.ComboBox2.Items.Add("Administrative Aide VI")
        AddAdmin.ComboBox2.Items.Add("Supervising Administrative Officer")
        AddAdmin.ComboBox2.Items.Add("Department Head")
    End Function

    Public Shared Function AdminDepartment()
        AddAdmin.ComboBox3.Items.Clear()
        AddAdmin.ComboBox3.Items.Add("Hospital")
        AddAdmin.ComboBox3.Items.Add("Finance")
        AddAdmin.ComboBox3.Items.Add("Tourism")
        AddAdmin.ComboBox3.Items.Add("Supply")
        AddAdmin.ComboBox3.Items.Add("Info Tech")
    End Function

End Class
