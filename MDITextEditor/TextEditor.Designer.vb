<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.txtEditorWindow = New System.Windows.Forms.TextBox()
        Me.ttTipsForTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtEditorWindow
        '
        Me.txtEditorWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditorWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditorWindow.Location = New System.Drawing.Point(0, 0)
        Me.txtEditorWindow.Multiline = True
        Me.txtEditorWindow.Name = "txtEditorWindow"
        Me.txtEditorWindow.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEditorWindow.Size = New System.Drawing.Size(649, 490)
        Me.txtEditorWindow.TabIndex = 2
        Me.ttTipsForTextEditor.SetToolTip(Me.txtEditorWindow, "Enter your text here")
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 490)
        Me.Controls.Add(Me.txtEditorWindow)
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor -"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEditorWindow As TextBox
    Friend WithEvents ttTipsForTextEditor As ToolTip
End Class
