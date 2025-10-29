// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save As", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class CatalogBuilderSaveAsExcelFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Save;
        public  PushButton Cancel;

        partial void OnInitialize();

        public CatalogBuilderSaveAsExcelFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Save = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Save);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
