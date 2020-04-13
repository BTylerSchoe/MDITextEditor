

Option Strict On
''' <summary>
''' Program Name:   AverageUnitsShippedByEmployee
''' 
'''       Author:   Brayden Schoenau
''' 
'''         Date:   3/6/2018
''' 
'''      Purpose:   A small windows from application that prompts for the daily units shipped of 3 employee thoughout the week
'''                 After totaling each employees units shipped it then displays their individual weekly average.
'''                 After calculating all of the individual averages it then calculates the companies average daily units shipped
'''                 for all employees.
''' </summary>
Public Class frmAverageUnitsShippedByEmployee
    ''' <summary>
    '''         DECLARE AND INITIALIZE VARIABLES 
    ''' </summary>
    ''' Declare days as a multi-dimension array (3x7) 
    Dim days(2, 6) As Integer
    ' Declare and initalize variables as integer data types equal to 0
    Dim coloumIndexCounter As Integer = 0
    Dim rowIndexCounter As Integer = 0
    Dim employee1Total As Integer = 0
    Dim employee2Total As Integer = 0
    Dim employee3Total As Integer = 0
    ' Declare and initialize currentDay counter as an integer data type equal to 1
    Dim currentDay As Integer = 1

    ''' <summary>
    ''' Private subroutine that calulates the total and average units shipped by employee 1
    ''' </summary>
    Private Sub CalculateAndDisplayEmployee1Average()

        Dim employee1Average As Double = 0.00
        ' Loops thought row index 0 from column index 0-6
        For i As Integer = 0 To days.GetLength(1) - 1
            employee1Total += days(0, i)
        Next

        employee1Average = employee1Total / days.GetLength(1)
        ' Set lblEmployeeOneAverage text to "Average: " + calulated average
        lblEmployeeOneAverage.Text = "Average: " & employee1Average.ToString("n2")

    End Sub

    ''' <summary>
    ''' Private subroutine that calulates the total and average units shipped by employee 12
    ''' </summary>
    Private Sub CalculateAndDisplayEmployee2Average()

        Dim employee2Average As Double = 0.00

        For i As Integer = 0 To days.GetLength(1) - 1
            employee2Total += days(1, i)
        Next

        employee2Average = employee2Total / days.GetLength(1)
        ' Set lblEmployeeTwoAverage text to "Average: " + calulated average
        lblEmployeeTwoAverage.Text = "Average: " & employee2Average.ToString("n2")
    End Sub

    ''' <summary>
    ''' Private subroutine that calulates the total and average units shipped by employee 3
    ''' </summary>
    Private Sub CalculateAndDisplayEmployee3Average()

        Dim employee3Average As Double = 0.00

        For i As Integer = 0 To days.GetLength(1) - 1
            employee3Total += days(2, i)
        Next

        employee3Average = employee3Total / days.GetLength(1)
        ' Set lblEmployeeThreeAverage text to "Average: " + calulated average
        lblEmployeeThreeAverage.Text = "Average: " & employee3Average.ToString("n2")
    End Sub

    ''' <summary>
    ''' Private subroutine that calulates the total of all units shipped as well ass the average daily units shipped by all employees
    ''' </summary>
    Private Sub CalculateAndDisplayCompanyAverage()
        Dim companyTotal As Integer = 0
        Dim companyAverage As Double = 0.00
        Const divsionFactor As Integer = 21

        companyTotal = employee1Total + employee2Total + employee3Total

        companyAverage = companyTotal / divsionFactor

        ' Set lblCompanyDailyAverage Text to "Average per day: " + calculated average
        lblCompanyDailyAverage.Text = "Average per day: " & companyAverage.ToString("n2")
    End Sub

    ''' <summary>
    ''' Event handler for enter button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Declare vairable to store user's input
        Dim userInput As Integer = 0

        ' If user input is not a valid integer display corresponding error message
        If (Integer.TryParse(txtEnterUnits.Text, userInput) = False) Then

            MessageBox.Show("Please ensure value entered is a whole number")
            txtEnterUnits.Select()
            txtEnterUnits.Text = ""
            ' else If user input is not between 0 and 1000 inclusive, display corresponding error message
        ElseIf (userInput < 0 Or userInput > 1000) Then

            MessageBox.Show("Please ensure the units shipped between 1 and 1000 inclusive!")
            txtEnterUnits.Select()
            txtEnterUnits.Text = ""

            ' else if user input passes all validation begin processing
        Else

            lblDayCounter.Text = "Day " & currentDay.ToString()

            ' Set current index of days array equal to validated user input
            days(rowIndexCounter, coloumIndexCounter) = userInput

            ' If the current row index is equal to 0 
            If rowIndexCounter = 0 Then

                'set textbox for employee 1 units equal to userInput converted to a string, carriage return line feed
                txtEmployeeOneUnits.Text &= userInput.ToString & vbCrLf
                ' If the current row index is equal to 1
            ElseIf rowIndexCounter = 1 Then
                'set textbox for employee 2 units equal to userInput converted to a string, carriage return line feed
                txtEmployeeTwoUnits.Text &= userInput.ToString & vbCrLf
                ' If the current row index is equal to 2
            ElseIf rowIndexCounter = 2 Then
                'set textbox for employee 1 units equal to userInput converted to a string, carriage return line feed
                txtEmployeeThreeUnits.Text &= userInput.ToString & vbCrLf

            End If
            'Set counter for current day label equal to currentDay plus 1
            currentDay += 1
            'Set counter for column index equal to columnIndexCounter plus 1
            coloumIndexCounter += 1

            ' If the current row index is equal to 0 and the current column index is greater than 6
            If rowIndexCounter = 0 And coloumIndexCounter > 6 Then
                'Return to column index o
                coloumIndexCounter = 0
                'Set currentDay counter equal to 1
                currentDay = 1
                'Call CalculateAndDisplayEmployee1Average() Function to display average units for employee 1
                CalculateAndDisplayEmployee1Average()
                'Set row index counter equal to rowIndexCounter plus 1
                rowIndexCounter += 1

            End If
            ' If the current row index is equal to 1 and the current column index is greater than 6
            If rowIndexCounter = 1 And coloumIndexCounter > 6 Then
                coloumIndexCounter = 0
                currentDay = 1
                'Call CalculateAndDisplayEmployee2Average() Function to display average units for employee 2
                CalculateAndDisplayEmployee2Average()
                'Set row index counter equal to rowIndexCounter plus 1
                rowIndexCounter += 1
            End If
            ' If the current row index is equal to 2 and the current column index is greater than 6
            If rowIndexCounter = 2 And coloumIndexCounter > 6 Then
                coloumIndexCounter = 0
                currentDay = 1
                'Call CalculateAndDisplayEmployee3Average() Function to display average units for employee 3
                CalculateAndDisplayEmployee3Average()
                'Set row index counter equal to rowIndexCounter plus 1
                rowIndexCounter += 1

            End If

            'Set user input equal to 0
            userInput = 0
            'Set enterUnits textbox equal to an empty string
            txtEnterUnits.Text = ""
            'Set focus to enterUnits textbox 
            txtEnterUnits.Select()


        End If

    End Sub
    ''' <summary>
    ''' Event handler for button reset click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset all labels, text boxes, variables back to zero
        txtEnterUnits.Text = ""
        txtEmployeeOneUnits.Text = ""
        txtEmployeeTwoUnits.Text = ""
        txtEmployeeThreeUnits.Text = ""
        lblEmployeeOneAverage.Text = ""
        lblEmployeeTwoAverage.Text = ""
        lblEmployeeThreeAverage.Text = ""
        lblCompanyDailyAverage.Text = ""

        'Set employee total variables equal to 0
        employee1Total = 0

        employee2Total = 0

        employee3Total = 0


        btnEnter.Enabled = True




        ' Set currentDay variable back to zero
        currentDay = 1
        lblDayCounter.Text = ""
        'Re enables the Enter button to allow future user entries
        txtEnterUnits.Enabled = True
        txtEnterUnits.Select()
        rowIndexCounter = 0
        coloumIndexCounter = 0

        For i As Integer = 0 To days.GetLength(0) - 1

            For j As Integer = 0 To days.GetLength(1) - 1
                days(i, j) = 0
            Next
        Next
    End Sub
    ''' <summary>
    ''' Event handler for button Exit click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application
        Me.Close()
    End Sub
    ''' <summary>
    ''' Event handler to select the enterUnits textbox upon loading
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEnterUnits.Select()
    End Sub

    ''' <summary>
    ''' Event handler to initiate CalculateAndDisplayCompanyAverage() funtion and disable enter button.
    ''' Takes effect once lblEmployeeThreeAverage text changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lblEmployeeThreeAverage_TextChanged(sender As Object, e As EventArgs) Handles lblEmployeeThreeAverage.TextChanged
        If lblCompanyDailyAverage.Text = "" Then


            ' call CalculateAndDisplayCompanyAverage() Function to display the average units shipped for all employees
            CalculateAndDisplayCompanyAverage()
            'Set enterUnits textbox to disabled
            txtEnterUnits.Enabled = False
            'Set enter button to disabled
            btnEnter.Enabled = False
            'Set focus to reset button
            btnReset.Select()
        End If
    End Sub


End Class
