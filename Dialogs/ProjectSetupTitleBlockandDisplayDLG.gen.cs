// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupTitleBlockandDisplayDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox TitleBlockAndDisplayGB;
        public  Pane Pane7PANE;
        public  Pane NoPreviewAvailablePANE;
        public  Pane Pane8PANE;
        public  PushButton BtnSetupBlk;
        public  StaticText OrthoDrawingTemplateDWTST;
        public  TextField OrthoDrawingTemplateDWTTF;
        public  PushButton PushButton1PB;
        public  StaticText OrthoDrawingOutputFolderST;
        public  TextField OrthoDrawingOutputFolderTF;
        public  PushButton PushButton2PB;
        public  Pane Pane9PANE;
        public  GroupBox ElbowCenterlineGB;
        public  Pane Pane10PANE;
        public  StaticText CurvedST;
        public  RadioButton RadioButton1RB;
        public  StaticText CorneredST;
        public  RadioButton RadioButton2RB;
        public  GroupBox OrthoGenerationOptionsGB;
        public  CheckBox ShowHiddenLinePipingCK;
        public  Pane Pane11PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupTitleBlockandDisplayDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$134054|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5/[TreeViewItem]Title Block and Display|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            TitleBlockAndDisplayGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayGB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$previewPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            NoPreviewAvailablePANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$previewPanel|#1/[Pane]No preview available|$853162|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPreviewAvailablePANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            BtnSetupBlk = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2/[PushButton]Setup Title Block*|$btnSetupBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnSetupBlk);

            OrthoDrawingTemplateDWTST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2/[StaticText]Ortho drawing template (DWT): |$labelDWT|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDrawingTemplateDWTST);

            OrthoDrawingTemplateDWTTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2/[TextField]Ortho drawing template (DWT): |$m_txtDWTPath|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDrawingTemplateDWTTF);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2/[PushButton]**[1]|$btnDWTBrowse|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            OrthoDrawingOutputFolderST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2/[StaticText]Ortho drawing output folder (DWG): |$labelDWG|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDrawingOutputFolderST);

            OrthoDrawingOutputFolderTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2/[TextField]Ortho drawing output folder (DWG): |$m_txtDWGPath|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDrawingOutputFolderTF);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$editPanel|#2/[PushButton]**[2]|$btnDWGBrowse|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            ElbowCenterlineGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Elbow centerline|$groupBoxElbow|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowCenterlineGB);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Elbow centerline|$groupBoxElbow|#2/[Pane]$elbowPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            CurvedST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Elbow centerline|$groupBoxElbow|#2/[Pane]$elbowPanel|#1/[StaticText]Curved|$radioCurvedLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurvedST);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Elbow centerline|$groupBoxElbow|#2/[Pane]$elbowPanel|#1/[RadioButton]$m_radioBtnCurved|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            CorneredST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Elbow centerline|$groupBoxElbow|#2/[Pane]$elbowPanel|#1/[StaticText]Cornered|$radioCorneredLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CorneredST);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Elbow centerline|$groupBoxElbow|#2/[Pane]$elbowPanel|#1/[RadioButton]$m_radioBtnCornered|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            OrthoGenerationOptionsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Ortho generation options|$groupBoxOrtho|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoGenerationOptionsGB);

            ShowHiddenLinePipingCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132908|#1/[Pane]$m_splitVert|#1/[Pane]$133970|#2/[Pane]$m_orthographicsConfigureTBUserCtrl|#1/[GroupBox]Title block and display|$groupBox|#1/[Pane]$tLayoutPanelOpts|#3/[GroupBox]Ortho generation options|$groupBoxOrtho|#1/[CheckBox]Show Hidden Line Piping by default|$m_chkShowHiddenPiping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowHiddenLinePipingCK);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132974|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132974|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132974|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132974|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$132974|#2/[PushButton]Apply|$m_btnSave|#1",
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
