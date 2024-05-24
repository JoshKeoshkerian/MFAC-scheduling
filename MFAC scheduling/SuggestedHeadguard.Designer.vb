<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuggestedHeadguard
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
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.lblSuggestedHeadguards = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCorrect
        '
        Me.btnCorrect.Location = New System.Drawing.Point(151, 288)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(127, 71)
        Me.btnCorrect.TabIndex = 0
        Me.btnCorrect.Text = "Correct"
        Me.btnCorrect.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.Location = New System.Drawing.Point(414, 298)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(145, 61)
        Me.btnManual.TabIndex = 1
        Me.btnManual.Text = "Manually Enter Headguards"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'lblSuggestedHeadguards
        '
        Me.lblSuggestedHeadguards.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggestedHeadguards.Location = New System.Drawing.Point(218, 44)
        Me.lblSuggestedHeadguards.Name = "lblSuggestedHeadguards"
        Me.lblSuggestedHeadguards.Size = New System.Drawing.Size(328, 135)
        Me.lblSuggestedHeadguards.TabIndex = 2
        Me.lblSuggestedHeadguards.Text = "Suggested Headguards:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MFAC_scheduling.My.Resources.Resources.Screenshot_2024_05_24_093015
        Me.PictureBox1.Location = New System.Drawing.Point(12, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 268)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'SuggestedHeadguard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSuggestedHeadguards)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.btnCorrect)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.Name = "SuggestedHeadguard"
        Me.Text = "SuggestedHeadguard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCorrect As Button
    Friend WithEvents btnManual As Button
    Friend WithEvents lblSuggestedHeadguards As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
