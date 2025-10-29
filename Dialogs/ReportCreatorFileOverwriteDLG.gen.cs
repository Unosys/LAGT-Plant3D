// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1", Parent = typeof(ProgressDLG), GUIType = GuiType.UIA)]
    public partial class ReportCreatorFileOverwriteDLG : Pane
    {
        public  Pane PanePANE;
        public  Pane TheFileCTestFilepdfAlready1PANE;
        public  Pane TheFileCTestFilepdfAlready2PANE;
        public  PushButton M_noBtn;
        public  PushButton M_yesBtn;
        public  StaticText TheFileCTestFilepdfAlreadyST;
        public  TitleBar AutodeskAutoCADPlantReportCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportCreatorFileOverwriteDLG()
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

            TheFileCTestFilepdfAlready1PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[1]|$m_iconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileCTestFilepdfAlready1PANE);

            TheFileCTestFilepdfAlready2PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[2]|$m_buttonsTableLayoutPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileCTestFilepdfAlready2PANE);

            M_noBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]No|$m_noBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_noBtn);

            M_yesBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]Yes|$m_yesBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_yesBtn);

            TheFileCTestFilepdfAlreadyST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]The file \"C:*|$m_msgLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileCTestFilepdfAlreadyST);

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
