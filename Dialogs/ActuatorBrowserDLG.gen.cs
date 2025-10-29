// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ActuatorBrowserDLG", Parent = typeof(Plant3D))]
    public partial class ActuatorBrowserDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOk;
        public  GroupBox GroupBox;
        public  ScrollBar HorizontalScrollBar;
        public  TreeView TreeView;

        partial void OnInitialize();

        public ActuatorBrowserDLG()
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

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnOk = new PushButton()
            {
                Tag = "[PushButton]$btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOk);

            GroupBox = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox);

            HorizontalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar);

            TreeView = new TreeView()
            {
                Tag = "[TreeView]$treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeView);
        }
    }
}
