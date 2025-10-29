// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Migrate Specs and Catalogs|$TaskDialog_Enhanced")]
    public partial class MigrateSpecsAndCatalogsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  Image Image1IMG;
        public  StaticText SpecAndCatalogFilesST;
        public  StaticText StaticTextST;
        public  Image Image2IMG;
        public  StaticText MigrateAndCopySpecST;
        public  StaticText SelectSpecAndCatalogST;
        public  Image Image3IMG;
        public  StaticText DoNotMigrateST;
        public  StaticText ContentFromEarlierVersionsST;

        partial void OnInitialize();

        public MigrateSpecsAndCatalogsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Migrate Specs and Catalogs|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Image1IMG = new Image()
            {
                Tag = "[Image]$InformationImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            SpecAndCatalogFilesST = new StaticText()
            {
                Tag = "[StaticText]$HeaderTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecAndCatalogFilesST);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Image2IMG = new Image()
            {
                Tag = "[Image]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            MigrateAndCopySpecST = new StaticText()
            {
                Tag = "[StaticText]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigrateAndCopySpecST);

            SelectSpecAndCatalogST = new StaticText()
            {
                Tag = "[StaticText]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectSpecAndCatalogST);

            Image3IMG = new Image()
            {
                Tag = "[Image]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            DoNotMigrateST = new StaticText()
            {
                Tag = "[StaticText]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotMigrateST);

            ContentFromEarlierVersionsST = new StaticText()
            {
                Tag = "[StaticText]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentFromEarlierVersionsST);
        }
    }
}
