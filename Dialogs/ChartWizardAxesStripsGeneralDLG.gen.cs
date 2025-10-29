// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$WizardFormBase", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class ChartWizardAxesStripsGeneralDLG : Pane
    {
        public  PushButton AddPB;

        partial void OnInitialize();

        public ChartWizardAxesStripsGeneralDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddPB = new PushButton()
            {
                Tag = "[Pane]pnlBase|$pnlBase/[Pane]$grWizardPanel/[Pane]$workPanel/[Pane]grWizardParentControl|$grWizardParentControl/[Pane]$pnlParent/[Pane]$ChartAxesControl/[Pane]splitter|$splitter/[Pane]$1443790|#2/[Pane]$tabPanel/[Pane]$ChartAxisControl/[PageList]$tbcTabPages/[Pane]Strips|$tbStrips/[Pane]$stripsControl/[Pane]$stripsListControl/[Pane]$panelControl2/[PushButton]Add|$cbAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);
        }
    }
}
