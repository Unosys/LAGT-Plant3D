// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D - External Database Manager", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class Plant3DExternalDatabaseManagerDLG_1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton MigrateExistingMappedPropertiesPB;
        public  PushButton DoNotMigrateExistingPB;
        public  PushButton CancelPB;
        public  TitleBar Plant3DExternalCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public Plant3DExternalDatabaseManagerDLG_1()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            MigrateExistingMappedPropertiesPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigrateExistingMappedPropertiesPB);

            DoNotMigrateExistingPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotMigrateExistingPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Plant3DExternalCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DExternalCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
