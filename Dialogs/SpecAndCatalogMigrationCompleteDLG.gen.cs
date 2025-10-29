// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec and Catalog Migration Complete|$TaskDialog_Enhanced", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecAndCatalogMigrationCompleteDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SpecAndCatalogMigrationCompleteDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Spec and Catalog Migration Complete|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
