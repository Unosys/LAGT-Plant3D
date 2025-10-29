// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D - Import Selection List")]
    public partial class Plant3DImportSelectionListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton UpdateTheExistingStatusPB;
        public  PushButton ImportAsANewPB;
        public  CheckBox PerformMyCurrentChoiceCK;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public Plant3DImportSelectionListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            UpdateTheExistingStatusPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Import Selection List|$Window|#1/[PushButton]Update the existing 'Status' list*|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdateTheExistingStatusPB);

            ImportAsANewPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Import Selection List|$Window|#1/[PushButton]Import as a new 'Status_1' list*|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportAsANewPB);

            PerformMyCurrentChoiceCK = new CheckBox()
            {
                Tag = "[Pane]Plant 3D - Import Selection List|$Window|#1/[CheckBox]Perform my current choice for this import*|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PerformMyCurrentChoiceCK);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Import Selection List|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant 3D - Import Selection List|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
