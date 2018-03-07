Public Class frmSemesterAverage
    'Variables

    Dim grade As Decimal
    Dim courses(5) As Double
    Dim userInput As String
    Dim userInputValidated As Double = 0.0
    Dim errorMessages As String


    Private Function Lettergrades(grade As Double) As String

        Dim letterGrade As String

        'Grade Range
        If (grade >= 90) Then letterGrade = "A+"
        If (grade <= 89) Then letterGrade = "A"
        If (grade <= 84) Then letterGrade = "A-"
        If (grade <= 79) Then letterGrade = "B+"
        If (grade <= 76) Then letterGrade = "B"
        If (grade <= 72) Then letterGrade = "B-"
        If (grade <= 69) Then letterGrade = "C+"
        If (grade <= 66) Then letterGrade = "C"
        If (grade <= 62) Then letterGrade = "C-"
        If (grade <= 59) Then letterGrade = "D+"
        If (grade <= 56) Then letterGrade = "D"
        If (grade <= 52) Then letterGrade = "D-"
        If (grade <= 49) Then letterGrade = "F"

        Return letterGrade




    End Function


    'Function for calculation
    Private Function Validate(ByVal userInput1 As String, ByRef userinputValidated As Double) As Boolean
        Dim userInput2 As Double = 0.0
        Dim returnValue As Boolean = True

        If (Double.TryParse(userInput1, userInput2)) Then
            If userInput2 >= 0 AndAlso userInput2 <= 100 Then
                userinputValidated = userInput2
                returnValue = True

            Else
                returnValue = False


            End If
        Else
            returnValue = False

        End If
        Return returnValue




    End Function





    Private Sub txtCourse1_LostFocus(sender As Object, e As EventArgs) Handles txtCourse1.LostFocus
        'Course 1 validation
        userInput = txtCourse1.Text
        lblPrompt.Text = ""

        If Validate(userInput, userInputValidated) = True Then
            lblGrade1.Text = Lettergrades(userInputValidated)
            courses(0) = userInputValidated

        Else

            lblPrompt.Text = "Please ensure that what you input is between 0 and 100"
            txtCourse1.Focus()




        End If












    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblCourse2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCourse1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblCourse3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblPrompt.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Specific course error
        lblPrompt.Text = ""
        'validation clear
        errorMessages = ""
        Dim validator As Double = 0
        Dim GradeAverage As Double = 0.0

        For counter As Integer = 0 To 5


            ' Specific course error message
            validator = courses(counter)
            If validator = 0 Then
                errorMessages += "Please ensure the number you input " + "couse: " + (counter + 1).ToString + " is between 0 and 100" + vbCrLf


            End If
        Next



        If validator > 0 Then
            'Button and Textbox lock
            btnCalculate.Enabled = False

            txtCourse1.Enabled = False
            txtCourse2.Enabled = False
            txtCourse3.Enabled = False
            txtCourse4.Enabled = False
            txtCourse5.Enabled = False
            txtCourse6.Enabled = False

            For averageCounter As Integer = 0 To 5

                GradeAverage = GradeAverage + courses(averageCounter)

            Next

            GradeAverage = GradeAverage / 6

            lblSemesterCalculation.Text = Math.Round(GradeAverage, 2).ToString

            lblGradeOverall.Text = Lettergrades(GradeAverage)
            'Error Title

        Else

            lblPrompt.Text = "ERROR(s)" + vbCrLf + errorMessages




        End If




    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Reset for the course grades
        txtCourse1.Text = ""
        txtCourse1.Focus()

        txtCourse2.Text = ""
        txtCourse3.Text = ""
        txtCourse4.Text = ""
        txtCourse5.Text = ""
        txtCourse6.Text = ""

        'Letter Grades Reset
        lblGrade1.Text = ""
        lblGrade2.Text = ""
        lblGrade3.Text = ""
        lblGrade4.Text = ""
        lblGrade5.Text = ""
        lblGrade6.Text = ""

        'lblPrompt Reset
        lblPrompt.Text = ""

        'lblSemesterCalculation Reset
        lblSemesterCalculation.Text = ""

        'Variable Reset
        lblGradeOverall.Text = ""

        'Unlock Button
        btnCalculate.Enabled = True

        txtCourse1.Enabled = True
        txtCourse2.Enabled = True
        txtCourse3.Enabled = True
        txtCourse4.Enabled = True
        txtCourse5.Enabled = True
        txtCourse6.Enabled = True
        'Reset Error Messages
        errorMessages = ""
        ReDim courses(5)


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblGrade1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles lblGrade3.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblGrade1_Click_1(sender As Object, e As EventArgs) Handles lblGrade1.Click

    End Sub

    Private Sub txtCourse2_LostFocus(sender As Object, e As EventArgs) Handles txtCourse2.LostFocus
        'Course 2 validation
        userInput = txtCourse2.Text
        lblPrompt.Text = ""




        If Validate(userInput, userInputValidated) = True Then
            lblGrade2.Text = Lettergrades(userInputValidated)
            courses(1) = userInputValidated

        Else

            lblPrompt.Text = "Please ensure that what you input is between 0 and 100"
            txtCourse1.Focus()




        End If









    End Sub

    Private Sub txtCourse3_LostFocus(sender As Object, e As EventArgs) Handles txtCourse3.LostFocus
        'Course 3 validation
        userInput = txtCourse3.Text
        lblPrompt.Text = ""

        If Validate(userInput, userInputValidated) = True Then
            lblGrade3.Text = Lettergrades(userInputValidated)
            courses(2) = userInputValidated

        Else

            lblPrompt.Text = "Please ensure that what you input is between 0 and 100"
            txtCourse1.Focus()




        End If






    End Sub

    Private Sub txtCourse4_LostFocus(sender As Object, e As EventArgs) Handles txtCourse4.LostFocus
        'Course 4 validation
        userInput = txtCourse4.Text
        lblPrompt.Text = ""

        If Validate(userInput, userInputValidated) = True Then
            lblGrade4.Text = Lettergrades(userInputValidated)
            courses(3) = userInputValidated

        Else

            lblPrompt.Text = "Please ensure that what you input is between 0 and 100"
            txtCourse1.Focus()




        End If






    End Sub

    Private Sub txtCourse5_LostFocus(sender As Object, e As EventArgs) Handles txtCourse5.LostFocus
        'Course 5 validation
        userInput = txtCourse5.Text
        lblPrompt.Text = ""

        If Validate(userInput, userInputValidated) = True Then
            lblGrade5.Text = Lettergrades(userInputValidated)
            courses(4) = userInputValidated

        Else

            lblPrompt.Text = "Please ensure that what you input is between 0 and 100"
            txtCourse1.Focus()




        End If








    End Sub

    Private Sub txtCourse6_LostFocus(sender As Object, e As EventArgs) Handles txtCourse6.LostFocus
        'Course 6 validation

        userInput = txtCourse6.Text
        lblPrompt.Text = ""

        If Validate(userInput, userInputValidated) = True Then
            lblGrade6.Text = Lettergrades(userInputValidated)
            courses(5) = userInputValidated

        Else

            lblPrompt.Text = "Please ensure that what you input is between 0 and 100"
            txtCourse1.Focus()




        End If








    End Sub

    Private Sub lblSemester_Click(sender As Object, e As EventArgs) Handles lblSemester.Click

    End Sub

    Private Sub lblSemesterCalculation_Click(sender As Object, e As EventArgs) Handles lblSemesterCalculation.Click

    End Sub

    Private Sub lblGradeOverall_Click(sender As Object, e As EventArgs) Handles lblGradeOverall.Click

    End Sub
End Class
