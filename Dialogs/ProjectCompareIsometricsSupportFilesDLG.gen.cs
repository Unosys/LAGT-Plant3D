// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectCompareIsometricsSupportFilesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  StaticText SupportFiles1ST;
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
        public  StaticText SupportFiles2ST;
        public  PushButton PushButton6PB;
        public  PushButton PushButton7PB;
        public  ListBox ListBoxLB;
        public  GroupBox ModifiedGB;
        public  ListBoxItem IsoSkeyAcadBlockMapxmlLBI;
        public  StaticText IsoSkeyAcadBlockMapxmlST;
        public  ListBoxItem Plant3dIsoSymbolsdwgLBI;
        public  StaticText Plant3dIsoSymbolsdwgST;
        public  StaticText DetailsST;
        public  StaticText XMLFileMappingAutoCADST;
        public  PushButton SetupComparePB;
        public  StaticText SetupCompareST;
        public  Thumb ThumbCTL;
        public  PushButton Close2PB;
        public  StaticText CloseST;
        public  PushButton SyncReviewPB;
        public  StaticText SyncReviewST;

        partial void OnInitialize();

        public ProjectCompareIsometricsSupportFilesDLG()
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

            SupportFiles1ST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]Autodesk*|#4/[TreeViewItem]Autodesk*|#3/[StaticText]Support Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportFiles1ST);

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

            SupportFiles2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Support Files|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportFiles2ST);

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

            IsoSkeyAcadBlockMapxmlLBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSkeyAcadBlockMapxmlLBI);

            IsoSkeyAcadBlockMapxmlST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#1/[StaticText]IsoSkeyAcadBlockMap*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSkeyAcadBlockMapxmlST);

            Plant3dIsoSymbolsdwgLBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]#1/[ListBoxItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3dIsoSymbolsdwgLBI);

            Plant3dIsoSymbolsdwgST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListView_1|#1/[GroupBox]Modified|#1/[ListBoxItem]Autodesk*|#2/[StaticText]Plant3dIsoSymbols*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3dIsoSymbolsdwgST);

            DetailsST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Details|$TextBlock_4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailsST);

            XMLFileMappingAutoCADST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]XML file mapping AutoCAD blocks to use for Isometric SKEYs*|$TextBlock_5|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XMLFileMappingAutoCADST);

            SetupComparePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Setup Compare|$Button_5|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetupComparePB);

            SetupCompareST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Setup Compare|$Button_5|#3/[StaticText]Setup Compare|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetupCompareST);

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
