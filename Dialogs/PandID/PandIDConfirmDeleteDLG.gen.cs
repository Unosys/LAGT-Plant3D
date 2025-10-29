// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Confirm Delete", Parent = typeof(Pane))]
    public partial class PandIDConfirmDeleteDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  Image ImageIMG;
        public  StaticText AreYouSureYouST;
        public  TitleBar ConfirmDeleteCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDConfirmDeleteDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YesPB = new PushButton()
            {
                Tag = "[PushButton]Yes|$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[PushButton]No|$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            AreYouSureYouST = new StaticText()
            {
                Tag = "[StaticText]Are you sure you want to delete this row?|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AreYouSureYouST);

            ConfirmDeleteCTL = new TitleBar()
            {
                Tag = "[TitleBar]Confirm Delete|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfirmDeleteCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Confirm Delete|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
