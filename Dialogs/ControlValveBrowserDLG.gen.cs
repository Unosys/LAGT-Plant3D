// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ControlValveBrowserDlg", Parent = typeof(Plant3D))]
    public partial class ControlValveBrowserDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOk;
        public  GroupBox GroupBoxActuator;
        public  GroupBox GroupBoxBody;
        public  ScrollBar HorizontalScrollBar;
        public  GroupBox TableLayoutPanel;
        public  TreeView TreeViewActuator;
        public  TreeView TreeViewBody;
        public  ScrollBar VerticalScrollBar;
        public  ScrollBar VerticalScrollBar2;

        partial void OnInitialize();

        public ControlValveBrowserDLG()
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

            GroupBoxActuator = new GroupBox()
            {
                Tag = "[GroupBox]$groupBoxActuator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxActuator);

            GroupBoxBody = new GroupBox()
            {
                Tag = "[GroupBox]$groupBoxBody",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxBody);

            HorizontalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$treeViewActuator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar);

            TableLayoutPanel = new GroupBox()
            {
                Tag = "[GroupBox]$tableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel);

            TreeViewActuator = new TreeView()
            {
                Tag = "[TreeView]$treeViewActuator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewActuator);

            TreeViewBody = new TreeView()
            {
                Tag = "[TreeView]$treeViewBody",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewBody);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$treeViewActuator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);

            VerticalScrollBar2 = new ScrollBar()
            {
                Tag = "[ScrollBar]$treeViewBody",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar2);
        }
    }
}
