// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Advanced Iso Creation Options|$QuickIsoOptions|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class AdvancedIsoCreationOptionsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox OffsetLocationGB;
        public  StaticText ZST;
        public  TextField ZTF;
        public  StaticText DEGST;
        public  StaticText YST;
        public  TextField YTF;
        public  StaticText XST;
        public  StaticText DistanceST;
        public  StaticText RotationST;
        public  TextField RotationTF;
        public  TextField XTF;
        public  GroupBox DrawingCongestionSplittingGB;
        public  Pane PanePANE;
        public  StaticText MoreST;
        public  StaticText LessST;
        public  Scale LessSC;
        public  StaticText LevelOfCongestionToST;
        public  CheckBox CreateSplitPointsAutomaticallyCK;
        public  GroupBox AdvancedSettingsOverridesGB;
        public  CheckBox OverrideDefaultNorthArrowCK;
        public  CheckBox ReverseIsoStartAndCK;
        public  CheckBox IgnoreIsoAnnotationsFromCK;
        public  PopupList PopupListPL;
        public  PushButton DropDownButton1PB;
        public  CheckBox IgnoreBreakPointsFromCK;
        public  GroupBox ExportSettingsGB;
        public  CheckBox CreatePCFPerIsoCK;
        public  StaticText PCFOutputST;
        public  CheckBox SpoolCK;
        public  CheckBox WeldCK;
        public  CheckBox CutPieceCK;
        public  CheckBox BOMCK;
        public  PopupList FormatPL;
        public  PushButton DropDownButton2PB;
        public  StaticText FormatST;
        public  StaticText ExportTablesOnIsoST;
        public  GroupBox OverrideIsoSplittingGB;
        public  CheckBox SplitIsoWhenPropertyCK;
        public  ListBox ListBoxLB;
        public  ScrollBar VerticalScrollBarSB;
        public  ListBoxItem LineNumberLBI;
        public  ListBoxItem ServiceLBI;
        public  ListBoxItem SpecLBI;
        public  ListBoxItem NominalDiameterLBI;
        public  ListBoxItem MaterialLBI;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TitleBar AdvancedIsoCreationOptionsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AdvancedIsoCreationOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OffsetLocationGB = new GroupBox()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OffsetLocationGB);

            ZST = new StaticText()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[StaticText]Z:|$label_Z|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZST);

            ZTF = new TextField()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[TextField]Z:|$textBox_Z|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZTF);

            DEGST = new StaticText()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[StaticText]DEG*|$label_Deg|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DEGST);

            YST = new StaticText()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[StaticText]Y:|$label_Y|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YST);

            YTF = new TextField()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[TextField]Y:|$textBox_Y|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YTF);

            XST = new StaticText()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[StaticText]X:|$label_X|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XST);

            DistanceST = new StaticText()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[StaticText]Distance:|$label_OffsetDistance|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DistanceST);

            RotationST = new StaticText()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[StaticText]Rotation:|$label_OffsetRotation|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RotationST);

            RotationTF = new TextField()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[TextField]Rotation:|$textBox_Deg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RotationTF);

            XTF = new TextField()
            {
                Tag = "[GroupBox]Offset location|$groupBox_OverrideLocation|#5/[TextField]X:|$textBox_X|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XTF);

            DrawingCongestionSplittingGB = new GroupBox()
            {
                Tag = "[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingCongestionSplittingGB);

            PanePANE = new Pane()
            {
                Tag = "[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#1/[Pane]$congestionLevelPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            MoreST = new StaticText()
            {
                Tag = "[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#1/[Pane]$congestionLevelPanel|#1/[StaticText]More|$label_More|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoreST);

            LessST = new StaticText()
            {
                Tag = "[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#1/[Pane]$congestionLevelPanel|#1/[StaticText]Less|$label_Less|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LessST);

            LessSC = new Scale()
            {
                Tag = "[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#1/[Pane]$congestionLevelPanel|#1/[Scale]Less|$trackBar_CongestionSplitting|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LessSC);

            LevelOfCongestionToST = new StaticText()
            {
                Tag = "[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#1/[Pane]$congestionLevelPanel|#1/[StaticText]Level of congestion to split Iso at:|$label_Level|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LevelOfCongestionToST);

            CreateSplitPointsAutomaticallyCK = new CheckBox()
            {
                Tag = "[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#1/[CheckBox]Create split points automatically|$checkBox_CreateSplitAutomatically|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateSplitPointsAutomaticallyCK);

            AdvancedSettingsOverridesGB = new GroupBox()
            {
                Tag = "[GroupBox]Advanced settings *|$groupBox_AdvancedSettings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedSettingsOverridesGB);

            OverrideDefaultNorthArrowCK = new CheckBox()
            {
                Tag = "[GroupBox]Advanced settings *|$groupBox_AdvancedSettings|#4/[CheckBox]Override default North Arrow direction|$checkBox_OverrideNorthArrow|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverrideDefaultNorthArrowCK);

            ReverseIsoStartAndCK = new CheckBox()
            {
                Tag = "[GroupBox]Advanced settings *|$groupBox_AdvancedSettings|#4/[CheckBox]Reverse Iso start and end points|$checkBox_ReverseStartEnd|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReverseIsoStartAndCK);

            IgnoreIsoAnnotationsFromCK = new CheckBox()
            {
                Tag = "[GroupBox]Advanced settings *|$groupBox_AdvancedSettings|#4/[CheckBox]Ignore Iso annotations from model|$checkBox_IgnoreAnnotations|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IgnoreIsoAnnotationsFromCK);

            PopupListPL = new PopupList()
            {
                Tag = "[GroupBox]Advanced settings *|$groupBox_AdvancedSettings|#4/[PopupList]$comboBox_NorthArrowDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[GroupBox]Advanced settings *|$groupBox_AdvancedSettings|#4/[PopupList]$comboBox_NorthArrowDir|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            IgnoreBreakPointsFromCK = new CheckBox()
            {
                Tag = "[GroupBox]Advanced settings *|$groupBox_AdvancedSettings|#4/[CheckBox]Ignore Break Points from model|$checkBox_IgnoreBreakPoints|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IgnoreBreakPointsFromCK);

            ExportSettingsGB = new GroupBox()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportSettingsGB);

            CreatePCFPerIsoCK = new CheckBox()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[CheckBox]Create PCF per Iso Sheet*|$pcfOutputCheckbox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePCFPerIsoCK);

            PCFOutputST = new StaticText()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[StaticText]PCF Output:|$label3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFOutputST);

            SpoolCK = new CheckBox()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[CheckBox]Spool|$checkBox_ExportSpool|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolCK);

            WeldCK = new CheckBox()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[CheckBox]Weld|$checkBox_ExportWeld|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeldCK);

            CutPieceCK = new CheckBox()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[CheckBox]Cut Piece|$checkBox_ExportCutPiece|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CutPieceCK);

            BOMCK = new CheckBox()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[CheckBox]BOM|$checkBox_ExportBOM|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BOMCK);

            FormatPL = new PopupList()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[PopupList]Format:|$comboBox_ExportFormat|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormatPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[PopupList]Format:|$comboBox_ExportFormat|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            FormatST = new StaticText()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[StaticText]Format:|$label2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormatST);

            ExportTablesOnIsoST = new StaticText()
            {
                Tag = "[GroupBox]Export settings|$groupBox_ExportSettings|#2/[StaticText]Export tables on Iso creation:|$label1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportTablesOnIsoST);

            OverrideIsoSplittingGB = new GroupBox()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverrideIsoSplittingGB);

            SplitIsoWhenPropertyCK = new CheckBox()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[CheckBox]Split Iso when property changes:|$checkBox_SplitIso|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SplitIsoWhenPropertyCK);

            ListBoxLB = new ListBox()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[ListBox]$checkedListBox_PropertyNames|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            VerticalScrollBarSB = new ScrollBar()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[ListBox]$checkedListBox_PropertyNames|#1/[ScrollBar]Vertical Scroll Bar|$Vertical ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarSB);

            LineNumberLBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Line number|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumberLBI);

            ServiceLBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Service|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServiceLBI);

            SpecLBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Spec|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecLBI);

            NominalDiameterLBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Nominal diameter|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterLBI);

            MaterialLBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Override Iso splitting|$groupBox_Splitting|#3/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Material|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialLBI);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$button_help|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$button_cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$button_OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            AdvancedIsoCreationOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Advanced Iso Creation Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedIsoCreationOptionsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Advanced Iso Creation Options|$TitleBar|#1/[CustomWin]System Menu Bar|$QuickIsoOptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Advanced Iso Creation Options|$TitleBar|#1/[CustomWin]System Menu Bar|$QuickIsoOptions|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Advanced Iso Creation Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
