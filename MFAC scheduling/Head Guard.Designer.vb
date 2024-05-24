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
        Me.btnNextTimeSlot = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblDisplayTimeSlot = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(274, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 42)
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
        Me.lblTitle.Location = New System.Drawing.Point(270, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 36)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Select Headguard"
        '
        'btnNextTimeSlot
        '
        Me.btnNextTimeSlot.Location = New System.Drawing.Point(434, 391)
        Me.btnNextTimeSlot.Name = "btnNextTimeSlot"
        Me.btnNextTimeSlot.Size = New System.Drawing.Size(187, 23)
        Me.btnNextTimeSlot.TabIndex = 13
        Me.btnNextTimeSlot.Text = "Next Time Slot"
        Me.btnNextTimeSlot.UseVisualStyleBackColor = True
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
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(668, 391)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(101, 23)
        Me.btnContinue.TabIndex = 15
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblDisplayTimeSlot
        '
        Me.lblDisplayTimeSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayTimeSlot.Location = New System.Drawing.Point(123, 105)
        Me.lblDisplayTimeSlot.Name = "lblDisplayTimeSlot"
        Me.lblDisplayTimeSlot.Size = New System.Drawing.Size(171, 23)
        Me.lblDisplayTimeSlot.TabIndex = 16
        Me.lblDisplayTimeSlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MFAC_scheduling.My.Resources.Resources.Screenshot_2024_05_24_093038
        Me.PictureBox1.Location = New System.Drawing.Point(12, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Head_guard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDisplayTimeSlot)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnNextTimeSlot)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeadguard)
        Me.Controls.Add(Me.btnConfrimHeadguard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstbHeadguard)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Head_guard"
        Me.Text = "Head_Guard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeadguard As Label
    Friend WithEvents btnConfrimHeadguard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstbHeadguard As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnNextTimeSlot As Button
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblDisplayTimeSlot As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
