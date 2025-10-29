// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Branch Table Editor ? Branch Size Unavailable|$BranchSizeUnavailable_Window", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class BranchTableEditorBranchSizeUnavailableDLG : Window
    {
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  Image Image2IMG;
        public  StaticText SelectBranchFitting;

        partial void OnInitialize();

        public BranchTableEditorBranchSizeUnavailableDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Image2IMG = new Image()
            {
                Tag = "[Image]$BulletImage1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            SelectBranchFitting = new StaticText()
            {
                Tag = "[StaticText]$SelectBranchFitting|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectBranchFitting);
        }
    }
}
