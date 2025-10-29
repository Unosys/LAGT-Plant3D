// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupPlant3DDWG : Pane
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
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem ExportAndImportSettingsTVI;
        public  TreeViewItem DataManagerConfigurationTVI;
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
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  GroupBox SpoolNamingGB;
        public  PopupList PopupList1PL;
        public  PushButton DropDownButton1PB;
        public  GroupBox FileNamingGB;
        public  PopupList SuffixPL;
        public  PushButton DropDownButton2PB;
        public  TextField DelimiterTF;
        public  StaticText SuffixST;
        public  StaticText DelimiterST;
        public  PopupList AddPropertyPL;
        public  PushButton DropDownButton3PB;
        public  StaticText AddPropertyST;
        public  TextField TextField1TF;
        public  StaticText SampleST;
        public  TextField TextField2TF;
        public  StaticText PrefixST;
        public  CheckBox SpoolFormatCK;
        public  GroupBox DrawingFormatGB;
        public  GroupBox TableOverflowGB;
        public  RadioButton ToContinueLongTables1RB;
        public  StaticText ToContinueLongTablesST;
        public  RadioButton ToContinueLongTables2RB;
        public  StaticText MaximumPipeLengthST;
        public  CheckBox PlaceFieldWeldsAtCK;
        public  TextField MaximumPipeLengthTF;
        public  StaticText MakeupLengthST;
        public  CheckBox AddPipeMakeupLengthCK;
        public  TextField MakeupLengthTF;
        public  GroupBox SpoolsGB;
        public  TextField HeightTF;
        public  StaticText SizingMethodST;
        public  PopupList SizingMethodPL;
        public  PushButton DropDownButton4PB;
        public  TextField WidthTF;
        public  StaticText LengthST;
        public  StaticText WidthST;
        public  TextField LengthTF;
        public  StaticText HeightST;
        public  GroupBox ContentPathsGB;
        public  PushButton PushButton1PB;
        public  StaticText IsoStyleFilesDirectoryST;
        public  TextField IsoStyleFilesDirectoryTF;
        public  PushButton PushButton2PB;
        public  TextField ProductionIsoOutputDirectoryTF;
        public  StaticText ProductionIsoOutputDirectoryST;
        public  TextField QuickIsoOutputDirectoryTF;
        public  StaticText QuickIsoOutputDirectoryST;
        public  PushButton PushButton3PB;
        public  PopupList PopupList2PL;
        public  PushButton DropDownButton5PB;
        public  Pane Pane8PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupPlant3DDWG()
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

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Data Manager Configuration|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Layer and Color Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Piping Connection Settings|#4",
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

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            SpoolNamingGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spool naming|$groupBox_spoolNaming",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolNamingGB);

            PopupList1PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spool naming|$groupBox_spoolNaming/[PopupList]$comboBox_spoolNaming",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList1PL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spool naming|$groupBox_spoolNaming/[PopupList]$comboBox_spoolNaming/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            FileNamingGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNamingGB);

            SuffixPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[PopupList]Suffix|$comboBox_Suffix",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SuffixPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[PopupList]Suffix|$comboBox_Suffix/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            DelimiterTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[TextField]Delimiter|$textBox_Delimiter",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DelimiterTF);

            SuffixST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[StaticText]Suffix|$label5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SuffixST);

            DelimiterST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[StaticText]Delimiter|$label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DelimiterST);

            AddPropertyPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[PopupList]Add property|$comboBox_Properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyPL);

            DropDownButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[PopupList]Add property|$comboBox_Properties/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton3PB);

            AddPropertyST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[StaticText]Add property|$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyST);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[TextField]$textBox_Sample",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            SampleST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[StaticText]Sample|$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SampleST);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[TextField]$textBox_Prefix",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            PrefixST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]File naming|$groupBox_FileName/[StaticText]Prefix|$lb_Prefix",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrefixST);

            SpoolFormatCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[CheckBox]Spool format|$checkBox_SpoolFormat",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolFormatCK);

            DrawingFormatGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingFormatGB);

            TableOverflowGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[GroupBox]Table overflow|$groupBox_TableOverflow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableOverflowGB);

            ToContinueLongTables1RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[GroupBox]Table overflow|$groupBox_TableOverflow/[RadioButton]To continue long tables:[1]|$radioButton_SplitIso",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToContinueLongTables1RB);

            ToContinueLongTablesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[GroupBox]Table overflow|$groupBox_TableOverflow/[StaticText]To continue long tables:|$label_TableOverflow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToContinueLongTablesST);

            ToContinueLongTables2RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[GroupBox]Table overflow|$groupBox_TableOverflow/[RadioButton]To continue long tables:[2]|$radioButton_Overflow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToContinueLongTables2RB);

            MaximumPipeLengthST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[StaticText]Maximum pipe length:|$label4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximumPipeLengthST);

            PlaceFieldWeldsAtCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[CheckBox]Place field welds at maximum pipe lengths|$checkBox_PlaceFieldWelds",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlaceFieldWeldsAtCK);

            MaximumPipeLengthTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[TextField]Maximum pipe length:|$textBox_MaxPipeLength",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximumPipeLengthTF);

            MakeupLengthST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[StaticText]Makeup Length:|$label_MakeupLength",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MakeupLengthST);

            AddPipeMakeupLengthCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[CheckBox]Add pipe makeup length to BOM for Field Fit Welds|$checkBox_AddMakeupLength",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPipeMakeupLengthCK);

            MakeupLengthTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Drawing format|$groupBox1/[TextField]Makeup Length:|$textBox_MakeupLength",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MakeupLengthTF);

            SpoolsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolsGB);

            HeightTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[TextField]Height:|$textBox_Height",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeightTF);

            SizingMethodST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[StaticText]Sizing method:|$label_SpoolSizing",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizingMethodST);

            SizingMethodPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[PopupList]Sizing method:|$comboBox_SpoolSizing",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizingMethodPL);

            DropDownButton4PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[PopupList]Sizing method:|$comboBox_SpoolSizing/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton4PB);

            WidthTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[TextField]Width:|$textBox_Width",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WidthTF);

            LengthST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[StaticText]Length:|$label_Length",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LengthST);

            WidthST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[StaticText]Width:|$label_Width",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WidthST);

            LengthTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[TextField]Length:|$textBox_Length",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LengthTF);

            HeightST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Spools|$groupBox_Spools/[StaticText]Height:|$label_Height",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeightST);

            ContentPathsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentPathsGB);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[PushButton]**[1]|$button_ProdDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            IsoStyleFilesDirectoryST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[StaticText]Iso Style files directory:|$label_Template",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleFilesDirectoryST);

            IsoStyleFilesDirectoryTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[TextField]Iso Style files directory:|$textBox_IsoStyleFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleFilesDirectoryTF);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[PushButton]**[2]|$button_QuickDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            ProductionIsoOutputDirectoryTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[TextField]Production iso output directory:|$textBox_ProdIsoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProductionIsoOutputDirectoryTF);

            ProductionIsoOutputDirectoryST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[StaticText]Production iso output directory:|$label_ProdIsoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProductionIsoOutputDirectoryST);

            QuickIsoOutputDirectoryTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[TextField]Quick iso output directory:|$textBox_QuickIsoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QuickIsoOutputDirectoryTF);

            QuickIsoOutputDirectoryST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[GroupBox]Content paths|$groupBox_Path/[StaticText]Quick iso output directory:|$label_QuickIsoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QuickIsoOutputDirectoryST);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[PushButton]+|$button_NewType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            PopupList2PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[PopupList]$comboBox_IsoType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList2PL);

            DropDownButton5PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3409204/[Pane]$m_splitVert/[Pane]$1313372/[Pane]$m_isometricPathsUserCtrl/[Pane]$panel_IsoStyleSetup/[PopupList]$comboBox_IsoType/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton5PB);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1313384",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1313384/[PushButton]Help|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#2/[PushButton]Cancel|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1313384/[PushButton]OK|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1313384/[PushButton]Apply|$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar/[CustomWin]System Menu Bar|$EditProjectSettingsDlg",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar/[CustomWin]System Menu Bar|$EditProjectSettingsDlg/[MenuItem]System|$Item 1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
