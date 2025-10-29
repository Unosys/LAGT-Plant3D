// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Audit Project|$AuditDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class Plant3DAuditProjectDLG_Piping : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton AuditPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public Plant3DAuditProjectDLG_Piping()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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
                Tag = "[TitleBar]Plant 3D - Audit Project|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
