// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Spec and Catalog Migration Required|$Window_1")]
    public partial class SpecAndCatalogMigrationRequireTaskDLG : Autodesk.GUIHarness.MainWin
    {
        public  TitleBar SpecAndCatalogMigrationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close1PB;
        public  Image ImageIMG;
        public  StaticText SpecAndCatalogFiles1ST;
        public  StaticText SpecAndCatalogFiles2ST;
        public  StaticText UseTheMigrateSpecsST;
        public  GroupBox ShowDetailsGB;
        public  PushButton ShowDetailsPB;
        public  StaticText ShowDetailsST;
        public  PushButton Close2PB;
        public  StaticText CloseST;

        partial void OnInitialize();

        public SpecAndCatalogMigrationRequireTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SpecAndCatalogMigrationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Spec and Catalog Migration Required|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecAndCatalogMigrationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Spec and Catalog Migration Required|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Spec and Catalog Migration Required|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]Spec and Catalog Migration Required|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            ImageIMG = new Image()
            {
                Tag = "[Image]$image1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            SpecAndCatalogFiles1ST = new StaticText()
            {
                Tag = "[StaticText]Spec and Catalog files being opened were created with a previous version of Autodesk AutoCAD Plant 3D|$textBlock1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecAndCatalogFiles1ST);

            SpecAndCatalogFiles2ST = new StaticText()
            {
                Tag = "[StaticText]Spec and Catalog files must be migrated to the current version before they can be used*|$textBlock2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecAndCatalogFiles2ST);

            UseTheMigrateSpecsST = new StaticText()
            {
                Tag = "[StaticText]Use the Migrate Specs *|$textBlock3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseTheMigrateSpecsST);

            ShowDetailsGB = new GroupBox()
            {
                Tag = "[GroupBox]Show details|$expanderFiles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsGB);

            ShowDetailsPB = new PushButton()
            {
                Tag = "[GroupBox]Show details|$expanderFiles|#1/[PushButton]Show details|$HeaderSite|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsPB);

            ShowDetailsST = new StaticText()
            {
                Tag = "[GroupBox]Show details|$expanderFiles|#1/[PushButton]Show details|$HeaderSite|#1/[StaticText]Show details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsST);

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$button1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

            CloseST = new StaticText()
            {
                Tag = "[PushButton]Close|$button1|#1/[StaticText]Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseST);
        }
    }
}
