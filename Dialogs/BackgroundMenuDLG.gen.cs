// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]BackgroundMenuDLG", Parent = typeof(Plant3D))]
    public partial class BackgroundMenuDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DevExpressXtraBarsControlsS;
        public  CustomWin CustomWin1;
        public  PushButton Color;
        public  PushButton Watermark;

        partial void OnInitialize();

        public BackgroundMenuDLG()
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

            CustomWin1 = new CustomWin()
            {
                Tag = "#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1);

            Color = new PushButton()
            {
                Tag = "[PushButton]Color|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Color);

            Watermark = new PushButton()
            {
                Tag = "[PushButton]Watermark|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Watermark);
        }
    }
}
