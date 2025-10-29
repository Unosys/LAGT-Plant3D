// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Settings|$SettingsForm|#2", Parent = typeof(ReportCreatorDLG), GUIType = GuiType.UIA)]
    public partial class SettingsDLG : Pane
    {
        public  Pane PanePANE;
        public  StaticText LocationOfReportConfigurationST;
        public  RadioButton M_repFilesLocGeneralRadioBtn;
        public  RadioButton M_repFilesLocProjectRadioBtn;
        public  RadioButton M_repFilesLocCustomRadioBtn;
        public  TextField M_customPathTxtBox;
        public  PushButton M_customPathEditBtn;
        public  StaticText CProgramDataAutodeskAutodeskAutoCADPlant3DST;
        public  TextField M_projectPathTxtBox;
        public  PushButton M_okBtn;
        public  PushButton M_cancelBtn;
        public  TitleBar SettingsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SettingsDLG()
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

            LocationOfReportConfigurationST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Location of Report Configuration Files|$m_repFilesLocationLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocationOfReportConfigurationST);

            M_repFilesLocGeneralRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[RadioButton]Location of Report Configuration Files[1]|$m_repFilesLocGeneralRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_repFilesLocGeneralRadioBtn);

            M_repFilesLocProjectRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[RadioButton]Location of Report Configuration Files[2]|$m_repFilesLocProjectRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_repFilesLocProjectRadioBtn);

            M_repFilesLocCustomRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[RadioButton]Location of Report Configuration Files[3]|$m_repFilesLocCustomRadioBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_repFilesLocCustomRadioBtn);

            M_customPathTxtBox = new TextField()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[TextField]C:*[1]|$m_customPathTxtBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_customPathTxtBox);

            M_customPathEditBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]**|$m_customPathEditBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_customPathEditBtn);

            CProgramDataAutodeskAutodeskAutoCADPlant3DST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]C:*|$m_generalPathLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CProgramDataAutodeskAutodeskAutoCADPlant3DST);

            M_projectPathTxtBox = new TextField()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[TextField]C:*[2]|$m_projectPathTxtBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectPathTxtBox);

            M_okBtn = new PushButton()
            {
                Tag = "[PushButton]OK|$m_okBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

            M_cancelBtn = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_cancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            SettingsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Settings|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SettingsForm|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SettingsForm|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
