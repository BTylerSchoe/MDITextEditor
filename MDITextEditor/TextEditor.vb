''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'Program Name:          Text Editor
'
'      Author:          Brayden Schoenau
'
'        Date:          4/20/2018
'
'     Purpose:          A Text editor windows from application that can save files, save files as, open new files, 
'                       copy file contents, paste from the cliptray, and cut text from a file.
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Strict On

Imports System.IO


Public Class frmTextEditor
    ' initalize a new instance of the saveFileDialog class
    Dim SaveFileDialog As New SaveFileDialog

    '''''''''''''''''''''''''''''''''''''''''''''''''''
    '           Event Handlers
    '''''''''''''''''''''''''''''''''''''''''''''''''''

    ''' <summary>
    ''' New click event handler, opens a new document 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuNew_Click(sender As Object, e As EventArgs)
        ' Clear text box to start a new document 
        txtEditorWindow.Text = ""
        ' move focus to the text box
        txtEditorWindow.Select()
        Me.Text = "Text Editor - "



    End Sub
    ''' <summary>
    ''' Open click event handler, opens a new document.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs)
        ' Declare a new openFileDialog to allow the user to choose a document to open
        Dim openFileDialog As New OpenFileDialog
        ' Declare a string variable to store the file path of the selected document
        Dim fullFilePath As String = String.Empty
        ' Declare a new string variable to stare the contexts of the selected document
        Dim fileContent As String = String.Empty

        ' Filter the dialog box to only allow selection of text files
        openFileDialog.Filter = "txt files (*.txt)|*.txt"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Set the full file path variable equal to the file name
            fullFilePath = openFileDialog.FileName
            ' If the current file exits
            If File.Exists(fullFilePath) Then

                ' Set file context equal to the 
                fileContent = Open(fullFilePath)
                ' Set the txtEditorWindow's text equal to the contents of fileContent variable
                txtEditorWindow.Text = fileContent
                ' Set the title of the form to "Text Editor - " and concatinate the full file path
                Me.Text = "Text Editor - " & fullFilePath
                ' Update the title to reflect the content of the document
                Update()



            End If

        End If





    End Sub
    ''' <summary>
    ''' Save click event handler, Saves the current document
    ''' Performs a save as if the file has not previously been saved
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSave_Click(sender As Object, e As EventArgs)


        ' Declare a new string variable as to store the fullFilePath
        Dim fullFilePath As String = String.Empty
        ' Declare a new string variable to store the output of the text document
        Dim output As String = String.Empty


        ' Set output variable equal to the contents of the txtEditorWindow text box
        output = txtEditorWindow.Text


        ' Filter dialog box to only allow save as a new text file
        SaveFileDialog.Filter = "txt files (*.txt)|*.txt"
        ' Set the full file path variable equal to the file name
        fullFilePath = SaveFileDialog.FileName
        ' If the file exits call the save subroutine
        If File.Exists(fullFilePath) Then

            Save(fullFilePath, output)

        ElseIf SaveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Set the full file path variable equal to the file name
            fullFilePath = SaveFileDialog.FileName
            'call the save subroutine
            Save(fullFilePath, output)

        End If

    End Sub
    ''' <summary>
    ''' Save As click event handler, saves the current document to the user specified location
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs)
        ' If text editor window is empty show error message to user
        If txtEditorWindow.Text = "" Then
            MessageBox.Show("File is empty. Please enter text.", "ERROR")
        Else
            ' initalize a new instance of the saveFileDialog class
            Dim saveFileDialog As New SaveFileDialog
            ' Declare a new string variable as to store the fullFilePath
            Dim fullFilePath As String = String.Empty
            ' Declare a new string variable to store the output of the text document
            Dim output As String = String.Empty


            ' Filter save file dialog to only allow saving of text documents
            saveFileDialog.Filter = "txt files (*.txt)|*.txt"
            ' 
            If saveFileDialog.ShowDialog() = DialogResult.OK Then

                ' Set the full file path variable equal to the file name
                fullFilePath = saveFileDialog.FileName

                ' Call the save subroutine
                Save(fullFilePath, output)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Close click event handler, Exits the application 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuClose_Click(sender As Object, e As EventArgs)
        ' Close the current application
        Me.Close()
    End Sub

    ''' <summary>
    ''' Exit click event handler, Exits the application 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuExit_Click(sender As Object, e As EventArgs)
        ' Close the current application
        Me.Close()
    End Sub

    ''' <summary>
    ''' Copy click event handler, Copys the text from the text editor window and saves it to the users cliptray
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs)
        ' Call the copy subroutine
        Copy()
    End Sub
    ''' <summary>
    ''' Paste click event handler, Pastes the current contents of the cliptray to the text editor's text box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs)
        ' Call the paste subroutine
        Paste()
    End Sub
    ''' <summary>
    ''' Cut click event handler, Cut the currentlt selected text from the text box and saves it to the users cliptray
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCut_Click(sender As Object, e As EventArgs)
        ' Call the cut subroutine
        Cut()
    End Sub

    ''' <summary>
    ''' About click event handler, Diplays information about the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs)
        ' Display message box tot he user containing info about the application
        MessageBox.Show("NetD 2202" & vbCrLf & vbCrLf & "   Lab #5" & vbCrLf & vbCrLf & " B. Schoenau", "About")
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''
    '           Sub Routines & Functions
    '''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' Copy sub routine, used to copy the selected text and store in the users cliptray
    ''' </summary>
    Friend Sub Copy()
        ' If the txtEditorWindows textbox is empty display error message
        If txtEditorWindow.Text = "" Then
            MessageBox.Show("Please select the text you wish to copy", "ERROR")
        ElseIf txtEditorWindow.SelectedText = "" Then
            ' If the user has not selected ny text to copy display error message
            MessageBox.Show("Please select the text you wish to copy", "ERROR")
        Else
            ' Store the slected text from the txtEditorWindow in the users cliptray
            My.Computer.Clipboard.SetText(txtEditorWindow.SelectedText)
        End If
    End Sub

    ''' <summary>
    ''' Cut sub routine, used to cut the currently selected text from the txtEditorWindow textbox
    ''' Sotes it in the users cliptray
    ''' </summary>
    Friend Sub Cut()
        ' If the txtEditorWindows textbox is empty display error message
        If txtEditorWindow.Text = "" Then
            MessageBox.Show("Please select the text you wish to cut", "ERROR")
            ' If the user has not selected ny text to copy display error message
        ElseIf txtEditorWindow.SelectedText = "" Then
            MessageBox.Show("Please select the text you wish to cut", "ERROR")
        Else
            ' cut the slected text form the txtEditorWindow and store it in the users cliptray
            My.Computer.Clipboard.SetText(txtEditorWindow.SelectedText)
            ' Set the selected text from the txtEditorWindow equal to an emprty string
            txtEditorWindow.SelectedText = ""
        End If
    End Sub
    ''' <summary>
    ''' Paste Sub Routine, 
    ''' </summary>used to paste the current contents of the users cliptray to the txtEditorWindow text box
    Friend Sub Paste()
        ' Set the selected text form the txtEditorWindow text box equal to the content of the users cliptray as a string

    End Sub

    ''' <summary>
    ''' Save Sub Routine, used to save the current context of the form text box to a text document
    ''' </summary>
    ''' <param name="fullFilePath"></param>
    ''' <param name="output"></param>
    Friend Sub Save(fullFilePath As String, output As String)

        ' initialize a new instance of the file stream class with the specified path, creation mode and read/write permissions 
        Dim fileStream As New FileStream(fullFilePath, FileMode.Create, FileAccess.Write)
        ' Initialize a new instance of the streamWriter class
        Dim writeStream As New StreamWriter(fileStream)
        ' Write the contexts of the output to the new filestream
        writeStream.Write(output)
        ' Close the current wrtieStream
        writeStream.Close()


    End Sub
    Friend Sub ExternalSave()

        ' Declare a new string variable as to store the fullFilePath
        Dim fullFilePath As String = String.Empty
        ' Declare a new string variable to store the output of the text document
        Dim output As String = String.Empty


        ' Set output variable equal to the contents of the txtEditorWindow text box
        output = txtEditorWindow.Text


        ' Filter dialog box to only allow save as a new text file
        saveFileDialog.Filter = "txt files (*.txt)|*.txt"
        ' Set the full file path variable equal to the file name
        fullFilePath = saveFileDialog.FileName
        ' If the file exits call the save subroutine
        If File.Exists(fullFilePath) Then

            Save(fullFilePath, output)

        ElseIf saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Set the full file path variable equal to the file name
            fullFilePath = SaveFileDialog.FileName
            'call the save subroutine
            Save(fullFilePath, output)
            End If


        Me.Text = "Text Editor - " & fullFilePath

    End Sub

    Friend Sub ExternalSaveAs()

        ' initalize a new instance of the saveFileDialog class

        ' Declare a new string variable as to store the fullFilePath
        Dim fullFilePath As String = String.Empty
        ' Declare a new string variable to store the output of the text document
        Dim output As String = String.Empty


        ' Filter save file dialog to only allow saving of text documents
        saveFileDialog.Filter = "txt files (*.txt)|*.txt"
        ' 
        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            ' Set the full file path variable equal to the file name
            fullFilePath = saveFileDialog.FileName
            output = txtEditorWindow.Text
            ' Call the save subroutine
            Save(fullFilePath, output)
        End If
        Me.Text = "Text Editor - " & fullFilePath
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


End Class


