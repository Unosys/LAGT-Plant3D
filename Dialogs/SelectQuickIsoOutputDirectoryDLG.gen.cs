// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Quick Iso Output Directory", Parent = typeof(IsometricDWGSettingsIsoStyleSetupDLG), GUIType = GuiType.UIA)]
    public partial class SelectQuickIsoOutputDirectoryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Open;
        public  PushButton Cancel;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectQuickIsoOutputDirectoryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Quick Iso Output Directory|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
