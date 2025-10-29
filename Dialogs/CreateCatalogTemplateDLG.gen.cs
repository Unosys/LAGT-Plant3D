// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Create Catalog Template|$Window_1", Parent = typeof(Plant3DCatalogBuilderDLG), GUIType = GuiType.UIA)]
    public partial class CreateCatalogTemplateDLG : Window
    {
        public  TitleBar CreateCatalogTemplateCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  StaticText SpecifyTheCatalogTemplate1ST;
        public  StaticText SpecifyTheCatalogTemplate2ST;
        public  TextField FileNameTB;
        public  Pane PanePANE;
        public  PushButton SelectFilePathBtn;
        public  StaticText StaticTextST;
        public  StaticText CProgramDataAutodeskAutodeskAutoCADPlant3D1ST;
        public  StaticText CProgramDataAutodeskAutodeskAutoCADPlant3D2ST;
        public  StaticText CatalogTemplateUnitType1ST;
        public  StaticText CatalogTemplateUnitType2ST;
        public  RadioButton ImperialRadio;
        public  RadioButton MetricRadio;
        public  PushButton Ok;
        public  StaticText OKST;
        public  PushButton Cancel;
        public  StaticText CancelST;
        public  PushButton Help;
        public  StaticText HelpST;

        partial void OnInitialize();

        public CreateCatalogTemplateDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CreateCatalogTemplateCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Catalog Template|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateCatalogTemplateCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Catalog Template|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Catalog Template|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Catalog Template|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            SpecifyTheCatalogTemplate1ST = new StaticText()
            {
                Tag = "[StaticText]Specify the Catalog Template file name:|$Label_26|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheCatalogTemplate1ST);

            SpecifyTheCatalogTemplate2ST = new StaticText()
            {
                Tag = "[StaticText]Specify the Catalog Template file name:|$Label_26|#1/[StaticText]Specify the Catalog Template file name:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheCatalogTemplate2ST);

            FileNameTB = new TextField()
            {
                Tag = "[TextField]Specify the Catalog Template file name:|$FileNameTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTB);

            PanePANE = new Pane()
            {
                Tag = "[TextField]Specify the Catalog Template file name:|$FileNameTB|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            SelectFilePathBtn = new PushButton()
            {
                Tag = "[PushButton]**|$SelectFilePathBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFilePathBtn);

            StaticTextST = new StaticText()
            {
                Tag = "[PushButton]**|$SelectFilePathBtn|#1/[StaticText]**|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            CProgramDataAutodeskAutodeskAutoCADPlant3D1ST = new StaticText()
            {
                Tag = "[StaticText]C:*|$FilePathDirLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CProgramDataAutodeskAutodeskAutoCADPlant3D1ST);

            CProgramDataAutodeskAutodeskAutoCADPlant3D2ST = new StaticText()
            {
                Tag = "[StaticText]C:*|$FilePathDirLabel|#2/[StaticText]C:*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CProgramDataAutodeskAutodeskAutoCADPlant3D2ST);

            CatalogTemplateUnitType1ST = new StaticText()
            {
                Tag = "[StaticText]Catalog Template unit type:|$Label_27|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogTemplateUnitType1ST);

            CatalogTemplateUnitType2ST = new StaticText()
            {
                Tag = "[StaticText]Catalog Template unit type:|$Label_27|#3/[StaticText]Catalog Template unit type:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogTemplateUnitType2ST);

            ImperialRadio = new RadioButton()
            {
                Tag = "[RadioButton]Catalog Template unit type:[1]|$ImperialRadio|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialRadio);

            MetricRadio = new RadioButton()
            {
                Tag = "[RadioButton]Catalog Template unit type:[2]|$MetricRadio|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MetricRadio);

            Ok = new PushButton()
            {
                Tag = "[PushButton]OK|$OkBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ok);

            OKST = new StaticText()
            {
                Tag = "[PushButton]OK|$OkBtn|#2/[StaticText]OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKST);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#3/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpBtn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$HelpBtn|#4/[StaticText]Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);
        }
    }
}
