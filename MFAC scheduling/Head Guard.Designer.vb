<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Head_guard
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
        Me.lblHeadguard = New System.Windows.Forms.Label()
        Me.btnConfrimHeadguard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstbHeadguard = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeadguard
        '
        Me.lblHeadguard.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblHeadguard.Location = New System.Drawing.Point(431, 145)
        Me.lblHeadguard.Name = "lblHeadguard"
        Me.lblHeadguard.Size = New System.Drawing.Size(190, 192)
        Me.lblHeadguard.TabIndex = 11
        Me.lblHeadguard.Text = "Selected Headguard"
        Me.lblHeadguard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfrimHeadguard
        '
        Me.btnConfrimHeadguard.Location = New System.Drawing.Point(169, 391)
        Me.btnConfrimHeadguard.Name = "btnConfrimHeadguard"
        Me.btnConfrimHeadguard.Size = New System.Drawing.Size(75, 23)
        Me.btnConfrimHeadguard.TabIndex = 10
        Me.btnConfrimHeadguard.Text = "Confirm"
        Me.btnConfrimHeadguard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(231, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 43)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select headguard (if multiple, hit confirm one at a time)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstbHeadguard
        '
        Me.lstbHeadguard.FormattingEnabled = True
        Me.lstbHeadguard.ItemHeight = 16
        Me.lstbHeadguard.Location = New System.Drawing.Point(112, 145)
        Me.lstbHeadguard.Name = "lstbHeadguard"
        Me.lstbHeadguard.Size = New System.Drawing.Size(204, 228)
        Me.lstbHeadguard.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(227, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 51)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Select Headguard"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(674, 391)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(475, 350)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(104, 23)
        Me.btnGoBack.TabIndex = 14
        Me.btnGoBack.Text = "Remove "
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Head_guard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeadguard)
        Me.Controls.Add(Me.btnConfrimHeadguard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstbHeadguard)
        Me.Name = "Head_guard"
        Me.Text = "Head_Guard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeadguard As Label
    Friend WithEvents btnConfrimHeadguard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstbHeadguard As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnGoBack As Button
End Class
