// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Duplicate Part family|$DuplicatePartFamilyWindow")]
    public partial class DuplicatePartfamilyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CreatePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public DuplicatePartfamilyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$CreateButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
