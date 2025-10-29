// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupIsoDefaultSettingsDLG : Pane
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
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem IsoStyleSetupTVI;
        public  TreeViewItem DefaultSettingsTVI;
        public  TreeViewItem AnnotationsTVI;
        public  TreeViewItem DimensionsTVI;
        public  TreeViewItem ThemesTVI;
        public  TreeViewItem SlopedAndOffsetPipingTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  TreeViewItem LivePreviewTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  CheckBox SpoolFormatCK;
        public  Pane Pane7PANE;
        public  GroupBox DrawingOutputGB;
        public  StaticText OffsetST;
        public  StaticText YST;
        public  StaticText StaticTextST;
        public  TextField XTF;
        public  CheckBox ExportDataTablesCK;
        public  StaticText XST;
        public  StaticText ModelPlacementAdjustmentsST;
        public  StaticText RotationST;
        public  TextField TextFieldTF;
        public  PopupList FileFormatPL;
        public  PushButton DropDownButton1PB;
        public  CheckBox Spools1CK;
        public  StaticText FileFormatST;
        public  TextField RevisionNumberTF;
        public  TextField ModelPlacementAdjustmentsTF;
        public  CheckBox WeldListsCK;
        public  StaticText RevisionNumberST;
        public  CheckBox CutPieces1CK;
        public  CheckBox OverwriteExistingFilesCK;
        public  CheckBox BillOfMaterials1CK;
        public  CheckBox CreateDWFFilesCK;
        public  GroupBox AnnotationsGB;
        public  CheckBox Spools2CK;
        public  CheckBox WeldsCK;
        public  CheckBox CutPieces2CK;
        public  CheckBox BillOfMaterials2CK;
        public  Link AnnotationsLINK;
        public  GroupBox DrawingCongestionSplittingGB;
        public  CheckBox IgnoreModelAnnotationsCK;
        public  PushButton AddPropertyPB;
        public  CheckBox IgnoreModelBreakPointsCK;
        public  Pane Pane8PANE;
        public  StaticText LevelOfCongestionToST;
        public  StaticText MoreST;
        public  StaticText LessST;
        public  Scale LessSC;
        public  ListBox ListBoxLB;
        public  ListBoxItem LineNumberLBI;
        public  ListBoxItem ServiceLBI;
        public  ListBoxItem SpecLBI;
        public  ListBoxItem NominalDiameterLBI;
        public  ListBoxItem MaterialLBI;
        public  CheckBox SplitDrawingOnPropertyCK;
        public  CheckBox CreateSplitPointsAutomaticallyCK;
        public  GroupBox DataFormatsGB;
        public  GroupBox MeasurementsGB;
        public  PopupList SystemPL;
        public  PushButton DropDownButton2PB;
        public  GroupBox AttributeGB;
        public  PopupList PopupList1PL;
        public  PushButton DropDownButton3PB;
        public  PopupList FormattingPL;
        public  PushButton DropDownButton4PB;
        public  PopupList PrecisionPL;
        public  PushButton DropDownButton5PB;
        public  StaticText PrecisionST;
        public  StaticText FormattingST;
        public  StaticText SystemST;
        public  PopupList DatesPL;
        public  PushButton DropDownButton6PB;
        public  PopupList DecimalsPL;
        public  PushButton DropDownButton7PB;
        public  StaticText DatesST;
        public  StaticText DecimalsST;
        public  GroupBox DimensioningDefaultThemeGB;
        public  CheckBox StringCK;
        public  CheckBox LocatingCK;
        public  CheckBox EndtoendCK;
        public  Link DimensioningLINK;
        public  PushButton PushButtonPB;
        public  PopupList PopupList2PL;
        public  PushButton DropDownButton8PB;
        public  Pane Pane9PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupIsoDefaultSettingsDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            DefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Default Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultSettingsTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Annotations|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Dimensions|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Themes|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Sloped and Offset Piping|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Title Block and Display|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Live Preview|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526768|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            SpoolFormatCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[CheckBox]Spool format|$checkBox_SpoolFormat|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolFormatCK);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            DrawingOutputGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingOutputGB);

            OffsetST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]Offset|$label_OffsetLocation|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OffsetST);

            YST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]Y|$label_Y|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YST);

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]?|$label_Deg|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            XTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[TextField]X|$textBox_Y|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XTF);

            ExportDataTablesCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[CheckBox]Export data tables:|$checkBox_ExportDataTables|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportDataTablesCK);

            XST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]X|$label_X|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XST);

            ModelPlacementAdjustmentsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]Model placement adjustments:|$label3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModelPlacementAdjustmentsST);

            RotationST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]Rotation|$label_OffsetRotation|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RotationST);

            TextFieldTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[TextField]?|$textBox_X|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            FileFormatPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[PopupList]File format:|$comboBox_ExportFormat|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileFormatPL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[PopupList]File format:|$comboBox_ExportFormat|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            Spools1CK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[CheckBox]Spools|$checkBox_ExportSpool|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spools1CK);

            FileFormatST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]File format:|$label2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileFormatST);

            RevisionNumberTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[TextField]Revision number:|$textBox_RevisionNumber|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberTF);

            ModelPlacementAdjustmentsTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[TextField]Model placement adjustments:|$textBox_Deg|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModelPlacementAdjustmentsTF);

            WeldListsCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[CheckBox]Weld lists|$checkBox_ExportWeld|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeldListsCK);

            RevisionNumberST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[StaticText]Revision number:|$label_RevisionNumber|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberST);

            CutPieces1CK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[CheckBox]Cut pieces|$checkBox_ExportCutPiece|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CutPieces1CK);

            OverwriteExistingFilesCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[CheckBox]Overwrite existing files|$checkBox_OverwriteExisting|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverwriteExistingFilesCK);

            BillOfMaterials1CK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[CheckBox]Bill of materials|$checkBox_ExportBOM|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BillOfMaterials1CK);

            CreateDWFFilesCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing *|$groupBox_StandardOptions|#1/[CheckBox]Create DWF files|$checkBox_CreateDWF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateDWFFilesCK);

            AnnotationsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Annotations|$groupBox_Annotations|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsGB);

            Spools2CK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Annotations|$groupBox_Annotations|#5/[CheckBox]Spools|$checkBox_Spools|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spools2CK);

            WeldsCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Annotations|$groupBox_Annotations|#5/[CheckBox]Welds|$checkBox_Welds|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeldsCK);

            CutPieces2CK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Annotations|$groupBox_Annotations|#5/[CheckBox]Cut pieces|$checkBox_CutPiece|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CutPieces2CK);

            BillOfMaterials2CK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Annotations|$groupBox_Annotations|#5/[CheckBox]Bill of materials|$checkBox_BOM|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BillOfMaterials2CK);

            AnnotationsLINK = new Link()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Annotations|$groupBox_Annotations|#5/[Link]Annotations|$linkLabel_Annotations|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsLINK);

            DrawingCongestionSplittingGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingCongestionSplittingGB);

            IgnoreModelAnnotationsCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[CheckBox]Ignore model annotations|$checkBox_IgnoreAnnotations|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IgnoreModelAnnotationsCK);

            AddPropertyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[PushButton]Add Property*|$button_SelectProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyPB);

            IgnoreModelBreakPointsCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[CheckBox]Ignore model break points|$checkBox_IgnoreBreakPoints|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IgnoreModelBreakPointsCK);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[Pane]$congestionLevelPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            LevelOfCongestionToST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[Pane]$congestionLevelPanel|#1/[StaticText]Level of congestion to split Iso at:|$label_slider|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LevelOfCongestionToST);

            MoreST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[Pane]$congestionLevelPanel|#1/[StaticText]More|$label_more|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoreST);

            LessST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[Pane]$congestionLevelPanel|#1/[StaticText]Less|$label_less|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LessST);

            LessSC = new Scale()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[Pane]$congestionLevelPanel|#1/[Scale]Less|$trackBar_CongestionSplitting|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LessSC);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[ListBox]$checkedListBox_PropertyNames|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            LineNumberLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Line number|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumberLBI);

            ServiceLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Service|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServiceLBI);

            SpecLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Spec|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecLBI);

            NominalDiameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Nominal diameter|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterLBI);

            MaterialLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[ListBox]$checkedListBox_PropertyNames|#1/[ListBoxItem]Material|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialLBI);

            SplitDrawingOnPropertyCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[CheckBox]Split drawing on property change|$checkBox_SplitIso|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SplitDrawingOnPropertyCK);

            CreateSplitPointsAutomaticallyCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Drawing congestion splitting|$groupBox_Congestion|#2/[CheckBox]Create split points automatically|$checkBox_CreateSplitAutomatically|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateSplitPointsAutomaticallyCK);

            DataFormatsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataFormatsGB);

            MeasurementsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MeasurementsGB);

            SystemPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[PopupList]System|$comboBox_System|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[PopupList]System|$comboBox_System|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            AttributeGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AttributeGB);

            PopupList1PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[PopupList]$comboBox_Measurements|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList1PL);

            DropDownButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[PopupList]$comboBox_Measurements|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton3PB);

            FormattingPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[PopupList]Formatting|$comboBox_Formatting|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingPL);

            DropDownButton4PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[PopupList]Formatting|$comboBox_Formatting|#2/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton4PB);

            PrecisionPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[PopupList]Precision|$comboBox_Precision|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrecisionPL);

            DropDownButton5PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[PopupList]Precision|$comboBox_Precision|#3/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton5PB);

            PrecisionST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[StaticText]Precision|$label7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrecisionST);

            FormattingST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[GroupBox]Attribute|$groupBox_Attribute|#1/[StaticText]Formatting|$label6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingST);

            SystemST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[GroupBox]Measurements|$groupBox_Measurements|#1/[StaticText]System|$label5|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemST);

            DatesPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[PopupList]Dates:|$comboBox_Dates|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatesPL);

            DropDownButton6PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[PopupList]Dates:|$comboBox_Dates|#2/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton6PB);

            DecimalsPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[PopupList]Decimals:|$comboBox_Decimals|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DecimalsPL);

            DropDownButton7PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[PopupList]Decimals:|$comboBox_Decimals|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton7PB);

            DatesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[StaticText]Dates:|$label4|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatesST);

            DecimalsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Data formats|$groupBox_DataFormats|#4/[StaticText]Decimals:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DecimalsST);

            DimensioningDefaultThemeGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Dimensioning    ( default theme ) |$groupBox_Dimensioning|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensioningDefaultThemeGB);

            StringCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Dimensioning    ( default theme ) |$groupBox_Dimensioning|#3/[CheckBox]String|$checkBox_StringDimensions|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StringCK);

            LocatingCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Dimensioning    ( default theme ) |$groupBox_Dimensioning|#3/[CheckBox]Locating|$checkBox_LocatingDimensions|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocatingCK);

            EndtoendCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Dimensioning    ( default theme ) |$groupBox_Dimensioning|#3/[CheckBox]End-to-end|$checkBox_EndToEndDimensions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndtoendCK);

            DimensioningLINK = new Link()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[Pane]$panel_IsoStyleAdvancedDefaultOptions|#1/[GroupBox]Dimensioning    ( default theme ) |$groupBox_Dimensioning|#3/[Link]Dimensioning|$linkLabel_Dimensioning|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensioningLINK);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[PushButton]+|$button_NewIsoStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            PopupList2PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[PopupList]$comboBox_IsoType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList2PL);

            DropDownButton8PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$525956|#1/[Pane]$m_splitVert|#1/[Pane]$526788|#2/[Pane]$m_advanceDefaultsUserCtrl|#1/[PopupList]$comboBox_IsoType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton8PB);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$591506|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$591506|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$591506|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$591506|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$591506|#2/[PushButton]Apply|$m_btnSave|#1",
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
