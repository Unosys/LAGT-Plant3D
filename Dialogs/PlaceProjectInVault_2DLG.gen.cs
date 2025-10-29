// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Place Project in Vault", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class PlaceProjectInVault_2DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  Image ImageIMG;
        public  StaticText TheSelectedWorkspaceFolderST;
        public  TitleBar PlaceProjectInVaultCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PlaceProjectInVault_2DLG()
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

            TheSelectedWorkspaceFolderST = new StaticText()
            {
                Tag = "[StaticText]The selected workspace folder should be on your computer local drive*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheSelectedWorkspaceFolderST);

            PlaceProjectInVaultCTL = new TitleBar()
            {
                Tag = "[TitleBar]Place Project in Vault|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlaceProjectInVaultCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Place Project in Vault|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
