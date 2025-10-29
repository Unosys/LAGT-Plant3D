// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(Pane))]
    public partial class PandIDSelectBlockErrorMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  Image ImageIMG;
        public  StaticText TheProjectFileAlreadyST;
        public  TitleBar ErrorCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDSelectBlockErrorMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]Yes|$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]No|$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            TheProjectFileAlreadyST = new StaticText()
            {
                Tag = "[StaticText]The project file already contains a block definition*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheProjectFileAlreadyST);

            ErrorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Error|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ErrorCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Error|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
