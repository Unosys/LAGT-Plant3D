// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D - Delete Shared List")]
    public partial class Plant3DDeleteSharedListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton DeleteTETSFromBothPB;
        public  PushButton StopSharingTETSPB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public Plant3DDeleteSharedListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DeleteTETSFromBothPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Delete ?TETS? from both P*|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteTETSFromBothPB);

            StopSharingTETSPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Stop sharing ?TETS?|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StopSharingTETSPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
