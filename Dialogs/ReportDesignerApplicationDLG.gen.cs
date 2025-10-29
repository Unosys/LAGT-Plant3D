// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$XRDesignFormExBase", Parent = typeof(Pane))]
    public partial class ReportDesignerApplicationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane DevExpressXtraReportsUserDesignerXRDesignToolBox;
        public  PushButton ClosePB;
        public  Pane ToolBoxDockPanel1;
        public  MenuItem WindowsMI;
        public  CustomizedPagelist RibbonTabsPG;
        public  Pane CornerPanel;
        public  PushButton GroupAndSortPB;
        public  PushButton FieldListPB;
        public  Pane FilterStringPANE;

        partial void OnInitialize();

        public ReportDesignerApplicationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DevExpressXtraReportsUserDesignerXRDesignToolBox = new Pane()
            {
                Tag = "[Pane]$toolBoxDockPanel1|#2/[Pane]$toolBoxDockPanel1_Container|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraReportsUserDesignerXRDesignToolBox);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ToolBoxDockPanel1 = new Pane()
            {
                Tag = "[Pane]$toolBoxDockPanel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBoxDockPanel1);

            WindowsMI = new MenuItem()
            {
                Tag = "[Pane]#1/[Pane]#1/[Pane]#1/[ToolBar]#5/[MenuItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WindowsMI);

            RibbonTabsPG = new CustomizedPagelist()
            {
                Tag = "[Pane]$83560316|#1/[PageList]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RibbonTabsPG);

            CornerPanel = new Pane()
            {
                Tag = "[Pane]$xrDesignPanel|#3/[Pane]#1/[Pane]$ReportFrame|#1/[Pane]$topPanel/[Pane]$cornerPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CornerPanel);

            GroupAndSortPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]#1/[Pane]#1/[ToolBar]#5/[MenuItem]#1/[PushButton]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupAndSortPB);

            FieldListPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]Lower Ribbon|#1/[Pane]View|#1/[ToolBar]View|#5/[MenuItem]#1/[PushButton]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldListPB);

            FilterStringPANE = new Pane()
            {
                Tag = "[Pane]#4/[Pane]#1/[Pane]#1/[Pane]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringPANE);
        }
    }
}
