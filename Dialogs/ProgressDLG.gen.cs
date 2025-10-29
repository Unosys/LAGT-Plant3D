// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Progress|$ProgressForm", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class ProgressDLG : Pane
    {
        public  Pane AutodeskAutoCADPlantReportPANE;
        public  Pane PanePANE;
        public  Pane TheFileCTestFilepdfAlready1PANE;
        public  Pane TheFileCTestFilepdfAlready2PANE;
        public  PushButton NoPB;
        public  PushButton YesPB;
        public  StaticText TheFileCTestFilepdfAlreadyST;
        public  TitleBar AutodeskAutoCADPlantReportCTL;
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  StaticText ProcessingReport1OfST;
        public  CustomWin ProcessingReport1OfWIN;
        public  TitleBar ProgressCTL;

        partial void OnInitialize();

        public ProgressDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutodeskAutoCADPlantReportPANE = new Pane()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskAutoCADPlantReportPANE);

            PanePANE = new Pane()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[Pane]$m_mainTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            TheFileCTestFilepdfAlready1PANE = new Pane()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[1]|$m_iconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileCTestFilepdfAlready1PANE);

            TheFileCTestFilepdfAlready2PANE = new Pane()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[2]|$m_buttonsTableLayoutPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileCTestFilepdfAlready2PANE);

            NoPB = new PushButton()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]No|$m_noBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            YesPB = new PushButton()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[Pane]$m_mainTableLayoutPanel|#1/[Pane]The file \"C:*[2]|$m_buttonsTableLayoutPanel|#2/[PushButton]Yes|$m_yesBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            TheFileCTestFilepdfAlreadyST = new StaticText()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[Pane]$m_mainTableLayoutPanel|#1/[StaticText]The file \"C:*|$m_msgLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileCTestFilepdfAlreadyST);

            AutodeskAutoCADPlantReportCTL = new TitleBar()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[TitleBar]Autodesk AutoCAD Plant Report Creator|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskAutoCADPlantReportCTL);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$MessageForm|#1/[TitleBar]Autodesk AutoCAD Plant Report Creator|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_cancelBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ProcessingReport1OfST = new StaticText()
            {
                Tag = "[StaticText]Processing report 1 of 1|$m_statusLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProcessingReport1OfST);

            ProcessingReport1OfWIN = new CustomWin()
            {
                Tag = "[CustomWin]Processing report 1 of 1|$m_progressBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProcessingReport1OfWIN);

            ProgressCTL = new TitleBar()
            {
                Tag = "[TitleBar]Progress|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProgressCTL);
        }
    }
}
