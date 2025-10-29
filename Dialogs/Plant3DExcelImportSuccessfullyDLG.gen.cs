// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Excel Import|$Window_1", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class Plant3DExcelImportSuccessfullyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close2PB;

        partial void OnInitialize();

        public Plant3DExcelImportSuccessfullyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close2PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Close|$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
