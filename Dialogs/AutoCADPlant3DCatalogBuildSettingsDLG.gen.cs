// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Autodesk AutoCAD Plant 3D Catalog Builder Settings|$Window_1", Parent = typeof(AutoCADPlant3DCatalogBuilderApplicationDLG), GUIType = GuiType.UIA)]
    public partial class AutoCADPlant3DCatalogBuildSettingsDLG : Autodesk.GUIHarness.Window
    {
        public  TitleBar AutodeskAutoCADPlant3DCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  GroupBox CatalogTemplateDefaultsGB;
        public  StaticText CatalogTemplateDefaultsST;
        public  CheckBox ApplyDefaultValuesToCK;
        public  StaticText SelectPipingUnitType1ST;
        public  StaticText SelectPipingUnitType2ST;
        public  RadioButton ImperialRadio;
        public  RadioButton Metric;
        public  StaticText Category1ST;
        public  StaticText Category2ST;
        public  PopupList CategoryPL;
        public  PushButton AdvancedBtn;
        public  StaticText AdvancedST;
        public  PushButton PropertyPB;
        public  StaticText PropertyST;
        public  PushButton ValuePB;
        public  StaticText ValueST;
        public  StaticText Graphics1ST;
        public  StaticText Graphics2ST;
        public  StaticText SizeFrom1ST;
        public  StaticText SizeFrom2ST;
        public  StaticText SizeTo1ST;
        public  StaticText SizeTo2ST;
        public  StaticText EndType1ST;
        public  StaticText EndType2ST;
        public  StaticText PressureClass1ST;
        public  StaticText PressureClass2ST;
        public  StaticText Schedule1ST;
        public  StaticText Schedule2ST;
        public  StaticText Material1ST;
        public  StaticText Material2ST;
        public  StaticText MaterialCode1ST;
        public  StaticText MaterialCode2ST;
        public  PopupList GraphicsPL;
        public  PopupList SizeFromPL;
        public  PopupList SizeToPL;
        public  PopupList EndTypePL;
        public  TextField PressureClassTF;
        public  Pane Pane1PANE;
        public  TextField ScheduleTF;
        public  Pane Pane2PANE;
        public  TextField MaterialTF;
        public  Pane Pane3PANE;
        public  TextField MaterialCodeTF;
        public  Pane Pane4PANE;
        public  GroupBox BuildCatalogDefaultsGB;
        public  StaticText BuildCatalogDefaultsST;
        public  CheckBox CreatePartFamilyPreviewCK;
        public  GroupBox LongDescriptionsGB;
        public  StaticText LongDescriptionsST;
        public  CheckBox AutoCreatLongDescCheck;
        public  StaticText LongDescriptionFamilyStyle1ST;
        public  StaticText LongDescriptionFamilyStyle2ST;
        public  PopupList LongDescriptionFamilyStylePL;
        public  StaticText LongDescriptionSizeStyle1ST;
        public  StaticText LongDescriptionSizeStyle2ST;
        public  PopupList LongDescriptionSizeStylePL;
        public  PushButton EditStyleBtn;
        public  StaticText EditLongDescriptionStylesST;
        public  GroupBox ChangeCatalogTemplateUnitsGB;
        public  StaticText ChangeCatalogTemplateUnitsST;
        public  StaticText Units1ST;
        public  StaticText Units2ST;
        public  PopupList UnitsPL;
        public  PushButton ConvertBtn;
        public  StaticText ConvertST;
        public  StaticText NoteChangesAffectEntire1ST;
        public  StaticText NoteChangesAffectEntire2ST;
        public  PushButton OKPB;
        public  StaticText OKST;
        public  PushButton Cancel;
        public  StaticText CancelST;
        public  PushButton HelpPB;
        public  StaticText HelpST;

        partial void OnInitialize();

        public AutoCADPlant3DCatalogBuildSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutodeskAutoCADPlant3DCTL = new TitleBar()
            {
                Tag = "[TitleBar]Autodesk AutoCAD Plant 3D Catalog Builder Settings|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskAutoCADPlant3DCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Autodesk AutoCAD Plant 3D Catalog Builder Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Autodesk AutoCAD Plant 3D Catalog Builder Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Autodesk AutoCAD Plant 3D Catalog Builder Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CatalogTemplateDefaultsGB = new GroupBox()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogTemplateDefaultsGB);

            CatalogTemplateDefaultsST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Catalog Template Defaults|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogTemplateDefaultsST);

            ApplyDefaultValuesToCK = new CheckBox()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[CheckBox]Apply default values to newly created Part Families|$OverrideNewFamilyDefaultValueCheck|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyDefaultValuesToCK);

            SelectPipingUnitType1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Select piping unit type to edit:|$Label_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectPipingUnitType1ST);

            SelectPipingUnitType2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Select piping unit type to edit:|$Label_1|#2/[StaticText]Select piping unit type to edit:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectPipingUnitType2ST);

            ImperialRadio = new RadioButton()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[RadioButton]Select piping unit type to edit:[1]|$ImperialRadio|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialRadio);

            Metric = new RadioButton()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[RadioButton]Select piping unit type to edit:[2]|$MetricRadio|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Metric);

            Category1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Category:|$Label_6|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Category1ST);

            Category2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Category:|$Label_6|#3/[StaticText]Category:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Category2ST);

            CategoryPL = new PopupList()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PopupList]Category:|$CategoryComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategoryPL);

            AdvancedBtn = new PushButton()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PushButton]Advanced*|$AdvancedBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedBtn);

            AdvancedST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PushButton]Advanced*|$AdvancedBtn|#3/[StaticText]Advanced*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedST);

            PropertyPB = new PushButton()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PushButton]Property|$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyPB);

            PropertyST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PushButton]Property|$Button_1|#1/[StaticText]Property|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyST);

            ValuePB = new PushButton()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PushButton]Value|$Button_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValuePB);

            ValueST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PushButton]Value|$Button_2|#2/[StaticText]Value|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueST);

            Graphics1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Graphics|$Label_7|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Graphics1ST);

            Graphics2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Graphics|$Label_7|#4/[StaticText]Graphics|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Graphics2ST);

            SizeFrom1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Size From|$Label_8|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeFrom1ST);

            SizeFrom2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Size From|$Label_8|#5/[StaticText]Size From|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeFrom2ST);

            SizeTo1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Size To|$Label_9|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeTo1ST);

            SizeTo2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Size To|$Label_9|#6/[StaticText]Size To|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeTo2ST);

            EndType1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]End Type|$Label_10|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndType1ST);

            EndType2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]End Type|$Label_10|#7/[StaticText]End Type|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndType2ST);

            PressureClass1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Pressure Class|$Label_11|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClass1ST);

            PressureClass2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Pressure Class|$Label_11|#8/[StaticText]Pressure Class|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClass2ST);

            Schedule1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Schedule|$Label_12|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Schedule1ST);

            Schedule2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Schedule|$Label_12|#9/[StaticText]Schedule|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Schedule2ST);

            Material1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Material|$Label_13|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Material1ST);

            Material2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Material|$Label_13|#10/[StaticText]Material|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Material2ST);

            MaterialCode1ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Material Code|$Label_14|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialCode1ST);

            MaterialCode2ST = new StaticText()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[StaticText]Material Code|$Label_14|#11/[StaticText]Material Code|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialCode2ST);

            GraphicsPL = new PopupList()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PopupList]Graphics|$GraphicModeCB|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GraphicsPL);

            SizeFromPL = new PopupList()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PopupList]Size From|$SizeFromCB|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeFromPL);

            SizeToPL = new PopupList()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PopupList]Size To|$SizeToCB|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeToPL);

            EndTypePL = new PopupList()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[PopupList]End Type|$EndTypeCB|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypePL);

            PressureClassTF = new TextField()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Pressure Class|$PressureClassTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassTF);

            Pane1PANE = new Pane()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Pressure Class|$PressureClassTB|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            ScheduleTF = new TextField()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Schedule|$ScheduleTB|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScheduleTF);

            Pane2PANE = new Pane()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Schedule|$ScheduleTB|#2/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MaterialTF = new TextField()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Material|$MaterialTB|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialTF);

            Pane3PANE = new Pane()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Material|$MaterialTB|#3/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MaterialCodeTF = new TextField()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Material Code|$MaterialCodeTB|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialCodeTF);

            Pane4PANE = new Pane()
            {
                Tag = "[GroupBox]Catalog Template Defaults|$CatalogTemplateDefaultsGroup|#1/[TextField]Material Code|$MaterialCodeTB|#4/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            BuildCatalogDefaultsGB = new GroupBox()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BuildCatalogDefaultsGB);

            BuildCatalogDefaultsST = new StaticText()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[StaticText]BuildCatalogDefaults|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BuildCatalogDefaultsST);

            CreatePartFamilyPreviewCK = new CheckBox()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[CheckBox]Create Part Family preview lisp files|$CreateFamilyLispCheck|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePartFamilyPreviewCK);

            LongDescriptionsGB = new GroupBox()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionsGB);

            LongDescriptionsST = new StaticText()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[StaticText]Long Descriptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionsST);

            AutoCreatLongDescCheck = new CheckBox()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[CheckBox]Automatically create Long Descriptions using Long Description Styles when catalog is built|$AutoCreatLongDescCheck|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCreatLongDescCheck);

            LongDescriptionFamilyStyle1ST = new StaticText()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[StaticText]Long Description (Family) style:|$Label_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionFamilyStyle1ST);

            LongDescriptionFamilyStyle2ST = new StaticText()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[StaticText]Long Description (Family) style:|$Label_2|#2/[StaticText]Long Description (Family) style:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionFamilyStyle2ST);

            LongDescriptionFamilyStylePL = new PopupList()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[PopupList]Long Description (Family) style:|$LDFamilyComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionFamilyStylePL);

            LongDescriptionSizeStyle1ST = new StaticText()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[StaticText]Long Description (Size) style:|$Label_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionSizeStyle1ST);

            LongDescriptionSizeStyle2ST = new StaticText()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[StaticText]Long Description (Size) style:|$Label_3|#3/[StaticText]Long Description (Size) style:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionSizeStyle2ST);

            LongDescriptionSizeStylePL = new PopupList()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[PopupList]Long Description (Size) style:|$LDSizeComboBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionSizeStylePL);

            EditStyleBtn = new PushButton()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[PushButton]Edit Long Description Styles*|$EditStyleBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditStyleBtn);

            EditLongDescriptionStylesST = new StaticText()
            {
                Tag = "[GroupBox]BuildCatalogDefaults|$BuildCatalogDefaultsGroup|#2/[GroupBox]Long Descriptions|$LongDescGroup|#1/[PushButton]Edit Long Description Styles*|$EditStyleBtn|#1/[StaticText]Edit Long Description Styles*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditLongDescriptionStylesST);

            ChangeCatalogTemplateUnitsGB = new GroupBox()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangeCatalogTemplateUnitsGB);

            ChangeCatalogTemplateUnitsST = new StaticText()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[StaticText]Change Catalog Template Units|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangeCatalogTemplateUnitsST);

            Units1ST = new StaticText()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[StaticText]Units:|$Label_4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Units1ST);

            Units2ST = new StaticText()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[StaticText]Units:|$Label_4|#2/[StaticText]Units:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Units2ST);

            UnitsPL = new PopupList()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[PopupList]Units:|$UnitComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnitsPL);

            ConvertBtn = new PushButton()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[PushButton]Convert|$ConvertBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertBtn);

            ConvertST = new StaticText()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[PushButton]Convert|$ConvertBtn|#1/[StaticText]Convert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertST);

            NoteChangesAffectEntire1ST = new StaticText()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[StaticText]Note: Changes affect entire Catalog Template|$Label_5|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoteChangesAffectEntire1ST);

            NoteChangesAffectEntire2ST = new StaticText()
            {
                Tag = "[GroupBox]Change Catalog Template Units|$CatalogTemplateUnitsGroup|#3/[StaticText]Note: Changes affect entire Catalog Template|$Label_5|#3/[StaticText]Note: Changes affect entire Catalog Template|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoteChangesAffectEntire2ST);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OkBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            OKST = new StaticText()
            {
                Tag = "[PushButton]OK|$OkBtn|#1/[StaticText]OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKST);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$HelpBtn|#3/[StaticText]Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);
        }
    }
}
