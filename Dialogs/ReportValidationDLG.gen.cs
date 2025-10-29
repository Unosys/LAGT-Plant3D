// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Report Validation", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class ReportValidationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ContinueWithReportGenerationPB;
        public  PushButton ReturnToCreateReportPB;
        public  PushButton ReviewMissingWeightLogPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public ReportValidationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ContinueWithReportGenerationPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContinueWithReportGenerationPB);

            ReturnToCreateReportPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReturnToCreateReportPB);

            ReviewMissingWeightLogPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1003|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReviewMissingWeightLogPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandButton_2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
