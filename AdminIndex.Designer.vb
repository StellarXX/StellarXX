<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminIndex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(22, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(129, 124)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(186, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(418, 226)
        DataGridView1.TabIndex = 1
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(364, 259)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(240, 213)
        DataGridView2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(223, 324)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "AUDIT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(223, 353)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(223, 382)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 5
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(52, 405)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 6
        Button4.Text = "LOGOUT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(22, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 23)
        Label1.TabIndex = 7
        Label1.Text = "COMPLETE NAME"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(22, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 8
        Label2.Text = "POSITION"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(22, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 23)
        Label3.TabIndex = 9
        Label3.Text = "DEPARTMENT"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(22, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 23)
        Label4.TabIndex = 10
        Label4.Text = "MONTH"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(22, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 23)
        Label5.TabIndex = 11
        Label5.Text = "DAY"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(89, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 23)
        Label6.TabIndex = 12
        Label6.Text = "YEAR"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(22, 326)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 23)
        Label7.TabIndex = 13
        Label7.Text = "WEEK"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' AdminIndex
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(626, 484)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Name = "AdminIndex"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminIndex"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
