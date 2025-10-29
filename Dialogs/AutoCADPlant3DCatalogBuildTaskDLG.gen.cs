// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Autodesk AutoCAD Plant 3D Catalog Builder|#1", Parent = typeof(AutoCADPlant3DCatalogBuilderApplicationDLG), GUIType = GuiType.UIA)]
    public partial class AutoCADPlant3DCatalogBuildTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  PushButton Cancel;

        partial void OnInitialize();

        public AutoCADPlant3DCatalogBuildTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]Yes|$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]No|$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
