// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Replace Existing Files")]
    public partial class ReplaceExistingFilesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ExportAndReplacePB;
        public  PushButton DontReplacePB;
        public  PushButton ExportButKeepBothPB;
        public  CheckBox DoThisForTheCK;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public ReplaceExistingFilesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ExportAndReplacePB = new PushButton()
            {
                Tag = "[Pane]Replace Existing Files|$Window|#1/[PushButton]Export and Replace|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndReplacePB);

            DontReplacePB = new PushButton()
            {
                Tag = "[Pane]Replace Existing Files|$Window|#1/[PushButton]Don't Replace|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DontReplacePB);

            ExportButKeepBothPB = new PushButton()
            {
                Tag = "[Pane]Replace Existing Files|$Window|#1/[PushButton]Export, but keep both files|$CommandLink_1003|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportButKeepBothPB);

            DoThisForTheCK = new CheckBox()
            {
                Tag = "[Pane]Replace Existing Files|$Window|#1/[CheckBox]Do this for the next 0 conflicts|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoThisForTheCK);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Replace Existing Files|$Window|#1/[PushButton]Cancel|$CommandButton_2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
