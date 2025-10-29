// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Chart Wizard|$WizardFormBase", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG : Pane
    {
        public  PageList PageListPG;
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

        public ChartWizardSeriesViewsFibonacciIndicatorsLevelsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PageListPG = new PageList()
            {
                Tag = "[Pane]pnlBase|$pnlBase|#1/[Pane]$grWizardPanel|#1/[Pane]$workPanel|#2/[Pane]grWizardParentControl|$grWizardParentControl|#1/[Pane]$pnlParent|#3/[Pane]$SeriesViewConfigControl|#1/[Pane]splitter|$splitter|#1/[Pane]$1377024|#3/[Pane]$tabPanel|#3/[Pane]$XYDiagramSeriesViewBaseControl|#1/[PageList]$tbcPagesControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]Cancel|$sbCancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PreviousPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]<< Previous|$sbPreviousPage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousPB);

            FinishPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]Finish|$sbFinish|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FinishPB);

            NextPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#2/[PushButton]Next >>|$sbNextPage|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            ChartWizardCTL = new TitleBar()
            {
                Tag = "[TitleBar]Chart Wizard|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChartWizardCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Chart Wizard|$TitleBar|#1/[CustomWin]System Menu Bar|$WizardFormBase|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Chart Wizard|$TitleBar|#1/[CustomWin]System Menu Bar|$WizardFormBase|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Chart Wizard|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Chart Wizard|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Chart Wizard|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
