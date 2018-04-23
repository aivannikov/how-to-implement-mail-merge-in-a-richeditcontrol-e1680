Imports Microsoft.VisualBasic
Imports System
Namespace MailMerge
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
			Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
			Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
			Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
			Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
			Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
			Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
			Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
			Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
			Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
			Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
			Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
			Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
			Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
			Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
			Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
			Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
			Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
			Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
			Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
			Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
			Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
			Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
			Me.mergeToNewDocumentItem = New DevExpress.XtraBars.BarButtonItem()
			Me.mergeToFileItem = New DevExpress.XtraBars.BarButtonItem()
			Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
			Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
			Me.insertIfFieldItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
			Me.commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
			Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
			Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
			Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
			Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.richEditControl2 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 141)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(792, 401)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
'			Me.xtraTabControl1.Selected += New DevExpress.XtraTab.TabPageEventHandler(Me.xtraTabControl1_Selected);
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.richEditControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(785, 372)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
			Me.richEditControl1.MenuManager = Me.ribbonControl1
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(785, 372)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationIcon = Nothing
			Me.ribbonControl1.AutoSizeItems = True
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.mergeToNewDocumentItem, Me.mergeToFileItem, Me.changeStyleItem1, Me.insertIfFieldItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 6
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.homeRibbonPage1, Me.mailingsRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
			Me.ribbonControl1.SelectedPage = Me.mailingsRibbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(792, 141)
			Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
			' 
			' fileNewItem1
			' 
			Me.fileNewItem1.Glyph = (CType(resources.GetObject("fileNewItem1.Glyph"), System.Drawing.Image))
			Me.fileNewItem1.Id = 0
			Me.fileNewItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
			Me.fileNewItem1.LargeGlyph = (CType(resources.GetObject("fileNewItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			Me.fileOpenItem1.Glyph = (CType(resources.GetObject("fileOpenItem1.Glyph"), System.Drawing.Image))
			Me.fileOpenItem1.Id = 1
			Me.fileOpenItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
			Me.fileOpenItem1.LargeGlyph = (CType(resources.GetObject("fileOpenItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			Me.fileSaveItem1.Glyph = (CType(resources.GetObject("fileSaveItem1.Glyph"), System.Drawing.Image))
			Me.fileSaveItem1.Id = 2
			Me.fileSaveItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
			Me.fileSaveItem1.LargeGlyph = (CType(resources.GetObject("fileSaveItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			Me.fileSaveAsItem1.Glyph = (CType(resources.GetObject("fileSaveAsItem1.Glyph"), System.Drawing.Image))
			Me.fileSaveAsItem1.Id = 3
			Me.fileSaveAsItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
			Me.fileSaveAsItem1.LargeGlyph = (CType(resources.GetObject("fileSaveAsItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' quickPrintItem1
			' 
			Me.quickPrintItem1.Glyph = (CType(resources.GetObject("quickPrintItem1.Glyph"), System.Drawing.Image))
			Me.quickPrintItem1.Id = 4
			Me.quickPrintItem1.LargeGlyph = (CType(resources.GetObject("quickPrintItem1.LargeGlyph"), System.Drawing.Image))
			Me.quickPrintItem1.Name = "quickPrintItem1"
			' 
			' printItem1
			' 
			Me.printItem1.Glyph = (CType(resources.GetObject("printItem1.Glyph"), System.Drawing.Image))
			Me.printItem1.Id = 5
			Me.printItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
			Me.printItem1.LargeGlyph = (CType(resources.GetObject("printItem1.LargeGlyph"), System.Drawing.Image))
			Me.printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Glyph = (CType(resources.GetObject("printPreviewItem1.Glyph"), System.Drawing.Image))
			Me.printPreviewItem1.Id = 6
			Me.printPreviewItem1.LargeGlyph = (CType(resources.GetObject("printPreviewItem1.LargeGlyph"), System.Drawing.Image))
			Me.printPreviewItem1.Name = "printPreviewItem1"
			' 
			' undoItem1
			' 
			Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
			Me.undoItem1.Id = 7
			Me.undoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
			Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
			Me.redoItem1.Id = 8
			Me.redoItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
			Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
			Me.redoItem1.Name = "redoItem1"
			' 
			' changeFontNameItem1
			' 
			Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
			Me.changeFontNameItem1.Id = 9
			Me.changeFontNameItem1.Name = "changeFontNameItem1"
			Me.changeFontNameItem1.Width = 150
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' changeFontSizeItem1
			' 
			Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
			Me.changeFontSizeItem1.Id = 10
			Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
			' 
			' repositoryItemRichEditFontSizeEdit1
			' 
			Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
			Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl1
			Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
			' 
			' changeFontColorItem1
			' 
			Me.changeFontColorItem1.Glyph = (CType(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image))
			Me.changeFontColorItem1.Id = 11
			Me.changeFontColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeFontColorItem1.Name = "changeFontColorItem1"
			' 
			' changeFontBackColorItem1
			' 
			Me.changeFontBackColorItem1.Glyph = (CType(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image))
			Me.changeFontBackColorItem1.Id = 12
			Me.changeFontBackColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
			' 
			' toggleFontBoldItem1
			' 
			Me.toggleFontBoldItem1.Glyph = (CType(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontBoldItem1.Id = 13
			Me.toggleFontBoldItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
			Me.toggleFontBoldItem1.LargeGlyph = (CType(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
			' 
			' toggleFontItalicItem1
			' 
			Me.toggleFontItalicItem1.Glyph = (CType(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontItalicItem1.Id = 14
			Me.toggleFontItalicItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
			Me.toggleFontItalicItem1.LargeGlyph = (CType(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
			' 
			' fontSizeIncreaseItem1
			' 
			Me.fontSizeIncreaseItem1.Glyph = (CType(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image))
			Me.fontSizeIncreaseItem1.Id = 21
			Me.fontSizeIncreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.OemPeriod))
			Me.fontSizeIncreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image))
			Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
			' 
			' fontSizeDecreaseItem1
			' 
			Me.fontSizeDecreaseItem1.Glyph = (CType(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image))
			Me.fontSizeDecreaseItem1.Id = 22
			Me.fontSizeDecreaseItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Oemcomma))
			Me.fontSizeDecreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image))
			Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
			' 
			' clearFormattingItem1
			' 
			Me.clearFormattingItem1.Glyph = (CType(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image))
			Me.clearFormattingItem1.Id = 23
			Me.clearFormattingItem1.LargeGlyph = (CType(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image))
			Me.clearFormattingItem1.Name = "clearFormattingItem1"
			' 
			' toggleParagraphAlignmentLeftItem1
			' 
			Me.toggleParagraphAlignmentLeftItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentLeftItem1.Id = 25
			Me.toggleParagraphAlignmentLeftItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
			Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
			' 
			' toggleParagraphAlignmentCenterItem1
			' 
			Me.toggleParagraphAlignmentCenterItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentCenterItem1.Id = 26
			Me.toggleParagraphAlignmentCenterItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
			Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
			' 
			' toggleParagraphAlignmentRightItem1
			' 
			Me.toggleParagraphAlignmentRightItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentRightItem1.Id = 27
			Me.toggleParagraphAlignmentRightItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
			Me.toggleParagraphAlignmentRightItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
			' 
			' toggleParagraphAlignmentJustifyItem1
			' 
			Me.toggleParagraphAlignmentJustifyItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentJustifyItem1.Id = 28
			Me.toggleParagraphAlignmentJustifyItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J))
			Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
			' 
			' toggleNumberingListItem1
			' 
			Me.toggleNumberingListItem1.Glyph = (CType(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image))
			Me.toggleNumberingListItem1.Id = 29
			Me.toggleNumberingListItem1.LargeGlyph = (CType(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
			' 
			' toggleBulletedListItem1
			' 
			Me.toggleBulletedListItem1.Glyph = (CType(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image))
			Me.toggleBulletedListItem1.Id = 30
			Me.toggleBulletedListItem1.LargeGlyph = (CType(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
			' 
			' toggleMultiLevelListItem1
			' 
			Me.toggleMultiLevelListItem1.Glyph = (CType(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image))
			Me.toggleMultiLevelListItem1.Id = 31
			Me.toggleMultiLevelListItem1.LargeGlyph = (CType(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
			' 
			' decreaseIndentItem1
			' 
			Me.decreaseIndentItem1.Glyph = (CType(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image))
			Me.decreaseIndentItem1.Id = 32
			Me.decreaseIndentItem1.LargeGlyph = (CType(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image))
			Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
			' 
			' increaseIndentItem1
			' 
			Me.increaseIndentItem1.Glyph = (CType(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image))
			Me.increaseIndentItem1.Id = 33
			Me.increaseIndentItem1.LargeGlyph = (CType(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image))
			Me.increaseIndentItem1.Name = "increaseIndentItem1"
			' 
			' toggleShowWhitespaceItem1
			' 
			Me.toggleShowWhitespaceItem1.Glyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image))
			Me.toggleShowWhitespaceItem1.Id = 34
			Me.toggleShowWhitespaceItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.D8))
			Me.toggleShowWhitespaceItem1.LargeGlyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
			' 
			' showParagraphFormItem1
			' 
			Me.showParagraphFormItem1.Glyph = (CType(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image))
			Me.showParagraphFormItem1.Id = 35
			Me.showParagraphFormItem1.LargeGlyph = (CType(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
			' 
			' insertMergeFieldItem1
			' 
			Me.insertMergeFieldItem1.Glyph = (CType(resources.GetObject("insertMergeFieldItem1.Glyph"), System.Drawing.Image))
			Me.insertMergeFieldItem1.Id = 36
			Me.insertMergeFieldItem1.LargeGlyph = (CType(resources.GetObject("insertMergeFieldItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
			' 
			' showAllFieldCodesItem1
			' 
			Me.showAllFieldCodesItem1.Glyph = (CType(resources.GetObject("showAllFieldCodesItem1.Glyph"), System.Drawing.Image))
			Me.showAllFieldCodesItem1.Id = 37
			Me.showAllFieldCodesItem1.LargeGlyph = (CType(resources.GetObject("showAllFieldCodesItem1.LargeGlyph"), System.Drawing.Image))
			Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
			' 
			' showAllFieldResultsItem1
			' 
			Me.showAllFieldResultsItem1.Glyph = (CType(resources.GetObject("showAllFieldResultsItem1.Glyph"), System.Drawing.Image))
			Me.showAllFieldResultsItem1.Id = 38
			Me.showAllFieldResultsItem1.LargeGlyph = (CType(resources.GetObject("showAllFieldResultsItem1.LargeGlyph"), System.Drawing.Image))
			Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
			' 
			' toggleViewMergedDataItem1
			' 
			Me.toggleViewMergedDataItem1.Glyph = (CType(resources.GetObject("toggleViewMergedDataItem1.Glyph"), System.Drawing.Image))
			Me.toggleViewMergedDataItem1.Id = 39
			Me.toggleViewMergedDataItem1.LargeGlyph = (CType(resources.GetObject("toggleViewMergedDataItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
			' 
			' mergeToNewDocumentItem
			' 
			Me.mergeToNewDocumentItem.Caption = "Merge to New Document"
			Me.mergeToNewDocumentItem.Id = 40
			Me.mergeToNewDocumentItem.Name = "mergeToNewDocumentItem"
'			Me.mergeToNewDocumentItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.mergeToNewDocumentItem_ItemClick);
			' 
			' mergeToFileItem
			' 
			Me.mergeToFileItem.Caption = "Merge to File"
			Me.mergeToFileItem.Id = 41
			Me.mergeToFileItem.Name = "mergeToFileItem"
'			Me.mergeToFileItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.mergeToFileItem_ItemClick);
			' 
			' changeStyleItem1
			' 
			Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
			Me.changeStyleItem1.Id = 2
			Me.changeStyleItem1.Name = "changeStyleItem1"
			' 
			' repositoryItemRichEditStyleEdit1
			' 
			Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
			Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl1
			Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
			' 
			' insertIfFieldItem1
			' 
			Me.insertIfFieldItem1.Caption = "Insert IF Field"
			Me.insertIfFieldItem1.Id = 5
			Me.insertIfFieldItem1.Name = "insertIfFieldItem1"
'			Me.insertIfFieldItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.insertFieldItem1_ItemClick);
			' 
			' homeRibbonPage1
			' 
			Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.fontRibbonPageGroup1})
			Me.homeRibbonPage1.Name = "homeRibbonPage1"
			' 
			' commonRibbonPageGroup1
			' 
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.undoItem1)
			Me.commonRibbonPageGroup1.ItemLinks.Add(Me.redoItem1)
			Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
			Me.commonRibbonPageGroup1.RichEditControl = Me.richEditControl1
			' 
			' fontRibbonPageGroup1
			' 
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontNameItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontColorItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeFontBackColorItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontBoldItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.toggleFontItalicItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1)
			Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1)
			Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
			Me.fontRibbonPageGroup1.RichEditControl = Me.richEditControl1
			' 
			' mailingsRibbonPage1
			' 
			Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1})
			Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
			' 
			' mailMergeRibbonPageGroup1
			' 
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertIfFieldItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeToNewDocumentItem)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeToFileItem)
			Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
			Me.mailMergeRibbonPageGroup1.RichEditControl = Me.richEditControl1
			' 
			' ribbonStatusBar1
			' 
			Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 542)
			Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
			Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
			Me.ribbonStatusBar1.Size = New System.Drawing.Size(792, 24)
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.richEditControl2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(785, 372)
			Me.xtraTabPage2.Text = "xtraTabPage2"
			' 
			' richEditControl2
			' 
			Me.richEditControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl2.Location = New System.Drawing.Point(0, 0)
			Me.richEditControl2.MenuManager = Me.ribbonControl1
			Me.richEditControl2.Name = "richEditControl2"
			Me.richEditControl2.Size = New System.Drawing.Size(785, 372)
			Me.richEditControl2.TabIndex = 1
			Me.richEditControl2.Text = "richEditControl2"
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
			Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
			Me.richEditBarController1.BarItems.Add(Me.printItem1)
			Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
			Me.richEditBarController1.BarItems.Add(Me.undoItem1)
			Me.richEditBarController1.BarItems.Add(Me.redoItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
			Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
			Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
			Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
			Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
			Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
			Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
			Me.richEditBarController1.RichEditControl = Me.richEditControl1
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontNameItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontSizeItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontColorItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.changeFontBackColorItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.fontSizeIncreaseItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.fontSizeDecreaseItem1)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.clearFormattingItem1)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "Font"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.fileNewItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.fileOpenItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.fileSaveItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.fileSaveAsItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.quickPrintItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.printItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.undoItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.redoItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "Common"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(792, 566)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Controls.Add(Me.ribbonStatusBar1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
		Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
		Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
		Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
		Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
		Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
		Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
		Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
		Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
		Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
		Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
		Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
		Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
		Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
		Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
		Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
		Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
		Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
		Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
		Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
		Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
		Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
		Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
		Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
		Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
		Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
		Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
		Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
		Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
		Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
		Private richEditControl2 As DevExpress.XtraRichEdit.RichEditControl
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private WithEvents mergeToNewDocumentItem As DevExpress.XtraBars.BarButtonItem
		Private WithEvents mergeToFileItem As DevExpress.XtraBars.BarButtonItem
		Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
		Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
		Private commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
		Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
		Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
		Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
		Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
		Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
		Private WithEvents insertIfFieldItem1 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

