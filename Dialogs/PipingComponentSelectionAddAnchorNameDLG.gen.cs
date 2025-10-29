// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PipingComponentSelectionAddAnchorNameDLG : Window
    {
        public  PushButton CancelPB;

        partial void OnInitialize();

        public PipingComponentSelectionAddAnchorNameDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
