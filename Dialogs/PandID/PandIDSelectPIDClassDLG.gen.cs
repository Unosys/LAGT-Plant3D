// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]SelectPIDClassDLG")]
    public partial class PandIDSelectPIDClassDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnOK;
        public  TreeView ClassTreeView;

        partial void OnInitialize();

        public PandIDSelectPIDClassDLG()
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

            BtnOK = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$panel2|#2/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            ClassTreeView = new TreeView()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$panel1|#1/[TreeView]$classTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassTreeView);
        }
    }
}
