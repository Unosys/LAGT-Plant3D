// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$WizardFormBase", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class ChartWizardApearanceDLG : Autodesk.GUIHarness.Pane
    {
        public  GroupBox ChartAppearanceControl;
        public  GroupBox ChartPanelControl1;
        public  GroupBox GrWizardPanel;
        public  GroupBox PanelNavigation;
        public  GroupBox PnlHintOffset;
        public  GroupBox PnlParent;
        public  GroupBox WorkPanel;

        partial void OnInitialize();

        public ChartWizardApearanceDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ChartAppearanceControl = new GroupBox()
            {
                Tag = "[GroupBox]$ChartAppearanceControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChartAppearanceControl);

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
