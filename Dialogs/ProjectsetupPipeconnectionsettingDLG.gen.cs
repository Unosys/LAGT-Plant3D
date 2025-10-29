// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectsetupPipeconnectionsettingDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem DatabaseSetupTVI;
        public  TreeViewItem DrawingPropertiesTVI;
        public  TreeViewItem ReportsTVI;
        public  TreeViewItem FileNameFormatTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem ExportAndImportSettingsTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem DataManagerConfigurationTVI;
        public  TreeViewItem LayerAndColorSettingsTVI;
        public  TreeViewItem PipingConnectionSettingsTVI;
        public  TreeViewItem PIDObjectMappingTVI;
        public  TreeViewItem Plant3DClassDefinitionsTVI;
        public  TreeViewItem SpecUpdateSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox JointSetupGB;
        public  GroupBox WaferBoltsGB;
        public  TextField RoundUpToNearestTF;
        public  StaticText RoundUpToNearestST;
        public  GroupBox WeldDotsGB;
        public  TextField DiameterTF;
        public  StaticText DiameterST;
        public  GroupBox WeldGapsGB;
        public  TextField GapSizeTF;
        public  StaticText GapSizeST;
        public  CheckBox UseWeldGapsCK;
        public  GroupBox PipeSegmentsGB;
        public  TextField MinimumLengthTF;
        public  StaticText MinimumLengthST;
        public  GroupBox CompoundJointsGB;
        public  PushButton Delete1PB;
        public  PushButton Modify1PB;
        public  PushButton Add1PB;
        public  Table DataGridView1TBL;
        public  CustomWin TopRow1WIN;
        public  Header Name1CTL;
        public  Header End11CTL;
        public  Header End21CTL;
        public  Header ConnectionPartCTL;
        public  Header ImperialToMetricConnection1CTL;
        public  CustomWin Row01WIN;
        public  CustomWin NameRow01WIN;
        public  CustomWin End1Row01WIN;
        public  CustomWin End2Row01WIN;
        public  CustomWin ConnectionPartRow0WIN;
        public  CustomWin ImperialToMetricConnection1WIN;
        public  GroupBox SimpleJointsGB;
        public  PushButton Delete2PB;
        public  Table DataGridView2TBL;
        public  Pane VerticalScrollBarPANE;
        public  CustomWin TopRow2WIN;
        public  Header Name2CTL;
        public  Header End12CTL;
        public  Header End22CTL;
        public  Header FastenersCTL;
        public  Header RequiredMatchesCTL;
        public  Header OptionalMatchesCTL;
        public  Header ImperialToMetricConnection2CTL;
        public  CustomWin Row02WIN;
        public  CustomWin NameRow02WIN;
        public  CustomWin End1Row02WIN;
        public  CustomWin End2Row02WIN;
        public  CustomWin FastenersRow0WIN;
        public  CustomWin RequiredMatchesRow0WIN;
        public  CustomWin OptionalMatchesRow0WIN;
        public  CustomWin ImperialToMetricConnection2WIN;
        public  PushButton Modify2PB;
        public  PushButton Add2PB;
        public  Pane Pane7PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectsetupPipeconnectionsettingDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Paths|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Data Manager Configuration|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Layer and Color Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Piping Connection Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingConnectionSettingsTVI);

            PIDObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectMappingTVI);

            Plant3DClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassDefinitionsTVI);

            SpecUpdateSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Spec Update Settings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$3281504|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            JointSetupGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(JointSetupGB);

            WaferBoltsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Wafer bolts|$groupBox7|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WaferBoltsGB);

            RoundUpToNearestTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Wafer bolts|$groupBox7|#6/[TextField]Round up to nearest:|$m_tbWaferBoltRounding|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RoundUpToNearestTF);

            RoundUpToNearestST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Wafer bolts|$groupBox7|#6/[StaticText]Round up to nearest:|$label2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RoundUpToNearestST);

            WeldDotsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Weld dots|$groupBox6|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeldDotsGB);

            DiameterTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Weld dots|$groupBox6|#5/[TextField]Diameter:|$m_tbWeldDiameter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiameterTF);

            DiameterST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Weld dots|$groupBox6|#5/[StaticText]Diameter:|$label4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiameterST);

            WeldGapsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Weld gaps|$groupBox5|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeldGapsGB);

            GapSizeTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Weld gaps|$groupBox5|#4/[TextField]Gap size:|$m_tbWeldgapSize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GapSizeTF);

            GapSizeST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Weld gaps|$groupBox5|#4/[StaticText]Gap size:|$label3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GapSizeST);

            UseWeldGapsCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Weld gaps|$groupBox5|#4/[CheckBox]Use weld gaps|$m_cbUseWeldgaps|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseWeldGapsCK);

            PipeSegmentsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Pipe segments|$groupBox4|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSegmentsGB);

            MinimumLengthTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Pipe segments|$groupBox4|#3/[TextField]Minimum length:|$txtboxMinLength|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimumLengthTF);

            MinimumLengthST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Pipe segments|$groupBox4|#3/[StaticText]Minimum length:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimumLengthST);

            CompoundJointsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompoundJointsGB);

            Delete1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[PushButton]Delete|$btnDeleteCompound|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Delete1PB);

            Modify1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[PushButton]Modify*|$btnModifyCompound|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Modify1PB);

            Add1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[PushButton]Add*|$btnAddCompound|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add1PB);

            DataGridView1TBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView1TBL);

            TopRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRow1WIN);

            Name1CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Top Row|#1/[Header]Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Name1CTL);

            End11CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Top Row|#1/[Header]End 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End11CTL);

            End21CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Top Row|#1/[Header]End 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End21CTL);

            ConnectionPartCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Top Row|#1/[Header]Connection Part|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectionPartCTL);

            ImperialToMetricConnection1CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Top Row|#1/[Header]Imperial to Metric Connection|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialToMetricConnection1CTL);

            Row01WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row01WIN);

            NameRow01WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Row 0|#2/[CustomWin]Name Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameRow01WIN);

            End1Row01WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Row 0|#2/[CustomWin]End 1 Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End1Row01WIN);

            End2Row01WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Row 0|#2/[CustomWin]End 2 Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End2Row01WIN);

            ConnectionPartRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Row 0|#2/[CustomWin]Connection Part Row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectionPartRow0WIN);

            ImperialToMetricConnection1WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[Table]DataGridView|$m_dataGridView2|#1/[CustomWin]Row 0|#2/[CustomWin]Imperial to Metric Connection Row 0|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialToMetricConnection1WIN);

            SimpleJointsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SimpleJointsGB);

            Delete2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[PushButton]Delete|$m_btnDeleteSimple|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Delete2PB);

            DataGridView2TBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView2TBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[Pane]Vertical Scroll Bar|$9376062|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            TopRow2WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRow2WIN);

            Name2CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Name2CTL);

            End12CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]End 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End12CTL);

            End22CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]End 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End22CTL);

            FastenersCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]Fasteners|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FastenersCTL);

            RequiredMatchesCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]Required Matches|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RequiredMatchesCTL);

            OptionalMatchesCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]Optional Matches|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OptionalMatchesCTL);

            ImperialToMetricConnection2CTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]Imperial to Metric Connection|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialToMetricConnection2CTL);

            Row02WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row02WIN);

            NameRow02WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2/[CustomWin]Name Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameRow02WIN);

            End1Row02WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2/[CustomWin]End 1 Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End1Row02WIN);

            End2Row02WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2/[CustomWin]End 2 Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(End2Row02WIN);

            FastenersRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2/[CustomWin]Fasteners Row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FastenersRow0WIN);

            RequiredMatchesRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2/[CustomWin]Required Matches Row 0|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RequiredMatchesRow0WIN);

            OptionalMatchesRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2/[CustomWin]Optional Matches Row 0|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OptionalMatchesRow0WIN);

            ImperialToMetricConnection2WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Row 0|#2/[CustomWin]Imperial to Metric Connection Row 0|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialToMetricConnection2WIN);

            Modify2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[PushButton]Modify*|$m_btnModifySimple|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Modify2PB);

            Add2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4002300|#1/[Pane]$m_splitVert|#1/[Pane]$4395384|#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[PushButton]Add*|$m_btnAddSimple|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add2PB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4854018|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4854018|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4854018|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4854018|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4854018|#2/[PushButton]Apply|$m_btnSave|#1",
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
