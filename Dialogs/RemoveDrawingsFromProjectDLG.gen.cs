// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Remove Drawing* From Project", Parent = typeof(CustomWin))]
    public partial class RemoveDrawingsFromProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton RemoveTheDrawingsFromPB;
        public  PushButton DoNotRemoveThePB;

        partial void OnInitialize();

        public RemoveDrawingsFromProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RemoveTheDrawingsFromPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveTheDrawingsFromPB);

            DoNotRemoveThePB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotRemoveThePB);
        }
    }
}
