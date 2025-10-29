// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class IsometricDWGSettingsIsoStyleSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox PlaceFieldWeldsAtCK;
        public  TextField MaximumPipeLengthTF;
        public  PushButton DropDownButton5PB;
        public  PushButton CancelPB;
        public  PopupList SizingMethodPL;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  PushButton PushButton4PB;
        public  PushButton PushButton3PB;
        public  PushButton PushButton2PB;
        public  PushButton PushButton1PB;
        public  Pane Pane5PANE;

        partial void OnInitialize();

        public IsometricDWGSettingsIsoStyleSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PlaceFieldWeldsAtCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1971426|#1/[Pane]$m_splitVert|#1/[Pane]$14486074|#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Field Welds and Makeup|$groupBox_FieldWelds|#3/[CheckBox]Place field welds at maximum pipe lengths|$checkBox_PlaceFieldWelds",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlaceFieldWeldsAtCK);

            MaximumPipeLengthTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$32638408|#1/[Pane]$m_splitVert|#1/[Pane]$2757140|#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Field Welds and Makeup|$groupBox_FieldWelds|#3/[TextField]Maximum pipe length:|$textBox_MaxPipeLength|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximumPipeLengthTF);

            DropDownButton5PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$7540474|#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[PopupList]$comboBox_IsoType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton5PB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            SizingMethodPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]$groupBox_Spools|#5/[PopupList]$comboBox_SpoolSizing|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizingMethodPL);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$18221148|#1/[Pane]$m_splitVert|#1/[Pane]*/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Drawing Type|$groupBox_DrawingType|#1/[RadioButton]$radioButton_Spool|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$18221148|#1/[Pane]$m_splitVert|#1/[Pane]*/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Drawing Type|$groupBox_DrawingType|#1/[RadioButton]$radioButton_Isometric|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            PushButton4PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2233834|#1/[Pane]$m_splitVert|#1/[Pane]$529804|#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Filename format|$groupBox_FileName|#4/[Pane]$token_panel|#1/[Pane]elementHost1|$token_host|#1/[Pane]elementHost1|#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]$AddTokenBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[PushButton]$button_NewType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$7540474|#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Content paths|$groupBox_Path|#5/[PushButton]**[2]|$button_QuickDir|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$7540474|#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Content paths|$groupBox_Path|#5/[PushButton]**[1]|$button_ProdDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$7540474|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);
        }
    }
}
