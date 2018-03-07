<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
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
        Me.txtCourse1 = New System.Windows.Forms.TextBox()
        Me.txtCourse4 = New System.Windows.Forms.TextBox()
        Me.txtCourse5 = New System.Windows.Forms.TextBox()
        Me.txtCourse6 = New System.Windows.Forms.TextBox()
        Me.txtCourse3 = New System.Windows.Forms.TextBox()
        Me.txtCourse2 = New System.Windows.Forms.TextBox()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblGrade2 = New System.Windows.Forms.Label()
        Me.lblGrade3 = New System.Windows.Forms.Label()
        Me.lblGrade4 = New System.Windows.Forms.Label()
        Me.lblGrade5 = New System.Windows.Forms.Label()
        Me.lblGrade6 = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblGrade1 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSemesterCalculation = New System.Windows.Forms.Label()
        Me.lblGradeOverall = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCourse1
        '
        Me.txtCourse1.Location = New System.Drawing.Point(157, 26)
        Me.txtCourse1.Name = "txtCourse1"
        Me.txtCourse1.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse1.TabIndex = 0
        Me.txtCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse4
        '
        Me.txtCourse4.Location = New System.Drawing.Point(157, 158)
        Me.txtCourse4.Name = "txtCourse4"
        Me.txtCourse4.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse4.TabIndex = 4
        Me.txtCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse5
        '
        Me.txtCourse5.Location = New System.Drawing.Point(157, 202)
        Me.txtCourse5.Name = "txtCourse5"
        Me.txtCourse5.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse5.TabIndex = 5
        Me.txtCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse6
        '
        Me.txtCourse6.Location = New System.Drawing.Point(157, 246)
        Me.txtCourse6.Name = "txtCourse6"
        Me.txtCourse6.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse6.TabIndex = 6
        Me.txtCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse3
        '
        Me.txtCourse3.Location = New System.Drawing.Point(157, 114)
        Me.txtCourse3.Name = "txtCourse3"
        Me.txtCourse3.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse3.TabIndex = 3
        Me.txtCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCourse2
        '
        Me.txtCourse2.Location = New System.Drawing.Point(157, 70)
        Me.txtCourse2.Name = "txtCourse2"
        Me.txtCourse2.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse2.TabIndex = 2
        Me.txtCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCourse1
        '
        Me.lblCourse1.Location = New System.Drawing.Point(88, 26)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(63, 23)
        Me.lblCourse1.TabIndex = 6
        Me.lblCourse1.Text = "Course 1:"
        '
        'lblCourse2
        '
        Me.lblCourse2.Location = New System.Drawing.Point(88, 70)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(63, 20)
        Me.lblCourse2.TabIndex = 7
        Me.lblCourse2.Text = "Course 2:"
        '
        'lblCourse3
        '
        Me.lblCourse3.Location = New System.Drawing.Point(88, 114)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(63, 13)
        Me.lblCourse3.TabIndex = 8
        Me.lblCourse3.Text = "Course 3: "
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(88, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Course 4:"
        '
        'lblCourse5
        '
        Me.lblCourse5.Location = New System.Drawing.Point(88, 202)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(63, 20)
        Me.lblCourse5.TabIndex = 10
        Me.lblCourse5.Text = "Course 5:"
        '
        'lblCourse6
        '
        Me.lblCourse6.Location = New System.Drawing.Point(88, 246)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(63, 20)
        Me.lblCourse6.TabIndex = 11
        Me.lblCourse6.Text = "Course 6:"
        '
        'lblGrade2
        '
        Me.lblGrade2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade2.Location = New System.Drawing.Point(280, 72)
        Me.lblGrade2.Name = "lblGrade2"
        Me.lblGrade2.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade2.TabIndex = 13
        '
        'lblGrade3
        '
        Me.lblGrade3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade3.Location = New System.Drawing.Point(280, 116)
        Me.lblGrade3.Name = "lblGrade3"
        Me.lblGrade3.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade3.TabIndex = 14
        '
        'lblGrade4
        '
        Me.lblGrade4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade4.Location = New System.Drawing.Point(280, 160)
        Me.lblGrade4.Name = "lblGrade4"
        Me.lblGrade4.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade4.TabIndex = 15
        '
        'lblGrade5
        '
        Me.lblGrade5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade5.Location = New System.Drawing.Point(282, 205)
        Me.lblGrade5.Name = "lblGrade5"
        Me.lblGrade5.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade5.TabIndex = 16
        '
        'lblGrade6
        '
        Me.lblGrade6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade6.Location = New System.Drawing.Point(282, 248)
        Me.lblGrade6.Name = "lblGrade6"
        Me.lblGrade6.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade6.TabIndex = 17
        '
        'lblPrompt
        '
        Me.lblPrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrompt.Location = New System.Drawing.Point(88, 324)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(233, 164)
        Me.lblPrompt.TabIndex = 18
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(88, 491)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(74, 23)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(168, 491)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGrade1
        '
        Me.lblGrade1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade1.Location = New System.Drawing.Point(280, 28)
        Me.lblGrade1.Name = "lblGrade1"
        Me.lblGrade1.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade1.TabIndex = 22
        '
        'lblSemester
        '
        Me.lblSemester.Location = New System.Drawing.Point(85, 282)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(66, 23)
        Me.lblSemester.TabIndex = 23
        Me.lblSemester.Text = "Semester:"
        '
        'lblSemesterCalculation
        '
        Me.lblSemesterCalculation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterCalculation.Location = New System.Drawing.Point(157, 281)
        Me.lblSemesterCalculation.Name = "lblSemesterCalculation"
        Me.lblSemesterCalculation.Size = New System.Drawing.Size(100, 23)
        Me.lblSemesterCalculation.TabIndex = 24
        Me.lblSemesterCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGradeOverall
        '
        Me.lblGradeOverall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeOverall.Location = New System.Drawing.Point(282, 285)
        Me.lblGradeOverall.Name = "lblGradeOverall"
        Me.lblGradeOverall.Size = New System.Drawing.Size(39, 13)
        Me.lblGradeOverall.TabIndex = 25
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(427, 526)
        Me.Controls.Add(Me.lblGradeOverall)
        Me.Controls.Add(Me.lblSemesterCalculation)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblGrade1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblGrade6)
        Me.Controls.Add(Me.lblGrade5)
        Me.Controls.Add(Me.lblGrade4)
        Me.Controls.Add(Me.lblGrade3)
        Me.Controls.Add(Me.lblGrade2)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblCourse1)
        Me.Controls.Add(Me.txtCourse2)
        Me.Controls.Add(Me.txtCourse3)
        Me.Controls.Add(Me.txtCourse6)
        Me.Controls.Add(Me.txtCourse5)
        Me.Controls.Add(Me.txtCourse4)
        Me.Controls.Add(Me.txtCourse1)
        Me.Name = "frmSemesterAverage"
        Me.Text = "Semester Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents txtCourse5 As TextBox
    Friend WithEvents txtCourse6 As TextBox
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblGrade2 As Label
    Friend WithEvents lblGrade3 As Label
    Friend WithEvents lblGrade4 As Label
    Friend WithEvents lblGrade5 As Label
    Friend WithEvents lblGrade6 As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblGrade1 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblSemesterCalculation As Label
    Friend WithEvents lblGradeOverall As Label
End Class
