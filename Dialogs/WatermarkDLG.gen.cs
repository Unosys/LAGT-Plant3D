// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Watermark|$WatermarkEditorForm", Parent = typeof(PreviewDLG), GUIType = GuiType.UIA)]
    public partial class WatermarkDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane ClickTheAddButtonPANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  Pane ViewPANE;
        public  Pane TextSettingsPANE;
        public  Pane Pane6PANE;
        public  Pane PositionPANE;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  Pane Pane7PANE;
        public  CheckBox BoldCK;
        public  CheckBox ItalicCK;
        public  StaticText TextST;
        public  StaticText DirectionST;
        public  StaticText FontST;
        public  TextField ColorTF;
        public  PushButton Open1PB;
        public  CustomWin ColorWIN;
        public  PopupList FontPL;
        public  PushButton Open2PB;
        public  CustomWin FontWIN;
        public  PopupList SizePL;
        public  PushButton Open3PB;
        public  CustomWin SizeWIN;
        public  PopupList DirectionPL;
        public  PushButton Open4PB;
        public  CustomWin DirectionWIN;
        public  PopupList TextPL;
        public  PopupList PopupListPL;
        public  StaticText ColorST;
        public  StaticText SizeST;
        public  Scale Transparency0255SC;
        public  TextField Transparency0255TF;
        public  CustomWin Transparency0255WIN;
        public  StaticText Transparency0255ST;
        public  StaticText PositionST;
        public  Window TextSettingsWIN;
        public  Window PictureSettingsWIN;
        public  Pane IdPANE;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  Pane PageRangePANE;
        public  Pane Pane8PANE;
        public  TextField TextField3TF;
        public  TextField TextField4TF;
        public  RadioButton RadioButton3RB;
        public  RadioButton RadioButton4RB;
        public  StaticText EnterPageNumbersAndorST;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  Pane EnterPageNumbersAndorPANE;
        public  PushButton PushButton1PB;
        public  Pane Pane9PANE;
        public  ListBox ListBoxLB;
        public  ListBoxItem Watermark1LBI;
        public  PushButton PushButton2PB;
        public  PushButton PushButton3PB;
        public  TitleBar WatermarksCTL;
        public  PushButton ClosePB;
        public  PushButton BrowsePB;

        partial void OnInitialize();

        public WatermarkDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ClickTheAddButtonPANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]Click the ?Add? button to create a watermark|$separatorPanel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClickTheAddButtonPANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]$myPrintControl1Container|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]$myPrintControl1Container|#3/[Pane]$myPrintControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            ViewPANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]$myPrintControl1Container|#3/[Pane]$myPrintControl1|#1/[Pane]View|$DocumentViewer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewPANE);

            TextSettingsPANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]$xtraTpTextSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextSettingsPANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            PositionPANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[Pane]Position:|$textPositionPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PositionPANE);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[Pane]Position:|$textPositionPanel|#2/[RadioButton]$textPositionInfrontEdit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[Pane]Position:|$textPositionPanel|#2/[RadioButton]$textPositionBehindEdit|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[Pane]$textStylePanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            BoldCK = new CheckBox()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[Pane]$textStylePanel|#1/[CheckBox]Bold|$chbBold|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoldCK);

            ItalicCK = new CheckBox()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[Pane]$textStylePanel|#1/[CheckBox]Italic|$chbItalic|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItalicCK);

            TextST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[StaticText]Text:|$lbText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextST);

            DirectionST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[StaticText]Direction:|$lbLayout|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectionST);

            FontST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[StaticText]Font:|$lbFont|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FontST);

            ColorTF = new TextField()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[TextField]Color:|$ceWatermarkColor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorTF);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[TextField]Color:|$ceWatermarkColor|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            ColorWIN = new CustomWin()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[TextField]Color:|$ceWatermarkColor|#1/[CustomWin]C*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorWIN);

            FontPL = new PopupList()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Font:|$cmbWatermarkFont|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FontPL);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Font:|$cmbWatermarkFont|#3/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            FontWIN = new CustomWin()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Font:|$cmbWatermarkFont|#3/[CustomWin]*Font:*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FontWIN);

            SizePL = new PopupList()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Size:|$cmbWatermarkFontSize|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizePL);

            Open3PB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Size:|$cmbWatermarkFontSize|#4/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open3PB);

            SizeWIN = new CustomWin()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Size:|$cmbWatermarkFontSize|#4/[CustomWin]*Size:*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeWIN);

            DirectionPL = new PopupList()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Direction:|$lkpTextDirection|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectionPL);

            Open4PB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Direction:|$lkpTextDirection|#2/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open4PB);

            DirectionWIN = new CustomWin()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Direction:|$lkpTextDirection|#2/[CustomWin]*Direction:*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectionWIN);

            TextPL = new PopupList()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Text:|$cmbWatermarkText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextPL);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[PopupList]Text:|$cmbWatermarkText|#1/[PopupList]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            ColorST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[StaticText]Color:|$lbFontColor|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorST);

            SizeST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[StaticText]Size:|$lbFontSize|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeST);

            Transparency0255SC = new Scale()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[Scale]Transparency (0-255):|$trBarTextTransparency|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Transparency0255SC);

            Transparency0255TF = new TextField()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[TextField]Transparency (0-255):|$teTransparentValue|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Transparency0255TF);

            Transparency0255WIN = new CustomWin()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[TextField]Transparency (0-255):|$teTransparentValue|#2/[CustomWin]*Transparency (0-255):*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Transparency0255WIN);

            Transparency0255ST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[StaticText]Transparency (0-255):|$lbTextTransparency|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Transparency0255ST);

            PositionST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Text Settings|$xtraTpTextSettings|#1/[Pane]$tpTextSettings|#1/[StaticText]Position:|$labelTextPosition|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PositionST);

            TextSettingsWIN = new Window()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Window]Text Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextSettingsWIN);

            PictureSettingsWIN = new Window()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Window]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PictureSettingsWIN);

            IdPANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Id|$grpBoxWatermarkId|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdPANE);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Id|$grpBoxWatermarkId|#1/[TextField]$teId|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Id|$grpBoxWatermarkId|#1/[TextField]$teId|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            PageRangePANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Page range|$grpBoxPageRange|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangePANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Page range|$grpBoxPageRange|#2/[Pane]$tblBoxPageRange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Page range|$grpBoxPageRange|#2/[Pane]$tblBoxPageRange|#1/[TextField]$tePageRange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Page range|$grpBoxPageRange|#2/[Pane]$tblBoxPageRange|#1/[TextField]$tePageRange|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            RadioButton3RB = new RadioButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Page range|$grpBoxPageRange|#2/[Pane]$tblBoxPageRange|#1/[RadioButton]$rbAll|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3RB);

            RadioButton4RB = new RadioButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Page range|$grpBoxPageRange|#2/[Pane]$tblBoxPageRange|#1/[RadioButton]$rbPages|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton4RB);

            EnterPageNumbersAndorST = new StaticText()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[Pane]Page range|$grpBoxPageRange|#2/[Pane]$tblBoxPageRange|#1/[StaticText]Enter page numbers and*|$lbPageRange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterPageNumbersAndorST);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            EnterPageNumbersAndorPANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]Enter page numbers and*|$watermarkListPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterPageNumbersAndorPANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$watermarkListPanel|#1/[PushButton]$btnAddWatermark|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]Enter page numbers and*|$watermarkListPanel|#1/[Pane]$watermarkListContainer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]Enter page numbers and*|$watermarkListPanel|#1/[Pane]$watermarkListContainer|#1/[ListBox]$watermarkList|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Watermark1LBI = new ListBoxItem()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]Enter page numbers and*|$watermarkListPanel|#1/[Pane]$watermarkListContainer|#1/[ListBox]$watermarkList|#1/[ListBoxItem]Watermark1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Watermark1LBI);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]Enter page numbers and*|$watermarkListPanel|#1/[PushButton]$btnDown|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]Enter page numbers and*|$watermarkListPanel|#1/[PushButton]$btnUp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            WatermarksCTL = new TitleBar()
            {
                Tag = "[TitleBar]Watermarks|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WatermarksCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Watermarks|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            BrowsePB = new PushButton()
            {
                Tag = "[Pane]$rootPanel|#2/[Pane]$editorsGroup|#2/[PageList]$tabControl|#1/[Pane]Picture Settings|$xtraTpPictureSettings|#1/[Pane]$tpPictureSettings|#1/[PushButton]Browse*|$btnSelectPicture|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);
        }
    }
}
