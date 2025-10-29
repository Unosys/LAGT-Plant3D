// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Missing Existing File", Parent = typeof(CreateSpecFromExistingSpecDLG1))]
    public partial class SpecUtilityMissingExistingFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  Image ImageIMG;
        public  StaticText MissingExistingFileDoST;
        public  TitleBar MissingExistingFileCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SpecUtilityMissingExistingFileDLG()
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

            MissingExistingFileDoST = new StaticText()
            {
                Tag = "[StaticText]Missing existing file*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MissingExistingFileDoST);

            MissingExistingFileCTL = new TitleBar()
            {
                Tag = "[TitleBar]Missing Existing File|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MissingExistingFileCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Missing Existing File|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
