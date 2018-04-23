Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraBars
Imports DevExpress.XtraTab

Namespace MailMerge
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			ribbonControl1.SelectedPage = mailingsRibbonPage1
			richEditControl1.LoadDocument("invitation.rtf", DocumentFormat.Rtf)

			richEditControl1.Options.MailMerge.DataSource = New SampleData()
			richEditControl1.Options.MailMerge.ViewMergedData = True
		End Sub

		Private Sub mergeToNewDocumentItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles mergeToNewDocumentItem.ItemClick
			richEditControl1.Document.MailMerge(richEditControl2.Document)
			xtraTabControl1.SelectedTabPageIndex = 1
		End Sub

		Private Sub xtraTabControl1_Selected(ByVal sender As Object, ByVal e As TabPageEventArgs) Handles xtraTabControl1.Selected
			Select Case e.PageIndex
				Case 0
					Me.richEditBarController1.RichEditControl = Me.richEditControl1
				Case 1
					Me.richEditBarController1.RichEditControl = Me.richEditControl2
			End Select
		End Sub

		Private Sub mergeToFileItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles mergeToFileItem.ItemClick
			Dim myMergeOptions As MailMergeOptions = richEditControl1.Document.CreateMailMergeOptions()
			myMergeOptions.DataSource = New SampleData()
			myMergeOptions.FirstRecordIndex = 1
			myMergeOptions.LastRecordIndex = 3
			myMergeOptions.MergeMode = MergeMode.NewSection

			Dim fileDialog As New SaveFileDialog()
			fileDialog.Filter = "RTF documents (*.rtf)|*.rtf|All files (*.*)|*.*"
			fileDialog.FilterIndex = 1
			fileDialog.RestoreDirectory = True

			fileDialog.ShowDialog()
			Dim fName As String = fileDialog.FileName
			If fName <> "" Then
				richEditControl1.Document.MailMerge(myMergeOptions, fileDialog.FileName, DocumentFormat.Rtf)
			End If
		End Sub

		Private Sub insertFieldItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles insertIfFieldItem1.ItemClick
			Dim document As Document = richEditControl1.Document
			document.Fields.Add(document.CaretPosition,"IF <value1> <operator> <value2> ""true"" ""false"" ")
		End Sub
	End Class
End Namespace