// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Optimize Project Database", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class OptimizeProjectDatabaseDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;

        partial void OnInitialize();

        public OptimizeProjectDatabaseDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Optimize Project Database|$Window/[PushButton]Cancel|$CommandButton_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
