// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$WizardFormBase", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class ChartWizardDataPointsDLG : Pane
    {
        public  GroupBox ChartPanelControl1;
        public  GroupBox GrWizardPanel;
        public  GroupBox NewChartDataControl;
        public  GroupBox PanelControl1;
        public  GroupBox PanelNavigation;
        public  GroupBox PnlHintOffset;
        public  GroupBox PnlParent;
        public  Table PointsGrid;
        public  GroupBox SeriesPointEditControl;
        public  GroupBox WorkPanel;

        partial void OnInitialize();

        public ChartWizardDataPointsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ChartPanelControl1 = new GroupBox()
            {
                Tag = "[GroupBox]$chartPanelControl1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChartPanelControl1);

            GrWizardPanel = new GroupBox()
            {
                Tag = "[GroupBox]$grWizardPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GrWizardPanel);

            NewChartDataControl = new GroupBox()
            {
                Tag = "[GroupBox]$NewChartDataControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewChartDataControl);

            PanelControl1 = new GroupBox()
            {
                Tag = "[GroupBox]$panelControl1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanelControl1);

            PanelNavigation = new GroupBox()
            {
                Tag = "[GroupBox]$panelNavigation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanelNavigation);

            PnlHintOffset = new GroupBox()
            {
                Tag = "[GroupBox]$pnlHintOffset",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlHintOffset);

            PnlParent = new GroupBox()
            {
                Tag = "[GroupBox]$pnlParent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlParent);

            PointsGrid = new Table()
            {
                Tag = "[Table]$pointsGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PointsGrid);

            SeriesPointEditControl = new GroupBox()
            {
                Tag = "[GroupBox]$SeriesPointEditControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SeriesPointEditControl);

            WorkPanel = new GroupBox()
            {
                Tag = "[GroupBox]$workPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WorkPanel);
        }
    }
}
