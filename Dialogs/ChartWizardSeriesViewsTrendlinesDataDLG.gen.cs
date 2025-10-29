// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$WizardFormBase", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class ChartWizardSeriesViewsTrendlinesDataDLG : Pane
    {
        public  PageList PageList2PG;
        public  PushButton CancelPB;
        public  PushButton PreviousPB;
        public  PushButton FinishPB;
        public  PushButton NextPB;
        public  TitleBar ChartWizardCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ChartWizardSeriesViewsTrendlinesDataDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PageList2PG = new PageList()
            {
                Tag = "[Pane]$pnlBase|#1/[Pane]$grWizardPanel|#1/[Pane]$workPanel|#2/[Pane]$grWizardParentControl|#1/[Pane]$pnlParent|#3/[Pane]$SeriesViewConfigControl|#1/[Pane]$splitter|#1/[Pane]$1388778|#3/[Pane]$tabPanel|#3/[Pane]$XYDiagramSeriesViewBaseControl|#1/[PageList]$tbcPagesControl|#1/[Pane]$tbIndicators|#1/[Pane]$indicatorsControl|#1/[Pane]$panelIndicator|#3/[Pane]$TrendLineControl|#1/[Pane]$panelProperties|#3/[PageList]$xtraTabControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageList2PG);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]$sbCancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PreviousPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]$sbPreviousPage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousPB);

            FinishPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]$sbFinish|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FinishPB);

            NextPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]$sbNextPage|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            ChartWizardCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChartWizardCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]$WizardFormBase|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]$WizardFormBase|#1/[MenuItem]$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
