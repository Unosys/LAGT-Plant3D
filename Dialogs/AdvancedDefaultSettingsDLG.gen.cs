// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Advanced Default Settings|$Window_1", Parent = typeof(AutoCADPlant3DCatalogBuildSettingsDLG), GUIType = GuiType.UIA)]
    public partial class AdvancedDefaultSettingsDLG : Window
    {
        public  TitleBar AdvancedDefaultSettingsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton Ok;
        public  StaticText OKST;
        public  PushButton Cancel;
        public  StaticText CancelST;
        public  PushButton Help;
        public  StaticText HelpST;
        public  GroupBox PortPropertyDefaultsGB;
        public  StaticText PortPropertyDefaultsST;
        public  StaticText SpecifyEngagementLengthAndST;
        public  StaticText TheseValuesAreUsedST;
        public  PopupList TheseValuesAreUsedPL;
        public  PushButton AddBtn;
        public  StaticText AddST;
        public  PushButton RemoveBtn;
        public  StaticText RemoveST;
        public  Pane Pane1PANE;
        public  Table DataGridView1TBL;
        public  ScrollBar VerticalScrollBar1SB;
        public  CustomWin TopRow1WIN;
        public  Header SizeCTL;
        public  Header EndTypeCTL;
        public  Header PressureClassCTL;
        public  Header EngagementLengthCTL;
        public  CustomWin Row01WIN;
        public  CustomWin SizeRow0WIN;
        public  CustomWin EndTypeRow0WIN;
        public  CustomWin PressureClassRow0WIN;
        public  CustomWin EngagementLengthRow0WIN;
        public  CustomWin Row11WIN;
        public  CustomWin SizeRow1WIN;
        public  CustomWin EndTypeRow1WIN;
        public  CustomWin PressureClassRow1WIN;
        public  CustomWin EngagementLengthRow1WIN;
        public  CustomWin Row21WIN;
        public  CustomWin SizeRow2WIN;
        public  CustomWin EndTypeRow2WIN;
        public  CustomWin PressureClassRow2WIN;
        public  CustomWin EngagementLengthRow2WIN;
        public  CustomWin Row31WIN;
        public  CustomWin SizeRow3WIN;
        public  CustomWin EndTypeRow3WIN;
        public  CustomWin PressureClassRow3WIN;
        public  CustomWin EngagementLengthRow3WIN;
        public  CustomWin Row41WIN;
        public  CustomWin SizeRow4WIN;
        public  CustomWin EndTypeRow4WIN;
        public  CustomWin PressureClassRow4WIN;
        public  CustomWin EngagementLengthRow4WIN;
        public  CustomWin Row51WIN;
        public  CustomWin SizeRow5WIN;
        public  CustomWin EndTypeRow5WIN;
        public  CustomWin PressureClassRow5WIN;
        public  CustomWin EngagementLengthRow5WIN;
        public  GroupBox CustomSizeListAndGB;
        public  StaticText CustomSizeListAndST;
        public  StaticText SpecifyWhichSizesAreST;
        public  Pane Pane2PANE;
        public  Table DataGridView2TBL;
        public  ScrollBar VerticalScrollBar2SB;
        public  CustomWin TopRow2WIN;
        public  Header CustomSizeListCTL;
        public  Header NominalDiameterCTL;
        public  Header MatchingPipeODCTL;
        public  CustomWin Row02WIN;
        public  CustomWin CustomSizeListRow1WIN;
        public  CustomWin NominalDiameterRow0WIN;
        public  CustomWin MatchingPipeODRow1WIN;
        public  CustomWin Row12WIN;
        public  CustomWin CustomSizeListRow2WIN;
        public  CustomWin NominalDiameterRow1WIN;
        public  CustomWin MatchingPipeODRow2WIN;
        public  CustomWin Row22WIN;
        public  CustomWin CustomSizeListRow3WIN;
        public  CustomWin NominalDiameterRow2WIN;
        public  CustomWin MatchingPipeODRow3WIN;
        public  CustomWin Row32WIN;
        public  CustomWin CustomSizeListRow4WIN;
        public  CustomWin NominalDiameterRow3WIN;
        public  CustomWin MatchingPipeODRow4WIN;
        public  CustomWin Row42WIN;
        public  CustomWin CustomSizeListRow5WIN;
        public  CustomWin NominalDiameterRow4WIN;
        public  CustomWin MatchingPipeODRow5WIN;
        public  CustomWin Row52WIN;
        public  CustomWin CustomSizeListRow6WIN;
        public  CustomWin NominalDiameterRow5WIN;
        public  CustomWin MatchingPipeODRow6WIN;

        partial void OnInitialize();

        public AdvancedDefaultSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AdvancedDefaultSettingsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Advanced Default Settings|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedDefaultSettingsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Advanced Default Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Advanced Default Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Advanced Default Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Ok = new PushButton()
            {
                Tag = "[PushButton]OK|$OkBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ok);

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

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$HelpBtn|#3/[StaticText]Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);

            PortPropertyDefaultsGB = new GroupBox()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PortPropertyDefaultsGB);

            PortPropertyDefaultsST = new StaticText()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[StaticText]Port Property Defaults|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PortPropertyDefaultsST);

            SpecifyEngagementLengthAndST = new StaticText()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[StaticText]Specify Engagement Length and Wall Thickness*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyEngagementLengthAndST);

            TheseValuesAreUsedST = new StaticText()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[StaticText]These values are used when the Catalog Template is exported*|$TextBlock_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheseValuesAreUsedST);

            TheseValuesAreUsedPL = new PopupList()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[PopupList]These values are used when the Catalog Template is exported*|$PortPropertyComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheseValuesAreUsedPL);

            AddBtn = new PushButton()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[PushButton]Add|$AddBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddBtn);

            AddST = new StaticText()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[PushButton]Add|$AddBtn|#1/[StaticText]Add|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddST);

            RemoveBtn = new PushButton()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[PushButton]Remove|$RemoveBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveBtn);

            RemoveST = new StaticText()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[PushButton]Remove|$RemoveBtn|#2/[StaticText]Remove|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveST);

            Pane1PANE = new Pane()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            DataGridView1TBL = new Table()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView1TBL);

            VerticalScrollBar1SB = new ScrollBar()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[ScrollBar]Vertical Scroll Bar|$2950932|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar1SB);

            TopRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRow1WIN);

            SizeCTL = new Header()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Top Row|#1/[Header]Size|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeCTL);

            EndTypeCTL = new Header()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Top Row|#1/[Header]End Type|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeCTL);

            PressureClassCTL = new Header()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Top Row|#1/[Header]Pressure Class|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassCTL);

            EngagementLengthCTL = new Header()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Top Row|#1/[Header]Engagement Length|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthCTL);

            Row01WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row01WIN);

            SizeRow0WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 0|#2/[CustomWin]Size Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeRow0WIN);

            EndTypeRow0WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 0|#2/[CustomWin]End Type Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeRow0WIN);

            PressureClassRow0WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 0|#2/[CustomWin]Pressure Class Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassRow0WIN);

            EngagementLengthRow0WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 0|#2/[CustomWin]Engagement Length Row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthRow0WIN);

            Row11WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row11WIN);

            SizeRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 1|#3/[CustomWin]Size Row 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeRow1WIN);

            EndTypeRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 1|#3/[CustomWin]End Type Row 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeRow1WIN);

            PressureClassRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 1|#3/[CustomWin]Pressure Class Row 1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassRow1WIN);

            EngagementLengthRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 1|#3/[CustomWin]Engagement Length Row 1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthRow1WIN);

            Row21WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row21WIN);

            SizeRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 2|#4/[CustomWin]Size Row 2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeRow2WIN);

            EndTypeRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 2|#4/[CustomWin]End Type Row 2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeRow2WIN);

            PressureClassRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 2|#4/[CustomWin]Pressure Class Row 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassRow2WIN);

            EngagementLengthRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 2|#4/[CustomWin]Engagement Length Row 2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthRow2WIN);

            Row31WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 3|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row31WIN);

            SizeRow3WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 3|#5/[CustomWin]Size Row 3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeRow3WIN);

            EndTypeRow3WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 3|#5/[CustomWin]End Type Row 3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeRow3WIN);

            PressureClassRow3WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 3|#5/[CustomWin]Pressure Class Row 3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassRow3WIN);

            EngagementLengthRow3WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 3|#5/[CustomWin]Engagement Length Row 3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthRow3WIN);

            Row41WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 4|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row41WIN);

            SizeRow4WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 4|#6/[CustomWin]Size Row 4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeRow4WIN);

            EndTypeRow4WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 4|#6/[CustomWin]End Type Row 4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeRow4WIN);

            PressureClassRow4WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 4|#6/[CustomWin]Pressure Class Row 4|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassRow4WIN);

            EngagementLengthRow4WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 4|#6/[CustomWin]Engagement Length Row 4|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthRow4WIN);

            Row51WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 5|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row51WIN);

            SizeRow5WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 5|#7/[CustomWin]Size Row 5|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeRow5WIN);

            EndTypeRow5WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 5|#7/[CustomWin]End Type Row 5|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeRow5WIN);

            PressureClassRow5WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 5|#7/[CustomWin]Pressure Class Row 5|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassRow5WIN);

            EngagementLengthRow5WIN = new CustomWin()
            {
                Tag = "[GroupBox]Port Property Defaults|$PortPropertyDefaultsGroup|#1/[Pane]$EngagementLengthHost|#1/[Table]DataGridView|$4719384|#1/[CustomWin]Row 5|#7/[CustomWin]Engagement Length Row 5|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthRow5WIN);

            CustomSizeListAndGB = new GroupBox()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListAndGB);

            CustomSizeListAndST = new StaticText()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[StaticText]Custom Size List and OD Defaults|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListAndST);

            SpecifyWhichSizesAreST = new StaticText()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[StaticText]Specify which sizes are included in the Custom Size List and edit Outside Diameters|$TextBlock_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyWhichSizesAreST);

            Pane2PANE = new Pane()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            DataGridView2TBL = new Table()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView2TBL);

            VerticalScrollBar2SB = new ScrollBar()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[ScrollBar]Vertical Scroll Bar|$2491974|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar2SB);

            TopRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRow2WIN);

            CustomSizeListCTL = new Header()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Top Row|#1/[Header]Custom Size List|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListCTL);

            NominalDiameterCTL = new Header()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Top Row|#1/[Header]Nominal Diameter|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterCTL);

            MatchingPipeODCTL = new Header()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Top Row|#1/[Header]Matching Pipe OD|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODCTL);

            Row02WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row02WIN);

            CustomSizeListRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 0|#2/[CustomWin]Custom Size List Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListRow1WIN);

            NominalDiameterRow0WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 0|#2/[CustomWin]Nominal Diameter Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow0WIN);

            MatchingPipeODRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 0|#2/[CustomWin]Matching Pipe OD Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODRow1WIN);

            Row12WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row12WIN);

            CustomSizeListRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 1|#3/[CustomWin]Custom Size List Row 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListRow2WIN);

            NominalDiameterRow1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 1|#3/[CustomWin]Nominal Diameter Row 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow1WIN);

            MatchingPipeODRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 1|#3/[CustomWin]Matching Pipe OD Row 1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODRow2WIN);

            Row22WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row22WIN);

            CustomSizeListRow3WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 2|#4/[CustomWin]Custom Size List Row 2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListRow3WIN);

            NominalDiameterRow2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 2|#4/[CustomWin]Nominal Diameter Row 2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow2WIN);

            MatchingPipeODRow3WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 2|#4/[CustomWin]Matching Pipe OD Row 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODRow3WIN);

            Row32WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 3|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row32WIN);

            CustomSizeListRow4WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 3|#5/[CustomWin]Custom Size List Row 3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListRow4WIN);

            NominalDiameterRow3WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 3|#5/[CustomWin]Nominal Diameter Row 3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow3WIN);

            MatchingPipeODRow4WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 3|#5/[CustomWin]Matching Pipe OD Row 3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODRow4WIN);

            Row42WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 4|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row42WIN);

            CustomSizeListRow5WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 4|#6/[CustomWin]Custom Size List Row 4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListRow5WIN);

            NominalDiameterRow4WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 4|#6/[CustomWin]Nominal Diameter Row 4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow4WIN);

            MatchingPipeODRow5WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 4|#6/[CustomWin]Matching Pipe OD Row 4|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODRow5WIN);

            Row52WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 5|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row52WIN);

            CustomSizeListRow6WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 5|#7/[CustomWin]Custom Size List Row 5|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomSizeListRow6WIN);

            NominalDiameterRow5WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 5|#7/[CustomWin]Nominal Diameter Row 5|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow5WIN);

            MatchingPipeODRow6WIN = new CustomWin()
            {
                Tag = "[GroupBox]Custom Size List and OD Defaults|$CustomSizeDefaultsGroup|#2/[Pane]$WindowsFormsHost_2|#1/[Table]DataGridView|$2229922|#1/[CustomWin]Row 5|#7/[CustomWin]Matching Pipe OD Row 5|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODRow6WIN);
        }
    }
}
