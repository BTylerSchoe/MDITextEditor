'==================================================================================
'
'Program Name:      MDIParent1.vb
'
'Author:            Brayden Schoenau
'
'
'Date:              4/20/2018
'
'Purpose:           This is a small MDI windows form application that has 2 pchild forms
'                   This program contains an average units shipped by employee child form
'                   created for lab 3 of NetD 2202 as well as a Text Editor child form created 
'                   for lab 5 of NetD 2202. This application allows the user to save files, 
'                   save files As, open New files, copy file contents, paste from the cliptray, 
'                   and cut text from a file
'
'===================================================================================

Option Strict On

' import namespace for use in application
Imports System.Windows.Forms
Imports MDITextEditor.frmTextEditor
Imports System.IO

Public Class frmMdiTextEditor
    ' Declare a original file content variable for comparison
    Dim originalFileContent As String = String.Empty
    Dim SaveFileDialog As New SaveFileDialog

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, btnNew.Click

        Dim frmTextEditor As New frmTextEditor

        frmTextEditor.MdiParent = Me

        frmTextEditor.Text = "Text Editor - New(Unsaved)"

        frmTextEditor.Show()

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles mnuOpen.Click, btnOpen.Click
        Dim frmTextEditor As New frmTextEditor

        frmTextEditor.MdiParent = Me



        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            'TODO:       Add code here to open the file.
            Dim fileContent As String = String.Empty
            If File.Exists(FileName) Then

                '  Set file context equal to the 
                fileContent = Open(FileName)
                originalFileContent = Open(FileName)
                ' Set the txtEditorWindow's text equal to the contents of fileContent variable
                frmTextEditor.txtEditorWindow.Text = fileContent
                '  Set the title of the form to "Text Editor - " And concatinate the full file path
                If FileName <> String.Empty Then
                    frmTextEditor.Text = "Text Editor - " & FileName


                End If

                frmTextEditor.Show()


                End If
            End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuSaveAs.Click
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            Dim frm As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

            frm.ExternalSaveAs()
        End If
    End Sub


    Friend Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExit.Click


        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then

            If frmTextEditor.txtEditorWindow.Text IsNot originalFileContent Then
                MessageBox.Show("Do you wish to save your changes before you exit?", "File Content Has Changed", MessageBoxButtons.YesNoCancel)

                If MessageBoxButtons.YesNoCancel = vbYes Then


                    Dim frm As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

                    frm.ExternalSaveAs()
                    Me.Close()
                ElseIf MessageBoxButtons.YesNoCancel = vbNo Then
                    Me.Close()
                ElseIf MessageBoxButtons.YesNoCancel = vbCancel Then
                    frmTextEditor.txtEditorWindow.Select()
                End If
            Else
                Me.Close()
            End If

        End If




    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCut.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCopy.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuPaste.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        Paste()
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuAverageUnitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAverageUnitsToolStripMenuItem.Click
        Dim frmAverageUnitsShipped As New frmAverageUnitsShippedByEmployee

        frmAverageUnitsShipped.MdiParent = Me

        frmAverageUnitsShipped.Show()
    End Sub







    '''''''''''''''''''''''''''''''''''''''''''''''''''
    '           Sub Routines & Functions
    '''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' Copy sub routine, used to copy the selected text and store in the users cliptray
    ''' </summary>
    Private Sub Copy()


        Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)




        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then

            ' If the txtEditorWindows textbox is empty display error message
            If frmTextEditor.txtEditorWindow.Text = "" Then
                MessageBox.Show("Please select the text you wish to copy", "ERROR")
            ElseIf frmTextEditor.txtEditorWindow.SelectedText = "" Then
                ' If the user has not selected ny text to copy display error message
                MessageBox.Show("Please select the text you wish to copy", "ERROR")
            Else
                ' Store the slected text from the txtEditorWindow in the users cliptray
                My.Computer.Clipboard.SetText(frmTextEditor.txtEditorWindow.SelectedText)
            End If

        End If



    End Sub



    ''' <summary>
    ''' Cut sub routine, used to cut the currently selected text from the txtEditorWindow textbox
    ''' Sotes it in the users cliptray
    ''' </summary>
    Private Sub Cut()

        Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)




        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            ' If the txtEditorWindows textbox is empty display error message
            If frmTextEditor.txtEditorWindow.Text = "" Then
                MessageBox.Show("Please select the text you wish to cut", "ERROR")
                ' If the user has not selected ny text to copy display error message
            ElseIf frmTextEditor.txtEditorWindow.SelectedText = "" Then
                MessageBox.Show("Please select the text you wish to cut", "ERROR")
            Else
                ' cut the slected text form the txtEditorWindow and store it in the users cliptray
                My.Computer.Clipboard.SetText(frmTextEditor.txtEditorWindow.SelectedText)
                ' Set the selected text from the txtEditorWindow equal to an emprty string
                frmTextEditor.txtEditorWindow.SelectedText = ""
            End If
        End If
    End Sub
    ''' <summary>
    ''' Paste Sub Routine, 
    ''' </summary>used to paste the current contents of the users cliptray to the txtEditorWindow text box
    Private Sub Paste()

        Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)




        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            ' Set the selected text form the txtEditorWindow text box equal to the content of the users cliptray as a string
            frmTextEditor.txtEditorWindow.SelectedText = My.Computer.Clipboard.GetText().ToString
        End If
    End Sub

    ''' <summary>
    ''' Save Sub Routine, used to save the current context of the form text box to a text document
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <param name="output"></param>
    Private Sub Save(fileName As String, output As String)
        ' initialize a new instance of the file stream class with the specified path, creation mode and read/write permissions 
        Dim fileStream As New FileStream(fileName, FileMode.Create, FileAccess.Write)
        ' Initialize a new instance of the streamWriter class
        Dim writeStream As New StreamWriter(fileStream)
        ' Write the contexts of the output to the new filestream
        writeStream.Write(output)
        ' Close the current wrtieStream
        writeStream.Close()


    End Sub


    ''' <summary>
    ''' Open Function, used to open an existing text document from the openDialog window
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <returns></returns>
    Private Function Open(filePath As String) As String
        ' Delcare a new string variable caleed fileContent to store the contexts of the selected text document
        Dim fileContent As String = String.Empty
        ' initialize a new instance of the file stream class with the specified path, creation mode and read/write permissions
        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        ' Initialize a new instance of the streamReader class
        Dim readStream As New StreamReader(fileStream)
        ' Set file content variable equal to the return value of the ReadToEnd function
        fileContent = readStream.ReadToEnd()
        ' Close the current streamRead instance 
        readStream.Close()
        ' Return the value of the fileContent Variable
        Return fileContent

    End Function

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("NetD 2202 " & vbCrLf & vbCrLf & "Brayden Schoenau" & vbCrLf & vbCrLf &
                        "TextEditor", "About")
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.ActiveMdiChild.Close()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            Dim frm As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

            frm.ExternalSave()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            Dim frm As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

            frm.ExternalSave()
        End If
    End Sub
End Class
