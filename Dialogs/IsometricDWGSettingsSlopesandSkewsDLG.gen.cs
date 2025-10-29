// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class IsometricDWGSettingsSlopesandSkewsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  Pane SlopedAndOffsetPipingPANE;
        public  CheckBox SpoolFormatCK;
        public  PushButton PushButtonPB;
        public  PopupList PopupListPL;
        public  PushButton DropDownButton1PB;
        public  GroupBox OffsetPipingAnnotationOptionsGB;
        public  TextField VerticalTF;
        public  TextField HorizontalTF;
        public  StaticText VerticalST;
        public  StaticText HorizontalST;
        public  CheckBox DisplayOffsetAngleAnnotationCK;
        public  ComboBox PercentageOfTriangleToCB;
        public  StaticText PercentageOfTriangleToST;
        public  GroupBox OffsetPipingGB;
        public  StaticText ShowRolledOffsets3DST;
        public  Pane ShowRolledOffsets3D1PANE;
        public  StaticText SlopedPipeWithAST;
        public  Pane SlopedPipeWithA1PANE;
        public  Pane ShowRolledOffsets3D2PANE;
        public  StaticText Show2DVerticalhorizontalOffsetsST;
        public  Pane SlopedPipeWithA2PANE;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  RadioButton RadioButton3RB;
        public  Pane Show2DVerticalhorizontalOffsetsPANE;
        public  RadioButton RadioButton4RB;
        public  RadioButton RadioButton5RB;
        public  RadioButton RadioButton6RB;
        public  Pane ShowRolledOffsets3D3PANE;
        public  RadioButton RadioButton7RB;
        public  RadioButton RadioButton8RB;
        public  GroupBox SlopedPipingGB;
        public  StaticText DegreesST;
        public  CustomWin ShowAsFallUp1WIN;
        public  CustomWin SpinnerWIN;
        public  PushButton ForwardPB;
        public  PushButton BackwardPB;
        public  CustomWin ShowAsFallUp2WIN;
        public  StaticText ShowAsFallUpST;
        public  PopupList ShowFallsAsPL;
        public  PushButton DropDownButton2PB;
        public  StaticText ShowFallsAsST;
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

        public IsometricDWGSettingsSlopesandSkewsDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            DefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Default Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultSettingsTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Annotations|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Dimensions|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Themes|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Sloped and Offset Piping|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Title Block and Display|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Live Preview|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$23530852|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            SlopedAndOffsetPipingPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingPANE);

            SpoolFormatCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[CheckBox]Spool format|$checkBox_SpoolFormat|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolFormatCK);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[PushButton]+|$button_NewIsoStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[PopupList]$comboBox_IsoStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[PopupList]$comboBox_IsoStyle|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            OffsetPipingAnnotationOptionsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OffsetPipingAnnotationOptionsGB);

            VerticalTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2/[TextField]Vertical:|$textBox_Vertical|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalTF);

            HorizontalTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2/[TextField]Horizontal:|$textBox_Horizontal|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalTF);

            VerticalST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2/[StaticText]Vertical:|$label_Vertical|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalST);

            HorizontalST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2/[StaticText]Horizontal:|$label_Horizontal|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalST);

            DisplayOffsetAngleAnnotationCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2/[CheckBox]Display offset angle annotation |$checkBox_DisplaySkewAngle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayOffsetAngleAnnotationCK);

            PercentageOfTriangleToCB = new ComboBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2/[ComboBox]Percentage of triangle to hatch:|$comboBox_HatchPercentage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PercentageOfTriangleToCB);

            PercentageOfTriangleToST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset piping annotation options|$groupBox2|#2/[StaticText]Percentage of triangle to hatch:|$label_Percentage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PercentageOfTriangleToST);

            OffsetPipingGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OffsetPipingGB);

            ShowRolledOffsets3DST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[StaticText]Show rolled offsets (3D skews) as:|$label_3DSkew|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowRolledOffsets3DST);

            ShowRolledOffsets3D1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show rolled offsets (3D skews) as:[1]|$pictureBox_3DSkew|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowRolledOffsets3D1PANE);

            SlopedPipeWithAST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[StaticText]Sloped pipe with a 2D horizontal offset as:|$label_2DHorizontalSkew|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedPipeWithAST);

            SlopedPipeWithA1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Sloped pipe with a 2D horizontal offset as:[1]|$pictureBox_2DHorizontalSkew|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedPipeWithA1PANE);

            ShowRolledOffsets3D2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show rolled offsets (3D skews) as:[2]|$pictureBox_2DSkew|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowRolledOffsets3D2PANE);

            Show2DVerticalhorizontalOffsetsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[StaticText]Show 2D vertical*|$label_Show_2D_Skews_As|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Show2DVerticalhorizontalOffsetsST);

            SlopedPipeWithA2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Sloped pipe with a 2D horizontal offset as:[2]|$panel_2DHorizontalSkews|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedPipeWithA2PANE);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Sloped pipe with a 2D horizontal offset as:[2]|$panel_2DHorizontalSkews|#3/[RadioButton]$radioButton_3DBox2D|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Sloped pipe with a 2D horizontal offset as:[2]|$panel_2DHorizontalSkews|#3/[RadioButton]$radioButton_2DTriangleWithFall|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            RadioButton3RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Sloped pipe with a 2D horizontal offset as:[2]|$panel_2DHorizontalSkews|#3/[RadioButton]$radioButton_TwoSkewTriangles2D|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3RB);

            Show2DVerticalhorizontalOffsetsPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show 2D vertical*|$panel_2DSkews|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Show2DVerticalhorizontalOffsetsPANE);

            RadioButton4RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show 2D vertical*|$panel_2DSkews|#1/[RadioButton]$radioButton_SkewBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton4RB);

            RadioButton5RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show 2D vertical*|$panel_2DSkews|#1/[RadioButton]$radioButton_SkewTriangleWithNormal|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton5RB);

            RadioButton6RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show 2D vertical*|$panel_2DSkews|#1/[RadioButton]$radioButton_SkewTriangleWithAlternate|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton6RB);

            ShowRolledOffsets3D3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show rolled offsets (3D skews) as:[3]|$panel_3DSkews|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowRolledOffsets3D3PANE);

            RadioButton7RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show rolled offsets (3D skews) as:[3]|$panel_3DSkews|#5/[RadioButton]$radioButton_3DBox3D|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton7RB);

            RadioButton8RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Offset Piping|$groupBox_Skews|#3/[Pane]Show rolled offsets (3D skews) as:[3]|$panel_3DSkews|#5/[RadioButton]$radioButton_TwoSkewTriangles3D|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton8RB);

            SlopedPipingGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedPipingGB);

            DegreesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[StaticText]degrees|$label_unit|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DegreesST);

            ShowAsFallUp1WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[CustomWin]Show as fall up to:|$numericUpDown_ShowAsFallUpTo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowAsFallUp1WIN);

            SpinnerWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[CustomWin]Show as fall up to:|$numericUpDown_ShowAsFallUpTo|#1/[CustomWin]Spinner|$41947072|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpinnerWIN);

            ForwardPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[CustomWin]Show as fall up to:|$numericUpDown_ShowAsFallUpTo|#1/[CustomWin]Spinner|$41947072|#2/[PushButton]Forward|$SmallIncrement|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ForwardPB);

            BackwardPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[CustomWin]Show as fall up to:|$numericUpDown_ShowAsFallUpTo|#1/[CustomWin]Spinner|$41947072|#2/[PushButton]Backward|$SmallDecrement|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackwardPB);

            ShowAsFallUp2WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[CustomWin]Show as fall up to:|$numericUpDown_ShowAsFallUpTo|#1/[CustomWin]Show as fall up to:|$numericUpDown_ShowAsFallUpTo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowAsFallUp2WIN);

            ShowAsFallUpST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[StaticText]Show as fall up to:|$label_Show_FALL_Up|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowAsFallUpST);

            ShowFallsAsPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[PopupList]Show Falls as:|$comboBox_ShowFallsAs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowFallsAsPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[PopupList]Show Falls as:|$comboBox_ShowFallsAs|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            ShowFallsAsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$8917246|#1/[Pane]$m_splitVert|#1/[Pane]$28510192|#2/[Pane]$m_isometricSlopedDimensionsUserCtrl|#1/[Pane]Sloped and Offset Piping|$panel_SlopedDimensions|#1/[GroupBox]Sloped piping|$groupBox_Falls|#1/[StaticText]Show Falls as:|$label_Show_Falls_As|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowFallsAsST);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$11931180|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$11931180|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$11931180|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$11931180|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$11931180|#2/[PushButton]Apply|$m_btnSave|#1",
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
