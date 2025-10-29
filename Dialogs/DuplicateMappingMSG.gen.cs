// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Duplicate Mapping")]
    public partial class DuplicateMappingMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OverwriteTheMappingPB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DuplicateMappingMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OverwriteTheMappingPB = new PushButton()
            {
                Tag = "[Pane]Duplicate Mapping|$Window|#1/[PushButton]Overwrite the mapping|$CommandButton_1313|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverwriteTheMappingPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Duplicate Mapping|$Window|#1/[PushButton]Cancel|$CommandButton_1315|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Duplicate Mapping|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
