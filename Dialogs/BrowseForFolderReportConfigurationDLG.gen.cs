// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Browse For Folder Report Configuration", Parent = typeof(ReportConfigurationDLG))]
    public partial class BrowseForFolderReportConfigurationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton MakeNewFolder;
        public  PushButton OK;
        public  StaticText SelectReportFilesFolder;
        public  ScrollBar SelectReportFilesFolderHorizontalScrollBar;
        public  TreeView SelectReportFilesFolderTree;
        public  CustomWin SHBrowseForFolderShellNameSpaceControl;

        partial void OnInitialize();

        public BrowseForFolderReportConfigurationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            MakeNewFolder = new PushButton()
            {
                Tag = "[PushButton]$14150",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MakeNewFolder);

            OK = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            SelectReportFilesFolder = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectReportFilesFolder);

            SelectReportFilesFolderHorizontalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$Select report files folder.",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectReportFilesFolderHorizontalScrollBar);

            SelectReportFilesFolderTree = new TreeView()
            {
                Tag = "[TreeView]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectReportFilesFolderTree);

            SHBrowseForFolderShellNameSpaceControl = new CustomWin()
            {
                Tag = "[CustomWin]$SHBrowseForFolder ShellNameSpace Control",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SHBrowseForFolderShellNameSpaceControl);
        }
    }
}
