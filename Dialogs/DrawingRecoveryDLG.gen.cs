// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Drawing Recovery|#1", Parent = typeof(Plant3D))]
    public partial class DrawingRecoveryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ShowDetailsPB;
        public  CheckBox DoNotShowMeCK;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DrawingRecoveryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ShowDetailsPB = new PushButton()
            {
                Tag = "[Pane]Drawing Recovery|$Window|#1/[PushButton]Show details|$ExpandoButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsPB);

            DoNotShowMeCK = new CheckBox()
            {
                Tag = "[Pane]$Window|#1/[CheckBox]$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotShowMeCK);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandButton_8|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
