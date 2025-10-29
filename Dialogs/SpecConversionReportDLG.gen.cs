// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Conversion Report|$SpecMigrationErrorReportWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecConversionReportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close2PB;

        partial void OnInitialize();

        public SpecConversionReportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
