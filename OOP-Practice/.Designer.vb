<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCreateInstances = New System.Windows.Forms.Button()
        Me.lstInstances = New System.Windows.Forms.ListBox()
        Me.btnShowDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateInstances
        '
        Me.btnCreateInstances.Location = New System.Drawing.Point(234, 274)
        Me.btnCreateInstances.Name = "btnCreateInstances"
        Me.btnCreateInstances.Size = New System.Drawing.Size(182, 23)
        Me.btnCreateInstances.TabIndex = 0
        Me.btnCreateInstances.Text = "Create Instance"
        Me.btnCreateInstances.UseVisualStyleBackColor = True
        '
        'lstInstances
        '
        Me.lstInstances.FormattingEnabled = True
        Me.lstInstances.Location = New System.Drawing.Point(234, 72)
        Me.lstInstances.Name = "lstInstances"
        Me.lstInstances.Size = New System.Drawing.Size(349, 147)
        Me.lstInstances.TabIndex = 1
        '
        'btnShowDetails
        '
        Me.btnShowDetails.Location = New System.Drawing.Point(422, 274)
        Me.btnShowDetails.Name = "btnShowDetails"
        Me.btnShowDetails.Size = New System.Drawing.Size(161, 23)
        Me.btnShowDetails.TabIndex = 2
        Me.btnShowDetails.Text = "Show Details"
        Me.btnShowDetails.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShowDetails)
        Me.Controls.Add(Me.lstInstances)
        Me.Controls.Add(Me.btnCreateInstances)
        Me.Name = "Form1"
        Me.Text = "OOP-Practice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateInstances As Button
    Friend WithEvents lstInstances As ListBox
    Friend WithEvents btnShowDetails As Button
End Class
