// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]#1", Parent = typeof(Plant3D))]
    public partial class ViewMenuDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DevExpressXtraBarsControlsS;
        public  MenuItem PageLayout;
        public  PushButton Facing;
        public  PushButton Continuous;
        public  PushButton Toolbar;
        public  PushButton StatusBar;
        public  PushButton Customize;

        partial void OnInitialize();

        public ViewMenuDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DevExpressXtraBarsControlsS = new CustomWin()
            {
                Tag = "[DevExpress.XtraBars.Controls.SubMenuBarControl]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraBarsControlsS);

            PageLayout = new MenuItem()
            {
                Tag = "[MenuItem]Page Layout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageLayout);

            Facing = new PushButton()
            {
                Tag = "[PushButton]Facing|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Facing);

            Continuous = new PushButton()
            {
                Tag = "[PushButton]Continuous|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Continuous);

            Toolbar = new PushButton()
            {
                Tag = "[PushButton]Toolbar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Toolbar);

            StatusBar = new PushButton()
            {
                Tag = "[PushButton]Status Bar|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusBar);

            Customize = new PushButton()
            {
                Tag = "[PushButton]Customize|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Customize);
        }
    }
}
