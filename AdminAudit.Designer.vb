<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAudit
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        TextBox1 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 69)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(441, 334)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 17)
        Label1.TabIndex = 1
        Label1.Text = "Search ID:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(82, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(149, 23)
        TextBox1.TabIndex = 2
        ' 
        ' AdminAudit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 415)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "AdminAudit"
        Text = "AdminAudit"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
