// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Network Path Not Found|#1", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class NetworkPathNotFoundP3DDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton RemovePathsAndContinuePB;
        public  PushButton DontRemovePathsPB;
        public  PushButton ShowDetailsPB;
        public  CheckBox AlwaysApplySelectedActionCK;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public NetworkPathNotFoundP3DDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            RemovePathsAndContinuePB = new PushButton()
            {
                Tag = "[Pane]Network Path Not Found|$Window/[PushButton]Remove paths and continue*|$CommandLink_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePathsAndContinuePB);

            DontRemovePathsPB = new PushButton()
            {
                Tag = "[Pane]Network Path Not Found|$Window/[PushButton]Don't remove paths*|$CommandLink_1002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DontRemovePathsPB);

            ShowDetailsPB = new PushButton()
            {
                Tag = "[Pane]Network Path Not Found|$Window/[PushButton]Show details|$ExpandoButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsPB);

            AlwaysApplySelectedActionCK = new CheckBox()
            {
                Tag = "[Pane]Network Path Not Found|$Window/[CheckBox]Always apply selected action|$VerificationCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlwaysApplySelectedActionCK);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Network Path Not Found|$Window/[PushButton]Cancel|$CommandButton_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
