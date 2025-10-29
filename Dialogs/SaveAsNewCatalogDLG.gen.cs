// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save As New Catalog|#1", Parent = typeof(BuildCatalogSingleDLG), GUIType = GuiType.UIA)]
    public partial class SaveAsNewCatalogDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Save;
        public  PushButton Cancel;
        public  PushButton Close;

        partial void OnInitialize();

        public SaveAsNewCatalogDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Save = new PushButton()
            {
                Tag = "[PushButton]Save|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Save);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Close = new PushButton()
            {
                Tag = "[TitleBar]Save As New Catalog|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close);
        }
    }
}
