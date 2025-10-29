// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Export Report Data", Parent = typeof(Plant3D))]
    public partial class ExportReportDataDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Help;
        public  StaticText NoteEachSelectedReportIs;
        public  PushButton Cancel;
        public  PushButton Browse;
        public  PushButton Export;
        public  TextField ExportFile;
        public  StaticText ExportFileText;
        public  StaticText ReportsText;
        public  ListBox Reports;

        partial void OnInitialize();

        public ExportReportDataDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Help = new PushButton()
            {
                Tag = "[PushButton]#4|$m_btHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            NoteEachSelectedReportIs = new StaticText()
            {
                Tag = "[StaticText]#3|$m_lbNote",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoteEachSelectedReportIs);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$m_btCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Browse = new PushButton()
            {
                Tag = "[PushButton]$m_btBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Browse);

            Export = new PushButton()
            {
                Tag = "[PushButton]$m_btExport",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Export);

            ExportFile = new TextField()
            {
                Tag = "[TextField]#1|$m_tbFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportFile);

            ExportFileText = new StaticText()
            {
                Tag = "[StaticText]#2|$m_lbExportFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportFileText);

            ReportsText = new StaticText()
            {
                Tag = "[StaticText]#1|$m_lbReports",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsText);

            Reports = new ListBox()
            {
                Tag = "[ListBox]#1|$m_checkedListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Reports);
        }
    }
}
