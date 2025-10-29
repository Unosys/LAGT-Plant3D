// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Path Name Error", Parent = typeof(ModifySharedContentFolderDLG), GUIType = GuiType.UIA)]
    public partial class PathNameErrorDLG : Window
    {
        public  PushButton OK;
        public  Image ImageIMG;
        public  StaticText NotAValidPathST;
        public  TitleBar PathNameErrorCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PathNameErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            NotAValidPathST = new StaticText()
            {
                Tag = "[StaticText]Not a valid path name selected*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NotAValidPathST);

            PathNameErrorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Path Name Error|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathNameErrorCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Path Name Error|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
