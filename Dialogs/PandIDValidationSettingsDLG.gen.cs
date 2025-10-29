// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]P&ID Validation Settings", Parent = typeof(Plant3D))]
    public partial class PandIDValidationSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;
        public  StaticText Description;
        public  StaticText SizeDiscrepanciesBetweenCom;
        public  StaticText ErrorReporting;
        public  StaticText ReportTheFollowingCondition1;
        public  TreeView ReportTheFollowingCondition2;

        partial void OnInitialize();

        public PandIDValidationSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Help = new PushButton()
            {
                Tag = "[PushButton]#3|$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Description = new StaticText()
            {
                Tag = "[StaticText]#2|$gbDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Description);

            SizeDiscrepanciesBetweenCom = new StaticText()
            {
                Tag = "[StaticText]#1|$lblDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeDiscrepanciesBetweenCom);

            ErrorReporting = new StaticText()
            {
                Tag = "[StaticText]#1|$gbErrorReporting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ErrorReporting);

            ReportTheFollowingCondition1 = new StaticText()
            {
                Tag = "[StaticText]#1|$lblErrorReporting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportTheFollowingCondition1);

            ReportTheFollowingCondition2 = new TreeView()
            {
                Tag = "[TreeView]#1|$treeView2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportTheFollowingCondition2);
        }
    }
}
