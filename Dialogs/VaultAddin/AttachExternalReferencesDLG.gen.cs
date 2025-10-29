// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Attach External References|$frmVaultAttachReferences", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AttachExternalReferencesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText zeroFiles0ST;
        public  StaticText SelectTheDrawingsToST;
        public  GroupBox DetailsGB;
        public  GroupBox PreviewGB;
        public  GroupBox SelectTheDrawingsTo1GB;
        public  CheckBox PromptForInsertionPointCK;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton AttachPB;
        public  GroupBox SelectTheDrawingsTo2GB;
        public  TextField TextFieldTF;
        public  TreeView TreeViewTV;
        public  TreeViewItem Proj2TVI;
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

        public AttachExternalReferencesDLG()
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
                Tag = "[GroupBox]Details|$groupBox4|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailsGB);

            PreviewGB = new GroupBox()
            {
                Tag = "[GroupBox]Preview|$groupBox3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewGB);

            SelectTheDrawingsTo1GB = new GroupBox()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[1]|$groupBox2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheDrawingsTo1GB);

            PromptForInsertionPointCK = new CheckBox()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[1]|$groupBox2|#3/[CheckBox]Prompt for insertion point, rotation, and scale |$m_cbCLIPrompt|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PromptForInsertionPointCK);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[1]|$groupBox2|#3/[RadioButton]$m_radioOverlay|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[1]|$groupBox2|#3/[RadioButton]$m_radioAttach|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

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

            SelectTheDrawingsTo2GB = new GroupBox()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheDrawingsTo2GB);

            TextFieldTF = new TextField()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2/[TextField]$m_textBoxSearch|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            TreeViewTV = new TreeView()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            Proj2TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2/[TreeView]$m_treeView|#1/[TreeViewItem]Proj2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Proj2TVI);

            PIDDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2/[TreeView]$m_treeView|#1/[TreeViewItem]Proj2|#1/[TreeViewItem]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsTVI);

            Plant3DDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2/[TreeView]$m_treeView|#1/[TreeViewItem]Proj2|#1/[TreeViewItem]Plant 3D Drawings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDrawingsTVI);

            OrthographicDrawingsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2/[TreeView]$m_treeView|#1/[TreeViewItem]Proj2|#1/[TreeViewItem]Orthographic Drawings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicDrawingsTVI);

            RelatedFilesTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Select the drawings to be referenced:[2]|$groupBox1|#2/[TreeView]$m_treeView|#1/[TreeViewItem]Proj2|#1/[TreeViewItem]Related Files|#4",
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
