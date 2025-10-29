// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]$MainForm", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class ReportCreatorDLG : Autodesk.GUIHarness.MainWin
    {
        public  Pane PanePANE;
        public  StaticText StaticTextST;
        public  Pane DataSource1PANE;
        public  PushButton M_settingsBtn;
        public  PopupList M_repConfigCmbBox;
        public  PushButton DropDownButton1PB;
        public  PushButton M_repConfigEditBtn;
        public  RadioButton M_drawingDataRadioBtn;
        public  RadioButton M_projectDataRadioBtn;
        public  PopupList M_projectCmbBox;
        public  PushButton DropDownButton2PB;
        public  StaticText ProjectNameST;
        public  StaticText ProjectVersionST;
        public  StaticText ProjectDescriptionST;
        public  StaticText FilePathST;
        public  StaticText OutputTypeST;
        public  StaticText TargetST;
        public  TreeView M_dwgsTreeView;
        public  StaticText ProjectST;
        public  StaticText ReportConfigurationST;
        public  StaticText DataSourceST;
        public  Pane DataSource2PANE;
        public  PushButton Close1PB;
        public  PushButton HelpPB;
        public  PushButton M_previewBtn;
        public  PushButton M_printBtn;
        public  TitleBar AutodeskAutoCADPlantReportCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public ReportCreatorDLG()
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

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]$m_bottomDelimiter|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            DataSource1PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Data Source[1]|$m_repConfigComboTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSource1PANE);

            M_settingsBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Data Source[1]|$m_repConfigComboTableLayoutPanel|#1/[PushButton]Settings|$m_settingsBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_settingsBtn);

            M_repConfigCmbBox = new PopupList()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Data Source[1]|$m_repConfigComboTableLayoutPanel|#1/[PopupList]$m_repConfigCmbBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_repConfigCmbBox);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Data Source[1]|$m_repConfigComboTableLayoutPanel|#1/[PopupList]$m_repConfigCmbBox|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            M_repConfigEditBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Data Source[1]|$m_repConfigComboTableLayoutPanel|#1/[PushButton]Edit*|$m_repConfigEditBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_repConfigEditBtn);

            M_drawingDataRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[RadioButton]Data Source[1]|$m_drawingDataRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingDataRadioBtn);

            M_projectDataRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[RadioButton]$m_projectDataRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectDataRadioBtn);

            M_projectCmbBox = new PopupList()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PopupList]Project|$m_projectCmbBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectCmbBox);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PopupList]Project|$m_projectCmbBox|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            ProjectNameST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Project Name:|$m_projectNameAttributeLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNameST);

            ProjectVersionST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Project Version:|$m_projectVersionAttributeLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectVersionST);

            ProjectDescriptionST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Project Description:|$m_projectDescriptionAttributeLbl|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDescriptionST);

            FilePathST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]File Path:|$m_repConfigFilePathAttributeLbl|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilePathST);

            OutputTypeST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Output Type:|$m_repConfigOutputTypeAttributeLbl|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OutputTypeST);

            TargetST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Target:|$m_repConfigTargetAttributeLbl|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TargetST);

            M_dwgsTreeView = new TreeView()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[TreeView]File Path:|$m_dwgsTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dwgsTreeView);

            ProjectST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Project|$m_projectLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectST);

            ReportConfigurationST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Report Configuration|$m_repConfigLbl|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportConfigurationST);

            DataSourceST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Data Source|$m_repDataLbl|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSourceST);

            DataSource2PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$m_bottomButtonsTableLayoutPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSource2PANE);

            Close1PB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$m_bottomButtonsTableLayoutPanel|#2/[PushButton]$m_closeBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$m_bottomButtonsTableLayoutPanel|#2/[PushButton]Help|$m_helpBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            M_previewBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$m_bottomButtonsTableLayoutPanel|#2/[PushButton]Preview|$m_previewBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_previewBtn);

            M_printBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$m_bottomButtonsTableLayoutPanel|#2/[PushButton]Print*|$m_printBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_printBtn);

            AutodeskAutoCADPlantReportCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskAutoCADPlantReportCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]System Menu Bar|$MainForm|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]System Menu Bar|$MainForm|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
