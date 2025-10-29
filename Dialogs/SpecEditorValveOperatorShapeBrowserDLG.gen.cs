// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Valve Operator Shape Browser|$CustomizeValveOperatorWindow", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class SpecEditorValveOperatorShapeBrowserDLG : Autodesk.GUIHarness.Window
    {
        public  PushButton CancelPB;

        partial void OnInitialize();

        public SpecEditorValveOperatorShapeBrowserDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
