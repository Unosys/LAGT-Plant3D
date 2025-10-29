// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]View is Up to Date", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ViewisUptoDateDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton UpdateViewAnywayPB;
        public  PushButton DoNotUpdateViewPB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ViewisUptoDateDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            UpdateViewAnywayPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdateViewAnywayPB);

            DoNotUpdateViewPB = new PushButton()
            {
                Tag = "[Pane]View is Up to Date|$Window|#1/[PushButton]$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotUpdateViewPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]View is Up to Date|$Window|#1/[PushButton]$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]View is Up to Date|$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
