// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Project Compare|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectCompare : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  TreeViewItem ProjectTVI;
        public  StaticText Project1ST;
        public  TreeViewItem PIDTVI;
        public  PushButton PushButton2PB;
        public  StaticText PID1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory3TVI;
        public  StaticText Classes1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI;
        public  PushButton PushButton3PB;
        public  StaticText Piping3D1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI;
        public  StaticText Classes2ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI;
        public  StaticText LayerColorSettingsST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI;
        public  PushButton PushButton4PB;
        public  StaticText Isometrics1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI;
        public  StaticText BlocksST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI;
        public  StaticText IsoStylesST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI;
        public  StaticText SupportFilesST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI;
        public  PushButton PushButton5PB;
        public  StaticText Orthos1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI;
        public  StaticText OrthoCubeLibraryST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI;
        public  StaticText Misc1ST;
        public  TreeViewItem AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI;
        public  StaticText SpecSheets1ST;
        public  CustomWin CustomWinWIN;
        public  StaticText ProjectCompareSummaryST;
        public  Pane Pane1PANE;
        public  StaticText CompareSuccessfulST;
        public  StaticText ProjectUnitsMatchCurrentST;
        public  StaticText NoDifferencesFoundInST;
        public  StaticText Project2ST;
        public  StaticText Misc2ST;
        public  StaticText ProjectDifferencesFoundST;
        public  StaticText StaticTextST;
        public  StaticText DifferencesFoundInTheseST;
        public  StaticText PID2ST;
        public  StaticText Piping3D2ST;
        public  StaticText Isometrics2ST;
        public  StaticText Orthos2ST;
        public  StaticText SpecSheets2ST;
        public  Pane Pane2PANE;
        public  StaticText ProjectInformationThatIsST;
        public  StaticText DefaultProjectST;
        public  StaticText WillBeDisplayedWithST;
        public  StaticText SampleProjectST;
        public  StaticText DifferencesYouChooseToST;
        public  Thumb ThumbCTL;
        public  PushButton Close2PB;
        public  StaticText CloseST;
        public  PushButton SyncReviewPB;
        public  StaticText SyncReviewST;
        public  ListBox ListBoxLB;
        public  GroupBox ModifiedGB;
        public  ListBoxItem CheckANSIBLBI;
        public  StaticText CheckANSIBST;
        public  ListBox CheckANSIBFilesLB;
        public  ListBoxItem Isoatr;
        public  StaticText IsoatrST;
        public  ListBoxItem Isodwt;
        public  StaticText IsodwtST;
        public  ListBoxItem IsoConfig;
        public  PushButton SetupComparePB;

        partial void OnInitialize();

        public ProjectCompare()
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

            ProjectTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectTVI);

            Project1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#1/[StaticText]Project|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Project1ST);

            PIDTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDTVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#2/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PID1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#2/[StaticText]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PID1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory3TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#2/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory3TVI);

            Classes1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#2/[TreeViewItem]#1/[StaticText]Classes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Classes1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory4TVI);

            PushButton3PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#3/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            Piping3D1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#3/[StaticText]Piping(3D)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Piping3D1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#3/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory5TVI);

            Classes2ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#3/[TreeViewItem]#1/[StaticText]Classes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Classes2ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#3/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory6TVI);

            LayerColorSettingsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#3/[TreeViewItem]#2/[StaticText]Layer *|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerColorSettingsST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory7TVI);

            PushButton4PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            Isometrics1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[StaticText]Isometrics|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Isometrics1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory8TVI);

            BlocksST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[TreeViewItem]#1/[StaticText]Blocks|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlocksST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory9TVI);

            IsoStylesST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[TreeViewItem]#2/[StaticText]Iso Styles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStylesST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[TreeViewItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory10TVI);

            SupportFilesST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#4/[TreeViewItem]#3/[StaticText]Support Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportFilesST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory11TVI);

            PushButton5PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#5/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            Orthos1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#5/[StaticText]Orthos|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Orthos1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#5/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory12TVI);

            OrthoCubeLibraryST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#5/[TreeViewItem]#1/[StaticText]OrthoCube Library|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoCubeLibraryST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory13TVI);

            Misc1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#6/[StaticText]Misc|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Misc1ST);

            AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectCompareCompareWindowProjectCategory14TVI);

            SpecSheets1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]#7/[StaticText]Spec Sheets|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheets1ST);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            ProjectCompareSummaryST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Project Compare Summary|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectCompareSummaryST);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            CompareSuccessfulST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Compare Successful|$TextBlock_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompareSuccessfulST);

            ProjectUnitsMatchCurrentST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Project Units match current project*|$TextBlock_3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectUnitsMatchCurrentST);

            NoDifferencesFoundInST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]No differences found in these project parts:|$TextBlock_4|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoDifferencesFoundInST);

            Project2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Project|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Project2ST);

            Misc2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Misc|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Misc2ST);

            ProjectDifferencesFoundST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Project Differences Found|$TextBlock_5|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDifferencesFoundST);

            StaticTextST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]$TextBlock_6|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            DifferencesFoundInTheseST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Differences found in these project parts:|$TextBlock_7|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DifferencesFoundInTheseST);

            PID2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]P*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PID2ST);

            Piping3D2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Piping(3D)|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Piping3D2ST);

            Isometrics2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Isometrics|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Isometrics2ST);

            Orthos2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Orthos|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Orthos2ST);

            SpecSheets2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_4|#1/[StaticText]Spec Sheets|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheets2ST);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ProjectInformationThatIsST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_3|#2/[StaticText]Project information that is different from|$TextBlock_8|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectInformationThatIsST);

            DefaultProjectST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_3|#2/[StaticText]DefaultProject|$TextBlock_9|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultProjectST);

            WillBeDisplayedWithST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_3|#2/[StaticText]will be displayed with an icon next to it:|$TextBlock_12|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WillBeDisplayedWithST);

            SampleProjectST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_3|#2/[StaticText]SampleProject|$TextBlock_11|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SampleProjectST);

            DifferencesYouChooseToST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Pane]$ScrollViewer_3|#2/[StaticText]Differences you choose to update in DefaultProject will display the following icon:|$TextBlock_13|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DifferencesYouChooseToST);

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

            ListBoxLB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            ModifiedGB = new GroupBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#2/[GroupBox]Modified|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifiedGB);

            CheckANSIBLBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#2/[GroupBox]Modified|#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIBLBI);

            CheckANSIBST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#2/[GroupBox]Modified|#1/[ListBoxItem]#1/[StaticText]Check_ANSI-B|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIBST);

            CheckANSIBFilesLB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$FilesListView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckANSIBFilesLB);

            Isoatr = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$FilesListView|#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Isoatr);

            IsoatrST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$FilesListView|#1/[ListBoxItem]#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoatrST);

            Isodwt = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$FilesListView|#1/[ListBoxItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Isodwt);

            IsodwtST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$FilesListView|#1/[ListBoxItem]#2/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsodwtST);

            IsoConfig = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$FilesListView|#1/[ListBoxItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoConfig);

            SetupComparePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Setup Compare|$Button_5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetupComparePB);
        }
    }
}
