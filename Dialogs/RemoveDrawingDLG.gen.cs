// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Remove Drawings From Project", Parent = typeof(Plant3D))]
    public partial class RemoveDrawingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText TheSelectedDrawingAndST;
        public  PushButton RemoveTheDrawingFromPB;
        public  PushButton DoNotRemoveThePB;

        partial void OnInitialize();

        public RemoveDrawingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TheSelectedDrawingAndST = new StaticText()
            {
                Tag = "[Pane]$Window|#1/[StaticText]$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheSelectedDrawingAndST);

            RemoveTheDrawingFromPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveTheDrawingFromPB);

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
