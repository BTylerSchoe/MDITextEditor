<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMdiTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMdiTextEditor))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAverageUnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileMenu, Me.mnuEditMenu, Me.mnuWindowsMenu, Me.mnuHelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.mnuWindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(843, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuFileMenu
        '
        Me.mnuFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.mnuOpen, Me.ToolStripSeparator3, Me.mnuSave, Me.mnuSaveAs, Me.ToolStripSeparator5, Me.mnuClose, Me.mnuExit})
        Me.mnuFileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuFileMenu.Name = "mnuFileMenu"
        Me.mnuFileMenu.Size = New System.Drawing.Size(44, 24)
        Me.mnuFileMenu.Text = "&File"
        Me.mnuFileMenu.ToolTipText = "Click to display file options"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.NewToolStripMenuItem.Text = "&New"
        Me.NewToolStripMenuItem.ToolTipText = "click to start a new document"
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = CType(resources.GetObject("mnuOpen.Image"), System.Drawing.Image)
        Me.mnuOpen.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(181, 26)
        Me.mnuOpen.Text = "&Open"
        Me.mnuOpen.ToolTipText = "click to open an existing document"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(178, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(181, 26)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "click to save the current document"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(181, 26)
        Me.mnuSaveAs.Text = "Save &As"
        Me.mnuSaveAs.ToolTipText = "click to save document with a specific name and location"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(178, 6)
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(181, 26)
        Me.mnuClose.Text = "&Close"
        Me.mnuClose.ToolTipText = "click to close the active form"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuExit.Text = "E&xit"
        Me.mnuExit.ToolTipText = "click to exit the application"
        '
        'mnuEditMenu
        '
        Me.mnuEditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCut, Me.mnuCopy, Me.mnuPaste})
        Me.mnuEditMenu.Name = "mnuEditMenu"
        Me.mnuEditMenu.Size = New System.Drawing.Size(47, 24)
        Me.mnuEditMenu.Text = "&Edit"
        Me.mnuEditMenu.ToolTipText = "click to display the edit options"
        '
        'mnuCut
        '
        Me.mnuCut.Image = CType(resources.GetObject("mnuCut.Image"), System.Drawing.Image)
        Me.mnuCut.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(181, 26)
        Me.mnuCut.Text = "Cu&t"
        Me.mnuCut.ToolTipText = "click to cut the selected text"
        '
        'mnuCopy
        '
        Me.mnuCopy.Image = CType(resources.GetObject("mnuCopy.Image"), System.Drawing.Image)
        Me.mnuCopy.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(181, 26)
        Me.mnuCopy.Text = "&Copy"
        Me.mnuCopy.ToolTipText = "click to cop the selected text"
        '
        'mnuPaste
        '
        Me.mnuPaste.Image = CType(resources.GetObject("mnuPaste.Image"), System.Drawing.Image)
        Me.mnuPaste.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(181, 26)
        Me.mnuPaste.Text = "&Paste"
        Me.mnuPaste.ToolTipText = "click to paste the text from your clip tray"
        '
        'mnuWindowsMenu
        '
        Me.mnuWindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascade, Me.mnuTileVertical, Me.mnuTileHorizontal, Me.mnuAverageUnitsToolStripMenuItem})
        Me.mnuWindowsMenu.Name = "mnuWindowsMenu"
        Me.mnuWindowsMenu.Size = New System.Drawing.Size(82, 24)
        Me.mnuWindowsMenu.Text = "&Windows"
        Me.mnuWindowsMenu.ToolTipText = "click to display window options"
        '
        'mnuCascade
        '
        Me.mnuCascade.Name = "mnuCascade"
        Me.mnuCascade.Size = New System.Drawing.Size(182, 26)
        Me.mnuCascade.Text = "&Cascade"
        Me.mnuCascade.ToolTipText = "click to cascade windows"
        '
        'mnuTileVertical
        '
        Me.mnuTileVertical.Name = "mnuTileVertical"
        Me.mnuTileVertical.Size = New System.Drawing.Size(182, 26)
        Me.mnuTileVertical.Text = "Tile &Vertical"
        Me.mnuTileVertical.ToolTipText = "click to tile windows vertically"
        '
        'mnuTileHorizontal
        '
        Me.mnuTileHorizontal.Name = "mnuTileHorizontal"
        Me.mnuTileHorizontal.Size = New System.Drawing.Size(182, 26)
        Me.mnuTileHorizontal.Text = "Tile &Horizontal"
        Me.mnuTileHorizontal.ToolTipText = "click to tile windows horizontally"
        '
        'mnuAverageUnitsToolStripMenuItem
        '
        Me.mnuAverageUnitsToolStripMenuItem.Name = "mnuAverageUnitsToolStripMenuItem"
        Me.mnuAverageUnitsToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.mnuAverageUnitsToolStripMenuItem.Text = "Average &Units"
        Me.mnuAverageUnitsToolStripMenuItem.ToolTipText = "click to open Average units form"
        '
        'mnuHelpMenu
        '
        Me.mnuHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelpMenu.Name = "mnuHelpMenu"
        Me.mnuHelpMenu.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelpMenu.Text = "&Help"
        Me.mnuHelpMenu.ToolTipText = "click to view help options"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(181, 26)
        Me.mnuAbout.Text = "&About ..."
        Me.mnuAbout.ToolTipText = "click to view form information about the application"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnOpen, Me.btnSave})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(843, 27)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(24, 24)
        Me.btnNew.Text = "New"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(24, 24)
        Me.btnOpen.Text = "Open"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(24, 24)
        Me.btnSave.Text = "Save"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(843, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'frmMdiTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 558)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMdiTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mdi Text Editor -"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuHelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTileVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTileHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuEditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuAverageUnitsToolStripMenuItem As ToolStripMenuItem
End Class
