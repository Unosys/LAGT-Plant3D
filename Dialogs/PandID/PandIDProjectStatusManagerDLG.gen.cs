// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]ProjectStatusManagerDLG", Parent = typeof(Pane))]
    public partial class PandIDProjectStatusManagerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnClose;
        public  PushButton BtnDelete;
        public  PushButton BtnHelp;
        public  PushButton BtnNew;
        public  PushButton BtnRename;
        public  GroupBox GroupBox1;
        public  StaticText LblCurrentProject;
        public  ListView LstStatus;
        public  ScrollBar VerticalScrollBar;

        partial void OnInitialize();

        public PandIDProjectStatusManagerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnClose = new PushButton()
            {
                Tag = "[PushButton]$btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnClose);

            BtnDelete = new PushButton()
            {
                Tag = "[PushButton]$btnDelete",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnDelete);

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnNew = new PushButton()
            {
                Tag = "[GroupBox]Defined statuses|$groupBox1|#1/[PushButton]New*|$btnNew|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnNew);

            BtnRename = new PushButton()
            {
                Tag = "[PushButton]$btnRename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnRename);

            GroupBox1 = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox1);

            LblCurrentProject = new StaticText()
            {
                Tag = "[StaticText]$lblCurrentProject",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblCurrentProject);

            LstStatus = new ListView()
            {
                Tag = "[ListView]$lstStatus",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LstStatus);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$lstStatus",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);
        }
    }
}
