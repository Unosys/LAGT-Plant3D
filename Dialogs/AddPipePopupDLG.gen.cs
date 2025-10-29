// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]*Pip*|#1", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class AddPipePopupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox CheckBX;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AddPipePopupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CheckBX = new CheckBox()
            {
                Tag = "[Pane]$Window|#1/[CheckBox]$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBX);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]|$Window|#1/[PushButton]$CommandButton_8|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
