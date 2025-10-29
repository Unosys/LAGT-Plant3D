// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Project Compare|$Window_1|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectComparePIDBlocksDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar ProjectCompareCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close1PB;
        public  StaticText CurrentProjectST;
        public  StaticText DefaultProjectST;
        public  StaticText ComparedToST;
        public  PushButton PushButton1PB;
        public  StaticText SampleProjectST;
        public  StaticText CompareSummaryST;
        public  TreeView TreeViewTV;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory1TVI;
        public  StaticText ProjectST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory2TVI;
        public  PushButton PushButton2PB;
        public  StaticText PIDST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory3TVI;
        public  StaticText Blocks1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI;
        public  StaticText Classes1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI;
        public  PushButton PushButton3PB;
        public  StaticText Piping3DST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI;
        public  StaticText Classes2ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI;
        public  StaticText LayerColorSettingsST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI;
        public  StaticText SupportFiles1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI;
        public  PushButton PushButton4PB;
        public  StaticText IsometricsST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI;
        public  StaticText Blocks2ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI;
        public  StaticText IsoStylesST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI;
        public  StaticText SupportFiles2ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI;
        public  PushButton PushButton5PB;
        public  StaticText OrthosST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI;
        public  StaticText OrthoCubeLibraryST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory15TVI;
        public  PushButton PushButton6PB;
        public  StaticText PipeSpecsST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory16TVI;
        public  StaticText SpecSheetsST;
        public  Thumb ThumbCTL;
        public  CustomWin CustomWinWIN;
        public  StaticText PIDBlocksST;
        public  PushButton PushButton7PB;
        public  PushButton PushButton8PB;
        public  ListBox ListBoxLB;
        public  GroupBox ModifiedGB;
        public  ListBoxItem OvalTagStyle3dblock1LBI;
        public  StaticText OvalTagStyle3dblock1ST;
        public  StaticText OvalTagStyle3dblock2ST;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText ExistingBlockInCurrentST;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  PushButton Close2PB;
        public  StaticText CloseST;
        public  PushButton SyncReviewPB;
        public  StaticText SyncReviewST;

        partial void OnInitialize();

        public ProjectComparePIDBlocksDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ProjectCompareCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectCompareCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            CurrentProjectST = new StaticText()
            {
                Tag = "[StaticText]Current Project:|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectST);

            DefaultProjectST = new StaticText()
            {
                Tag = "[StaticText]DefaultProject|$TextBlock_5|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultProjectST);

            ComparedToST = new StaticText()
            {
                Tag = "[StaticText]Compared to:|$TextBlock_6|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComparedToST);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            SampleProjectST = new StaticText()
            {
                Tag = "[StaticText]SampleProject|$TextBlock_7|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SampleProjectST);

            CompareSummaryST = new StaticText()
            {
                Tag = "[StaticText]Compare Summary|$TextBox_1|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompareSummaryST);

            TreeViewTV = new TreeView()
            {
                Tag = "[TreeView]$TreeView_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory1TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory1TVI);

            ProjectST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#1/[StaticText]Project|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory2TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory2TVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PIDST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2/[StaticText]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory3TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory3TVI);

            Blocks1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2/[TreeViewItem]Autodesk*|#1/[StaticText]Blocks|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Blocks1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2/[TreeViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI);

            Classes1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2/[TreeViewItem]Autodesk*|#2/[StaticText]Classes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Classes1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI);

            PushButton3PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            Piping3DST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[StaticText]Piping(3D)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Piping3DST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI);

            Classes2ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#1/[StaticText]Classes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Classes2ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI);

            LayerColorSettingsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#2/[StaticText]Layer *|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerColorSettingsST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI);

            SupportFiles1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#3/[StaticText]Support Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportFiles1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI);

            PushButton4PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            IsometricsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[StaticText]Isometrics|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricsST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI);

            Blocks2ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#1/[StaticText]Blocks|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Blocks2ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI);

            IsoStylesST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#2/[StaticText]Iso Styles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStylesST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI);

            SupportFiles2ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#3/[StaticText]Support Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportFiles2ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI);

            PushButton5PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            OrthosST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5/[StaticText]Orthos|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthosST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI);

            OrthoCubeLibraryST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5/[TreeViewItem]Autodesk*|#1/[StaticText]OrthoCube Library|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoCubeLibraryST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory15TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory15TVI);

            PushButton6PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#6/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            PipeSpecsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#6/[StaticText]Pipe Specs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecsST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory16TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#6/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory16TVI);

            SpecSheetsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#6/[TreeViewItem]Autodesk*|#1/[StaticText]Spec Sheets|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheetsST);

            ThumbCTL = new Thumb()
            {
                Tag = "[Thumb]$GridSplitter_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThumbCTL);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            PIDBlocksST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]P*|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDBlocksST);

            PushButton7PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]$Button_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton7PB);

            PushButton8PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton8PB);

            ListBoxLB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            ModifiedGB = new GroupBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifiedGB);

            OvalTagStyle3dblock1LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OvalTagStyle3dblock1LBI);

            OvalTagStyle3dblock1ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#1/[StaticText]Oval Tag Style_3dblock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OvalTagStyle3dblock1ST);

            OvalTagStyle3dblock2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Oval Tag Style_3dblock|$TextBlock_9|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OvalTagStyle3dblock2ST);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$SourceBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$SourceBlock|#1/[Pane]$3087530|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ExistingBlockInCurrentST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Existing Block in Current Project|$TextBlock_10|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExistingBlockInCurrentST);

            Pane3PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$TargetBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$TargetBlock|#2/[Pane]$21041764|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$Button_4|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

            CloseST = new StaticText()
            {
                Tag = "[PushButton]Close|$Button_4|#3/[StaticText]Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseST);

            SyncReviewPB = new PushButton()
            {
                Tag = "[PushButton]Sync Review|$Button_8|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SyncReviewPB);

            SyncReviewST = new StaticText()
            {
                Tag = "[PushButton]Sync Review|$Button_8|#2/[StaticText]Sync Review|$TextBlock_4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SyncReviewST);
        }
    }
}
