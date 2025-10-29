// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Check Out|$frmVaultGetCheckOut", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class CollaborationCheckOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton PushButtonPB;
        public  PushButton CheckOutPB;
        public  GroupBox DetailsGB;
        public  GroupBox GroupBoxGB;
        public  TreeView TreeViewTV;
        public  TreeViewItem ImperialENU03TVI;
        public  TreeViewItem PIDDrawingsTVI;
        public  TreeViewItem Plant3DDrawingsTVI;
        public  TreeViewItem Draw2TVI;
        public  TreeViewItem PipeSpecsTVI;
        public  TreeViewItem RelatedFilesTVI;
        public  TreeViewItem OrthographicDrawingsTVI;
        public  TreeViewItem IsometricDrawingsTVI;
        public  TreeViewItem CheckANSIB1TVI;
        public  TreeViewItem CheckANSIB2TVI;
        public  TreeViewItem CheckANSIB3TVI;
        public  TreeViewItem CheckANSIB4TVI;
        public  TreeViewItem CheckANSIB5TVI;
        public  TreeViewItem CheckANSIB6TVI;
        public  StaticText zeroFiles0ST;
        public  StaticText SelectFilesToCheckST;
        public  PushButton SelectFilesToCheckPB;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  TitleBar CheckOutCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CollaborationCheckOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PushButtonPB = new PushButton()
            {
                Tag = "[PushButton]$m_btnDownArrow|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            CheckOutPB = new PushButton()
            {
                Tag = "[PushButton]Check Out|$m_btnCheckOut|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutPB);

            DetailsGB = new GroupBox()
            {
                Tag = "[GroupBox]Details|$groupBox4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailsGB);

            GroupBoxGB = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxGB);

            TreeViewTV = new TreeView()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            ImperialENU03TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialENU03TVI);

            PIDDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsTVI);

            Plant3DDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Plant 3D Drawings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDrawingsTVI);

            Draw2TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Plant 3D Drawings|#2/[TreeViewItem]Draw2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Draw2TVI);

            PipeSpecsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Pipe Specs|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecsTVI);

            RelatedFilesTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Related Files|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RelatedFilesTVI);

            OrthographicDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Orthographic Drawings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicDrawingsTVI);

            IsometricDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Isometric Drawings|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDrawingsTVI);

            CheckANSIB1TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Isometric Drawings|#6/[TreeViewItem]Check_ANSI-B[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIB1TVI);

            CheckANSIB2TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Isometric Drawings|#6/[TreeViewItem]Check_ANSI-B[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIB2TVI);

            CheckANSIB3TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Isometric Drawings|#6/[TreeViewItem]Check_ANSI-B[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIB3TVI);

            CheckANSIB4TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Isometric Drawings|#6/[TreeViewItem]Check_ANSI-B[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIB4TVI);

            CheckANSIB5TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Isometric Drawings|#6/[TreeViewItem]Check_ANSI-B[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIB5TVI);

            CheckANSIB6TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Isometric Drawings|#6/[TreeViewItem]Check_ANSI-B[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIB6TVI);

            zeroFiles0ST = new StaticText()
            {
                Tag = "[StaticText]0 files *|$m_labelCheckFilesInfo|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zeroFiles0ST);

            SelectFilesToCheckST = new StaticText()
            {
                Tag = "[StaticText]Select files to check out:|$m_labelSelectDrawings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFilesToCheckST);

            SelectFilesToCheckPB = new PushButton()
            {
                Tag = "[PushButton]Select files to check out:|$m_btnComments|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFilesToCheckPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CheckOutCTL = new TitleBar()
            {
                Tag = "[TitleBar]Check Out|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Check Out|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultGetCheckOut|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Check Out|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultGetCheckOut|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Check Out|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Check Out|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Check Out|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
