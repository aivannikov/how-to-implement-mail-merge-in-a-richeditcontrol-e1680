using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraBars;
using DevExpress.XtraTab;

namespace MailMerge {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            ribbonControl1.SelectedPage = mailingsRibbonPage1;
            richEditControl1.LoadDocument("invitation.rtf", DocumentFormat.Rtf);

            richEditControl1.Options.MailMerge.DataSource = new SampleData();
            richEditControl1.Options.MailMerge.ViewMergedData = true;            
        }

        private void mergeToNewDocumentItem_ItemClick(object sender, ItemClickEventArgs e) {
            richEditControl1.Document.MailMerge(richEditControl2.Document);
            xtraTabControl1.SelectedTabPageIndex = 1;
        }
        
        private void xtraTabControl1_Selected(object sender, TabPageEventArgs e) {
            switch(e.PageIndex) {
                case 0:
                    this.richEditBarController1.RichEditControl = this.richEditControl1;
                    break;
                case 1:
                    this.richEditBarController1.RichEditControl = this.richEditControl2;
                    break;
            }
        }

        private void mergeToFileItem_ItemClick(object sender, ItemClickEventArgs e) {
            MailMergeOptions myMergeOptions = richEditControl1.Document.CreateMailMergeOptions();
            myMergeOptions.DataSource = new SampleData();
            myMergeOptions.FirstRecordIndex = 1;
            myMergeOptions.LastRecordIndex = 3;
            myMergeOptions.MergeMode = MergeMode.NewSection;

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "RTF documents (*.rtf)|*.rtf|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            fileDialog.ShowDialog();
            string fName = fileDialog.FileName;
            if (fName != "") 
                richEditControl1.Document.MailMerge(myMergeOptions,
                    fileDialog.FileName, DocumentFormat.Rtf);
        }

        private void insertFieldItem1_ItemClick(object sender, ItemClickEventArgs e) {
            Document document = richEditControl1.Document;
            document.Fields.Add(document.CaretPosition,"IF <value1> <operator> <value2> \"true\" \"false\" ");
        }
    }
}