// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]PandIDValidationSettingsDLG")]
    public partial class PandIDPandIDValidationSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnOK;
        public  TreeView ReportTheFollowingConditionsTV;
        public  TreeViewItem PIDObjectsTVI;
        public  TreeViewItem threeDPipingTVI;
        public  TreeViewItem BaseAutoCADObjectsTVI;
        public  TreeViewItem threeDModelToPIDTVI;

        partial void OnInitialize();

        public PandIDPandIDValidationSettingsDLG()
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
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            ReportTheFollowingConditionsTV = new TreeView()
            {
                Tag = "[GroupBox]$gbErrorReporting|#1/[TreeView]$treeView2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportTheFollowingConditionsTV);

            PIDObjectsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$gbErrorReporting|#1/[TreeView]$treeView2|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectsTVI);

            threeDPipingTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$gbErrorReporting|#1/[TreeView]$treeView2|#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(threeDPipingTVI);

            BaseAutoCADObjectsTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$gbErrorReporting|#1/[TreeView]$treeView2|#1/[TreeViewItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BaseAutoCADObjectsTVI);

            threeDModelToPIDTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$gbErrorReporting|#1/[TreeView]$treeView2|#1/[TreeViewItem]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(threeDModelToPIDTVI);
        }
    }
}
