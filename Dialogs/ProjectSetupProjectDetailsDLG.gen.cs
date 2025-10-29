// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupProjectDetailsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TreeView M_treeView;
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
        public  TreeViewItem P3dLineGroupTVI;
        public  TreeViewItem PipingAndEquipmentTVI;
        public  TreeViewItem PulledPipeBendTVI;
        public  TreeViewItem SteelStructureTVI;
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
        public  PushButton AddRowPB;
        public  PushButton PushButton2PB;
        public  GroupBox CustomPropertiesGB;
        public  PushButton DeleteRowPB;
        public  PushButton DeletePB;
        public  PushButton AddPB;
        public  GroupBox GeneralPropertiesGB;
        public  TextField ProjectNumberTF;
        public  StaticText ProjectNumberST;
        public  TextField ProjectDescriptionTF;
        public  TextField ProjectNameTF;
        public  StaticText ProjectDescriptionST;
        public  StaticText ProjectNameST;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton FNAddPB;
        public  PushButton FNDeletePB;
        public  TextField M_tb_name;
        public  PushButton Add1PB;
        public  ListBox CustomCategoriesLB;
        public  ListBoxItem ProjectDataLBI;
        public  ListBoxItem ClientInformationLBI;

        partial void OnInitialize();

        public ProjectSetupProjectDetailsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_treeView = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67130|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            SharedPlantContentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Shared Plant Content|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharedPlantContentTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            DisplaySettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Display Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplaySettingsTVI);

            LineSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Line Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineSettingsTVI);

            ExportAndImportSettings1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Export and Import Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettings1TVI);

            DataManagerConfiguration1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Data Manager Configuration|#4",
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

            PIDPainterSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#2/[TreeViewItem]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDPainterSettingsTVI);

            PipeSpecsInPIDTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Pipe Specs in P*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecsInPIDTVI);

            PipeSpecObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Pipe Specs in P*|#7/[TreeViewItem]Pipe Spec Object Mapping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecObjectMappingTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettings2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettings2TVI);

            DataManagerConfiguration2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Data Manager Configuration|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfiguration2TVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Layer and Color Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]#3/[TreeViewItem]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingConnectionSettingsTVI);

            PipeBendSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Pipe Bend Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeBendSettingsTVI);

            PIDObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectMappingTVI);

            Plant3DClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassDefinitionsTVI);

            P3dLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]P3d Line Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupTVI);

            PipingAndEquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Piping and Equipment|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingAndEquipmentTVI);

            PulledPipeBendTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Pulled Pipe Bend|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PulledPipeBendTVI);

            SteelStructureTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Steel Structure|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SteelStructureTVI);

            SpecUpdateSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Spec Update Settings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            SymbolsAndReferenceTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Symbols and Reference|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndReferenceTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            IsoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Default Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleDefaultSettingsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Themes|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Annotations|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Dimensions|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Sloped and Offset Piping|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplay1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Title Block and Display|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplay1TVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Live Preview|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            OrthoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5/[TreeViewItem]Ortho Style Default Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoStyleDefaultSettingsTVI);

            TitleBlockAndDisplay2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5/[TreeViewItem]Title Block and Display|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplay2TVI);

            AddRowPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4/[PushButton]Add Row*|$m_btnAddRow|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddRowPB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General paths and file locations|$m_groupBoxReportDir|#3/[PushButton]**[2]|$m_btnReportDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            CustomPropertiesGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomPropertiesGB);

            DeleteRowPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4/[PushButton]Delete Row|$m_btnDeleteRow|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteRowPB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4/[PushButton]Delete|$m_btnRemove|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]Custom properties|$m_groupBoxCustom|#4/[PushButton]Add*|$m_btnAdd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            GeneralPropertiesGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General properties|$m_groupBoxGeneral|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralPropertiesGB);

            ProjectNumberTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General properties|$m_groupBoxGeneral|#1/[TextField]Project number:|$m_textBoxProjectNumber|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNumberTF);

            ProjectNumberST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General properties|$m_groupBoxGeneral|#1/[StaticText]Project number:|$m_lblProjectNumber|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNumberST);

            ProjectDescriptionTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General properties|$m_groupBoxGeneral|#1/[TextField]Project description:|$m_textBoxProjectDesc|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDescriptionTF);

            ProjectNameTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General properties|$m_groupBoxGeneral|#1/[TextField]Project name:|$m_textBoxProjectName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNameTF);

            ProjectDescriptionST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General properties|$m_groupBoxGeneral|#1/[StaticText]Project description:|$m_lblProjectDesc|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDescriptionST);

            ProjectNameST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$67126|#1/[Pane]$m_splitVert|#1/[Pane]$67136|#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]General properties|$m_groupBoxGeneral|#1/[StaticText]Project name:|$m_lblProjectName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNameST);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$68546|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$68546|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

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

            FNAddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_fileNameFormatUserCtrl/[GroupBox]File name format|$m_gb_FNF/[Pane]Click add to start building a file name format*|$m_panle_1/[Pane]$m_pannel_1_2/[PushButton]Add|$m_add",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FNAddPB);

            FNDeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_fileNameFormatUserCtrl/[GroupBox]File name format|$m_gb_FNF/[Pane]Click add to start building a file name format*|$m_panle_1/[Pane]$m_panel_properties/[Pane]$FileNameFormatPropertyItem/[Pane]$m_panel_property/[Pane]$m_panel_property_definition/[PushButton]$m_bt_delete",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FNDeletePB);

            M_tb_name = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_fileNameFormatUserCtrl/[GroupBox]File name format|$m_gb_FNF/[Pane]Click add to start building a file name format*|$m_panle_1/[Pane]$m_panel_properties/[Pane]$FileNameFormatPropertyItem/[Pane]$m_panel_property/[Pane]$m_panel_property_definition/[TextField]$m_tb_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tb_name);

            Add1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|/[Pane]$394682|/[Pane]$m_splitVert|/[Pane]$394668|/[Pane]$m_jointsUserCtrl|/[GroupBox]Joint setup|$groupBox_JointSetup|/[GroupBox]Simple joints|$groupBox_SimpleJoints|/[PushButton]Add*|$m_btnAddSimple",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add1PB);

            CustomCategoriesLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]$m_groupBoxCustom|#4/[ListBox]$m_listBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomCategoriesLB);

            ProjectDataLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]$m_groupBoxCustom|#4/[ListBox]$m_listBox|#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataLBI);

            ClientInformationLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_projectDetailsUserCtrl|#1/[GroupBox]Project details|$m_groupBoxProject|#1/[GroupBox]$m_groupBoxCustom|#4/[ListBox]$m_listBox|#1/[ListBoxItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClientInformationLBI);
        }
    }
}
