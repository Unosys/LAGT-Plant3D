// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#2", Parent = typeof(ReportConfigurationDLG), GUIType = GuiType.UIA)]
    public partial class ReportCreatorConfirmDeleteDLG : Pane
    {
        public  Pane M_mainTableLayoutPanel;
        public  Pane M_iconPicBox;
        public  Pane M_buttonsTableLayoutPanel;
        public  PushButton M_noBtn;
        public  PushButton M_yesBtn;
        public  StaticText M_msgLbl;
        public  TitleBar AutodeskAutoCADPlantReportCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportCreatorConfirmDeleteDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_mainTableLayoutPanel = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mainTableLayoutPanel);

            M_iconPicBox = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Are you sure you want to delete current report configuration?[1]|$m_iconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_iconPicBox);

            M_buttonsTableLayoutPanel = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Are you sure you want to delete current report configuration?[2]|$m_buttonsTableLayoutPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonsTableLayoutPanel);

            M_noBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Are you sure you want to delete current report configuration?[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]No|$m_noBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_noBtn);

            M_yesBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Are you sure you want to delete current report configuration?[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]Yes|$m_yesBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_yesBtn);

            M_msgLbl = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Are you sure you want to delete current report configuration?|$m_msgLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_msgLbl);

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
