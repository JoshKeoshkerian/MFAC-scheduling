<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rotation
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
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(228, 446)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(573, 71)
        Me.btnDefault.TabIndex = 0
        Me.btnDefault.Text = "Generate"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'lblOriginal
        '
        Me.lblOriginal.Location = New System.Drawing.Point(12, 109)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(210, 303)
        Me.lblOriginal.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(246, 109)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(210, 303)
        Me.lbl1.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(496, 109)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(210, 303)
        Me.lbl2.TabIndex = 3
        '
        'lbl3
        '
        Me.lbl3.Location = New System.Drawing.Point(765, 109)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(210, 303)
        Me.lbl3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 51)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rotation Generator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(879, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MFAC_scheduling.My.Resources.Resources.Screenshot_2024_05_24_093050
        Me.PictureBox1.Location = New System.Drawing.Point(12, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Rotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 556)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.btnDefault)
        Me.MaximumSize = New System.Drawing.Size(1017, 603)
        Me.Name = "Rotation"
        Me.Text = "Rotation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDefault As Button
    Friend WithEvents lblOriginal As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
