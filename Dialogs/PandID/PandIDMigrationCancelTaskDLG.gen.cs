// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Cancel", Parent = typeof(Pane))]
    public partial class PandIDMigrationCancelTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ExitPB;

        partial void OnInitialize();

        public PandIDMigrationCancelTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ExitPB = new PushButton()
            {
                Tag = "[Pane]Cancel|$Window|#1/[PushButton]Exit|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExitPB);
        }
    }
}
