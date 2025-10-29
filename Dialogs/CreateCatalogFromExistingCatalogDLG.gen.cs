// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Create Catalog From Existing Catalog|$Window_1|", Parent = typeof(MainWin))]
    public partial class CreateCatalogFromExistingCatalogDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar CreateCatalogFromExistingCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CreatePB;
        public  StaticText CreateST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton HelpPB;
        public  StaticText HelpST;
        public  StaticText SourceCatalogNameST;
        public  StaticText SourceCatalognameST;
        public  TextField SourceCatalogNameTF;
        public  Pane Pane1PANE;
        public  PushButton PushButton1PB;
        public  StaticText StaticText1ST;
        public  StaticText CAutoCADPlant3D20161ST;
        public  StaticText NewCatalogNameST;
        public  StaticText NewCatalognameST;
        public  TextField NewCatalogNameTF;
        public  Pane Pane2PANE;
        public  PushButton PushButton2PB;
        public  StaticText StaticText2ST;
        public  StaticText CAutoCADPlant3D20162ST;

        partial void OnInitialize();

        public CreateCatalogFromExistingCatalogDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CreateCatalogFromExistingCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Catalog From Existing Catalog|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateCatalogFromExistingCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Catalog From Existing Catalog|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Catalog From Existing Catalog|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Catalog From Existing Catalog|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$CreateButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            CreateST = new StaticText()
            {
                Tag = "[PushButton]Create|$CreateButton|#3/[StaticText]Create|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#4/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpButton|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$HelpButton|#5/[StaticText]Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);

            SourceCatalogNameST = new StaticText()
            {
                Tag = "[StaticText]Source Catalog name:|$ExistingFileText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SourceCatalogNameST);

            SourceCatalognameST = new StaticText()
            {
                Tag = "[StaticText]Source Catalog name:|$ExistingFileText|#1/[StaticText]Source Catalog _name:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SourceCatalognameST);

            SourceCatalogNameTF = new TextField()
            {
                Tag = "[TextField]Source Catalog name:|$ExistingFileTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SourceCatalogNameTF);

            Pane1PANE = new Pane()
            {
                Tag = "[TextField]Source Catalog name:|$ExistingFileTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]**[1]|$ExistingFileBrowseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            StaticText1ST = new StaticText()
            {
                Tag = "[PushButton]**[1]|$ExistingFileBrowseButton|#1/[StaticText]**|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            CAutoCADPlant3D20161ST = new StaticText()
            {
                Tag = "[StaticText]C:*[1]|$ExistingFilePathText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CAutoCADPlant3D20161ST);

            NewCatalogNameST = new StaticText()
            {
                Tag = "[StaticText]New Catalog name:|$NewFileText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewCatalogNameST);

            NewCatalognameST = new StaticText()
            {
                Tag = "[StaticText]New Catalog name:|$NewFileText|#3/[StaticText]New Catalog _name:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewCatalognameST);

            NewCatalogNameTF = new TextField()
            {
                Tag = "[TextField]New Catalog name:|$NewFileTextBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewCatalogNameTF);

            Pane2PANE = new Pane()
            {
                Tag = "[TextField]New Catalog name:|$NewFileTextBox|#2/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]**[2]|$NewFileBrowseButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            StaticText2ST = new StaticText()
            {
                Tag = "[PushButton]**[2]|$NewFileBrowseButton|#2/[StaticText]**|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            CAutoCADPlant3D20162ST = new StaticText()
            {
                Tag = "[StaticText]C:*[2]|$NewFilePathText|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CAutoCADPlant3D20162ST);
        }
    }
}
