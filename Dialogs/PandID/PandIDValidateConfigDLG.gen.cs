// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmDWGValidationSettings")]
    public partial class PandIDValidateConfigDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOK;
        public  GroupBox GbDescription;
        public  GroupBox GbErrorReporting;
        public  StaticText LblDescription;
        public  StaticText LblErrorReporting;
        public  TreeView TreeView2;

        partial void OnInitialize();

        public PandIDValidateConfigDLG()
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

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            GbDescription = new GroupBox()
            {
                Tag = "[GroupBox]$gbDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GbDescription);

            GbErrorReporting = new GroupBox()
            {
                Tag = "[GroupBox]$gbErrorReporting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GbErrorReporting);

            LblDescription = new StaticText()
            {
                Tag = "[StaticText]$lblDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblDescription);

            LblErrorReporting = new StaticText()
            {
                Tag = "[StaticText]$lblErrorReporting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblErrorReporting);

            TreeView2 = new TreeView()
            {
                Tag = "[TreeView]$treeView2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeView2);
        }
    }
}
