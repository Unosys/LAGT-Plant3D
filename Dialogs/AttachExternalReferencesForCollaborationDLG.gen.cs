// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmVaultAttachReferences", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AttachExternalReferencesForCollaborationDLG : Pane
    {
        public  StaticText zeroFiles0ST;
        public  StaticText SelectTheDrawingsToST;
        public  GroupBox DetailsGB;
        public  StaticText ImperialENU03ST;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton AttachPB;
        public  GroupBox SelectTheDrawingsToGB;
        public  TreeView TreeViewTV;
        public  TreeViewItem ImperialENU03TVI;
        public  TreeViewItem PIDDrawingsTVI;
        public  TreeViewItem Plant3DDrawingsTVI;
        public  TreeViewItem OrthographicDrawingsTVI;
        public  TreeViewItem RelatedFilesTVI;
        public  TitleBar AttachExternalReferencesCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AttachExternalReferencesForCollaborationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            zeroFiles0ST = new StaticText()
            {
                Tag = "[StaticText]0 files *|$m_labelCheckFilesInfo|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zeroFiles0ST);

            SelectTheDrawingsToST = new StaticText()
            {
                Tag = "[StaticText]Select the drawings to be referenced:|$m_labelSelectDrawings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheDrawingsToST);

            DetailsGB = new GroupBox()
            {
                Tag = "[GroupBox]Details|$groupBox4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailsGB);

            ImperialENU03ST = new StaticText()
            {
                Tag = "[GroupBox]Details|$groupBox4|#2/[StaticText]Imperial_ENU_03|$m_labelFileDetailInfo1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialENU03ST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            AttachPB = new PushButton()
            {
                Tag = "[PushButton]Attach|$m_btnAttach|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AttachPB);

            SelectTheDrawingsToGB = new GroupBox()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheDrawingsToGB);

            TreeViewTV = new TreeView()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:|$groupBox1|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            ImperialENU03TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:|$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialENU03TVI);

            PIDDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:|$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsTVI);

            Plant3DDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:|$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Plant 3D Drawings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDrawingsTVI);

            OrthographicDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:|$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Orthographic Drawings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicDrawingsTVI);

            RelatedFilesTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:|$groupBox1|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Imperial_ENU_03|#1/[TreeViewItem]Related Files|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RelatedFilesTVI);

            AttachExternalReferencesCTL = new TitleBar()
            {
                Tag = "[TitleBar]Attach External References|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AttachExternalReferencesCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Attach External References|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultAttachReferences|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Attach External References|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultAttachReferences|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Attach External References|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Attach External References|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Attach External References|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
