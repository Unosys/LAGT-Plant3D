// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Autodesk AutoCAD Plant Report Creator|$ExceptionMessageForm|#2", Parent = typeof(ReportCreatorDLG), GUIType = GuiType.UIA)]
    public partial class ReportCreatorSelectDrawingErrorDLG : Pane
    {
        public  Pane PanePANE;
        public  Pane PleaseSelectAtLeast1PANE;
        public  StaticText PleaseSelectAtLeastST;
        public  Pane PleaseSelectAtLeast2PANE;
        public  PushButton M_detailsBtn;
        public  PushButton M_okBtn;
        public  TitleBar AutodeskAutoCADPlantReportCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportCreatorSelectDrawingErrorDLG()
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

            PleaseSelectAtLeast1PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Please select at least one drawing*[1]|$m_iconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseSelectAtLeast1PANE);

            PleaseSelectAtLeastST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Please select at least one drawing*|$m_mainExceptionText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseSelectAtLeastST);

            PleaseSelectAtLeast2PANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Please select at least one drawing*[2]|$m_buttonsPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseSelectAtLeast2PANE);

            M_detailsBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Please select at least one drawing*[2]|$m_buttonsPanel|#2/[PushButton]Details|$m_detailsBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_detailsBtn);

            M_okBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Please select at least one drawing*[2]|$m_buttonsPanel|#2/[PushButton]OK|$m_okBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

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
