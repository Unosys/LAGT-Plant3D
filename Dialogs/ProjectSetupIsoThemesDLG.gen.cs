// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectSetupIsoThemesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem DatabaseSetupTVI;
        public  TreeViewItem DrawingPropertiesTVI;
        public  TreeViewItem FileNameFormatTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem ReportsTVI;
        public  TreeViewItem SharedPlantContentTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem SymbolsAndReferenceTVI;
        public  TreeViewItem IsoStyleSetupTVI;
        public  TreeViewItem IsoStyleDefaultSettingsTVI;
        public  TreeViewItem ThemesTVI;
        public  TreeViewItem AnnotationsTVI;
        public  TreeViewItem DimensionsTVI;
        public  TreeViewItem SlopedAndOffsetPipingTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  TreeViewItem LivePreviewTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;
        public  PopupList ThemePL;
        public  StaticText ThemesST;
        public  PushButton XMLPB;
        public  StaticText XMLST;
        public  Window DefaultPiping;
        public  StaticText DefaultPipingST;
        public  Window Override;
        public  StaticText OverrideST;
        public  Window BranchPiping;
        public  StaticText BranchPipingST;
        public  CustomWin CustomWin3WIN;
        public  StaticText EnableOfflineInstrumentConnectionST;
        public  CheckBox CheckBoxCK;
        public  StaticText BranchPipingThemesST;
        public  CustomWin CustomWin4WIN;
        public  PushButton PushButton1PB;
        public  ListBox BranchPipingThemesLB;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupThemeData1LBI;
        public  StaticText OfflineInstrumentConnectionST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupThemeData2LBI;
        public  StaticText VentDrainPipingST;
        public  CustomWin CustomWin5WIN;
        public  PushButton PushButton2PB;
        public  StaticText DefaultThemeSettingsST;
        public  ListView BranchPipingThemesLV;
        public  ListViewItem AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting1LVI;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay1WIN;
        public  StaticText SymbolScaleST;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay2WIN;
        public  TextField TextField1TF;
        public  Pane Pane8PANE;
        public  ListViewItem AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting2LVI;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay3WIN;
        public  StaticText MaxNumberOfComponentsST;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay4WIN;
        public  TextField TextField2TF;
        public  Pane Pane9PANE;
        public  ListViewItem AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting3LVI;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay5WIN;
        public  StaticText MaxNumberOfPipesST;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay6WIN;
        public  TextField TextField3TF;
        public  Pane Pane10PANE;
        public  CustomWin CustomWin6WIN;
        public  PushButton PushButton3PB;
        public  StaticText EnableST;
        public  CheckBox AnnotationsCK;
        public  CheckBox BillOfMaterialsReportCK;
        public  CheckBox DimensionsCK;
        public  CustomWin CustomWin7WIN;
        public  PushButton PushButton4PB;
        public  StaticText PipingDetailsST;
        public  CustomWin CustomWin8WIN;
        public  PushButton PushButton5PB;
        public  StaticText StartsWithST;
        public  CustomWin CustomWin9WIN;
        public  PushButton PushButton6PB;
        public  StaticText EndsWithST;
        public  Pane Pane11PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  GroupBox ThemesGB;

        partial void OnInitialize();

        public ProjectSetupIsoThemesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            SharedPlantContentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Shared Plant Content|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharedPlantContentTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            SymbolsAndReferenceTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Symbols and Reference|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndReferenceTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            IsoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Default Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleDefaultSettingsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Themes|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Annotations|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Dimensions|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Sloped and Offset Piping|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Title Block and Display|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Live Preview|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]$4589920|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            ThemePL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PopupList]Theme:|$ComboBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemePL);

            ThemesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[StaticText]Themes|$TextBlock_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesST);

            XMLPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]XML|$XMLEditor_button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XMLPB);

            XMLST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]XML|$XMLEditor_button|#1/[StaticText]XML|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XMLST);

            DefaultPiping = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultPiping);

            DefaultPipingST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#1/[StaticText]$tabtext|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultPipingST);

            Override = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Override);

            OverrideST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#2/[StaticText]Override|$tabtext|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverrideST);

            BranchPiping = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BranchPiping);

            BranchPipingST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3/[StaticText]$tabtext|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BranchPipingST);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            EnableOfflineInstrumentConnectionST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[StaticText]Enable Offline Instrument Connection Theme:|$UpRightButtonTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnableOfflineInstrumentConnectionST);

            CheckBoxCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CheckBox]$UpRightButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxCK);

            BranchPipingThemesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[StaticText]Branch Piping Themes|$ThemesTextBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BranchPipingThemesST);

            CustomWin4WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$ThemeInforButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin4WIN);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$ThemeInforButton|#1/[PushButton]$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            BranchPipingThemesLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListBox]Branch Piping Themes|$ThemeListView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BranchPipingThemesLB);

            AutodeskProcessPowerProjectManagerUIProjectSetupThemeData1LBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListBox]Branch Piping Themes|$ThemeListView|#1/[ListBoxItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupThemeData1LBI);

            OfflineInstrumentConnectionST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListBox]Branch Piping Themes|$ThemeListView|#1/[ListBoxItem]Autodesk*|#1/[StaticText]Offline Instrument Connection|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OfflineInstrumentConnectionST);

            AutodeskProcessPowerProjectManagerUIProjectSetupThemeData2LBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListBox]Branch Piping Themes|$ThemeListView|#1/[ListBoxItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupThemeData2LBI);

            VentDrainPipingST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListBox]Branch Piping Themes|$ThemeListView|#1/[ListBoxItem]Autodesk*|#2/[StaticText]Vent*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VentDrainPipingST);

            CustomWin5WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin5WIN);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#2/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            DefaultThemeSettingsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#2/[StaticText]Default Theme Settings|$CollapsiblePanel_TextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultThemeSettingsST);

            BranchPipingThemesLV = new ListView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BranchPipingThemesLV);

            AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting1LVI = new ListViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting1LVI);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay1WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay1WIN);

            SymbolScaleST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#1/[StaticText]Symbol Scale|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolScaleST);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay2WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay2WIN);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#2/[TextField]#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting2LVI = new ListViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting2LVI);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay3WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay3WIN);

            MaxNumberOfComponentsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#1/[StaticText]Max Number of Components|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaxNumberOfComponentsST);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay4WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay4WIN);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#2/[TextField]#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting3LVI = new ListViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupDisplaySetting3LVI);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay5WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay5WIN);

            MaxNumberOfPipesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#1/[StaticText]Max Number of Pipes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaxNumberOfPipesST);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay6WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupDisplaySettingColumnDisplay6WIN);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[ListView]Branch Piping Themes|$dataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#2/[TextField]#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            CustomWin6WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin6WIN);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#3/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            EnableST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#3/[StaticText]Enable|$CollapsiblePanel_TextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnableST);

            AnnotationsCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CheckBox]Annotations|$ThemeEnablesAnnotationCheckBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsCK);

            BillOfMaterialsReportCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CheckBox]Bill of materials report|$ThemeEnablesReportCheckBox|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BillOfMaterialsReportCK);

            DimensionsCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CheckBox]Dimensions|$ThemeEnablesDimensionCheckBox|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsCK);

            CustomWin7WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin7WIN);

            PushButton4PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#4/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            PipingDetailsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#4/[StaticText]Piping Details|$CollapsiblePanel_TextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingDetailsST);

            CustomWin8WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin8WIN);

            PushButton5PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#5/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            StartsWithST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#5/[StaticText]Starts With|$CollapsiblePanel_TextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartsWithST);

            CustomWin9WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin9WIN);

            PushButton6PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#6/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            EndsWithST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]Autodesk*|#3/[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#6/[StaticText]Ends With|$CollapsiblePanel_TextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndsWithST);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2097694|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2097694|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2097694|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2097694|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2097694|#2/[PushButton]Apply|$m_btnSave|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ThemesGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_isometricThemesUserCtrl|#1/[Pane]Dimensions|$panel_Themes|#1/[GroupBox]Themes|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesGB);
        }
    }
}
