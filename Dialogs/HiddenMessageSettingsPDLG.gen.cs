// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Hidden Message Settings|$Window_1")]
    public partial class HiddenMessageSettingsPDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TextField SearchTF;
        public  Pane PanePANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem AutoCADTVI;
        public  PushButton PushButton1PB;
        public  CheckBox CheckBox1CK;
        public  TreeViewItem AutoCADPlant3DTVI;
        public  PushButton PushButton2PB;
        public  CheckBox CheckBox2CK;
        public  TreeViewItem DeleteWSFilesTVI;
        public  CheckBox CheckBox3CK;
        public  StaticText DeleteWorkspaceFilesST;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public HiddenMessageSettingsPDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SearchTF = new TextField()
            {
                Tag = "[TextField]Search:|$mSearchBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTF);

            PanePANE = new Pane()
            {
                Tag = "[TextField]Search:|$mSearchBox/[Pane]$PART_ContentHost",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[TreeView]$PART_TreeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            AutoCADTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADTVI);

            PushButton1PB = new PushButton()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[PushButton]$Expander",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            AutoCADPlant3DTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[TreeViewItem]AutoCAD Plant 3D|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADPlant3DTVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[TreeViewItem]AutoCAD Plant 3D|#1/[PushButton]$Expander",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[TreeViewItem]AutoCAD Plant 3D|#1/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            DeleteWSFilesTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[TreeViewItem]AutoCAD Plant 3D|#1/[TreeViewItem]Delete Workspace Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteWSFilesTVI);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[TreeViewItem]AutoCAD Plant 3D|#1/[TreeViewItem]Delete Workspace Files|#1/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

            DeleteWorkspaceFilesST = new StaticText()
            {
                Tag = "[TreeView]$PART_TreeView/[TreeViewItem]AutoCAD|#1/[TreeViewItem]AutoCAD Plant 3D|#1/[TreeViewItem]Delete Workspace Files|#1/[StaticText]Delete Workspace Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteWorkspaceFilesST);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$Button_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Button_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$Button_3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Hidden Message Settings|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
