<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Slides
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
        Me.lstbLifeguards = New System.Windows.Forms.ListBox()
        Me.btnConfrimNumOfSlides = New System.Windows.Forms.Button()
        Me.grpSlides = New System.Windows.Forms.GroupBox()
        Me.rdbSlideNo = New System.Windows.Forms.RadioButton()
        Me.rdbSlideYes = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblSelectedSlide = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.grpSlides.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstbLifeguards
        '
        Me.lstbLifeguards.FormattingEnabled = True
        Me.lstbLifeguards.ItemHeight = 16
        Me.lstbLifeguards.Location = New System.Drawing.Point(333, 106)
        Me.lstbLifeguards.Name = "lstbLifeguards"
        Me.lstbLifeguards.Size = New System.Drawing.Size(120, 180)
        Me.lstbLifeguards.TabIndex = 14
        '
        'btnConfrimNumOfSlides
        '
        Me.btnConfrimNumOfSlides.Location = New System.Drawing.Point(352, 301)
        Me.btnConfrimNumOfSlides.Name = "btnConfrimNumOfSlides"
        Me.btnConfrimNumOfSlides.Size = New System.Drawing.Size(75, 23)
        Me.btnConfrimNumOfSlides.TabIndex = 13
        Me.btnConfrimNumOfSlides.Text = "Confirm"
        Me.btnConfrimNumOfSlides.UseVisualStyleBackColor = True
        '
        'grpSlides
        '
        Me.grpSlides.Controls.Add(Me.rdbSlideNo)
        Me.grpSlides.Controls.Add(Me.rdbSlideYes)
        Me.grpSlides.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSlides.Location = New System.Drawing.Point(126, 108)
        Me.grpSlides.Name = "grpSlides"
        Me.grpSlides.Size = New System.Drawing.Size(173, 178)
        Me.grpSlides.TabIndex = 10
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
        Me.lblTitle.Location = New System.Drawing.Point(228, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(333, 48)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Top Slides?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(673, 343)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblSelectedSlide
        '
        Me.lblSelectedSlide.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSelectedSlide.Location = New System.Drawing.Point(477, 142)
        Me.lblSelectedSlide.Name = "lblSelectedSlide"
        Me.lblSelectedSlide.Size = New System.Drawing.Size(163, 118)
        Me.lblSelectedSlide.TabIndex = 17
        Me.lblSelectedSlide.Text = "Selected Guards"
        Me.lblSelectedSlide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(506, 277)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(104, 23)
        Me.btnGoBack.TabIndex = 18
        Me.btnGoBack.Text = "Remove "
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Slides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblSelectedSlide)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstbLifeguards)
        Me.Controls.Add(Me.btnConfrimNumOfSlides)
        Me.Controls.Add(Me.grpSlides)
        Me.Name = "Slides"
        Me.Text = "Slides"
        Me.grpSlides.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstbLifeguards As ListBox
    Friend WithEvents btnConfrimNumOfSlides As Button
    Friend WithEvents grpSlides As GroupBox
    Friend WithEvents rdbSlideNo As RadioButton
    Friend WithEvents rdbSlideYes As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents lblSelectedSlide As Label
    Friend WithEvents btnGoBack As Button
End Class
