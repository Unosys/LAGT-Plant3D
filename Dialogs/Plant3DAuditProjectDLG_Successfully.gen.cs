// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Audit Project|$AuditDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class Plant3DAuditProjectDLG_Successfully : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close2PB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public Plant3DAuditProjectDLG_Successfully()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close2PB = new PushButton()
            {
                Tag = "[CustomWin]$SuccessPage|#1/[PushButton]Close|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

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
