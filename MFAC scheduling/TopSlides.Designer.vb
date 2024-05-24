<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopSlides
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
        Me.lblDisplayTimeSlot = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnNextTimeSlot = New System.Windows.Forms.Button()
        Me.lblHeadguard = New System.Windows.Forms.Label()
        Me.btnConfrimHeadguard = New System.Windows.Forms.Button()
        Me.lstbHeadguard = New System.Windows.Forms.ListBox()
        Me.grpSlides = New System.Windows.Forms.GroupBox()
        Me.rdbSlideNo = New System.Windows.Forms.RadioButton()
        Me.rdbSlideYes = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpSlides.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDisplayTimeSlot
        '
        Me.lblDisplayTimeSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayTimeSlot.Location = New System.Drawing.Point(211, 81)
        Me.lblDisplayTimeSlot.Name = "lblDisplayTimeSlot"
        Me.lblDisplayTimeSlot.Size = New System.Drawing.Size(171, 23)
        Me.lblDisplayTimeSlot.TabIndex = 23
        Me.lblDisplayTimeSlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(640, 406)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(119, 23)
        Me.btnContinue.TabIndex = 22
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        Me.btnContinue.Visible = False
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(561, 311)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(104, 23)
        Me.btnGoBack.TabIndex = 21
        Me.btnGoBack.Text = "Remove "
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnNextTimeSlot
        '
        Me.btnNextTimeSlot.Location = New System.Drawing.Point(520, 352)
        Me.btnNextTimeSlot.Name = "btnNextTimeSlot"
        Me.btnNextTimeSlot.Size = New System.Drawing.Size(187, 23)
        Me.btnNextTimeSlot.TabIndex = 20
        Me.btnNextTimeSlot.Text = "Next Time Slot"
        Me.btnNextTimeSlot.UseVisualStyleBackColor = True
        '
        'lblHeadguard
        '
        Me.lblHeadguard.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblHeadguard.Location = New System.Drawing.Point(517, 106)
        Me.lblHeadguard.Name = "lblHeadguard"
        Me.lblHeadguard.Size = New System.Drawing.Size(190, 192)
        Me.lblHeadguard.TabIndex = 19
        Me.lblHeadguard.Text = "Selected Headguard"
        Me.lblHeadguard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfrimHeadguard
        '
        Me.btnConfrimHeadguard.Location = New System.Drawing.Point(332, 352)
        Me.btnConfrimHeadguard.Name = "btnConfrimHeadguard"
        Me.btnConfrimHeadguard.Size = New System.Drawing.Size(75, 23)
        Me.btnConfrimHeadguard.TabIndex = 18
        Me.btnConfrimHeadguard.Text = "Confirm"
        Me.btnConfrimHeadguard.UseVisualStyleBackColor = True
        '
        'lstbHeadguard
        '
        Me.lstbHeadguard.FormattingEnabled = True
        Me.lstbHeadguard.ItemHeight = 16
        Me.lstbHeadguard.Location = New System.Drawing.Point(275, 106)
        Me.lstbHeadguard.Name = "lstbHeadguard"
        Me.lstbHeadguard.Size = New System.Drawing.Size(204, 228)
        Me.lstbHeadguard.TabIndex = 17
        '
        'grpSlides
        '
        Me.grpSlides.Controls.Add(Me.rdbSlideNo)
        Me.grpSlides.Controls.Add(Me.rdbSlideYes)
        Me.grpSlides.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSlides.Location = New System.Drawing.Point(87, 147)
        Me.grpSlides.Name = "grpSlides"
        Me.grpSlides.Size = New System.Drawing.Size(173, 178)
        Me.grpSlides.TabIndex = 24
        Me.grpSlides.TabStop = False
        Me.grpSlides.Text = "Lifeguard on Top Slide?"
        '
        'rdbSlideNo
        '
        Me.rdbSlideNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSlideNo.Location = New System.Drawing.Point(12, 97)
        Me.rdbSlideNo.Name = "rdbSlideNo"
        Me.rdbSlideNo.Size = New System.Drawing.Size(124, 47)
        Me.rdbSlideNo.TabIndex = 1
        Me.rdbSlideNo.TabStop = True
        Me.rdbSlideNo.Text = "No"
        Me.rdbSlideNo.UseVisualStyleBackColor = True
        '
        'rdbSlideYes
        '
        Me.rdbSlideYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSlideYes.Location = New System.Drawing.Point(12, 59)
        Me.rdbSlideYes.Name = "rdbSlideYes"
        Me.rdbSlideYes.Size = New System.Drawing.Size(98, 32)
        Me.rdbSlideYes.TabIndex = 0
        Me.rdbSlideYes.TabStop = True
        Me.rdbSlideYes.Text = "Yes"
        Me.rdbSlideYes.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(209, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(333, 48)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "Top Slides?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MFAC_scheduling.My.Resources.Resources.Screenshot_2024_05_24_093044
        Me.PictureBox1.Location = New System.Drawing.Point(12, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'TopSlides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpSlides)
        Me.Controls.Add(Me.lblDisplayTimeSlot)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnNextTimeSlot)
        Me.Controls.Add(Me.lblHeadguard)
        Me.Controls.Add(Me.btnConfrimHeadguard)
        Me.Controls.Add(Me.lstbHeadguard)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.Name = "TopSlides"
        Me.Text = "TopSlides"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpSlides.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDisplayTimeSlot As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnNextTimeSlot As Button
    Friend WithEvents lblHeadguard As Label
    Friend WithEvents btnConfrimHeadguard As Button
    Friend WithEvents lstbHeadguard As ListBox
    Friend WithEvents grpSlides As GroupBox
    Friend WithEvents rdbSlideNo As RadioButton
    Friend WithEvents rdbSlideYes As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
