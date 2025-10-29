// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Spec Update Available|#1", Parent = typeof(Plant3D))]
    public partial class SpecUpdateAvailableDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton UpdatePipeSpecsRecommendedPB;
        public  PushButton AskMeLaterPB;

        partial void OnInitialize();

        public SpecUpdateAvailableDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            UpdatePipeSpecsRecommendedPB = new PushButton()
            {
                Tag = "[Pane]Spec Update Available|$Window|#1/[PushButton]Update pipe specs (Recommended)|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdatePipeSpecsRecommendedPB);

            AskMeLaterPB = new PushButton()
            {
                Tag = "[Pane]Spec Update Available|$Window|#1/[PushButton]Ask me later|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AskMeLaterPB);
        }
    }
}
