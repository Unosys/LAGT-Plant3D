// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Add Joint|$AddModifySimpleJointDlg")]
    public partial class AddJointDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton AddPropertyPB;
        public  PushButton SpecFilterPB;
        public  CheckBox BELL1CK;
        public  CheckBox BV1CK;
        public  ListBox FastenersLB;
        public  ListBox End2LB;
        public  ListBox End1LB;
        public  CheckBox GasketCK;
        public  PushButton DeletePB;
        public  PushButton CancelPB;
        public  PushButton AddPB;

        partial void OnInitialize();

        public AddJointDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddPropertyPB = new PushButton()
            {
                Tag = "[GroupBox]$grpboxConn|#1/[PushButton]$btnFindAdd1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyPB);

            SpecFilterPB = new PushButton()
            {
                Tag = "[GroupBox]Fasteners|$grpboxPropMatches|#2/[PushButton]$btnFastenerFilter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecFilterPB);

            BELL1CK = new CheckBox()
            {
                Tag = "[GroupBox]$grpboxConn|#1/[Pane]$splitContainer1|#1/[Pane]#1/[ListBox]$clstboxEnd1|#1/[CheckBox]BELL|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BELL1CK);

            BV1CK = new CheckBox()
            {
                Tag = "[GroupBox]$grpboxConn|#1/[Pane]$splitContainer1|#1/[Pane]#1/[ListBox]$clstboxEnd1|#1/[CheckBox]BV|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BV1CK);

            FastenersLB = new ListBox()
            {
                Tag = "[GroupBox]$grpboxPropMatches|#2/[ListBox]$clstboxFasteners|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FastenersLB);

            End2LB = new ListBox()
            {
                Tag = "[GroupBox]Connection settings|$grpboxConn|#1/[Pane]$splitContainer1|#1/[Pane]#2/[ListBox]End 2:|$clstboxEnd2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End2LB);

            End1LB = new ListBox()
            {
                Tag = "[GroupBox]Connection settings|$grpboxConn|#1/[Pane]$splitContainer1|#1/[Pane]#1/[ListBox]End 1:|$clstboxEnd1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End1LB);

            GasketCK = new CheckBox()
            {
                Tag = "[GroupBox]Fasteners|$grpboxPropMatches|#2/[ListBox]$clstboxFasteners|#1/[CheckBox]Gasket|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GasketCK);

            DeletePB = new PushButton()
            {
                Tag = "[GroupBox]$grpboxConn|#1/[PushButton]Delete|$btnDelete1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]Add|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);
        }
    }
}
