// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Project Settings Check Out", Parent = typeof(Desktop))]
    public partial class ProjectSettingsCheckOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CheckOutNowPB;
        public  PushButton OpenReadonlyPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public ProjectSettingsCheckOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CheckOutNowPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Check out now|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutNowPB);

            OpenReadonlyPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Open read-only|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenReadonlyPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
