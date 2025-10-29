// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class P3DProjectSetupLayerColorDLG : Pane
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
        public  GroupBox AutomatedLayerAndColorGB;
        public  GroupBox PipeSupportSettingsGB;
        public  StaticText AddSuffixToCreateST;
        public  StaticText AddPrefixToCreateST;
        public  TextField AddSuffixToCreateTF;
        public  TextField AddPrefixToCreateTF;
        public  PopupList AssignLayerBy1PL;
        public  PushButton DropDownButton1PB;
        public  StaticText AssignLayerBy1ST;
        public  GroupBox PipingSettingsGB;
        public  StaticText ColorSettingsST;
        public  PopupList AssignColorByPL;
        public  PushButton DropDownButton2PB;
        public  PopupList AssignLayerBy2PL;
        public  PushButton DropDownButton3PB;
        public  StaticText AssignColorByST;
        public  Table DataGridViewTBL;
        public  Pane VerticalScrollBarPANE;
        public  CustomWin TopRowWIN;
        public  Header NominalDiameterCTL;
        public  Header ColorCTL;
        public  CustomWin Row0WIN;
        public  CustomWin NominalDiameterRow0WIN;
        public  CustomWin ColorRow0WIN;
        public  CustomWin Row3WIN;
        public  CustomWin NominalDiameterRow3WIN;
        public  CustomWin ColorRow3WIN;
        public  CustomWin Row4WIN;
        public  CustomWin NominalDiameterRow4WIN;
        public  CustomWin ColorRow4WIN;
        public  CustomWin Row7WIN;
        public  CustomWin NominalDiameterRow7WIN;
        public  CustomWin ColorRow7WIN;
        public  CustomWin Row8WIN;
        public  CustomWin NominalDiameterRow8WIN;
        public  CustomWin ColorRow8WIN;
        public  StaticText AssignLayerBy2ST;
        public  StaticText DefaultST;
        public  ListView AutomationSchemesLV;
        public  ListViewItem DefaultLVI;
        public  TextField TextFieldTF;
        public  StaticText AutomationSchemesST;
        public  PushButton SetCurrentPB;
        public  PushButton DeletePB;
        public  PushButton M_bt_new;
        public  StaticText CurrentAutomationSchemeST;
        public  CheckBox AutomateLayerAndColorCK;
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

        public P3DProjectSetupLayerColorDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Paths|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Data Manager Configuration|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Layer and Color Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Piping Connection Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingConnectionSettingsTVI);

            PIDObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectMappingTVI);

            Plant3DClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassDefinitionsTVI);

            SpecUpdateSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Spec Update Settings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396904|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            AutomatedLayerAndColorGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutomatedLayerAndColorGB);

            PipeSupportSettingsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSupportSettingsGB);

            AddSuffixToCreateST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2/[StaticText]Add suffix to create layer:|$m_PipeSupportsLayerSuffixLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddSuffixToCreateST);

            AddPrefixToCreateST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2/[StaticText]Add prefix to create layer:|$m_PipeSupportsLayerPrefixLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPrefixToCreateST);

            AddSuffixToCreateTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2/[TextField]Add suffix to create layer:|$m_PipeSupportsLayerSuffix|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddSuffixToCreateTF);

            AddPrefixToCreateTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2/[TextField]Add prefix to create layer:|$m_PipeSupportsLayerPrefix|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPrefixToCreateTF);

            AssignLayerBy1PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2/[PopupList]Assign layer by:|$m_PipeSupportsLayerOptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignLayerBy1PL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2/[PopupList]Assign layer by:|$m_PipeSupportsLayerOptions|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            AssignLayerBy1ST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Pipe Support Settings|$groupBox2|#2/[StaticText]Assign layer by:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignLayerBy1ST);

            PipingSettingsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingSettingsGB);

            ColorSettingsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[StaticText]Color settings:|$m_lblColorSettings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorSettingsST);

            AssignColorByPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[PopupList]Assign color by:|$m_cb_color|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignColorByPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[PopupList]Assign color by:|$m_cb_color|#2/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            AssignLayerBy2PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[PopupList]Assign layer by:|$m_cb_layer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignLayerBy2PL);

            DropDownButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[PopupList]Assign layer by:|$m_cb_layer|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton3PB);

            AssignColorByST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[StaticText]Assign color by:|$m_lblColorBy|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignColorByST);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[Pane]Vertical Scroll Bar|$20840472|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            NominalDiameterCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Nominal Diameter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterCTL);

            ColorCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Color|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorCTL);

            Row0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0WIN);

            NominalDiameterRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Nominal Diameter Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow0WIN);

            ColorRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Color Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorRow0WIN);

            Row3WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 3|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row3WIN);

            NominalDiameterRow3WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 3|#5/[CustomWin]Nominal Diameter Row 3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow3WIN);

            ColorRow3WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 3|#5/[CustomWin]Color Row 3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorRow3WIN);

            Row4WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 4|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row4WIN);

            NominalDiameterRow4WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 4|#6/[CustomWin]Nominal Diameter Row 4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow4WIN);

            ColorRow4WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 4|#6/[CustomWin]Color Row 4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorRow4WIN);

            Row7WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 7|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row7WIN);

            NominalDiameterRow7WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 7|#9/[CustomWin]Nominal Diameter Row 7|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow7WIN);

            ColorRow7WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 7|#9/[CustomWin]Color Row 7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorRow7WIN);

            Row8WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 8|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row8WIN);

            NominalDiameterRow8WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 8|#10/[CustomWin]Nominal Diameter Row 8|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterRow8WIN);

            ColorRow8WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 8|#10/[CustomWin]Color Row 8|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorRow8WIN);

            AssignLayerBy2ST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[GroupBox]Piping settings|$groupBox1|#1/[StaticText]Assign layer by:|$m_lblLayerBy|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignLayerBy2ST);

            DefaultST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[StaticText]Default|$m_curSchemeName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultST);

            AutomationSchemesLV = new ListView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[ListView]Automation schemes:|$lv_schemes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutomationSchemesLV);

            DefaultLVI = new ListViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[ListView]Automation schemes:|$lv_schemes|#1/[ListViewItem]Default|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultLVI);

            TextFieldTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[ListView]Automation schemes:|$lv_schemes|#1/[ListViewItem]Default|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            AutomationSchemesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[StaticText]Automation schemes:|$lb_schemes|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutomationSchemesST);

            SetCurrentPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[PushButton]Set current|$m_bt_setCurrent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetCurrentPB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[PushButton]Delete|$m_bt_delete|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            M_bt_new = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[PushButton]New*|$m_bt_new|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_new);

            CurrentAutomationSchemeST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[StaticText]Current automation scheme:|$m_lb_currentScheme|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentAutomationSchemeST);

            AutomateLayerAndColorCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$396912|#1/[Pane]$m_splitVert|#1/[Pane]$396864|#2/[Pane]$m_layerColorAssignmentUserCtrl|#1/[GroupBox]Automated layer and color assignment|$m_groupBoxLayerColor|#1/[CheckBox]Automate layer and color assignments when creating objects|$m_checkBoxAuto|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutomateLayerAndColorCK);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$13371848|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$13371848|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$13371848|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$13371848|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$13371848|#2/[PushButton]Apply|$m_btnSave|#1",
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
