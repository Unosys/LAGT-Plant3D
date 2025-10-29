// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$WizardView", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class ReportWizardDLG : Pane
    {
        public  PushButton PushButtonPB;
        public  PushButton NextPB;
        public  PushButton FinishPB;
        public  TreeViewItem LeftNode01TVI;
        public  TreeViewItem RightNode1TVI;
        public  PushButton AddPB;
        public  CheckBox IgnoreNullValuesCK;
        public  PushButton LandscapePB;
        public  ListBox ListBoxLB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportWizardDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]#1/[PushButton]$buttonPrevious|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            NextPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]The XtraLayoutControl|$layoutControlBase|#1/[PushButton]Next|$buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            FinishPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$layoutControlBase|#1/[PushButton]$buttonFinish|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FinishPB);

            LeftNode01TVI = new TreeViewItem()
            {
                Tag = "[Pane]$MasterDetailSelectDataMembersPageView|#1/[Pane]The XtraLayoutControl|$layoutControlBase|#1/[Pane]panelBaseContent|$panelBaseContent|#2/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$treeListQueries|#1/[CustomWin]Data Panel|#1/[TreeViewItem]Node0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LeftNode01TVI);

            RightNode1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$MasterDetailSelectDataMembersPageView|#1/[Pane]The XtraLayoutControl|$layoutControlBase|#1/[Pane]panelBaseContent|$panelBaseContent|#2/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$treeListFields|#2/[CustomWin]Data Panel|#1/[TreeViewItem]Node0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RightNode1TVI);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$MasterDetailAddGroupingLevelPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControl1|#1/[PushButton]$addGroupingButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            IgnoreNullValuesCK = new CheckBox()
            {
                Tag = "[Pane]$MasterDetailChooseSummaryOptionsPageView|#1/[Pane]The XtraLayoutControl|$layoutControlBase|#1/[Pane]panelBaseContent|$panelBaseContent|#2/[Pane]The XtraLayoutControl|$layoutControl1|#1/[CheckBox]Ignore null values|$ignoreNullValuesEdit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IgnoreNullValuesCK);

            LandscapePB = new PushButton()
            {
                Tag = "[Pane]$ConfigureReportPageSettingsPageView|#1/[Pane]The XtraLayoutControl|$layoutControlBase|#1/[Pane]panelBaseContent|$panelBaseContent|#2/[Pane]tablePanel1|$tablePanel1|#1/[Pane]$pageSetupControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Landscape|$cbLandscape|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LandscapePB);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$ChooseReportColorSchemePageView|#1/[Pane]The XtraLayoutControl|$layoutControlBase|#1/[Pane]panelBaseContent|$panelBaseContent|#2/[ListBox]$gridControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Report Wizard|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
