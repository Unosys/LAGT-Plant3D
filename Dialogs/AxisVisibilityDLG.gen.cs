// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AxisVisibilityInPanesForm", Parent = typeof(ChartWizardChartDLG))]
    public partial class AxisVisibilityDLG : Autodesk.GUIHarness.Pane
    {
        public  CustomWin ContentPanel;
        public  CustomWin FooterPanel;
        public  CustomWin LabelControl1;
        public  ListView ListViewPanes;
        public  Header ListViewPanesHeader;
        public  CustomWin SimpleButton1;

        partial void OnInitialize();

        public AxisVisibilityDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ContentPanel = new CustomWin()
            {
                Tag = "[CustomWin]$contentPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentPanel);

            FooterPanel = new CustomWin()
            {
                Tag = "[CustomWin]$footerPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FooterPanel);

            LabelControl1 = new CustomWin()
            {
                Tag = "[CustomWin]$labelControl1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LabelControl1);

            ListViewPanes = new ListView()
            {
                Tag = "[ListView]$listViewPanes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewPanes);

            ListViewPanesHeader = new Header()
            {
                Tag = "[Header]$listViewPanes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewPanesHeader);

            SimpleButton1 = new CustomWin()
            {
                Tag = "[CustomWin]$simpleButton1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SimpleButton1);
        }
    }
}
