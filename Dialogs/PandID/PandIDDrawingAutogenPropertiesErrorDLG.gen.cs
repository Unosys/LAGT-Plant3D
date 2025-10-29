// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(Pane))]
    public partial class PandIDDrawingAutogenPropertiesErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  Image ImageIMG;
        public  StaticText PleaseEnterANumberST;
        public  TitleBar ErrorCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDDrawingAutogenPropertiesErrorDLG()
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

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            PleaseEnterANumberST = new StaticText()
            {
                Tag = "[StaticText]Please enter a number*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseEnterANumberST);

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
