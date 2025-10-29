// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$ReportConfigurationForm")]
    public partial class ReportConfigurationDLG : Pane
    {
        public  Pane PanePANE;
        public  StaticText ReportConfigurationST;
        public  CheckBox M_overrideFileChkBox;
        public  TextField M_exportFilePathTxtBox;
        public  StaticText ExportFilePathST;
        public  PopupList M_repConfigCmbBox;
        public  ComboBox ReportConfigurationCB;
        public  PushButton DropDownButtonPB;
        public  StaticText TargetST;
        public  Pane TargetPANE;
        public  PushButton M_okBtn;
        public  PushButton M_cancelBtn;
        public  Pane ReportConfigurationPANE_1;
        public  RadioButton RadioButton1RB;
        public  RadioButton M_oneReportDwgRadioBtn;
        public  RadioButton M_oneReportRadioBtn;
        public  PushButton PushButton2PB;
        public  PushButton M_varsBtn;
        public  CheckBox M_showPrintOptionsChkBox;
        public  CheckBox AllReportsInOneCK;
        public  PushButton M_saveBtn;
        public  PushButton M_deleteBtn;
        public  ComboBox TargetCB;
        public  PushButton M_editQryBtn;
        public  PushButton M_editReportLayoutBtn;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportConfigurationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            ReportConfigurationST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]$m_repConfigLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportConfigurationST);

            M_overrideFileChkBox = new CheckBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[CheckBox]Overwrite existing file|$m_overrideFileChkBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_overrideFileChkBox);

            M_exportFilePathTxtBox = new TextField()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[TextField]Export File Path:|$m_exportFilePathTxtBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_exportFilePathTxtBox);

            ExportFilePathST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Export File Path:|$m_exportFilePathLbl|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportFilePathST);

            M_repConfigCmbBox = new PopupList()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PopupList]$m_repConfigCmbBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_repConfigCmbBox);

            ReportConfigurationCB = new ComboBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel/[ComboBox]$m_repConfigCmbBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportConfigurationCB);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PopupList]$m_repConfigCmbBox|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            TargetST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Target|$m_targetAttrLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TargetST);

            TargetPANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Target|$tableLayoutPanel1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TargetPANE);

            M_okBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Target|$tableLayoutPanel1|#4/[PushButton]OK|$m_okBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

            M_cancelBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Target|$tableLayoutPanel1|#3/[PushButton]Cancel|$m_cancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            ReportConfigurationPANE_1 = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$panel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportConfigurationPANE_1);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$panel1|#2/[RadioButton]$m_oneReportObjRadioBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            M_oneReportDwgRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$panel1|#2/[RadioButton]$m_oneReportDwgRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_oneReportDwgRadioBtn);

            M_oneReportRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$panel1|#2/[RadioButton]$m_oneReportRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_oneReportRadioBtn);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]$m_exportDirBrowseBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            M_varsBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]$m_varsBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_varsBtn);

            M_showPrintOptionsChkBox = new CheckBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[CheckBox]$m_showPrintOptionsChkBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_showPrintOptionsChkBox);

            AllReportsInOneCK = new CheckBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[CheckBox]$m_allInOneChkBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllReportsInOneCK);

            M_saveBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]$m_saveBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_saveBtn);

            M_deleteBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]$m_deleteBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_deleteBtn);

            TargetCB = new ComboBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[ComboBox]Target|$m_targetCmbBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TargetCB);

            M_editQryBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]$m_editQryBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editQryBtn);

            M_editReportLayoutBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]$m_editReportLayoutBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editReportLayoutBtn);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
