// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupPIDLineDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView TreeViewTV;
        public  ScrollBar HorizontalScrollBar1SB;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem DatabaseSetupTVI;
        public  TreeViewItem DrawingPropertiesTVI;
        public  TreeViewItem ReportsTVI;
        public  TreeViewItem FileNameFormatTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem EndConnectionsTVI;
        public  TreeViewItem LineSettingsTVI;
        public  TreeViewItem ExportAndImportSettingsTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem DataManagerConfigurationTVI;
        public  TreeViewItem PIDClassDefinitionsTVI;
        public  TreeViewItem EngineeringItemsTVI;
        public  TreeViewItem EquipmentTVI;
        public  TreeViewItem InlineAssetsTVI;
        public  TreeViewItem InstrumentationTVI;
        public  TreeViewItem LinesTVI;
        public  TreeViewItem PipeLineSegmentsTVI;
        public  TreeViewItem JacketedPipeSegmentTVI;
        public  TreeViewItem PrimaryLineSegment1TVI;
        public  TreeViewItem PrimaryLineSegment2TVI;
        public  TreeViewItem PrimaryLineSegment3TVI;
        public  TreeViewItem SecondaryLineSegment1TVI;
        public  TreeViewItem SecondaryLineSegment2TVI;
        public  TreeViewItem SecondaryLineSegment3TVI;
        public  TreeViewItem SignalLineSegmentsTVI;
        public  TreeViewItem NozzlesTVI;
        public  TreeViewItem NonEngineeringItemsTVI;
        public  TreeViewItem PipeLineGroupTVI;
        public  TreeViewItem SignalLineGroupTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox ClassSettingsPipeLineGB;
        public  GroupBox LineGB;
        public  PushButton AddToToolPalettePB;
        public  PushButton BtnLineSettings;
        public  GroupBox PropertiesGB;
        public  PushButton RemovePB;
        public  Table DataGridViewTBL;
        public  Pane VerticalScrollBarPANE;
        public  CustomWin TopRowWIN;
        public  Header PropertyNameCTL;
        public  Header PropertyDescriptionCTL;
        public  Header DisplayNameCTL;
        public  Header DefaultValueCTL;
        public  Header PropertyTypeCTL;
        public  Header AcquisitionCTL;
        public  Header ReadOnlyCTL;
        public  Header VisibleCTL;
        public  CustomWin Row0WIN;
        public  CustomWin PropertyNameRow0WIN;
        public  CustomWin PropertyDescriptionRow0WIN;
        public  CustomWin DisplayNameRow0WIN;
        public  CustomWin DefaultValueRow0WIN;
        public  CustomWin PropertyTypeRow0WIN;
        public  CustomWin AcquisitionRow0WIN;
        public  CustomWin ReadOnlyRow0WIN;
        public  CustomWin VisibleRow0WIN;
        public  PushButton EditPB;
        public  PushButton AddPB;
        public  GroupBox TagFormatGB;
        public  PushButton DeletePB;
        public  PushButton ModifyPB;
        public  PushButton NewPB;
        public  ListBox ListBoxLB;
        public  ScrollBar HorizontalScrollBar2SB;
        public  ListBoxItem PipelineTagSizeSpecServiceLineNumberLBI;
        public  GroupBox AnnotationGB;
        public  PushButton RemoveAnnotationPB;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  PushButton AddAnnotationPB;
        public  PushButton EditAnnotationPB;
        public  PushButton EditBlockPB;
        public  Pane NoPreviewAvailablePANE;
        public  Pane Pane7PANE;
        public  PushButton HelpPB;
        public  PushButton M_btnCancel;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupPIDLineDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            HorizontalScrollBar1SB = new ScrollBar()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar1SB);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            EndConnectionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]End Connections|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndConnectionsTVI);

            LineSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Line Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Export and Import Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Data Manager Configuration|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            PIDClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsTVI);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            InlineAssetsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Inline Assets|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InlineAssetsTVI);

            InstrumentationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Instrumentation|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentationTVI);

            LinesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinesTVI);

            PipeLineSegmentsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineSegmentsTVI);

            JacketedPipeSegmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1/[TreeViewItem]Jacketed Pipe Segment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(JacketedPipeSegmentTVI);

            PrimaryLineSegment1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1/[TreeViewItem]Primary Line Segment|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrimaryLineSegment1TVI);

            PrimaryLineSegment2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1/[TreeViewItem]Primary Line Segment - Existing|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrimaryLineSegment2TVI);

            PrimaryLineSegment3TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1/[TreeViewItem]Primary Line Segment - New|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrimaryLineSegment3TVI);

            SecondaryLineSegment1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1/[TreeViewItem]Secondary Line Segment|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SecondaryLineSegment1TVI);

            SecondaryLineSegment2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1/[TreeViewItem]Secondary Line Segment - Existing|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SecondaryLineSegment2TVI);

            SecondaryLineSegment3TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Pipe Line Segments|#1/[TreeViewItem]Secondary Line Segment - New|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SecondaryLineSegment3TVI);

            SignalLineSegmentsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4/[TreeViewItem]Signal Line Segments|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignalLineSegmentsTVI);

            NozzlesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Nozzles|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzlesTVI);

            NonEngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Non Engineering Items|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonEngineeringItemsTVI);

            PipeLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Pipe Line Group|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroupTVI);

            SignalLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Signal Line Group|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignalLineGroupTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            ClassSettingsPipeLineGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassSettingsPipeLineGB);

            LineGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Line|$m_gbLineSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineGB);

            AddToToolPalettePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Line|$m_gbLineSettings|#1/[PushButton]Add to Tool Palette*|$m_btnAddToTP|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddToToolPalettePB);

            BtnLineSettings = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Line|$m_gbLineSettings|#1/[PushButton]Edit Line*|$btnLineSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnLineSettings);

            PropertiesGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesGB);

            RemovePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Remove|$m_btnRemoveProperties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[Pane]Vertical Scroll Bar|$4264092|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            PropertyNameCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameCTL);

            PropertyDescriptionCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Description|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyDescriptionCTL);

            DisplayNameCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Display Name|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameCTL);

            DefaultValueCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Default Value|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueCTL);

            PropertyTypeCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Type|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTypeCTL);

            AcquisitionCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Acquisition|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionCTL);

            ReadOnlyCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Read Only|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadOnlyCTL);

            VisibleCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Visible|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleCTL);

            Row0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0WIN);

            PropertyNameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Name Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameRow0WIN);

            PropertyDescriptionRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Description Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyDescriptionRow0WIN);

            DisplayNameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Display Name Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameRow0WIN);

            DefaultValueRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Default Value Row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueRow0WIN);

            PropertyTypeRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Type Row 0|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTypeRow0WIN);

            AcquisitionRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Acquisition Row 0|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionRow0WIN);

            ReadOnlyRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Read Only Row 0|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadOnlyRow0WIN);

            VisibleRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Visible Row 0|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleRow0WIN);

            EditPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Edit*|$m_btnEditProperties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditPB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Add*|$m_btnAddProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            TagFormatGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagFormatGB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]Delete|$m_btnDeleteTag|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            ModifyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]Modify*|$m_btnModifyTag|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifyPB);

            NewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]New*|$m_btnNewTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewPB);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[ListBox]$m_listBoxTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            HorizontalScrollBar2SB = new ScrollBar()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[ListBox]$m_listBoxTag|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar2SB);

            PipelineTagSizeSpecServiceLineNumberLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[ListBox]$m_listBoxTag|#1/[ListBoxItem]Pipeline Tag *|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipelineTagSizeSpecServiceLineNumberLBI);

            AnnotationGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationGB);

            RemoveAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Remove Annotation*|$m_btnRemoveAnn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveAnnotationPB);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PopupList]$m_comboBoxAnn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PopupList]$m_comboBoxAnn|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            AddAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Add Annotation*|$m_btnAddAnn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAnnotationPB);

            EditAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Edit Annotation*|$m_btnModifyAnn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditAnnotationPB);

            EditBlockPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Edit Block*|$m_btnEditAnn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditBlockPB);

            NoPreviewAvailablePANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Pipe Line Segments|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[Pane]No preview available|$7277100|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPreviewAvailablePANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            M_btnCancel = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]Apply|$m_btnSave|#1",
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
        }
    }
}
