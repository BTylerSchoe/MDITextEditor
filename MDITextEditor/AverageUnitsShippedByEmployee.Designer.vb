<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDayCounter = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtEnterUnits = New System.Windows.Forms.TextBox()
        Me.lblUnitsPrompt = New System.Windows.Forms.Label()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblEmployeeOneAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoAverage = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeAverage = New System.Windows.Forms.Label()
        Me.lblCompanyDailyAverage = New System.Windows.Forms.Label()
        Me.txtEmployeeOneUnits = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwoUnits = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThreeUnits = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tlpAverageUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDayCounter
        '
        Me.lblDayCounter.Location = New System.Drawing.Point(14, 9)
        Me.lblDayCounter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDayCounter.Name = "lblDayCounter"
        Me.lblDayCounter.Size = New System.Drawing.Size(69, 16)
        Me.lblDayCounter.TabIndex = 0
        Me.lblDayCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(21, 365)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(166, 28)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "Enter"
        Me.tlpAverageUnitsShipped.SetToolTip(Me.btnEnter, "Click  to enter the units shipped")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtEnterUnits
        '
        Me.txtEnterUnits.Location = New System.Drawing.Point(111, 53)
        Me.txtEnterUnits.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEnterUnits.Name = "txtEnterUnits"
        Me.txtEnterUnits.Size = New System.Drawing.Size(76, 22)
        Me.txtEnterUnits.TabIndex = 2
        Me.tlpAverageUnitsShipped.SetToolTip(Me.txtEnterUnits, "Please enter the number of units shipped(Alt-U)")
        '
        'lblUnitsPrompt
        '
        Me.lblUnitsPrompt.Location = New System.Drawing.Point(21, 56)
        Me.lblUnitsPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnitsPrompt.Name = "lblUnitsPrompt"
        Me.lblUnitsPrompt.Size = New System.Drawing.Size(62, 16)
        Me.lblUnitsPrompt.TabIndex = 1
        Me.lblUnitsPrompt.Text = "&Units"
        Me.lblUnitsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.Location = New System.Drawing.Point(21, 86)
        Me.lblEmployeeOne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(166, 17)
        Me.lblEmployeeOne.TabIndex = 3
        Me.lblEmployeeOne.Text = "Employee 1"
        Me.lblEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(195, 86)
        Me.lblEmployee2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(160, 17)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(359, 86)
        Me.lblEmployee3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(170, 17)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeOneAverage
        '
        Me.lblEmployeeOneAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOneAverage.Location = New System.Drawing.Point(17, 271)
        Me.lblEmployeeOneAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeOneAverage.Name = "lblEmployeeOneAverage"
        Me.lblEmployeeOneAverage.Size = New System.Drawing.Size(171, 23)
        Me.lblEmployeeOneAverage.TabIndex = 9
        Me.tlpAverageUnitsShipped.SetToolTip(Me.lblEmployeeOneAverage, "Displays the average units shipped for employee 1")
        '
        'lblEmployeeTwoAverage
        '
        Me.lblEmployeeTwoAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTwoAverage.Location = New System.Drawing.Point(191, 271)
        Me.lblEmployeeTwoAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeTwoAverage.Name = "lblEmployeeTwoAverage"
        Me.lblEmployeeTwoAverage.Size = New System.Drawing.Size(165, 23)
        Me.lblEmployeeTwoAverage.TabIndex = 10
        Me.tlpAverageUnitsShipped.SetToolTip(Me.lblEmployeeTwoAverage, "Displays the average units shipped for employee 2")
        '
        'lblEmployeeThreeAverage
        '
        Me.lblEmployeeThreeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeThreeAverage.Location = New System.Drawing.Point(359, 271)
        Me.lblEmployeeThreeAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeThreeAverage.Name = "lblEmployeeThreeAverage"
        Me.lblEmployeeThreeAverage.Size = New System.Drawing.Size(171, 23)
        Me.lblEmployeeThreeAverage.TabIndex = 11
        Me.tlpAverageUnitsShipped.SetToolTip(Me.lblEmployeeThreeAverage, "Displays the average units shipped for employee 3")
        '
        'lblCompanyDailyAverage
        '
        Me.lblCompanyDailyAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCompanyDailyAverage.Location = New System.Drawing.Point(17, 311)
        Me.lblCompanyDailyAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyDailyAverage.Name = "lblCompanyDailyAverage"
        Me.lblCompanyDailyAverage.Size = New System.Drawing.Size(512, 34)
        Me.lblCompanyDailyAverage.TabIndex = 12
        Me.lblCompanyDailyAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tlpAverageUnitsShipped.SetToolTip(Me.lblCompanyDailyAverage, "Displays the companies daily average units shipped")
        '
        'txtEmployeeOneUnits
        '
        Me.txtEmployeeOneUnits.Location = New System.Drawing.Point(17, 110)
        Me.txtEmployeeOneUnits.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeOneUnits.Multiline = True
        Me.txtEmployeeOneUnits.Name = "txtEmployeeOneUnits"
        Me.txtEmployeeOneUnits.ReadOnly = True
        Me.txtEmployeeOneUnits.Size = New System.Drawing.Size(170, 146)
        Me.txtEmployeeOneUnits.TabIndex = 6
        Me.txtEmployeeOneUnits.TabStop = False
        Me.tlpAverageUnitsShipped.SetToolTip(Me.txtEmployeeOneUnits, "Displays the units shipped by employee for each day of the week")
        '
        'txtEmployeeTwoUnits
        '
        Me.txtEmployeeTwoUnits.Location = New System.Drawing.Point(195, 110)
        Me.txtEmployeeTwoUnits.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeTwoUnits.Multiline = True
        Me.txtEmployeeTwoUnits.Name = "txtEmployeeTwoUnits"
        Me.txtEmployeeTwoUnits.ReadOnly = True
        Me.txtEmployeeTwoUnits.Size = New System.Drawing.Size(160, 146)
        Me.txtEmployeeTwoUnits.TabIndex = 7
        Me.txtEmployeeTwoUnits.TabStop = False
        Me.tlpAverageUnitsShipped.SetToolTip(Me.txtEmployeeTwoUnits, "Displays the units shipped by employee for each day of the week")
        '
        'txtEmployeeThreeUnits
        '
        Me.txtEmployeeThreeUnits.Location = New System.Drawing.Point(363, 110)
        Me.txtEmployeeThreeUnits.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeThreeUnits.Multiline = True
        Me.txtEmployeeThreeUnits.Name = "txtEmployeeThreeUnits"
        Me.txtEmployeeThreeUnits.ReadOnly = True
        Me.txtEmployeeThreeUnits.Size = New System.Drawing.Size(166, 146)
        Me.txtEmployeeThreeUnits.TabIndex = 8
        Me.txtEmployeeThreeUnits.TabStop = False
        Me.tlpAverageUnitsShipped.SetToolTip(Me.txtEmployeeThreeUnits, "Displays the units shipped by employee for each day of the week")
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(191, 365)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(164, 28)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.tlpAverageUnitsShipped.SetToolTip(Me.btnReset, "Click to reset the application(Alt-R)")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 365)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(167, 28)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.tlpAverageUnitsShipped.SetToolTip(Me.btnExit, "Click to exit the application(Alt-E)")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(542, 420)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtEmployeeThreeUnits)
        Me.Controls.Add(Me.txtEmployeeTwoUnits)
        Me.Controls.Add(Me.txtEmployeeOneUnits)
        Me.Controls.Add(Me.lblCompanyDailyAverage)
        Me.Controls.Add(Me.lblEmployeeThreeAverage)
        Me.Controls.Add(Me.lblEmployeeTwoAverage)
        Me.Controls.Add(Me.lblEmployeeOneAverage)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.lblUnitsPrompt)
        Me.Controls.Add(Me.txtEnterUnits)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDayCounter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDayCounter As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtEnterUnits As TextBox
    Friend WithEvents lblUnitsPrompt As Label
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblEmployeeOneAverage As Label
    Friend WithEvents lblEmployeeTwoAverage As Label
    Friend WithEvents lblEmployeeThreeAverage As Label
    Friend WithEvents lblCompanyDailyAverage As Label
    Friend WithEvents txtEmployeeOneUnits As TextBox
    Friend WithEvents txtEmployeeTwoUnits As TextBox
    Friend WithEvents txtEmployeeThreeUnits As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tlpAverageUnitsShipped As ToolTip
End Class
