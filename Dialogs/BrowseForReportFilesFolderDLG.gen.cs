// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Browse For Folder|#1", Parent = typeof(SettingsDLG), GUIType = GuiType.UIA)]
    public partial class BrowseForReportFilesFolderDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText SelectReportFilesFolderST;
        public  Pane SelectReportFilesFolderPANE;
        public  TreeView SelectReportFilesFolderTV;
        public  TreeViewItem DesktopTVI;
        public  TreeViewItem LibrariesTVI;
        public  TreeViewItem AdministratorTVI;
        public  TreeViewItem ComputerTVI;
        public  TreeViewItem NetworkTVI;
        public  TreeViewItem ControlPanelTVI;
        public  TreeViewItem RecycleBinTVI;
        public  PushButton MakeNewFolderPB;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  Pane PanePANE;
        public  TitleBar BrowseForFolderCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public BrowseForReportFilesFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SelectReportFilesFolderST = new StaticText()
            {
                Tag = "[StaticText]Select report files folder*|$14146|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectReportFilesFolderST);

            SelectReportFilesFolderPANE = new Pane()
            {
                Tag = "[Pane]Select report files folder*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectReportFilesFolderPANE);

            SelectReportFilesFolderTV = new TreeView()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectReportFilesFolderTV);

            DesktopTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1/[TreeViewItem]Desktop|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesktopTVI);

            LibrariesTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Libraries|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LibrariesTVI);

            AdministratorTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Administrator|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdministratorTVI);

            ComputerTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Computer|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComputerTVI);

            NetworkTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Network|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NetworkTVI);

            ControlPanelTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Control Panel|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ControlPanelTVI);

            RecycleBinTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select report files folder*|#1/[TreeView]Select report files folder*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Recycle Bin|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecycleBinTVI);

            MakeNewFolderPB = new PushButton()
            {
                Tag = "[PushButton]Make New Folder|$14150|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MakeNewFolderPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$14151|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            BrowseForFolderCTL = new TitleBar()
            {
                Tag = "[TitleBar]Browse For Folder|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowseForFolderCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Browse For Folder|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
