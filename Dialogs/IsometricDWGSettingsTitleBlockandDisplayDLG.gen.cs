// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class IsometricDWGSettingsTitleBlockandDisplayDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  TreeViewItem GeneralIsoSettingsTVI;
        public  TreeViewItem IsoStyleSetupTVI;
        public  TreeViewItem IsoStyleDefaultSettingsTVI;
        public  TreeViewItem AnnotationsTVI;
        public  TreeViewItem DimensionsTVI;
        public  TreeViewItem ThemesTVI;
        public  TreeViewItem SlopedAndOffsetPipingTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  TreeViewItem LivePreviewTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane TitleBlockDisplayPANE;
        public  GroupBox InsulationAndPipeSupportGB;
        public  CheckBox ShowInsulationOnIsometricCK;
        public  CheckBox ShowPipeSupportsOnCK;
        public  GroupBox ElbowAndBendDisplayGB;
        public  StaticText ShowBendAsST;
        public  StaticText ShowElbowAsST;
        public  PopupList ShowBendAsPL;
        public  PushButton DropDownButton1PB;
        public  PopupList ShowElbowAsPL;
        public  PushButton DropDownButton2PB;
        public  CheckBox SpoolFormatCK;
        public  PushButton PushButton1PB;
        public  GroupBox TitleBlockPreviewGB;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  StaticText SpecifyNorthArrowTableST;
        public  StaticText IsometricDrawingTemplateDWTST;
        public  PushButton BtnTemplateBrowse;
        public  TextField IsometricDrawingTemplateDWTTF;
        public  PushButton SetupTitleBlockPB;
        public  PopupList PopupListPL;
        public  PushButton DropDownButton3PB;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public IsometricDWGSettingsTitleBlockandDisplayDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]General Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Project Details",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Database Setup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Drawing Properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Reports",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]File Name Format",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]P*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Plant 3D DWG Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            GeneralIsoSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]General Iso Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralIsoSettingsTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Iso Style Setup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            IsoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Iso Style Default Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleDefaultSettingsTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Annotations",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Dimensions",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Themes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Sloped and Offset Piping",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Title Block and Display",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Live Preview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$1903520/[TreeView]$m_treeView/[TreeViewItem]Ortho DWG Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1837282|#1/[Pane]$m_splitVert|#1/[Pane]$12847658|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            TitleBlockDisplayPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockDisplayPANE);

            InsulationAndPipeSupportGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Insulation and pipe support display|$m_groupBoxInsulation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationAndPipeSupportGB);

            ShowInsulationOnIsometricCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Insulation and pipe support display|$m_groupBoxInsulation/[CheckBox]Show insulation on isometric drawings|$checkBox_ShowInsulation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowInsulationOnIsometricCK);

            ShowPipeSupportsOnCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Insulation and pipe support display|$m_groupBoxInsulation/[CheckBox]Show pipe supports on isometric drawings|$m_chkDisplaySupport",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowPipeSupportsOnCK);

            ElbowAndBendDisplayGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Elbow and bend display|$m_groupBoxElbowBend",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowAndBendDisplayGB);

            ShowBendAsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Elbow and bend display|$m_groupBoxElbowBend/[StaticText]Show bend as:|$m_labelBend",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowBendAsST);

            ShowElbowAsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Elbow and bend display|$m_groupBoxElbowBend/[StaticText]Show elbow as:|$m_labelElbow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowElbowAsST);

            ShowBendAsPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Elbow and bend display|$m_groupBoxElbowBend/[PopupList]Show bend as:|$cmbElbows",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowBendAsPL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Elbow and bend display|$m_groupBoxElbowBend/[PopupList]Show bend as:|$cmbElbows/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            ShowElbowAsPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Elbow and bend display|$m_groupBoxElbowBend/[PopupList]Show elbow as:|$cmbBends",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowElbowAsPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Elbow and bend display|$m_groupBoxElbowBend/[PopupList]Show elbow as:|$cmbBends/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            SpoolFormatCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[CheckBox]Spool format|$checkBox_SpoolFormat",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolFormatCK);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[PushButton]+|$button_NewIsoStyle",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            TitleBlockPreviewGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Title block preview|$m_previewGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockPreviewGB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Title block preview|$m_previewGroupBox/[Pane]$5703912",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$264824|#1/[Pane]$m_splitVert|#1/[Pane]$199402|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            SpecifyNorthArrowTableST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Title block preview|$m_previewGroupBox/[StaticText]Specify north arrow, table placement, dimension appearance and more*|$m_labelSetupTitleBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyNorthArrowTableST);

            IsometricDrawingTemplateDWTST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Title block preview|$m_previewGroupBox/[StaticText]Isometric Drawing Template (DWT): |$label8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDrawingTemplateDWTST);

            BtnTemplateBrowse = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$29232906|#1/[Pane]$m_splitVert|#1/[Pane]$19203498|#2/[Pane]$m_isometricConfigureTBUserCtrl|#1/[Pane]Title block *|$panel_TitleBlock|#1/[GroupBox]Title block preview|$m_previewGroupBox|#1/[PushButton]**|$btnTemplateBrowse|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnTemplateBrowse);

            IsometricDrawingTemplateDWTTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[GroupBox]Title block preview|$m_previewGroupBox/[TextField]Isometric Drawing Template (DWT): |$txtBlockPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDrawingTemplateDWTTF);

            SetupTitleBlockPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$527314|#1/[Pane]$m_splitVert|#1/[Pane]$527308|#2/[Pane]$m_isometricConfigureTBUserCtrl|#1/[Pane]Title block *|$panel_TitleBlock|#1/[GroupBox]Title block preview|$m_previewGroupBox|#1/[PushButton]Setup Title Block*|$button_Setup_Blk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetupTitleBlockPB);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[PopupList]$comboBox_Isotype",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$11209338/[Pane]$m_splitVert/[Pane]$9045660/[Pane]$m_isometricConfigureTBUserCtrl/[Pane]Title block *|$panel_TitleBlock/[PopupList]$comboBox_Isotype/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton3PB);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3541638/[PushButton]Help|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3541638/[PushButton]Cancel|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3541638/[PushButton]OK|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3541638/[PushButton]Apply|$m_btnSave",
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
