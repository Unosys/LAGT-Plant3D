// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectSetupOrthoStyleDefaultSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
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
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  TreeViewItem OrthoStyleDefaultSettingsTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox DrawingOutputGB;
        public  GroupBox OffsetLocationGB;
        public  Link LearnMoreAboutLocationLINK;
        public  TextField RotationTF;
        public  StaticText ZST;
        public  TextField XTF;
        public  TextField ZTF;
        public  StaticText DistanceST;
        public  StaticText RotationST;
        public  StaticText XST;
        public  StaticText YST;
        public  TextField YTF;
        public  StaticText DEGST;
        public  GroupBox ElbowCenterlineGB;
        public  Pane Pane7PANE;
        public  StaticText CurvedST;
        public  RadioButton RadioButton1RB;
        public  StaticText CorneredST;
        public  RadioButton RadioButton2RB;
        public  CheckBox ShowHiddenLinePipingCK;
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

        public ProjectSetupOrthoStyleDefaultSettingsDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            SharedPlantContentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Shared Plant Content|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharedPlantContentTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            OrthoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5/[TreeViewItem]Ortho Style Default Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoStyleDefaultSettingsTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$15927422|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5/[TreeViewItem]Title Block and Display|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            DrawingOutputGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingOutputGB);

            OffsetLocationGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OffsetLocationGB);

            LearnMoreAboutLocationLINK = new Link()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[Link]Learn more about location offset|$linkLabel_learnMore|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnMoreAboutLocationLINK);

            RotationTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[TextField]Rotation:|$textBox_rotation|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RotationTF);

            ZST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[StaticText]Z:|$label_Z|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZST);

            XTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[TextField]X:|$textBox_distanceX|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XTF);

            ZTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[TextField]Z:|$textBox_distanceZ|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZTF);

            DistanceST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[StaticText]Distance:|$label_distance|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DistanceST);

            RotationST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[StaticText]Rotation:|$label_rotation|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RotationST);

            XST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[StaticText]X:|$label_X|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XST);

            YST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[StaticText]Y:|$label_Y|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YST);

            YTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[TextField]Y:|$textBox_distanceY|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YTF);

            DEGST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Offset location:|$groupBox_offsetLocation|#2/[StaticText]DEG*|$label_deg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DEGST);

            ElbowCenterlineGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Elbow centerline|$groupBox_elbow|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowCenterlineGB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Elbow centerline|$groupBox_elbow|#1/[Pane]$elbowPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            CurvedST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Elbow centerline|$groupBox_elbow|#1/[Pane]$elbowPanel|#1/[StaticText]Curved|$radioCurvedLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurvedST);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Elbow centerline|$groupBox_elbow|#1/[Pane]$elbowPanel|#1/[RadioButton]$m_radioBtnCurved|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            CorneredST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Elbow centerline|$groupBox_elbow|#1/[Pane]$elbowPanel|#1/[StaticText]Cornered|$radioCorneredLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CorneredST);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[GroupBox]Elbow centerline|$groupBox_elbow|#1/[Pane]$elbowPanel|#1/[RadioButton]$m_radioBtnCornered|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            ShowHiddenLinePipingCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17302990|#1/[Pane]$m_splitVert|#1/[Pane]$23791060|#2/[Pane]$m_orthoStyleDefaultSettingsUserCtrl|#1/[GroupBox]Drawing *|$groupBox_drawingOutput|#1/[CheckBox]Show Hidden Line Piping by default|$m_chkShowHiddenPiping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowHiddenLinePipingCK);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$28773320|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$28773320|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$28773320|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$28773320|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$28773320|#2/[PushButton]Apply|$m_btnSave|#1",
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
