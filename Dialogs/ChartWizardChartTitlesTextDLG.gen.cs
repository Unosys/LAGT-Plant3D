// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DesignerFormBase", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class ChartWizardChartTitlesTextDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton AddPB;
        public  Pane OptionsPANE;

        partial void OnInitialize();

        public ChartWizardChartTitlesTextDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#7/[PushButton]Cancel|$sbCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$hitTestTransparentPanelControl|#7/[PushButton]OK|$sbOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]pnlStructure|$pnlStructure|#3/[Pane]pnlActions|$pnlActions|#1/[Pane]$ucActionsControl|#1/[PushButton]$btnAddElement|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            OptionsPANE = new Pane()
            {
                Tag = "[Pane]pnlOptions|$pnlOptions|#7/[PageList]$tcOptionsProperties|#1/[Pane]Options|$tbpOptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OptionsPANE);
        }
    }
}
