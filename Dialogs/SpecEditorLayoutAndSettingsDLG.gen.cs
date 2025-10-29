// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Editor Layout and Settings|$LayoutAndSettingsWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecEditorLayoutAndSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton EditLongDescriptionStylesPB;

        partial void OnInitialize();

        public SpecEditorLayoutAndSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            EditLongDescriptionStylesPB = new PushButton()
            {
                Tag = "[GroupBox]Spec sheet settings|$GroupBox_1|#1/[GroupBox]Long descriptions|$LDGroupBox|#1/[PushButton]Edit long description styles*|$LDStylesButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditLongDescriptionStylesPB);
        }
    }
}
