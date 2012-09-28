<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilyMembers
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
        Me.lvwLeft = New System.Windows.Forms.ListView()
        Me.lvwRight = New System.Windows.Forms.ListView()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnCopyBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvwLeft
        '
        Me.lvwLeft.Location = New System.Drawing.Point(34, 40)
        Me.lvwLeft.Name = "lvwLeft"
        Me.lvwLeft.Size = New System.Drawing.Size(330, 359)
        Me.lvwLeft.TabIndex = 0
        Me.lvwLeft.UseCompatibleStateImageBehavior = False
        '
        'lvwRight
        '
        Me.lvwRight.Location = New System.Drawing.Point(458, 40)
        Me.lvwRight.Name = "lvwRight"
        Me.lvwRight.Size = New System.Drawing.Size(330, 358)
        Me.lvwRight.TabIndex = 1
        Me.lvwRight.UseCompatibleStateImageBehavior = False
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(36, 414)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(84, 40)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnCopyBack
        '
        Me.btnCopyBack.Location = New System.Drawing.Point(458, 414)
        Me.btnCopyBack.Name = "btnCopyBack"
        Me.btnCopyBack.Size = New System.Drawing.Size(84, 40)
        Me.btnCopyBack.TabIndex = 3
        Me.btnCopyBack.Text = "Copy Back"
        Me.btnCopyBack.UseVisualStyleBackColor = True
        '
        'frmFamilyMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 461)
        Me.Controls.Add(Me.btnCopyBack)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.lvwRight)
        Me.Controls.Add(Me.lvwLeft)
        Me.Name = "frmFamilyMembers"
        Me.Text = "Family Members"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwLeft As System.Windows.Forms.ListView
    Friend WithEvents lvwRight As System.Windows.Forms.ListView
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnCopyBack As System.Windows.Forms.Button

End Class
