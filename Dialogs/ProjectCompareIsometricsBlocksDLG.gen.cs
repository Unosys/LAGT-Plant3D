// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectCompareIsometricsBlocksDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar ProjectCompareCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close1PB;
        public  StaticText CurrentProjectDefaultProjectST;
        public  PushButton PushButton1PB;
        public  StaticText ComparedToSampleProjectST;
        public  StaticText CompareSummaryST;
        public  TreeView TreeViewTV;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory1TVI;
        public  StaticText ProjectST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory2TVI;
        public  PushButton PushButton2PB;
        public  StaticText PIDST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory3TVI;
        public  StaticText Classes1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI;
        public  PushButton PushButton3PB;
        public  StaticText Piping3DST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI;
        public  StaticText Classes2ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI;
        public  StaticText LayerColorSettingsST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI;
        public  PushButton PushButton4PB;
        public  StaticText IsometricsST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI;
        public  StaticText BlocksST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI;
        public  StaticText IsoStylesST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI;
        public  StaticText SupportFilesST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI;
        public  PushButton PushButton5PB;
        public  StaticText OrthosST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI;
        public  StaticText OrthoCubeLibraryST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI;
        public  StaticText MiscST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI;
        public  StaticText SpecSheetsST;
        public  CustomWin CustomWinWIN;
        public  StaticText IsometricsBlocksST;
        public  PushButton PushButton6PB;
        public  PushButton PushButton7PB;
        public  ListBox ListBoxLB;
        public  GroupBox ModifiedGB;
        public  ListBoxItem AnnoCCircleLBI;
        public  StaticText AnnoCCircleST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource2LBI;
        public  StaticText AnnoCircleST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource3LBI;
        public  StaticText AnnoDiamondST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource4LBI;
        public  StaticText AnnoEllipseST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource5LBI;
        public  StaticText AnnoInsulationWithTracingST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource6LBI;
        public  StaticText AnnoSlopeAngleST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource7LBI;
        public  StaticText AnnoSlopeGradientST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource8LBI;
        public  StaticText AnnoSlopeImperialInclineST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource9LBI;
        public  StaticText AnnoSlopeMetricInclineST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource10LBI;
        public  StaticText AnnoSlopePercentST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource11LBI;
        public  StaticText AnnoSlopeRatioST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource12LBI;
        public  StaticText AnnoSlotST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource13LBI;
        public  StaticText AnnoTriangleST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource14LBI;
        public  StaticText Press1ST;
        public  StaticText Press2ST;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText ExistingBlockInCurrentST;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  Thumb ThumbCTL;
        public  PushButton Close2PB;
        public  StaticText CloseST;
        public  PushButton SyncReviewPB;
        public  StaticText SyncReviewST;

        partial void OnInitialize();

        public ProjectCompareIsometricsBlocksDLG()
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

            CurrentProjectDefaultProjectST = new StaticText()
            {
                Tag = "[StaticText]Current Project:      DefaultProject|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjectST);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            ComparedToSampleProjectST = new StaticText()
            {
                Tag = "[StaticText]Compared to:      SampleProject|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComparedToSampleProjectST);

            CompareSummaryST = new StaticText()
            {
                Tag = "[StaticText]Compare Summary|$TextBox_1|#3",
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

            Classes1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#2/[TreeViewItem]Autodesk*|#1/[StaticText]Classes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Classes1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI);

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

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI);

            Classes2ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#1/[StaticText]Classes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Classes2ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI);

            LayerColorSettingsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#3/[TreeViewItem]Autodesk*|#2/[StaticText]Layer *|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerColorSettingsST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI);

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

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI);

            BlocksST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#1/[StaticText]Blocks|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlocksST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI);

            IsoStylesST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#2/[StaticText]Iso Styles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStylesST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI);

            SupportFilesST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#3/[StaticText]Support Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportFilesST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI);

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

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5/[TreeViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI);

            OrthoCubeLibraryST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#5/[TreeViewItem]Autodesk*|#1/[StaticText]OrthoCube Library|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoCubeLibraryST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI);

            MiscST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#6/[StaticText]Misc|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MiscST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI);

            SpecSheetsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#7/[StaticText]Spec Sheets|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheetsST);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            IsometricsBlocksST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Isometrics Blocks|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricsBlocksST);

            PushButton6PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]$Button_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            PushButton7PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton7PB);

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

            AnnoCCircleLBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoCCircleLBI);

            AnnoCCircleST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#1/[StaticText]AnnoCCircle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoCCircleST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource2LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource2LBI);

            AnnoCircleST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#2/[StaticText]AnnoCircle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoCircleST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource3LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource3LBI);

            AnnoDiamondST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#3/[StaticText]AnnoDiamond|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoDiamondST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource4LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource4LBI);

            AnnoEllipseST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#4/[StaticText]AnnoEllipse|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoEllipseST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource5LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource5LBI);

            AnnoInsulationWithTracingST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#5/[StaticText]AnnoInsulation with Tracing|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoInsulationWithTracingST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource6LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource6LBI);

            AnnoSlopeAngleST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#6/[StaticText]AnnoSlopeAngle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoSlopeAngleST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource7LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource7LBI);

            AnnoSlopeGradientST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#7/[StaticText]AnnoSlopeGradient|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoSlopeGradientST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource8LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource8LBI);

            AnnoSlopeImperialInclineST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#8/[StaticText]AnnoSlopeImperialIncline|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoSlopeImperialInclineST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource9LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource9LBI);

            AnnoSlopeMetricInclineST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#9/[StaticText]AnnoSlopeMetricIncline|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoSlopeMetricInclineST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource10LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource10LBI);

            AnnoSlopePercentST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#10/[StaticText]AnnoSlopePercent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoSlopePercentST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource11LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource11LBI);

            AnnoSlopeRatioST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#11/[StaticText]AnnoSlopeRatio|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoSlopeRatioST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource12LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource12LBI);

            AnnoSlotST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#12/[StaticText]AnnoSlot|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoSlotST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource13LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource13LBI);

            AnnoTriangleST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#13/[StaticText]AnnoTriangle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnoTriangleST);

            AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource14LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareConflictSource14LBI);

            Press1ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#14/[StaticText]Press|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Press1ST);

            Press2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Press|$TextBlock_9|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Press2ST);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]#1/[Pane]$7212656|#1",
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
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]#2/[Pane]$4263154|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            ThumbCTL = new Thumb()
            {
                Tag = "[Thumb]$GridSplitter_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThumbCTL);

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
                Tag = "[PushButton]Sync Review|$Button_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SyncReviewPB);

            SyncReviewST = new StaticText()
            {
                Tag = "[PushButton]Sync Review|$Button_2|#2/[StaticText]Sync Review|$TextBlock_4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SyncReviewST);
        }
    }
}
