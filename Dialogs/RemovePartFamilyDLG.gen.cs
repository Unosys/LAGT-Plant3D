// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Remove Part Family|#1", Parent = typeof(AutoCADPlant3DCatalogBuilderApplicationDLG), GUIType = GuiType.UIA)]
    public partial class RemovePartFamilyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public RemovePartFamilyDLG()
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

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Remove Part Family|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
