// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save Catalog Template As|#1", Parent = typeof(AutoCADPlant3DCatalogBuilderApplicationDLG), GUIType = GuiType.UIA)]
    public partial class SaveCatalogTemplateAsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton SavePB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SaveCatalogTemplateAsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SavePB = new PushButton()
            {
                Tag = "[PushButton]Save|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Save Catalog Template As|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
