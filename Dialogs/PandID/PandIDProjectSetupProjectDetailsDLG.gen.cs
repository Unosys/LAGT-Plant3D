// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupProjectDetailsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
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
        public  TreeViewItem DisplaySettingsTVI;
        public  TreeViewItem LineSettingsTVI;
        public  TreeViewItem ExportAndImportSettings1TVI;
        public  TreeViewItem DataManagerConfiguration1TVI;
        public  TreeViewItem PIDClassDefinitionsTVI;
        public  TreeViewItem EngineeringItemsTVI;
        public  TreeViewItem NonEngineeringItemsTVI;
        public  TreeViewItem PipeLineGroupTVI;
        public  TreeViewItem SignalLineGroupTVI;
        public  TreeViewItem PIDPainterSettingsTVI;
        public  TreeViewItem PipeSpecsInPIDTVI;
        public  TreeViewItem PipeSpecObjectMappingTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem ExportAndImportSettings2TVI;
        public  TreeViewItem DataManagerConfiguration2TVI;
        public  TreeViewItem LayerAndColorSettingsTVI;
        public  TreeViewItem PipingConnectionSettingsTVI;
        public  TreeViewItem PipeBendSettingsTVI;
        public  TreeViewItem PIDObjectMappingTVI;
        public  TreeViewItem Plant3DClassDefinitionsTVI;
        public  TreeViewItem SpecUpdateSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem SymbolsAndReferenceTVI;
        public  TreeViewItem IsoStyleSetupTVI;
        public  TreeViewItem IsoStyleDefaultSettingsTVI;
        public  TreeViewItem ThemesTVI;
        public  TreeViewItem AnnotationsTVI;
        public  TreeViewItem DimensionsTVI;
        public  TreeViewItem SlopedAndOffsetPipingTVI;
        public  TreeViewItem TitleBlockAndDisplay1TVI;
        public  TreeViewItem LivePreviewTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  TreeViewItem OrthoStyleDefaultSettingsTVI;
        public  TreeViewItem TitleBlockAndDisplay2TVI;
        public  PushButton CancelPB;
        public  PushButton M_add;
        public  TextField M_tb_name;
        public  PushButton M_btnOk;
        public  PushButton M_bt_delete;
        public  PushButton M_btnReportDir;
        public  PushButton RelatedFilesPB;
        public  PushButton M_btnAddRow;
        public  PushButton M_btnDeleteRow;
        public  PushButton M_btnAdd;

        partial void OnInitialize();

        public PandIDProjectSetupProjectDetailsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Database Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Drawing Properties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]File Name Format|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Project Details|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Reports|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            SharedPlantContentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Shared Plant Content|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharedPlantContentTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            DisplaySettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]Display Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplaySettingsTVI);

            LineSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]Line Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineSettingsTVI);

            ExportAndImportSettings1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]Export and Import Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettings1TVI);

            DataManagerConfiguration1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]Data Manager Configuration|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfiguration1TVI);

            PIDClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsTVI);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]#5/[TreeViewItem]Engineering Items|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);

            NonEngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]#5/[TreeViewItem]Non Engineering Items|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonEngineeringItemsTVI);

            PipeLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]#5/[TreeViewItem]Pipe Line Group|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroupTVI);

            SignalLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]#5/[TreeViewItem]Signal Line Group|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignalLineGroupTVI);

            PIDPainterSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDPainterSettingsTVI);

            PipeSpecsInPIDTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]Pipe Specs in P*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecsInPIDTVI);

            PipeSpecObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]Pipe Specs in P*|#7/[TreeViewItem]Pipe Spec Object Mapping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecObjectMappingTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettings2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettings2TVI);

            DataManagerConfiguration2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]Data Manager Configuration|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfiguration2TVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]Layer and Color Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]Piping Connection Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingConnectionSettingsTVI);

            PipeBendSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]Pipe Bend Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeBendSettingsTVI);

            PIDObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectMappingTVI);

            Plant3DClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]Plant 3D Class Definitions|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassDefinitionsTVI);

            SpecUpdateSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]Spec Update Settings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            SymbolsAndReferenceTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Symbols and Reference|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndReferenceTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Iso Style Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            IsoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Iso Style Default Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleDefaultSettingsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Themes|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Annotations|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Dimensions|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Sloped and Offset Piping|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplay1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Title Block and Display|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplay1TVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#4/[TreeViewItem]Live Preview|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            OrthoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#5/[TreeViewItem]Ortho Style Default Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoStyleDefaultSettingsTVI);

            TitleBlockAndDisplay2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#5/[TreeViewItem]Title Block and Display|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplay2TVI);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            M_add = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$19139036|#1/[Pane]$m_splitVert|#1/[Pane]$1445276|#2/[Pane]$m_fileNameFormatUserCtrl|#1/[GroupBox]File name format|$m_gb_FNF|#1/[Pane]Click add to start building a file name format*|$m_panle_1|#1/[Pane]$m_pannel_1_2|#1/[PushButton]Add|$m_add|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_add);

            M_tb_name = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_fileNameFormatUserCtrl/[GroupBox]File name format|$m_gb_FNF/[Pane]Click add to start building a file name format*|$m_panle_1/[Pane]$m_panel_properties/[Pane]$FileNameFormatPropertyItem/[Pane]$m_panel_property/[Pane]$m_panel_property_definition/[TextField]$m_tb_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_name);

            M_btnOk = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#2/[PushButton]OK|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_bt_delete = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$19139036|#1/[Pane]$m_splitVert|#1/[Pane]$1445276|#2/[Pane]$m_fileNameFormatUserCtrl|#1/[GroupBox]File name format|$m_gb_FNF|#1/[Pane]Click add to start building a file name format*|$m_panle_1|#1/[Pane]$m_panel_properties|#1/[Pane]$FileNameFormatPropertyItem|#1/[Pane]$m_panel_property|#1/[Pane]$m_panel_property_definition|#2/[PushButton]$m_bt_delete|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_delete);

            M_btnReportDir = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3084968|#1/[Pane]$m_splitVert|#1/[Pane]$6227718|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General paths and file locations|$m_groupBoxReportDir|#3/[PushButton]$m_btnReportDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnReportDir);

            RelatedFilesPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General paths and file locations|$m_groupBoxReportDir|#3/[PushButton]$m_btnRelatedFilesDir|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RelatedFilesPB);

            M_btnAddRow = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$854766|#1/[Pane]$m_splitVert|#1/[Pane]$2097790|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4/[PushButton]$m_btnAddRow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddRow);

            M_btnDeleteRow = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1443492|#1/[Pane]$m_splitVert|#1/[Pane]$7802038|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4/[PushButton]Delete Row|$m_btnDeleteRow|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDeleteRow);

            M_btnAdd = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$265828|#1/[Pane]$m_splitVert|#1/[Pane]$265826|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4/[PushButton]$m_btnAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAdd);
        }
    }
}
