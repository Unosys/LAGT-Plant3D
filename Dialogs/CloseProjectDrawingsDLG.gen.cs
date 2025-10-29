// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Close Project Drawings", Parent = typeof(CustomWin))]
    public partial class CloseProjectDrawingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public CloseProjectDrawingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[PushButton]OK|$CommandButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[PushButton]Cancel|$CommandButton_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
