<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WorkApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(215, 107)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(75, 23)
        Me.btnExtract.TabIndex = 0
        Me.btnExtract.Text = "Extract"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'txtLink
        '
        Me.txtLink.Location = New System.Drawing.Point(205, 152)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(100, 22)
        Me.txtLink.TabIndex = 1
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(484, 139)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(250, 193)
        Me.lblOutput.TabIndex = 2
        '
        'WorkApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.btnExtract)
        Me.Name = "WorkApp"
        Me.Text = "WorkApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExtract As Button
    Friend WithEvents txtLink As TextBox
    Friend WithEvents lblOutput As Label
End Class
