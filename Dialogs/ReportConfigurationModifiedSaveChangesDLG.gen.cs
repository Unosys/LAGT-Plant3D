// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1", Parent = typeof(ReportConfigurationDLG), GUIType = GuiType.UIA)]
    public partial class ReportConfigurationModifiedSaveChangesDLG : Pane
    {
        public  Pane PanePANE;
        public  Pane CurrentReportConfigurationHas1PANE;
        public  Pane CurrentReportConfigurationHas2PANE;
        public  PushButton M_noBtn;
        public  PushButton M_yesBtn;
        public  StaticText CurrentReportConfigurationHasST;
        public  TitleBar AutodeskAutoCADPlantReportCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportConfigurationModifiedSaveChangesDLG()
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

            CurrentReportConfigurationHas1PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Current report configuration has been modified*[1]|$m_iconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentReportConfigurationHas1PANE);

            CurrentReportConfigurationHas2PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Current report configuration has been modified*[2]|$m_buttonsTableLayoutPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentReportConfigurationHas2PANE);

            M_noBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Current report configuration has been modified*[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]No|$m_noBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_noBtn);

            M_yesBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Current report configuration has been modified*[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]Yes|$m_yesBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_yesBtn);

            CurrentReportConfigurationHasST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Current report configuration has been modified*|$m_msgLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentReportConfigurationHasST);

            AutodeskAutoCADPlantReportCTL = new TitleBar()
            {
                Tag = "[TitleBar]Autodesk AutoCAD Plant Report Creator|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskAutoCADPlantReportCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Autodesk AutoCAD Plant Report Creator|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
