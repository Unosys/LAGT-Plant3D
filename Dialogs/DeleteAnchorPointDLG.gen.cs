// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Delete Anchor Point|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class DeleteAnchorPointDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Image MainInstructionIconIMG;
        public  StaticText WouldYouLikeToST;
        public  StaticText DeletingTheSelectedAnchorST;
        public  PushButton DeleteTheAnchorPointPB;
        public  PushButton DoNotDeleteThePB;
        public  PushButton CancelPB;
        public  TitleBar DeleteAnchorPointCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DeleteAnchorPointDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Delete Anchor Point|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            WouldYouLikeToST = new StaticText()
            {
                Tag = "[Pane]Delete Anchor Point|$Window|#1/[StaticText]Would you like to delete the selected anchor point?|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WouldYouLikeToST);

            DeletingTheSelectedAnchorST = new StaticText()
            {
                Tag = "[Pane]Delete Anchor Point|$Window|#1/[StaticText]Deleting the selected anchor point will remove it from the list, and the specified piping component will no longer be dimensioned based on it*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletingTheSelectedAnchorST);

            DeleteTheAnchorPointPB = new PushButton()
            {
                Tag = "[Pane]Delete Anchor Point|$Window|#1/[PushButton]Delete the anchor point|$CommandLink_0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteTheAnchorPointPB);

            DoNotDeleteThePB = new PushButton()
            {
                Tag = "[Pane]Delete Anchor Point|$Window|#1/[PushButton]Do not delete the anchor point|$CommandLink_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotDeleteThePB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Delete Anchor Point|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DeleteAnchorPointCTL = new TitleBar()
            {
                Tag = "[TitleBar]Delete Anchor Point|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteAnchorPointCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Delete Anchor Point|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
