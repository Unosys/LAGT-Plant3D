// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Spec and Catalog Migration Required|$UpgradeMigrationRequiredWindow")]
    public partial class SpecAndCatalogMigrationRequired2DLG : Autodesk.GUIHarness.MainWin
    {
        public  PushButton Close1PB;
        public  PushButton ShowDetailsPB;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public SpecAndCatalogMigrationRequired2DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]Spec and Catalog Migration Required|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            ShowDetailsPB = new PushButton()
            {
                Tag = "[GroupBox]Show details|$expanderFiles|#1/[PushButton]Show details|$HeaderSite|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsPB);

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$button1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
