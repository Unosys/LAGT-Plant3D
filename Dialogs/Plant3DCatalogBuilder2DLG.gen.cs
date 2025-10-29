// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Welcome to the Autodesk AutoCAD Plant 3D Catalog Builder", Parent = typeof(Plant3D))]
    public partial class Plant3DCatalogBuilder2DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Image Image1;
        public  StaticText TextBlock1;
        public  StaticText CreateNew;
        public  StaticText EditExisting;
        public  StaticText TextBlock2;
        public  StaticText BuildCatalog;
        public  StaticText TextBlock3;
        public  PushButton Chevron;
        public  Image ChevronUpImage;
        public  StaticText Label1;

        partial void OnInitialize();

        public Plant3DCatalogBuilder2DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Image1 = new Image()
            {
                Tag = "[Image]$Image_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1);

            TextBlock1 = new StaticText()
            {
                Tag = "[StaticText]$TextBlock_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock1);

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

            TextBlock2 = new StaticText()
            {
                Tag = "[StaticText]$TextBlock_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock2);

            BuildCatalog = new StaticText()
            {
                Tag = "[StaticText]$BuildCatalog",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BuildCatalog);

            TextBlock3 = new StaticText()
            {
                Tag = "[StaticText]$TextBlock_3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock3);

            Chevron = new PushButton()
            {
                Tag = "[PushButton]$Chevron",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Chevron);

            ChevronUpImage = new Image()
            {
                Tag = "[Image]$ChevronUpImage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChevronUpImage);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$Label_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);
        }
    }
}
