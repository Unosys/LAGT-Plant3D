// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Piping - Pipe Spec Not Loaded|#1", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class PipingPipeSpecNotLoaded : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox DoNotShowThisCK;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PipingPipeSpecNotLoaded()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DoNotShowThisCK = new CheckBox()
            {
                Tag = "[Pane]$Window|#1/[CheckBox]$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotShowThisCK);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandButton_8|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
