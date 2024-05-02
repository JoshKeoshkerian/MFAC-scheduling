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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.picError = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.picError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(60, 276)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(143, 67)
        Me.btnExtract.TabIndex = 0
        Me.btnExtract.Text = "Begin"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(395, 139)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(271, 213)
        Me.lblOutput.TabIndex = 2
        '
        'picError
        '
        Me.picError.Image = Global.MFAC_scheduling.My.Resources.Resources.ErrorMessage
        Me.picError.Location = New System.Drawing.Point(288, 84)
        Me.picError.Name = "picError"
        Me.picError.Size = New System.Drawing.Size(418, 259)
        Me.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picError.TabIndex = 3
        Me.picError.TabStop = False
        '
        'lblError
        '
        Me.lblError.Location = New System.Drawing.Point(266, 368)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(192, 44)
        Me.lblError.TabIndex = 4
        Me.lblError.Text = "Something went wrong. Make sure google chrome is open and on the screen above"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(144, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(522, 59)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "MFAC Rotation System"
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(44, 94)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(198, 147)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Welcome! To start, ensure google chrome is open and on the screen shown to the ri" &
    "ght. Hit begin button below."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(509, 369)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(157, 43)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'WorkApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.picError)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExtract)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "WorkApp"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "WorkApp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExtract As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents picError As PictureBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnReset As Button
End Class
