// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Audit Project|$AuditDlg")]
    public partial class Plant3DAuditProjectDLG_Collaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox CheckBox1CK;
        public  CheckBox CheckBox2CK;
        public  PushButton CancelPB;
        public  PushButton AuditPB;
        public  PushButton ClosePB;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public Plant3DAuditProjectDLG_Collaboration()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CheckBox1CK = new CheckBox()
            {
                Tag = "[CustomWin]$StartPage|#1/[CheckBox]$OptionCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[CustomWin]$StartPage|#1/[CheckBox]$OptionCheckBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CancelPB = new PushButton()
            {
                Tag = "[CustomWin]$StartPage|#1/[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            AuditPB = new PushButton()
            {
                Tag = "[CustomWin]$StartPage|#1/[PushButton]Audit|$AuditButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuditPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Close2PB = new PushButton()
            {
                Tag = "[CustomWin]$SuccessPage|#1/[PushButton]Close|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
