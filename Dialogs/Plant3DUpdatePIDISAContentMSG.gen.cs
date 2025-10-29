// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D - Update * ISA Content", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class Plant3DUpdatePIDISAContentMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton UpdateThisProjectsISAPB;
        public  PushButton DontUpdatePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public Plant3DUpdatePIDISAContentMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            UpdateThisProjectsISAPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Update P*|$Window|#1/[PushButton]Update this project's ISA content|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdateThisProjectsISAPB);

            DontUpdatePB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Update P*|$Window|#1/[PushButton]Don't update|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DontUpdatePB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Update P*|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
