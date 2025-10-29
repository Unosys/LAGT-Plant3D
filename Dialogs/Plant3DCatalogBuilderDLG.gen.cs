// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Welcome to Autodesk AutoCAD Plant 3D Catalog Builder|$Window_1", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class Plant3DCatalogBuilderDLG : MainWin
    {
        public  PushButton ClosePB;
        public  StaticText CreateNew;
        public  StaticText EditExisting;
        public  StaticText CatalogsST;
        public  StaticText BuildCatalogST;
        public  PushButton Chevron;
        public  StaticText HowToCreateA1ST;

        partial void OnInitialize();

        public Plant3DCatalogBuilderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CreateNew = new StaticText()
            {
                Tag = "[StaticText]$CreateNew",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNew);

            EditExisting = new StaticText()
            {
                Tag = "[StaticText]$EditExisting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditExisting);

            CatalogsST = new StaticText()
            {
                Tag = "[StaticText]Catalogs|$TextBlock_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogsST);

            BuildCatalogST = new StaticText()
            {
                Tag = "[StaticText]$BuildCatalog",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BuildCatalogST);

            Chevron = new PushButton()
            {
                Tag = "[PushButton]$Chevron",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Chevron);

            HowToCreateA1ST = new StaticText()
            {
                Tag = "[StaticText]$Label_HowTo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HowToCreateA1ST);
        }
    }
}
