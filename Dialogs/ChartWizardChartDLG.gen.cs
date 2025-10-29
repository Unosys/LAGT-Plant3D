// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DesignerFormBase", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class ChartWizardChartDLG : Pane
    {
        public  PushButton ClosePB;
        public  CustomizedPagelist PageListPG;
        public  Pane OptionsPANE;
        public  Pane Pane5PANE;
        public  PushButton CancelPB;
        public  Pane NbWizard;
        public  Pane PanelNavigation;
        public  CustomWin DataFiltersWIN;

        partial void OnInitialize();

        public ChartWizardChartDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Chart Designer|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            PageListPG = new CustomizedPagelist()
            {
                Tag = "[Pane]pnlOptions|$pnlOptions|#7/[PageList]$tcOptionsProperties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);

            OptionsPANE = new Pane()
            {
                Tag = "[Pane]pnlOptions|$pnlOptions|#7/[PageList]$tcOptionsProperties|#1/[Pane]$tbpOptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OptionsPANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]pnlOptions|$pnlOptions|#7/[PageList]$tcOptionsProperties|#1/[Pane]Options|$tbpOptions|#1/[Pane]$ucOptionsControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#8/[PushButton]Cancel|$sbCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            NbWizard = new Pane()
            {
                Tag = "[Pane]$pnlBase/[Pane]$grWizardPanel/[Pane]$panelNavigation|#1/[Pane]$nbWizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NbWizard);

            PanelNavigation = new Pane()
            {
                Tag = "[Pane]$pnlBase/[Pane]$grWizardPanel/[Pane]$panelNavigation|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanelNavigation);

            DataFiltersWIN = new CustomWin()
            {
                Tag = "[Pane]pnlOptions|$pnlOptions|#6/[PageList]$tcOptionsProperties|#1/[Pane]Properties|$tbpProperties|#1/[Pane]$ucPropertyGrid|#1/[Table]$propertyGrid|#1/[CustomWin]Data Panel|#2/[CustomWin]#1/[CustomWin]Data Filters|#40",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataFiltersWIN);
        }
    }
}
