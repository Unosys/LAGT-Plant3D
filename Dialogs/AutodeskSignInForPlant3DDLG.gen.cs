// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs.Dialogs
{

    [UIElement(Tag = "[Window]Sign in", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AutodeskSignInForPlant3DDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar SignInCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  Pane PanePANE;
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;

        partial void OnInitialize();

        public AutodeskSignInForPlant3DDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SignInCTL = new TitleBar()
            {
                Tag = "[TitleBar]Sign in|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignInCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Sign in|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Sign in|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Sign in|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            PanePANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);
        }
    }
}
